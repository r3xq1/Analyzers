namespace Analyser
{
    using System;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Console.Title = "Analyzer by r3xq1";
            CPUAnalysis.Run(2000, 10);
           // IdleTime.Run();
            Console.Read();
        }
    }
}