using ThreeConstructors;
using Shoto;

namespace Task
{
    public class First_Task_Main
    {
        static void Main()
        {
            string[] Month = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
                };
            
            var Selected_Month =
            from p in Month
            where p.Length == 4
            select p;

            Console.WriteLine("Запрос выбирающий последовательность месяцев с длиной строки равной n:");

            foreach (string month in Selected_Month)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("---");

            Selected_Month = 
            from p in Month
            where p.StartsWith("D") || p.StartsWith("J") || p.StartsWith("F") || p.StartsWith("J") || p.StartsWith("Au")
            select p;

            Console.WriteLine("Запрос возвращающий только летние и зимние месяцы");

            foreach (string month in Selected_Month)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("---");

            Selected_Month =
            from p in Month
            orderby p
            select p;

            Console.WriteLine("Запрос вывода месяцев в алфавитном порядке:");

            foreach (string month in Selected_Month)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("---");

            Selected_Month =
            from p in Month
            where p.Contains('u') && p.Length >= 4
            select p;

            Console.WriteLine("Запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х:");

            foreach (string month in Selected_Month)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("---");

            List<Student> My_List = new List<Student>();
            
            Student student_1 = new("Bondarenko",18,3);
            Student student_2 = new("Kirienko",19,3);
            Student student_3 = new("Pashkevich",18,3);
            Student student_4 = new("Miloshko",18,3);
            Student student_5 = new("KimChen",19,3);
            Student student_6 = new("Kingsman",20,4);
            Student student_7 = new("Petrov",17,1);
            Student student_8 = new("Ignarev",17,1);
            Student student_9 = new("Pashkevich",20,3);
            Student student_10 = new("Nikitonchikov",18,3);

            My_List.Add(student_1);
            My_List.Add(student_2);
            My_List.Add(student_3);
            My_List.Add(student_4);
            My_List.Add(student_5);
            My_List.Add(student_6);
            My_List.Add(student_7);
            My_List.Add(student_8);
            My_List.Add(student_9);
            My_List.Add(student_10);

            int[] My_Array1 =  new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,20,50,100};    //290
            int[] My_Array2 =  new int[]{10,20,3,40,50};    //123
            int[] My_Array3 =  new int[]{60,70,8,9,500};    //647

            IEnumerable<IGrouping<int,int>> Result_Chet = from example in My_Array1
                                group example by example % 2; 

            foreach (var group in Result_Chet)  
            {  
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");  
                foreach (int i in group)  
                Console.WriteLine(i);  
            }       

            int[] Summs = new int[] {My_Array1.Sum(), My_Array2.Sum(), My_Array3.Sum()};

            IEnumerable<int> MaxArray = from example in Summs
                                                        orderby example descending
                                                        select example;
            
            bool vuhod = false;

            foreach (int item in MaxArray)
            {
                switch (item)
                {
                    case 123:
                    vuhod = true;
                    Console.WriteLine("Максимальный массив 2");
                    break;
                    case 290:
                    vuhod = true;
                    Console.WriteLine("Максимальный массив 1");
                    break;
                    case 647:
                    vuhod = true;
                    Console.WriteLine("Максимальный массив 3");
                    break;
                }

                if (vuhod == true)
                {
                    break;
                }
            }

            vuhod = false;

            IEnumerable<int> MinArray = from example in Summs
                                        orderby example
                                        select example;

            foreach (int item in MinArray)
            {
                switch (item)
                {
                    case 123:
                    vuhod = true;
                    Console.WriteLine("Минимальный массив 2");
                    break;
                    case 290:
                    vuhod = true;
                    Console.WriteLine("Минимальный массив 1");
                    break;
                    case 647:
                    vuhod = true;
                    Console.WriteLine("Минимальный массив 3");
                    break;
                }

                if (vuhod == true)
                {
                    break;
                }
            }

            int count = 0;

            int? test = 0;

            test = My_Array1.FirstOrDefault(number => number == 3);
            if (test != 0)
            {
                count = 1;
            }
            else count = 0;

            test = My_Array2.FirstOrDefault(number => number == 3);
            if (test != 0)
            {
                count = 2;
            }
            else count = 1;

            test = My_Array3.FirstOrDefault(number => number == 3);
            if (test != 0)
            {
                count = 3;
            }
            else count = 2;
            Console.WriteLine($"{count} массивов иммеют число 3");

            int[] Last_Array = {My_Array1.First(), My_Array2.First(), My_Array3.First()};

            foreach (int item in Last_Array)
            {
                Console.WriteLine($"Вот они слева на право : {item}");
            }

            Person[] people =
            {
                new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
                new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
            };
            Company[] companies =
            {
                new Company("Microsoft", "C#"),
                new Company("Google", "Go"),
                new Company("Oracle", "Java")
            };

            var employees = people.Join(companies, // второй набор
             p => p.Company, // свойство-селектор объекта из первого набора
             c => c.Title, // свойство-селектор объекта из второго набора
             (p, c) => new { Name = p.Name, Company = c.Title, Language = c.Language }); // результат
    
            foreach (var emp in employees)
            Console.WriteLine($"{emp.Name} - {emp.Company} ({emp.Language})");
            
            int Task_1 = My_Array1.First();
            int Task_2 = My_Array2.Last();
            int Task_3 = My_Array3.ElementAt(3);
            int Task_4 = My_Array1.Sum();
            double Task_5 = My_Array2.Average();

            Console.WriteLine($"Первое - {Task_1}; Второе - {Task_2}; Третье - {Task_3}; Четвертое - {Task_4}; Пятое - {Task_5};");
        }
    }

    public record class Person(string Name, string Company);
    public record class Company(string Title, string Language);
}