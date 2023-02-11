using System;
using System.Reflection;
using System.Security;

namespace Programm_Namespace
{
    public class Task_Main
    {
        static void Main()
        {
            Student Maksim = new();
            string name = "Say_My_Name";
            Type[] paramms = new Type[0];
            Reflector.Get_Namespace(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Public_Constr(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Public_Methods(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Fields(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Propierties(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Interfaces(Maksim,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            Reflector.Get_Invoke(Maksim,name,paramms,"D:\\Документы БГТУ\\C# Labs\\11 Lab\\Info_Of_Class.txt");
            var Nikita = Reflector.Create<Student>(Maksim);
        }
    }

    public static class Reflector
    {
        public static void Get_Namespace(object MyClass, string path)
        {
            Type typik_type = MyClass.GetType();
            StreamWriter writer = new StreamWriter(path,true);
            string? Namespace_Of_Class = typik_type.Namespace;
            writer.WriteLine($"Класс находится в пространстве имен {Namespace_Of_Class}");
            writer.Close();
        }

        public static void Get_Public_Constr(object typik, string path)
        {
            Type typik_type = typik.GetType();
            Type[] typik_array = new Type[0];
            ConstructorInfo Has_Public = typik_type.GetConstructor(BindingFlags.Public,typik_array);
            StreamWriter writer = new StreamWriter(path,true);
            if (Has_Public != null)
            {
                writer.WriteLine("Класс имеет публичный конструктор");
            }
            else
            {
                writer.WriteLine("Класс не имеет публичного конструктора");
            }
            writer.Close();
        }

        public static void Get_Public_Methods(object typik, string path)
        {
            Type typik_type = typik.GetType();
            MethodInfo[] Methods_Array = typik_type.GetMethods();
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine("Методы:");
            foreach (MethodInfo item in Methods_Array)
            {
                if(item.IsPublic)
                {
                    writer.WriteLine(item.Name);
                }
            }
            writer.Close();
        }

        public static void Get_Fields(object typik, string path)
        {
            Type typik_type = typik.GetType();
            string modificator = "";
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine("Поля:");
            foreach (FieldInfo field in typik_type.GetFields(
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static
            ))
            {
                    // получаем модификатор доступа
                if (field.IsPublic)
                modificator += "public ";
                else if (field.IsPrivate)
                modificator += "private ";
                else if (field.IsAssembly)
                modificator += "internal ";
                else if (field.IsFamily)
                modificator += "protected ";
                else if (field.IsFamilyAndAssembly)
                modificator += "private protected ";
                else if (field.IsFamilyOrAssembly)
                modificator += "protected internal ";
                if (field.IsStatic) modificator += "static ";
 
                writer.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
            }
            writer.Close();
        }

        public static void Get_Propierties(object typik, string path)
        {
            Type typik_type = typik.GetType();
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine("Свойства:");
            foreach (PropertyInfo prop in typik_type.GetProperties(
            BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
            {
            writer.Write($"{prop.PropertyType} {prop.Name} {{");
 
            // если свойство доступно для чтения
            if (prop.CanRead) writer.Write("get;");
            // если свойство доступно для записи
            if (prop.CanWrite) writer.Write("set;");
            writer.WriteLine("}");
            }
            writer.Close();
        }

        public static void Get_Interfaces(object typik, string path)
        {
            Type typik_type = typik.GetType();
            StreamWriter writer = new StreamWriter(path,true);
            writer.WriteLine("Интерфейсы:");
            foreach (Type tinterface in typik_type.GetInterfaces())
            {
                writer.WriteLine(tinterface.ToString());
            }
            writer.Close();
        }

        public static void Get_Invoke(object name_of_object, string method_name, Type[] param,string path)
        {
            var gg = name_of_object.GetType();
            StreamReader reader = new StreamReader(path);
            string str;
            bool Methods = false;
            while((str = reader.ReadLine()) != null)
            {
                if(Methods == true)
                {
                    break;
                }

                if (str == "Методы:")
                {
                    Methods = true;    
                }
            }
            var method = name_of_object.GetType().GetMethod(str);
            method?.Invoke(name_of_object,param);
        }

        public static object Create<T>(T name_of_object)
        {
            var type_object = name_of_object.GetType();
            object example = Activator.CreateInstance<T>();
            return example;
        }
    }

    public class Student
    {
        public string Name;

        public void Say_My_Name()
        {
            Console.WriteLine("Heisenberg");
        }

        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
    }
}