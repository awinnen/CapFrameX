using NvAPIWrapper;
using NvAPIWrapper.Native;
using NvAPIWrapper.Native.Display.Structures;
using NvAPIWrapper.Native.GPU.Structures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OpenHardwareMonitor.Hardware.Nvidia
{
    internal class NvidiaGroup : IGroup
    {
        private readonly List<Hardware> hardware = new List<Hardware>();
        private readonly StringBuilder report = new StringBuilder();

        public NvidiaGroup(ISettings settings)
        {
            try
            {
                NVIDIA.Initialize();
            }
            catch { return; }

            report.AppendLine("NVAPI");
            report.AppendLine();

            try
            {
                report.Append(" Version: ");
                report.AppendLine(NVIDIA.InterfaceVersionString);
            }
            catch { return; }

            PhysicalGPUHandle[] physicalGPUs;
            try
            {
                physicalGPUs = GPUApi.EnumPhysicalGPUs();

                if (physicalGPUs == null)
                {
                    report.AppendLine(" Error: NvAPI_EnumPhysicalGPUs not available");
                    report.AppendLine();
                    return;
                }
            }
            catch (Exception ex)
            {
                report.AppendLine(" Status: " + ex.ToString());
                report.AppendLine();
                return;
            }

            report.AppendLine();
            report.AppendLine("NVIDIA");
            report.AppendLine();
            report.AppendLine(" Status: " + "OK");
            report.AppendLine();

            IDictionary<PhysicalGPUHandle, DisplayHandle> displayHandlesDict =
              new Dictionary<PhysicalGPUHandle, DisplayHandle>();

            try
            {
                var displayHandles = DisplayApi.EnumNvidiaDisplayHandle();

                for (int i = 0; i < displayHandles.Length; i++)
                {
                    PhysicalGPUHandle[] handlesFromDisplay
                        = GPUApi.GetPhysicalGPUsFromDisplay(displayHandles[i]);

                    for (int j = 0; j < handlesFromDisplay.Length; j++)
                    {
                        if (!displayHandlesDict.ContainsKey(handlesFromDisplay[j]))
                            displayHandlesDict.Add(handlesFromDisplay[j], displayHandles[i]);
                    }
                }
            }
            catch { return; }

            report.Append("Number of GPUs: ");
            report.AppendLine(physicalGPUs.Length.ToString(CultureInfo.InvariantCulture));

            for (int i = 0; i < physicalGPUs.Length; i++)
            {
                displayHandlesDict.TryGetValue(physicalGPUs[i], out DisplayHandle displayHandle);
                hardware.Add(new NvidiaGPU(i, physicalGPUs[i], displayHandle, settings));
            }

            report.AppendLine();
        }

        public IHardware[] Hardware
        {
            get
            {
                return hardware.ToArray();
            }
        }

        public string GetReport()
        {
            return report.ToString();
        }

        public void Close()
        {
            foreach (Hardware gpu in hardware)
                gpu.Close();

            try
            {
                NVIDIA.Unload();
            }
            catch { }
        }
    }
}
