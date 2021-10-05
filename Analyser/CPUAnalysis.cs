namespace Analyser
{
    using System;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс для анализа загрузки процессора
    /// </summary>
    public static class CPUAnalysis
    {
        /// <summary>
        /// Метод для запуска анализатора нагрузки на центральный процессор
        /// </summary>
        /// <param name="timeSleep">Время ожидания перед обновлением счётчика</param>
        /// <param name="limit">Лимит превышения - по превышению будет выдан сигнал</param>
        public static void Run(int timeSleep, double limit)
        {
            using var p = new PerformanceCounter("Processor", "% Processor Time", "_Total"); // "Процессор", "% загруженности процессора", "0"
            var ss = Task.Run(() =>
            {
                while (true)
                {
                    Console.Clear();
                    float currentUsage = p.NextValue() / Environment.ProcessorCount;
                    Console.Write($"Процессор загружен на: {currentUsage}%");
                    //  Console.Write("\nЯдро 0 загружено на: {0}%", p2.NextValue());
                    if (currentUsage > limit)
                    {
                        Console.Beep();
                    }
                   // double suspensionTime = (currentUsage - limit) / currentUsage * 100;

                    Thread.Sleep(timeSleep);
                }    
            });
        }
    }
}