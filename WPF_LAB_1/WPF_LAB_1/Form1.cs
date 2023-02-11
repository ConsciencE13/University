namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string ru = textBox2.Text;
            string en = textBox1.Text;
            string amer = textBox3.Text;
            string jap = textBox4.Text;
            string test = "";

            try
            {
                int x = 2;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (en.Equals(test) == false)
            {
                float england = Convert.ToSingle(textBox1.Text);

            }
            else if (ru.Equals(test) == false)
            {
                float russian = Convert.ToSingle(textBox2.Text);


            }
            else if (amer.Equals(test) == false)
            {
                float american = Convert.ToSingle(textBox3.Text);
            }
            else if (jap.Equals(test) == false)
            {
                float japan = Convert.ToSingle(textBox4.Text);

            }
        }
        class Calculator
        {
            public delegate void RussianSize(float message);
            public event RussianSize? Calculate;              // 1.Определение события

            public Calculator(float sum) => Sum = sum;
            public float Sum { get; private set; }
            public void ConvertSize(float sum)
            {
                Calculate?.Invoke(sum+=Sum );   // 2.Вызов события 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}