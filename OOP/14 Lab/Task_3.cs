using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Lab_14
{
    public class Lab_14_Task_3
    {
        static void Main()
        {
            string my_path = @"D:\Документы БГТУ\C# Labs\14 Lab\Schet.txt";  

            Thread user_thread = new Thread(Count_To);

            user_thread.Start(9);

            void Count_To(object? do_kuda)
            {
                if (do_kuda is int)
                {
                    using (StreamWriter writer = new StreamWriter(my_path))
                    {
                        for (int i = 1; i <= (int)do_kuda; i++)
                        {
                            Console.WriteLine(i);
                            writer.WriteLine(i);
                            Console.WriteLine($"Статус: {Thread.CurrentThread.ThreadState}");
                            Console.WriteLine($"Имя: {Thread.CurrentThread.Name}");
                            Console.WriteLine($"Приоритет: {Thread.CurrentThread.Priority}");
                            Console.WriteLine($"Числовой индентификатор: {Thread.CurrentThread.ManagedThreadId}");
                            Console.WriteLine("<-----NEXT----->");
                        }
                        writer.Close();
                    }
                }
            }
        }
    }
}