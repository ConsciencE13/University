using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Lab_14
{
    public class Lab_14_Task_4
    {
        static void Main()
        {
            AutoResetEvent waiter = new AutoResetEvent(true);    //для 4а, 4б(1)
            Thread thread_1 = new Thread(() => Task(10,"even"));
            Thread thread_2 = new Thread(() => Task(10,"odd"));
            //Thread thread_1 = new Thread(() => Count(10,"even"));   //для 4б(2)
            //Thread thread_2 = new Thread(() => Count(10,"odd"));    //для 4б(2)
            thread_1.Name = "Первый поток";
            thread_2.Name = "Второй поток";
            // thread_1.Priority = ThreadPriority.Highest;  //для 4а
            // thread_2.Priority = ThreadPriority.Lowest;   //для 4а
            thread_1.Start();
            thread_2.Start();

            void Task(int n, string odd_or_even)
            {
                waiter.WaitOne();
                StreamWriter writer = new StreamWriter(@"D:\Документы БГТУ\C# Labs\14 Lab\Task_4.txt",true);
                if (odd_or_even == "even")
                {
                    Thread.Sleep(800);
                    for (int i = 0; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                            writer.WriteLine(Thread.CurrentThread.Name +" "+i);
                        }
                    }
                }
                if(odd_or_even == "odd")
                {
                    for (int i = 0; i <= n; i++)
                    {
                        Thread.Sleep(1000);
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                            writer.WriteLine(Thread.CurrentThread.Name +" "+ i);
                        }
                    }
                }
                writer.Close();
                waiter.Set();
            }
            // void Count(int n, string odd_even)
            // {
            //      if (odd_even == "even")
            //     {
            //         for (int i = 0; i <= n; i++)
            //         {
            //             if (i % 2 == 0)
            //             {
            //                 Thread.Sleep(1000);
            //                 Console.WriteLine(i);
            //             }
            //         }
            //     }
            //     if(odd_even == "odd")
            //     {
            //         for (int i = 0; i <= n; i++)
            //         {
            //             if (i % 2 != 0)
            //             {
            //                 Thread.Sleep(1200);
            //                 Console.WriteLine(i);
            //             }
            //         }
            //     }
            // }
        }
    }
}