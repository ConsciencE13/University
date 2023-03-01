using MyExeptions;

class Osnova
{
    static void Main(string[] args)
    {
        Predmet Table = new("Table","Bedrok",178954,"Green");
        Predmet Stool = new("Stool","Vibranium",584924,"Blue");        //Табуретка
        Predmet Chair = new("Chair","Wood",856193,"Yellow");
        Predmet Sofa = new("Sofa","Leather",675867,"Purple");
        Predmet Armchair = new("Armchair","Wool",453655,"Brown");

        NotBedrok Bedrok_Check = new();
        NotVibranium Vibranium_Check = new();
        CantFly Fly_Check = new();
        RealColor Color_Check = new();

        try
        {
            Bedrok_Check.Check_For_Bedrok(Table);    // 1 - исключение
            Vibranium_Check.Check_For_Vibranium(Stool);  // 2 - исключение  
            Chair.Change_My_Fly();
            Fly_Check.Check_For_Fly(Chair);  // 3 - исключнение
            Sofa.serial_number = Sofa.serial_number/0;   // 4 - исключение
            Color_Check.Check_For_Color(Armchair);   // 5 - исключение  
        }
        catch
        {
            Console.WriteLine("ВОЗНИКЛО ИСКЛЮЧЕНИЕ!!!!! ОБРАТИТЕСЬ К АДМИНИСТРАТОРУ");
        }
        // finally
        // {
        //     Console.WriteLine("Программа работает правильно!");
        // }
        Debug.Assert(true == false);
    }
}