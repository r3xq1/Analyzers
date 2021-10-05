namespace Analyser
{
    using System.Runtime.InteropServices;

    public static class Structures
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;

            //public LASTINPUTINFO(uint init)
            //{
            //    cbSize = (uint)Marshal.SizeOf<LASTINPUTINFO>();
            //    dwTime = init;
            //}
        }
    }
}