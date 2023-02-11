class Programm
{
    class Stroka
    {
        public string stroka;
        public Stroka(string str)
        {
            this.stroka = str;
        }  
        private string new_stroka = ""; 
        private bool chet = true;
        private int first_length, second_length;
        private char[] znaki = {'.',',',';',':','!','?','-'};   // 7 знаков без многоточия, скобок, кавычек
        private bool znak_prepinanija = false;
        public class Production
        {
            public int id;
            public string production_name;

            public Production(int id, string production_name)
            {
                this.id = id;
                this.production_name = production_name;
            }
        }
        public class Developer
        {
            public string fio;
            public int id;
            public string otdel;
            public Developer(string fio, int id, string otdel)
            {
                this.fio = fio;
                this.id = id;
                this.otdel = otdel;
            }
        }
        public static class StatisticOperation
        {
        /// <summary>
        /// Удаление всех символов равных заданному
        /// </summary>
        /// <param name="symbol"></param>
        public static void Udal(char symbol, Stroka str)
        {   
            foreach (var item in str.stroka)
            {
                if (item != symbol)
                {
                    str.new_stroka += item;
                }
            }
            str.stroka = str.new_stroka;
        }

        /// <summary>
        /// Удаление нечетных символов
        /// </summary>
        public static void Udal_Nechet(Stroka str)
        {
            str.new_stroka = "";
            foreach (var item in str.stroka)
            {
                if (str.chet == true)
                {
                    str.new_stroka += item;
                    str.chet = false;
                }
                else
                str.chet = true;
            }
            str.stroka = str.new_stroka;
        }

        /// <summary>
        /// Cравнение длин строк
        /// </summary>
        /// <param name="User_String"></param>
        public static void Sravni(string User_String,Stroka str)
        {
            str.first_length = User_String.Length;
            str.second_length = str.stroka.Length;
            if(str.first_length > str.second_length)
            {
                Console.WriteLine($"String {User_String} > than {str.stroka}");
            }
            else if(str.first_length < str.second_length)
            {
                Console.WriteLine($"String {User_String} < than {str.stroka}");
            }
            else if(str.first_length == str.second_length)
            {
                Console.WriteLine($"String {User_String} = {str.stroka}");
            }
        }
        /// <summary>
        /// Проверка на знаки препинания и их удаление
        /// </summary>
        public static void ZnakiProch(Stroka str)
        {
            str.new_stroka = "";
            foreach (var item in str.stroka)
            {
                for (int i = 0; i < 7; i++)
                {
                    if(item == str.znaki[i])
                    {
                        str.znak_prepinanija = true;
                    }
                    if(str.znak_prepinanija == true)
                    {
                        break;
                    }
                }
            if (str.znak_prepinanija == false)
            {
                str.new_stroka += item;
            }
            else
            {
                str.znak_prepinanija = false;
            }
            }
            str.stroka = str.new_stroka;
        }

        /// <summary>
        /// Проверка на символ
        /// </summary>
        /// <param name="example"></param>
        public static void Proverka_Na_Symbol(char example, Stroka str)
        {
            bool est_symbol = false;
            foreach (char item in str.stroka)
            {
                if (item == example)
                {
                    est_symbol = true;
                    break;
                }
            }
            if(est_symbol == false)
            {
                Console.WriteLine($"Символа {example} в строке {str.stroka} нет !!!");
            }
            else
            {
                Console.WriteLine($"В строке {str.stroka} присутствует символ {example} !");
            }
        }

        /// <summary>
        /// Удаление чисел из строки
        /// </summary>
        public static void Udalenie_Chisel(Stroka str)
        {
            char[] chisla = {'0','1','2','3','4','5','6','7','8','9'};
            str.new_stroka = "";
            bool chislo = false;
            foreach (var item in str.stroka)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(item == chisla[i])
                    {
                        chislo = true;
                    }
                    if(chislo == true)
                    {
                        break;
                    }
                }
            if (chislo == false)
            {
                str.new_stroka += item;
            }
            else
            {
                chislo = false;
            }
            }
            str.stroka = str.new_stroka;
        }
        }
    }

    static void Main(string[] args)
    {
        Stroka My_String = new("House");
        Stroka.StatisticOperation.Udal('o',My_String);
        Console.WriteLine(My_String.stroka);
        Stroka.StatisticOperation.Udal_Nechet(My_String);
        Console.WriteLine(My_String.stroka);
        string MyStr = "Garden";
        Stroka.StatisticOperation.Sravni(MyStr,My_String);
        Stroka My_Second_String = new("Today, is very? good! day!");
        Stroka.StatisticOperation.ZnakiProch(My_Second_String);
        Console.WriteLine(My_Second_String.stroka);
        Stroka.StatisticOperation.Proverka_Na_Symbol('o',My_Second_String);
        Stroka My_Third_String = new("HO23HO45");
        Stroka.StatisticOperation.Udalenie_Chisel(My_Third_String);
        Console.WriteLine(My_Third_String.stroka);
        Stroka.Production MyProd = new Stroka.Production(345678, "My new Production Int.");
        Console.WriteLine($"ID = {MyProd.id}, Name = {MyProd.production_name}");
        Stroka.Developer NewDev = new Stroka.Developer("Maksim Fadeev",6548203, "IT");
        Console.WriteLine($"Name = {NewDev.fio}, ID = {NewDev.id}, Otdel = {NewDev.otdel}");
    }
}