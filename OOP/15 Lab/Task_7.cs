using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_15
{
    class Lab_15_Task_7
    {
                static BlockingCollection<int> bc;

        static void producer()
        {
            for (int i = 0; i < 100; i++)
            {
                bc.Add(i * i);
                Console.WriteLine("Поступает товар с номером " + i*i);
            }
            bc.CompleteAdding();
        }

        static void consumer()
        {
            int i;
            while (!bc.IsCompleted)
            {
                if (bc.TryTake(out i))
                    Console.WriteLine("Покупается товар с номером: " + i);
            }
        }

        static void Main()
        {
            bc = new BlockingCollection<int>(4);

            // Создадим задачи поставщика и потребителя
            Task Pr = new Task(producer);
            Task Cn = new Task(consumer);

            // Запустим задачи
            Pr.Start();
            Cn.Start();

            try
            {
                Task.WaitAll(Cn, Pr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Cn.Dispose();
                Pr.Dispose();
                bc.Dispose();
            }

            Console.ReadLine();
        }
    }
}