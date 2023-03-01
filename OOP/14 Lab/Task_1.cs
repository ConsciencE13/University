using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Lab_14
{
    public class Lab_14_Task_1
    {
        static void Main()
        {
            Process my_process = Process.GetCurrentProcess();
            ProcessThreadCollection my_thread_collection = my_process.Threads;
            ProcessThread my_thread = my_thread_collection[0];    

            string my_path = @"D:\Документы БГТУ\C# Labs\14 Lab\info.txt";    

            using (StreamWriter writer = new StreamWriter(my_path,true))      
            {
                Console.WriteLine($"Id: {my_process.Id}");
                writer.WriteLine($"Id: {my_process.Id}");     

                Console.WriteLine($"Name: {my_process.MachineName}");
                writer.WriteLine($"Name: {my_process.MachineName}");      

                Console.WriteLine($"Priority {my_thread.CurrentPriority}");
                writer.WriteLine($"Priority {my_thread.CurrentPriority}");    

                Console.WriteLine($"Time: {my_thread.StartTime}");
                writer.WriteLine($"Time: {my_thread.StartTime}");     

                Console.WriteLine($"Current state: {my_thread.ThreadState}");
                writer.WriteLine($"Current state: {my_thread.ThreadState}");      

                Console.WriteLine($"Total time: {my_thread.TotalProcessorTime}");
                writer.WriteLine($"Total time: {my_thread.TotalProcessorTime}");  

                writer.Close();    
            }
        }
    }
}