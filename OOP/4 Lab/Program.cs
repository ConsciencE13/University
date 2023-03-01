using AllInformation;
class Program
{
    static void Main(string[] args)
    {
        //Rectangle
        Rectangle My_Rectangle = new();
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
        Rectangle Test = new();
        My_Printer.IAmPrinting(ref Test);
    }
}