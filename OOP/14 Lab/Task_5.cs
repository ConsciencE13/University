using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Lab_14
{
    public class Lab_14_Task_5
    {
        static void PrintTime(object state)
        {
            Console.Clear();
            Console.WriteLine("Текущее время:  "+
            DateTime.Now.ToLongTimeString());
        }
        static void Main()
        {
            // Делегат для типа Timer
            TimerCallback timeCB = new TimerCallback(PrintTime);

            Timer time = new Timer(timeCB, null, 0, 1000);
            Console.WriteLine("Нажми чтоб выйти");
            Console.ReadLine();
        }
    }
}