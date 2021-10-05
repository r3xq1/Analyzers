namespace Analyser
{
    using System.Runtime.InteropServices;

    internal static class NativeMethods
    {
        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetLastInputInfo(ref Structures.LASTINPUTINFO plii);

        [DllImport("Kernel32.dll")]
        public static extern uint GetLastError();
    }
}