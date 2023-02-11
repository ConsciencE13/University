using System.Text.RegularExpressions;

User Roman = new();
User_Info Roman_Info = new("Roman","Tyshkevich",19);
Roman.User_Event +=Roman_Info.User_Upgrade;
Roman.User_Event += Roman_Info.User_Work;
Roman.On_User_Event();

Console.WriteLine("-----");

MyFun MF = new();
MF.Pognali(MF.my_string,MF.Add_Symbol);
MF.Pognali(MF.my_string,MF.Udal_Znaki);
MF.Pognali(MF.my_string,MF.Zamena_Na_Zaglavnye);
MF.Pognali(MF.my_string,MF.Zamena_Na_Propisnyje);
MF.Pognali(MF.my_string,MF.Udal_Probely);

public delegate void Upgrade_Work();    //делегат

public class User
{
    public event Upgrade_Work? User_Event;  // событие
    public void On_User_Event() => User_Event();   //вызываем событие
}

public class User_Info
{
    private string name;
    private string surname;
    private int age;
    public User_Info(string Name, string Surname, int Age)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
    }
        public string Name { set { name = value; } get { return name; } }
        public string Surname { set { surname = value; } get { return surname; } }
        public int Age { set { age = value; } get { return age; } }

    public void User_Upgrade()  => Console.WriteLine("Я обновился!");   //Первый обработчик события
    public void User_Work() => Console.WriteLine($"{Name} {Surname} в возрасте {Age} приступил к работе!"); // Второй обработчик событий
}

public interface IFor_String
{
    void Udal_Znaki();
    void Add_Symbol();
    void Zamena_Na_Zaglavnye();
    void Zamena_Na_Propisnyje();
    void Udal_Probely();
}

public class MyFun : IFor_String
{
    public string my_string = "Я, кушаю кашу, И МНЕ очень нравится.";
    public void Udal_Znaki()
    {
        Console.WriteLine($"Исходная строка: {my_string}");
        var new_string = Regex.Replace(my_string, "[-.?!)(,:]", string.Empty);
        my_string = new_string;
        Console.WriteLine($"Измененная строка: {my_string}");
    }

    public void Add_Symbol()
    {
        Console.WriteLine($"Исходная строка: {my_string}");
        my_string += " Я Добавленый";
        Console.WriteLine($"Измененная строка: {my_string}");
    }

    public void Zamena_Na_Zaglavnye()
    {
        Console.WriteLine($"Исходная строка: {my_string}");
        my_string = my_string.ToUpper();
        Console.WriteLine($"Измененная строка: {my_string}");
    }

    public void Zamena_Na_Propisnyje()
    {
        Console.WriteLine($"Исходная строка: {my_string}");
        my_string = my_string.ToLower();
        Console.WriteLine($"Измененная строка: {my_string}");
    }

    public void Udal_Probely()
    {
        Console.WriteLine($"Исходная строка: {my_string}");
        my_string = my_string.Replace(" ","");
        Console.WriteLine($"Измененная строка: {my_string}");
    }

    public  void Pognali(string myStr, Action final) => final();


}