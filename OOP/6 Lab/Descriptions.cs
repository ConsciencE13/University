namespace MyExeptions
{

    public class Predmet
    {
        public string predmet_name;

        public string name_of_predmet_material;

        public int serial_number;

        internal string[] colors = new[] {"Red","Orange","Yellow","Green","Blue","Purple"};

        public string color;

        protected internal bool CanFly = false;    

        public Predmet(string predmet_name, string name_of_predmet_material, int serial_number, string color)
        {
            this.predmet_name = predmet_name;
            this.name_of_predmet_material = name_of_predmet_material;
            this.serial_number = serial_number;
            this.color = color;
        }

        public void Change_My_Fly()
        {
            if (CanFly == false) //если false станет true
            {
                CanFly = true;
            }
            else if(CanFly == true)
            {
                CanFly = false; //если true станет false
            }
            Console.WriteLine($"Now my status of fly = {CanFly}");
        }
    }

    public class NotBedrok : Exception
    {
        public void Check_For_Bedrok(Predmet Prd)
        {
            if (Prd.name_of_predmet_material == "bedrok" || Prd.name_of_predmet_material == "Bedrok")
            {
                throw new Exception("Предмет не может быть создан из бедрока");
            }
        }
    }

    public class NotVibranium : Exception
    {
        public void Check_For_Vibranium(Predmet Prd)
        {
            if (Prd.name_of_predmet_material == "Vibranium" || Prd.name_of_predmet_material == "vibranium")
            {
                throw new Exception("Предмет не может быть создан из вибраниума");
            }
        }
    }

    public class CantFly : Exception
    {
        public void Check_For_Fly(Predmet Prd)
        {
            if (Prd.CanFly)
            {
                throw new Exception("Предметы не могут летать");
            }
        }
    }

    public class RealColor : Exception
    {
        public void Check_For_Color(Predmet Prd)
        {
            foreach (string Color in Prd.colors)
            {
                if (Color == Prd.color)
                {
                    continue;
                }
                else
                {
                    throw new Exception("Такого цвета не бывает");
                }
            }
        }
    }

    public sealed class CallerArgumentExpressionAttribute : Attribute{
        public CallerArgumentExpressionAttribute (string parameterName){}
    }

    public static class Debug
    {
        public static void Assert(bool condition, [CallerArgumentExpression("condition")] string message = null)
        {
            if (!condition)
            {
                Console.WriteLine($"Assert failed! {message}");
            }
        }
    }
}