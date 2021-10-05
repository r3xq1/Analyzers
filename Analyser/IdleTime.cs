namespace Analyser
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Класс для анализа времени бездествия пользователя за компьютером
    /// </summary>
    public static class IdleTime
    {
        /// <summary>
        /// Метод для запуска анализа бездействия пользователя за компьютером
        /// </summary>
        public static void Run()
        {
            int resultMilliSec = 0;

            var ss = Task.Run(() =>
            {
                while (true)
                {
                    Console.Clear();
                    // Если 0 - значит пользователь активен, если нет - отошёл.
                    uint Milliseconds = GetLastUserInput.GetIdleTickCount();
                    Console.WriteLine(Milliseconds);
                    resultMilliSec += (int)Milliseconds;
                    if (Milliseconds == 0)
                    {
                        Console.WriteLine($"Пользователя не было: {resultMilliSec / 1000.0} милисекунд ");
                        Console.WriteLine($"Последнее время ввода: {GetLastUserInput.GetLastInputTime()}");
                        break;
                    }
                    //  Thread.Sleep(2000);
                }
            });
        }
    }
}