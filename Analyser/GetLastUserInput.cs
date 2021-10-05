namespace Analyser
{
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    public class GetLastUserInput
    {
        private static Structures.LASTINPUTINFO lastInPutNfo;

        static GetLastUserInput()
        {
            lastInPutNfo = new Structures.LASTINPUTINFO();
            lastInPutNfo.cbSize = (uint)Marshal.SizeOf(lastInPutNfo);
        }

        /// <summary>
        /// Idle time in ticks
        /// </summary>
        /// <returns></returns>
        public static uint GetIdleTickCount() => (uint)Environment.TickCount - GetLastInputTime();

        /// <summary>
        /// Last input time in ticks
        /// </summary>
        /// <returns></returns>
        public static uint GetLastInputTime() => !NativeMethods.GetLastInputInfo(ref lastInPutNfo) ? throw new Win32Exception(Marshal.GetLastWin32Error())  : lastInPutNfo.dwTime;
    }
}