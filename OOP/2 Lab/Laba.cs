using ThreeConstructors;
using Shoto;
class Laba
{

    static void Main(string[] args)
    {
        Student Misha = new();  //Создание объекта через конструктор без параметров  //Создание объекта через конструктор без параметров
        Student Nikita = new("Nikita", 34, 3);  //Создание объекта через конструктор с тремя параметрами
        Misha.Print();
        Nikita.Print();
        Console.WriteLine(Student.okonchanie);
        Console.WriteLine($"Выведем ID Миши, который только для чтения: {Misha.ID}");
        if (Misha.IsAlive)
        {
        Console.WriteLine("Миша живой");
        }
        else
        {
        Console.WriteLine("Миша умер -_-");
        }

        Console.WriteLine();

        Student Comp = new();
        int i = 1;
        Console.WriteLine("REF");
        Console.WriteLine("Previous value of integer i:" + i.ToString());
        string test1 = Comp.GetNextName(ref i);
        Console.WriteLine("Current value of integer i:" + i.ToString());
        Console.WriteLine("OUT");
        i = 0;
        Console.WriteLine("Previous value of integer i:" + i.ToString());
        string test2 = Comp.GetNextNameByOut(out i);
        Console.WriteLine("Current value of integer i:" + i.ToString());

        Console.WriteLine();

        Bus Ivan = new();
        Example Vot = new();
        Vot.Move();
        Vot.Say();
        Console.WriteLine("ToString");
        Bus busik = new Bus { Hours = 15, Minutes = 34, Seconds = 53, Name = "Nisan" };
        Console.WriteLine(busik.ToString()); // выведет 15:34:53
        Console.WriteLine("GetHash");
        int first_hash = busik.GetHashCode();
        Console.WriteLine($"Hash = {first_hash}");
        var bus1 = new Bus { Name = "LadaKalina" };
        var bus2 = new Bus { Name = "Sedana" };
        var bus3 = new Bus { Name = "Toyota" };

        bool bus1EqualsBus2 = bus1.Equals(bus2);   // false
        bool bus1EqualsBus3 = bus1.Equals(bus3);   // false

        Console.WriteLine(bus1EqualsBus2);    // false
        Console.WriteLine(bus1EqualsBus3);    // false
    }
}