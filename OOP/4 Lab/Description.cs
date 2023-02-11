namespace AllInformation
{
    public abstract class Figure
    {
        public int X;
        public int Y;
        
        protected int Square;

        public virtual void Give_My_Square()    //виртауальный метод
        {
            Console.Write("I'm Figure!");
        }

        public abstract void Say_My_Name();

    }
    public class Rectangle : Figure
    {
        public override void Say_My_Name()
        {
            Console.WriteLine("Я унаследован из абстрактного класса");
        }
        public override void Give_My_Square()   //Виртуальный метод
        {
            Square = X*Y;
            Console.WriteLine($"My Square is {Square}");
        }
        public override string ToString()
        {
            return "X: " + X + " " + "Y: " + Y + " " + "Square: "+ Square + " " + "ObjectType: "+ nameof(Rectangle);
        }
    }

    public interface Changing_The_Size
    {
        public void Change_The_Width(int width_1, int width_2, int heigth_1, int heigth_2)
        {
            width_1 = width_2;
            heigth_1 = heigth_2;
            Console.WriteLine($"Now width = {width_1} and heigth = {heigth_2}");
        }
        public void Change_Color(string color_1, string color_2)
        {
            color_1 = "";
            color_1 = color_2;
            Console.WriteLine($"Now color is {color_1}");
        }
        public void Say_My_Name(){}
    }

    public sealed class Control_Element
    {
        public string Name;
        public string Font;
        public int Width, Heigth;
        public Control_Element(string Name, string Font, int Width, int Heigth)
        {
            this.Name = Name;
            this.Font = Font;
            this.Width = Width;
            this.Heigth = Heigth;
        }
        public void Show_Info()
        {
            Console.WriteLine($"Name = {Name}\t Font = {Font}\t Width = {Width}\t Heigth = {Heigth}");
        }
        public override string ToString()
        {
            return "Name: " + Name + " " + "Font: " + Font + " " + "Width: "+ Width+ " " + "Heigth: "+ Heigth+ " " + "ObjectType: "+ nameof(Control_Element);
        }
    }

    public class TextBox : Figure, Changing_The_Size
    {
        public override void Say_My_Name()
        {   
            Console.WriteLine("Я унаследован из абстрактного класса");
        }
        void Changing_The_Size.Say_My_Name()
        {
            Console.WriteLine("Я унаследован из интерфейса");
        }
        public override string ToString()
        {
            return "ObjectType: "+ nameof(TextBox);
        }
    }

    public abstract class Window
    {
        public int Width;
        public int Heigth;
        public int Diagonal;
    }

    public class View_Window:Window
    {
        public void Show_Info()
        {
            Console.WriteLine($"Width = {Width}\t Heigth = {Heigth}\t Diagonal = {Diagonal}");
        }
        public override string ToString()
        {
            return "ObjectType: "+ nameof(View_Window);
        }
    }
    public class Button:View_Window
    {
        public void Show_Modern_Info()
        {
            Console.WriteLine($"My old width = {Width}, heigth = {Heigth}, diagonal = {Diagonal}");
            Width +=100;
            Heigth +=100;
            Diagonal +=100;
            Console.WriteLine($"My new width = {Width}, heigth = {Heigth}, diagonal = {Diagonal}");
        }
        public override string ToString()
        {
            return "ObjectType: "+ nameof(Button);
        }
    }

    public class Printer
    {
        public void IAmPrinting(ref Rectangle MyFig)
        {
            Console.WriteLine(MyFig.GetType());
        }
    }

}