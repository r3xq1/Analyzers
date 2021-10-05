namespace Analyser
{
    using System.Runtime.InteropServices;

    internal static class NativeMethods
    {
        [DllImport("User32.dll")]
        public static extern bool GetLastInputInfo(ref Structures.LASTINPUTINFO plii);

        [DllImport("Kernel32.dll")]
        public static extern uint GetLastError();
    }
}
