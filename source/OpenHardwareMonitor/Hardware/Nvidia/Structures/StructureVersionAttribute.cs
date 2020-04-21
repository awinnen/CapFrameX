using System;

namespace OpenHardwareMonitor.Hardware.Nvidia.Structures
{
    [AttributeUsage(AttributeTargets.Struct)]
    internal class StructureVersionAttribute : Attribute
    {
        public StructureVersionAttribute()
        {
        }

        public StructureVersionAttribute(int versionNumber)
        {
            VersionNumber = versionNumber;
        }

        public int VersionNumber { get; set; }
    }
}
