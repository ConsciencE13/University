using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Lab_15
{
    public class Lab_15_Task_1
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
            var timer = new Stopwatch();
            Task task_1 = new Task(() =>
            {
            timer.Start();
            int count = 0;
            int result = 10;
            for (int i = 1; i <= result; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Найдено {count} простых чисел из диапазона от 1 до {result}");
            Console.WriteLine($"ID: {Task.CurrentId}");
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine(foo);
            });
            task_1.Start();

            Console.WriteLine($"Идентификатор текущей задачи: {task_1.Id}");
            Console.WriteLine($"Завершена ли задача? {task_1.IsCompleted}");
            Console.WriteLine($"Статус задачи: {task_1.Status}");

            task_1.Wait();
        }
    }
}