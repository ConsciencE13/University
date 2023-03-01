using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Lab_15
{
    public class Lab_15_Task_2
    {
        public static bool IsPrime(int number) 
        { 
            for (int i = 2; i < number; i++) 
            { 
                if (number % i == 0) 
                    return false; 
            } 
            return true; 
        }
        static void Main()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            Task task_1 = new Task(() =>
            {
            int count = 0;
            int result = 10;
            for (int i = 1; i <= result; i++)
            {
                if(token.IsCancellationRequested)
                {
                Console.WriteLine();
                Console.WriteLine("Экстренное выключение!");
                return;
                }
                else if (IsPrime(i))
                {
                    Thread.Sleep(500);
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Найдено {count} простых чисел из диапазона от 1 до {result}");
            }, token);
            task_1.Start();
            Thread.Sleep(1000);
            source.Cancel();
            Thread.Sleep(1000);
            Console.WriteLine($"Task Status: {task_1.Status}");
            source.Dispose();
        }
    }
}