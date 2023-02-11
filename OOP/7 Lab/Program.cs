try
{
    CollectionType<int> MyColl = new(123456789,"D://Документы БГТУ//C# Labs//Seventh_lab//JustForFun.txt");
    Console.WriteLine(MyColl.Id);
    MyColl.Add(111);
    MyColl.Add(222);
    MyColl.Add(333);
    MyColl.Add(444);
    MyColl.Add(555);
    MyColl.Add(666);
    Console.WriteLine("---");
    MyColl.Show();
    MyColl.Remove(333);
    Console.WriteLine("---");
    MyColl.Show();
    Console.WriteLine("---");
    MyColl.SaveToFile();
}
finally
{
    Console.WriteLine("All fine");
}

interface IMyinterface<T>
{
    public void Add(T obj);
    public void Remove(T obj);
    public void Show();
}

public class CollectionType<T> : IMyinterface<T> where T : new()//ограничение по Info 
{
    public int Id;
    public string Path;

    public CollectionType(int Id, string Path)
    {
            this.Id = Id;
            this.Path = Path;
    }
    public List<T> list = new List<T>();
    public void Add(T obj)
    {
        list.Add(obj);
    }
    public void Remove(T obj)
    {
        list.Remove(obj);
    }
    public void Show()
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    public void SaveToFile()
    {
        StreamWriter writer = new StreamWriter(Path);
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
        writer.Close();
    }
}