using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Lab_15
{
    public class Lab_15_Task_5
    {
        static void Main()
        {
            Parallel.For(1, 5, Square);

            // вычисляем квадрат числа
            void Square(int n)
            {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Console.WriteLine($"Квадрат числа {n} равен {n * n}");
                Thread.Sleep(2000);
            }

                ParallelLoopResult result = Parallel.ForEach<int>(
                new List<int>() { 11, 33, 55, 88 },
                Square
                );
 
                // вычисляем квадрат числа
                void SS(int n)
                {
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Console.WriteLine($"Квадрат числа {n} равен {n * n}");
                Thread.Sleep(2000);
                }
                
                Parallel.Invoke(
    Print,
    () =>
    {
        Console.WriteLine($"Выполняется задача {Task.CurrentId}");
        Thread.Sleep(3000);
    },
    () => TR(5)
);
 
void Print()
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
}
// вычисляем квадрат числа
void TR(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
    Console.WriteLine($"Результат {n * n}");
}
        }
    }
}