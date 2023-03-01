class dopik
{
class intArray 
    {
        int[] IntArray;
        public int n 
        {
            get; 
            private set;
        }
        public int scalar
        {
            private get { return scalar; }
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                {
                    IntArray[i] *= value;
                }
            }
        }
        public intArray(int N) 
        {
            this.n = N;
            IntArray = new int[n];
        }
        public void readArray() 
        {
            Console.WriteLine("Введите элементы:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("intArray[{0}] = ", i); IntArray[i] = Convert.ToInt32( Console.ReadLine());
            }
        }
        public void printArray() 
        {
            Console.WriteLine("Вывод элементов:");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine("IntArray[{0}] = {1}; ",i,IntArray[i]);
            }
        }
        public int summ = 0;
        public void SumArr()
        {
            foreach (var item in IntArray)
            {
                summ +=item;
            }
            Console.WriteLine($"Summa = {summ}");
        }
        
        public int tt=0;
        private bool da = true;
        public void RaznostArr()
        {
            tt = IntArray[0];
            foreach (var item in IntArray)
            {
                if (da == true)
                {
                    da =  false;
                    continue;
                }
                tt = tt - item;
            }
            Console.WriteLine($"Raznost = {tt}");
        }
    }
        static void Main(string[] args)
        {
            intArray arr = new intArray(3);
            arr.readArray();
            arr.printArray();
            arr.SumArr();
            arr.RaznostArr();
        }
}