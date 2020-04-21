using OpenHardwareMonitor.Hardware.Nvidia.Structures;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenHardwareMonitor.Hardware.Helper
{
    internal static class ExtensionMethods
    {
        public static T Instantiate<T>(this Type type)
        {
            object instance = default(T);

            try
            {
                if (type.IsValueType)
                {
                    instance = (T)Activator.CreateInstance(type);
                }

                if (type.GetInterfaces().Any(i => i == typeof(IInitializable) || i == typeof(IAllocatable)))
                {
                    foreach (var field in type.GetRuntimeFields())
                    {
                        if (field.IsStatic || field.IsLiteral)
                        {
                            continue;
                        }

                        if (field.FieldType == typeof(StructureVersion))
                        {
                            var version =
                                type.GetCustomAttributes(typeof(StructureVersionAttribute), true)
                                    .Cast<StructureVersionAttribute>()
                                    .FirstOrDefault()?
                                    .VersionNumber;
                            field.SetValue(instance,
                                version.HasValue ? new StructureVersion(version.Value, type) : new StructureVersion());
                        }
                        else if (field.FieldType.IsArray)
                        {
                            var size =
                                field.GetCustomAttributes(typeof(MarshalAsAttribute), false)
                                    .Cast<MarshalAsAttribute>()
                                    .FirstOrDefault(attribute => attribute.Value != UnmanagedType.LPArray)?
                                    .SizeConst;
                            var arrayType = field.FieldType.GetElementType();
                            var array = Array.CreateInstance(
                                arrayType ?? throw new InvalidOperationException("Field type is null."), size ?? 0);

                            if (arrayType.IsValueType)
                            {
                                for (var i = 0; i < array.Length; i++)
                                {
                                    var obj = arrayType.Instantiate<object>();
                                    array.SetValue(obj, i);
                                }
                            }

                            field.SetValue(instance, array);
                        }
                        else if (field.FieldType == typeof(string))
                        {
                            var isByVal = field.GetCustomAttributes(typeof(MarshalAsAttribute), false)
                                .Cast<MarshalAsAttribute>()
                                .Any(attribute => attribute.Value == UnmanagedType.ByValTStr);

                            if (isByVal)
                            {
                                field.SetValue(instance, string.Empty);
                            }
                        }
                        else if (field.FieldType.IsValueType)
                        {
                            var isByRef = field.GetCustomAttributes(typeof(MarshalAsAttribute), false)
                                .Cast<MarshalAsAttribute>()
                                .Any(attribute => attribute.Value == UnmanagedType.LPStruct);

                            if (!isByRef)
                            {
                                var value = field.FieldType.Instantiate<object>();
                                field.SetValue(instance, value);
                            }
                        }
                    }
                }
            }
            catch
            {
                // ignored
            }

            return (T)instance;
        }
    }
}
