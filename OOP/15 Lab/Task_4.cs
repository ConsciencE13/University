using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Lab_15
{
    public class Lab_15_Task_4
    {
        static void Main()
        {
            Task<int> task_1 = new Task<int>(() => Sum(5,5));
            Task task_2 = task_1.ContinueWith(t => Console.WriteLine($"Результат = {task_1.Result}"));

            task_1.Start();
            task_2.Wait();

            int Sum(int a, int b) => a+b;
        }
    }
}