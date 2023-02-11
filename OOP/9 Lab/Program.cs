using System.Collections;
using System.Collections.Generic;
namespace Task
{
    public class Programm_Task_Main
    {
        static void Main()
        {
            Internet_Resourse<string> My_Resourses = new();
My_Resourses.Add("Onliner.by");
My_Resourses.Add("Electro Sila");
My_Resourses.Add("Evroopt");
My_Resourses.Add("Vitalur");
string[] New_Resourses = new string[3];

foreach (string item in My_Resourses)
{
    Console.WriteLine($"Объект:{item}");
}

Console.WriteLine($"Найдем индекс Евроопта:{My_Resourses.IndexOf("Evroopt")}");
Console.WriteLine($"Узнаем есть ли в коллекции занчение Остров чистоты: {My_Resourses.Contains("Остров чистоты")}");
Console.WriteLine($"Удалим значение Electro Sila:{My_Resourses.Remove("Electro Sila")}");
foreach (string item in My_Resourses)
{
    Console.WriteLine($"Объект:{item}");
}

Console.WriteLine("Скопируем значения My_Resourses в New_Resourses");
My_Resourses.CopyTo(New_Resourses,0);
foreach (string item in New_Resourses)
{
    Console.WriteLine($"Новый объект:{item}");
}
        }
    }

public class Internet_Resourse<T> : IList<T>
{
    private T[] List_Example = new T[0];

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)List_Example).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private int count;

    public int Count
    {
        get
        {
            return count;
        }
    }

    public bool IsReadOnly
    {
        get
        {
            return false;
        }
    }

    public Internet_Resourse()  //кконструктор
    {
        count = 0;
    }

    public void Add(T value)
    {
        T[] new_List_Example = new T[List_Example.Length +1];   // Увлеличили размер листа
        List_Example.CopyTo(new_List_Example,0);    // переносим старые данные
        new_List_Example[new_List_Example.Length-1] = value;  // заносим новое значение
        List_Example = new_List_Example;
    }

    public void RemoveAt(int value)
    {
        int index = value;
        if (index == -1) return;
        T[] new_List_Example = new T[List_Example.Length -1];
        int offset = 0;
        for (int i = 0; i < List_Example.Length; i++)
        {
            if (i == index) {offset++; continue;}
            new_List_Example[i-offset] = List_Example[i];
        }
        List_Example = new_List_Example;
    }

    public void Clear()
    {
        T[] List_Example = new T[0];
    }

    public bool Remove(T value1)
    {
        int temp;
        temp = IndexOf(value1);
        RemoveAt(temp);
        return true;
    }

    public void CopyTo(T[] User_Array, int index)
    {
        foreach (T i in List_Example)
        {
            User_Array.SetValue(i,index);
            index++;
        }
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < List_Example.Length; i++)
        {
            if (Equals(List_Example[i],item))
            {
                return i;
            }
        }
        return -1;
    }

    public void Insert(int index, T val)
    {   
        int count = 0;
        int Count = 0;
        if ((count + 1 <= List_Example.Length) && (index<Count) && (index >= 0 ))
        {
            count++;
            for(int i = Count - 1; i > index; i--)
            {
                List_Example[i] = List_Example[i-1];
            }
            List_Example[index] = val;
        }
    }

    public T this[int index]
    {
        get
        {
            return List_Example[index];
        }
        set
        {
            List_Example[index] = value;
        }
    }

    public bool Contains(T val)
    {
        int Count = 0;
        for (int i = 0; i < Count; i++)
        {
            if (Equals(List_Example[i],val))
            {
                return true;
            }
        }
        return false;
    }


}

}
