using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_15
{
    class Lab_15_Task_8
    {
        static async Task Main()
        {
            await PrintAsync();   // вызов асинхронного метода
            Console.WriteLine("Некоторые действия в методе Main");

            void Print()
            {
                Thread.Sleep(3000);     // имитация продолжительной работы
                Console.WriteLine("Hello!");
            }

            // определение асинхронного метода
            async Task PrintAsync()
            {
                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
                await Task.Run(() => Print());                // выполняется асинхронно
                Console.WriteLine("Конец метода PrintAsync");
            } 
        }
    }
}