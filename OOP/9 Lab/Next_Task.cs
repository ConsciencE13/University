using System.Collections.Concurrent;

namespace Task
{
    public delegate void Second_Task_Delegate();
    class Programm_Next_Task_Main
    {
    static void Main()
    {
        string val;
        ConcurrentDictionary<int,string> My_Friends = new ConcurrentDictionary<int, string>();
        My_Friends.TryAdd(1,"Maksim");
        My_Friends.TryAdd(2,"Nikita");
        My_Friends.TryAdd(3,"Aleks");
        My_Friends.TryAdd(4,"Misha");
        My_Friends.TryAdd(5,"Igor");

        foreach (var item in My_Friends)
        {
            Console.WriteLine(item.Value);
        }

        My_Friends.TryRemove(3, out val);

        Console.WriteLine("---");

        foreach (var item in My_Friends)
        {
            Console.WriteLine(item.Value);
        }

        HashSet<string> My_New_Collection = new HashSet<string>();

        foreach (var item in My_Friends)
        {
            My_New_Collection.Add(item.Value);
        }

        Console.Write("---");

        foreach (var item in My_New_Collection)
        {
            Console.WriteLine(item);
        }
        val = "";
        My_New_Collection.TryGetValue("Maksim", out val);
        Console.WriteLine($"Найдем есть ли в HashSet значение Максим: {val} был найден");

        ObservableCollection<Internet_Resourse<string>> My_Observable_Collection = new ObservableCollection<Internet_Resourse<string>>();
        My_Observable_Collection.CollectionChange += My_Observable_Collection.Say_Hello;
        My_Observable_Collection.On_CollectionChange();
        Internet_Resourse<string> Test_Resourse = new Internet_Resourse<string>();
        Test_Resourse.Add("New_Maskim");
        My_Observable_Collection.Add(Test_Resourse);
        Console.WriteLine("---");
        foreach (Internet_Resourse<string> item in My_Observable_Collection)
        {
            Console.WriteLine(item);
        }

    }
    }

    public class ObservableCollection<T> : Internet_Resourse<T>
    {
        public event Second_Task_Delegate? CollectionChange;

        public void On_CollectionChange() => CollectionChange();
        public void Say_Hello() => Console.WriteLine("Hello");

    }
}


