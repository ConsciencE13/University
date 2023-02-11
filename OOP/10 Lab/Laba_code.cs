namespace ThreeConstructors
{
        class Student
        {
                public int age{set;get;}
                public string FIO{set;get;}
                public int course{set;get;}
                public static int kolvo;
                public Student(){FIO = "Misha"; age = 20; course = 3;}  //конструктор без параметров
                public Student(string fio, int age, int course)
                {
                        this.FIO = fio;
                        this.age = age;
                        this.course = course;
                        kolvo++;
                }

                static int Okonchanie = 2025;
                public static int okonchanie => Okonchanie;
                public void Print() => Console.WriteLine($"Имя: {FIO}  Возраст: {age}  Курс: {course}");
                static Student()
                {
                        if(DateTime.Now.Year == Okonchanie)
                        {
                                Console.WriteLine("Поздравляю! Вы окончили университет");
                        }
                        else
                                Console.WriteLine($"Вам осталось учится {Okonchanie - DateTime.Now.Year} года");
                }
                // private Student(){ } //Закрытый конструктор
                public uint ID =  Convert.ToUInt32(DateTime.Now.Month + Okonchanie);
                public uint id
                {
                        get {return ID;}        //поле только для чтения
                }
                public bool IsAlive = true;       //константа
                public bool Alive       // с ограничением по set
                {
                        get {return IsAlive;}
                        private set {Alive = value;}
                }
                public string GetNextName(ref int id)
        {
                string returnText = "Next-" + id.ToString();
                id += 1;
                return returnText;
        }
        public string GetNextNameByOut(out int id)
        {
                id = 1;
                string returnText = "Next-" + id.ToString();
                return returnText;
        }
        static void ShowAll()
        {
                Console.WriteLine("We have: Name, Fio, Course and etc...");
        }
        }
}

namespace Shoto
{
        class Bus
{
        public string Name {get;set;}
        public override int GetHashCode()
        {
        return Name.GetHashCode();
        }
        
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
        return $"{Hours}:{Minutes}:{Seconds}";
        }
        public override bool Equals(object? obj)
        {   
        // если параметр метода представляет тип Person
        // то возвращаем true, если имена совпадают
        if (obj is Bus bus) return Name == bus.Name;
        return false;
        }
}
}