using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Lab_15
{
    public class Lab_15_Task_3
    {
        static void Main()
        {
            Task<string> task_1 = new Task<string> (() => Materials_Name("frog","stick","dirt"));
            Task<string> task_2 = new Task<string> (() => Elements_Name("fire","wind","water"));
            Task<string> task_3 = new Task<string> (() => Special_material("dust"));
            Task task_4 = new Task(() =>
                {
                    task_1.Start();
                    task_2.Start();
                    task_3.Start();
                    string result = task_1.Result + task_2.Result + task_3.Result;
                    Console.WriteLine(result);
                    task_1.Wait();
                    task_2.Wait();
                    task_3.Wait();

                });



            string Materials_Name(string material1, string material2, string material3)
            {
                return ($"В котле: {material1}, {material2}, {material3} ");
            }
            string Elements_Name(string elem1, string elem2, string elem3)
            {
                return ($"Добавили элементы: {elem1}, {elem2}, {elem3} ");
            }
            string Special_material(string special)
            {
                return ($"И самое главное: {special}");
            }

            task_4.Start();
            task_4.Wait();
        }
    }
}