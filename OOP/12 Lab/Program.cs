using System.IO;
using System.IO.Compression;

namespace CustomApplication
{
    public class Main_Task
    {
        static void Main()
        {
            Tyshkevich_Roman_Antonovich_DiskInfo Disk_Information = new();
            Tyshkevich_Roman_Antonovich_FileInfo File_Information = new("D:\\Документы БГТУ\\C# Labs\\12 Lab\\Example_File.txt");
            Tyshkevich_Roman_Antonovich_DirInfo Dir_Information = new("D:\\Документы БГТУ\\C# Labs\\12 Lab");
            Tyshkevich_Roman_Antonovich_FileManager File_Manager = new();
            Tyshkevich_Roman_Antonovich_Log Log = new();
            Log.About_Word("диск");
            Log.About_Day("11/10/2022");
            Log.About_Time("4:27:34 PM", "4:30:09 PM");
            Log.Give_All_Records();
            Log.Last_Hour(" 4:");
        }
    }

    public class Tyshkevich_Roman_Antonovich_DiskInfo
    {
        DriveInfo[] Disk_Info = DriveInfo.GetDrives();

        string message = "Была выведена на консоль информация по диску";

        Tyshkevich_Roman_Antonovich_Log Log_Info = new();
        
        public Tyshkevich_Roman_Antonovich_DiskInfo()
        {
            DiskInfo();
            Log_Info.Log(message);
        }

        public void DiskInfo()
        {
            foreach (DriveInfo disk in Disk_Info)
            {
                Console.WriteLine($"Название Тома: {disk.Name}");
                Console.WriteLine($"Файловая система: {disk.DriveType}");
                Console.WriteLine($"Объем диска: {disk.TotalSize}");
                Console.WriteLine($"Доступный объем: {disk.TotalFreeSpace}");
                Console.WriteLine($"Метка Тома: {disk.VolumeLabel}");
                Console.WriteLine();
            }
        }
    }

    public class Tyshkevich_Roman_Antonovich_FileInfo
    {
        Tyshkevich_Roman_Antonovich_Log Log_Info = new();
        public Tyshkevich_Roman_Antonovich_FileInfo(string user_path)
        {
            string message = $"Была выведена на консоль информация по определенному файлу. Путь до файла -> {user_path}";
            FileInfo(user_path);
            Log_Info.Log(message);
        }

        public void FileInfo(string path)
        {
            FileInfo File_Info = new(path);
            Console.WriteLine($"Полный путь файла: {File_Info.DirectoryName}");
            Console.WriteLine($"Размер файла: {File_Info.Length}");
            Console.WriteLine($"Расширение файла: {File_Info.Extension}");
            Console.WriteLine($"Имя файла: {File_Info.Name}");
            Console.WriteLine($"Дата создания файла: {File_Info.CreationTime}");
            Console.WriteLine($"Изменения файла: {File_Info.LastWriteTime}");
            Console.WriteLine();
        }
    }

    public class Tyshkevich_Roman_Antonovich_DirInfo
    {
        Tyshkevich_Roman_Antonovich_Log Log_Info = new();
        public Tyshkevich_Roman_Antonovich_DirInfo(string user_path)
        {
            string message = $"Была выведена на консоль информация по определенной директории. Путь до директории -> {user_path}";
            DirInfo(user_path);
            Log_Info.Log(message);
        }

        public void DirInfo(string path)
        {
            DirectoryInfo Dir_Info = new(path);
            Console.WriteLine($"Количество файлов:");
            foreach (var item in Dir_Info.GetFiles())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Время создания: {Dir_Info.CreationTime}");
            Console.WriteLine($"Количество поддиректорий:");
            foreach (var item in Dir_Info.GetDirectories())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Список родительских директорий:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Dir_Info.Parent);
                Dir_Info = Dir_Info.Parent;
            }
        }
    }

    public class Tyshkevich_Roman_Antonovich_FileManager
    {
        Tyshkevich_Roman_Antonovich_Log Log_Info = new();

        string message = $"На консоль была выведена информация про все файлы и папки на диске D. Была создана новая папка (D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect)\n{DateTime.Now.ToString()} Был создан новый файл (D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichDirInfo.txt) и сразу же удален\n{DateTime.Now.ToString()} Был создан новый zip файл (D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\My_Zip.zip)";
        public Tyshkevich_Roman_Antonovich_FileManager()
        {
            FileManager();
            Log_Info.Log(message);
        }

        public void FileManager()
        {
            string[] all_folders = System.IO.Directory.GetDirectories("D:\\");
            Console.WriteLine("Все папки на диске D:");
            foreach (string item in all_folders)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Все файлы на диске D: ");
            string[] all_files = System.IO.Directory.GetFiles("D:\\");
            foreach (string item in all_files)
            {
                Console.WriteLine(item);
            }
            System.IO.Directory.CreateDirectory("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect");
            System.IO.File.Create("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichDirInfo.txt").Close();
            System.IO.File.WriteAllText("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichDirInfo.txt", "Я новая информация");
            System.IO.File.Copy("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichDirInfo.txt","TyshkevichRomanAntonovichInspect\\New_Info.txt", true);
            System.IO.File.Delete("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichDirInfo.txt");
            System.IO.Directory.CreateDirectory("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichFiles");
            string file, new_file;
            foreach (var item in System.IO.Directory.GetFiles("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect"))
            {
                file = item.ToString();
                new_file = file.ToString().Replace("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect","D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichFiles");
                System.IO.File.Copy(file,new_file,true);
            }
            System.IO.Directory.Move("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichFiles","D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichFiles");
            ZipFile.CreateFromDirectory("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\TyshkevichRomanAntonovichFiles","D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\My_Zip.zip");
            ZipFile.ExtractToDirectory("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\My_Zip.zip","D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichInspect\\Raz_Files");
        }
    }

    public class Tyshkevich_Roman_Antonovich_Log
    {
        public void Log(string info)
        {
            StreamWriter writer = new StreamWriter("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt",true);
            string message = DateTime.Now.ToString(); // получаем сейчашнее время
            message += " ";
            string final_message = message + info;
            writer.WriteLine(final_message);
            writer.Close();
            Console.WriteLine("Запись была сохранена!");   
        }

        public void About_Day(string custom_date)
        {
            using (StreamReader reader = new StreamReader("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt"))
            {
                string line = "";
                while (line!=null || line!="")
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Contains(custom_date))
                    {
                        Console.WriteLine(line);
                    }
                }
                reader.Close();
            }
        }

        public void About_Time(string start_time, string end_time)
        {
            using (StreamReader reader = new StreamReader("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt"))
            {
                string line = "";
                while (line!=null || line!="")
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Contains(start_time) || line.Contains(end_time))
                    {
                        Console.WriteLine(line);
                    }
                }
                reader.Close();
            }
        }

        public void About_Word(string word)
        {
            StreamReader reader = new StreamReader("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt");
            string line = "";
            while (line!=null || line!="")
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (line.Contains(word))
                {
                    Console.WriteLine(line);
                }
            }
            reader.Close();
        }

        public void Give_All_Records()
        {
            using (StreamReader reader = new StreamReader("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt"))
            {
                int count = 0;
                while (reader.ReadLine() != null)
                {
                    count++;
                }
                reader.Close();
                Console.WriteLine($"В файле находится {count} записей!");
            }
        }

        public void Last_Hour(string user_hour)
        {
            using (StreamReader reader = new StreamReader("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt"))
            {
                string line = "";
                while (line != null || line !="")
                {
                    line = reader.ReadLine();
                    if (line == null || line == "")
                    {
                        break;
                    }
                    if (line.Contains(user_hour))
                    {
                        using (StreamWriter writer = new StreamWriter("D:\\Документы БГТУ\\C# Labs\\12 Lab\\Test.txt",true))
                        {
                            writer.WriteLine(line);
                            writer.Close();
                        }
                    }
                }
                reader.Close();
                System.IO.File.Delete("D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt");
                System.IO.File.Move("D:\\Документы БГТУ\\C# Labs\\12 Lab\\Test.txt", "D:\\Документы БГТУ\\C# Labs\\12 Lab\\TyshkevichRomanAntonovichLogfile.txt");
            }
        }
    }
}