            void Retorl(int[] numbers, string str)
            {
                (int MinA, int MaxA, int Sum, char FirstL) tuple;
                tuple.MinA = numbers.Min();
                tuple.MaxA = numbers.Max();
                int summa = 0;
                foreach (int item in numbers)
                {
                    summa += item;
                }
                tuple.Sum = summa;
                tuple.FirstL = str[0];
                Console.WriteLine($"Максимальый элемент = {tuple.MaxA}, Минимальный элемент = {tuple.MinA}, Сумма = {tuple.Sum}, Первая буква = {tuple.FirstL}");
            };
            int CheckedFun(){
                int val1 = checked(2147483647);
                return val1;
            }
            int UnCheckedFun(){
                int val2 = unchecked(2147483647);
                return val2;
            }
            bool BoolVariable = false;
            sbyte SbyteVariable = 12;
            short ShortVariable;
            int IntVariable;
            long LongVariable = 100;
            byte ByteVariable = 24;
            ushort UshortVariable = 9;
            uint UintVariable = 250;
            ulong UlongVariable;
            float FloatVariable = 12.5F;
            double DoubleVariable = 25.56D;
            char CharVariable = 'R';
            decimal DecimalVariable = 124678.5467M;
            Console.WriteLine("Введите раздел: 1)Типы 2)Строки 3)Массивы 4)Кортежи.");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                        Console.WriteLine("Введите переменную типа short:");
                        ShortVariable = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Введите переменную типа int:");
                        IntVariable = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите переменную типа Ulong:");
                        UlongVariable = Convert.ToUInt64(Console.ReadLine());
                        Console.WriteLine("Вот все наши переменные:");
                        Console.WriteLine(BoolVariable ? "True" : "False");
                        Console.WriteLine($"Sbyte = {SbyteVariable}");
                        Console.WriteLine($"Short = {ShortVariable}");
                        Console.WriteLine($"Int = {IntVariable}");
                        Console.WriteLine($"Long = {LongVariable}");
                        Console.WriteLine($"Byte = {ByteVariable}");
                        Console.WriteLine($"Ushort = {UshortVariable}");
                        Console.WriteLine($"Uint = {UintVariable}");
                        Console.WriteLine($"Ulong = {UlongVariable}");
                        Console.WriteLine($"Float = {FloatVariable}");
                        Console.WriteLine($"Double = {DoubleVariable}");
                        Console.WriteLine($"Char = {CharVariable}");
                        Console.WriteLine($"Decimal = {DecimalVariable}");
                        Console.WriteLine("5 Неявных приведений:");
                        Console.WriteLine($"Short в Int = {IntVariable = ShortVariable}");
                        Console.WriteLine($"Int в Long = {LongVariable = IntVariable}");
                        Console.WriteLine($"Ushort в ULong = {UlongVariable = UshortVariable}");
                        Console.WriteLine($"Ushort в Uint = {UintVariable = UshortVariable}");
                        Console.WriteLine($"Uint в Ulong = {UlongVariable = UintVariable}");
                        Console.WriteLine("5 Явных приведений:");
                        Console.WriteLine($"Double в Int = {IntVariable = (int)DoubleVariable}");
                        Console.WriteLine($"Float в Int = {IntVariable = (int)FloatVariable}");
                        Console.WriteLine($"Double в Float = {FloatVariable = (float)DoubleVariable}");
                        Console.WriteLine($"Int в Ushort = {UshortVariable = (ushort)IntVariable}");
                        Console.WriteLine($"Long в Ushort = {UshortVariable = (ushort)LongVariable}");
                        int iv = 123;
                        object oo;
                        Console.WriteLine($"Упаковка = {oo = iv}");
                        oo = 123;
                        iv = 0;
                        Console.WriteLine($"Распаковка = {iv = (int)oo}");
                        var example = "oma";
                        Console.WriteLine($"{CharVariable + example}");
                        int? NullExample = 8;
                        if (NullExample == null)
                        {
                            Console.WriteLine("Переменная NullExample имеет значение null");
                        }
                        else
                        {
                            Console.WriteLine("Переменная NullExample НЕ имеет значение null");
                        }
                        // var VarExpl = 123;
                        // VarExpl = 123.6F; // Ошибка так как c помощью var мы как бы гооврим компилятору выбрать тип за нас а дальше работает с этим типом
                        
                break;

                case 2:
                        string FirstString = "Roma";
                        string SecondString = "House";
                        Console.WriteLine("Сравним Roma и House. Если Roma и House равны то выведем ПОБЕДА если наоборот то ПОРАЖЕНИЕ ");
                        if (FirstString == SecondString)
                        {
                            Console.WriteLine("ПОБЕДА");
                        }
                        else 
                        {
                            Console.WriteLine("ПОРАЖЕНИЕ");
                        }
                        string S1 = "First", S2 = "Second", S3 = "Third", S4 = "";
                        S4 = S1 + " " + S2 + " ";
                        S4 = string.Concat(S4,"CoCo");
                        Console.WriteLine($"Сцепление(конкатенация) строк = {S4}");
                        S4 = "";
                        S4 = string.Copy(S1);
                        Console.WriteLine($"Копирование строк = {S4}");
                        S4 = "My House";
                        // int StartPos = S4.IndexOf(" ")+1;
                        S4 = S4.Substring(0,2);
                        Console.WriteLine($"Результат = {S4}");
                        S4 = "I love my University";
                        string[] StringArray = S4.Split(' ');
                        foreach (var item in StringArray)
                        {
                            Console.WriteLine($"Вот 1 слово из предложения = {item}");
                        }
                        S4 = "House";
                        S4 = S4.Insert(2,S1);
                        Console.WriteLine($"Вставка подстроки в строку = {S4}");
                        S4 = "Play together";
                        int ind = S4.Length - 8;
                        S4 = S4.Remove(ind);
                        Console.WriteLine($"Удаление подстроки = {S4}");
                        S4 = "Garee";
                        int number = 24;
                        string S5 = String.Format($"Street name = {S4}, Number = {number}");
                        Console.WriteLine($"Интерполяция = {S5}");
                break;

                case 3:
                        int[,] matrix = {{1,2,3},{4,5,6,}};
                        foreach (int ii in matrix)
                        Console.Write($"{ii} ");
                        Console.WriteLine();
                        string[] SArray = {"House", "School", "Work"};
                        foreach (var item in SArray)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        int Length = SArray.Length;
                        string NewWord;
                        int OldWord;
                        Console.WriteLine($"Введите элемент который поменять местами: ");
                        OldWord = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Введите новое слово: ");
                        NewWord = Console.ReadLine();
                        SArray[OldWord] = NewWord;
                        foreach (var item in SArray)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        int[][] jagged = new int[3][];
                        jagged[0] = new int[2];
                        jagged[1] = new int[3];
                        jagged[2] = new int[4];
                        int i;
                        for(i=0; i < 2; i++)
                        jagged[0][i] = i;
                        for(i=0; i < 3; i++)
                        jagged[1][i] = i;
                        for(i=0; i < 4; i++)
                        jagged[2][i] = i;
                        for(i=0; i < 2; i++)
                        Console.Write(jagged[0] [i] + " ") ;
                        Console.WriteLine();
                        for (i=0; i < 3; i++)
                        Console.Write(jagged[1][i] + " ");
                        Console.WriteLine() ;
                        for(i=0; i < 4; i++)
                        Console.Write(jagged[2] [i] + " ") ;
                        Console.WriteLine() ;
                        var array = new object[0];
                        var str = "";       
                break;

                case 4:
                        (int,string,char,string,ulong) tuple = (25,"Roma",'X',"Car",256);
                        (int,string,char,string,ulong) tupleB = (2556,"RomaKDHD",'O',"CarPPPP",2);
                        Console.WriteLine("Выведем весь кортеж:");
                        Console.Write($"{tuple.Item1}\t{tuple.Item2}\t{tuple.Item3}\t{tuple.Item4}\t{tuple.Item5}\n");
                        Console.WriteLine($"{tuple.Item3}");
                        var first = tuple.Item1;
                        var second = tuple.Item2;
                        var third = tuple.Item3;
                        var fourth = tuple.Item4;
                        var fifth = tuple.Item5;
                        if (tuple == tupleB)
                        {
                            Console.WriteLine("Кортежи совпадают");
                        }
                        else
                        {
                            Console.WriteLine("Кортежи не совпадают");
                        }
                break;
            }
                        Console.WriteLine("ФУНКЦИИ");
                        int[] MyArr =  new int[4] {1,2,3,4};
                        string myStr = "Roma";
                        Retorl(MyArr,myStr);
                        Console.WriteLine("CHECKED AND UNCHECKED");
                        int vlu;
                        Console.Write($"Checked = {vlu = CheckedFun()}, Uncheked = {vlu = UnCheckedFun()}");