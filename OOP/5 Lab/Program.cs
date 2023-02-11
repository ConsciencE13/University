using AllInformation;
using PClass;
class Program
{
    static void Main(string[] args)
    {
        //Rectangle
        Rectangle My_Rectangle = new();
        Rectangle My_Rectangle2 = new();
        My_Rectangle.X = 5;
        My_Rectangle.Y = 10;
        My_Rectangle.Give_My_Square();
        My_Rectangle.Say_My_Name();
        Console.WriteLine(My_Rectangle.ToString());
        Console.WriteLine("----------------------------");
        //Control_Element
        Control_Element Cont_Elem = new("Pole","Time New Roman",35,40);
        Cont_Elem.Show_Info();
        Console.WriteLine(Cont_Elem.ToString());
        Console.WriteLine("----------------------------");
        //TextBox
        TextBox My_TextBox = new();
        ((Figure)My_TextBox).Say_My_Name();
        ((Changing_The_Size)My_TextBox).Say_My_Name();
        Console.WriteLine(My_TextBox.ToString());
        Console.WriteLine("----------------------------");
        //View_Window
        View_Window My_View_Window = new();
        View_Window My_Second_Window = new();
        My_View_Window.Width = 15;
        My_View_Window.Heigth = 50;
        My_View_Window.Diagonal = 35;
        My_View_Window.Show_Info();
        Console.WriteLine(My_View_Window.ToString());
        Console.WriteLine("----------------------------");
        //Button
        Button My_Button = new();
        My_Button.Width = 10;
        My_Button.Heigth = 30;
        My_Button.Diagonal = 40;
        My_Button.Show_Info();
        My_Button.Show_Modern_Info();
        Console.WriteLine(My_Button.ToString());
        Console.WriteLine("----------------------------");
        //Dop
        Button My_Second_Button = new();
        if (My_Second_Button is Button)
        {
            Console.WriteLine("Yes My_Second_Button has Button type!");
        }
        else
        {
            Console.WriteLine("No I'm not Button!");
        }
        Printer My_Printer = new();
        Printer My_Printer2 = new();
        Rectangle Test = new();
        My_Printer.IAmPrinting(ref Test);
        Notebook MyNotebooks = new();
        MyNotebooks.model = "Asus";
        MyNotebooks.created = "Asus Company";
        MyNotebooks.number = 73849134;
        Console.WriteLine($"Я структура со следующими полями: Model = {MyNotebooks.model}, Created = {MyNotebooks.created}, Number = {MyNotebooks.number}");
        WeekDays Mond = WeekDays.Monday;
        Console.WriteLine($"Today is {Mond}");
        Shoes MyShoes = new();
        MyShoes.model = "Nike";
        MyShoes.size = 45;
        MyShoes.ShowModel();
        MyShoes.ShowSize();
        Interface_Software_Tool MyCont = new();
        MyCont.Add(My_Printer);
        MyCont.Add(My_Printer2);
        Console.WriteLine(MyCont.Components[0]);
        Console.WriteLine(MyCont.Components[1]);
        MyControll Contrl = new();
        Contrl.CountTextBox(My_Rectangle);
        Contrl.CountTextBox(My_Rectangle2);
        Contrl.CountTextBox(My_TextBox);
    }
}