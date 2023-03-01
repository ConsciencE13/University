using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Lab_14
{
    public class Lab_14_Task_2
    {
        static void Main()
        {
            AppDomain my_domain = AppDomain.CurrentDomain;

            Console.WriteLine($"Name: {my_domain.FriendlyName}");

            Console.WriteLine($"Details: {my_domain.GetAssemblies}");

            // функция создания нового домена больше не поддерживается!

            // AppDomain new_domain = AppDomain.CreateDomain("New_Domain");

            // new_domain.Load("Task_1.cs");
        }
    }
}