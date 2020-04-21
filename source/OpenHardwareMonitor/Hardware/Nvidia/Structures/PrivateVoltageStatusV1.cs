using System.Runtime.InteropServices;

namespace OpenHardwareMonitor.Hardware.Nvidia.Structures
{
    /// <summary>
    /// Contains information regarding GPU voltage boost status
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    internal struct PrivateVoltageStatusV1
    {
        //internal const int MaxNumberOfUnknown2 = 8;
        //internal const int MaxNumberOfUnknown3 = 8;

        //internal StructureVersion _Version;

        public uint Unknown1;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] Unknown2;

        public uint ValueInuV;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public uint[] Unknown3;
    }
}
