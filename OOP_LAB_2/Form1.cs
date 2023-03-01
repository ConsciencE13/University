using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab2
{
	public partial class Form1 : Form
	{
		string[] options = { "Кухня", "Ванна", "Туалет", "Подвал", "Балкон" };
		string[] materials = { "Лед", "Доски", "Камни", "Бетон", "Кирпичи" };

		public Form1()
		{
			InitializeComponent();
			textBox1.Validating += textBox1_Validating;
			textBox2.Validating += textBox2_Validating;
			textBox3.Validating += textBox3_Validating;
			textBox4.Validating += textBox4_Validating;
			textBox5.Validating += textBox5_Validating;
			textBox6.Validating += textBox6_Validating;
			textBox7.Validating += textBox7_Validating;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			checkedListBox1.Items.AddRange(options);
			comboBox1.Items.AddRange(materials);
			comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			textBox8.ReadOnly = true;

			listView1.View = View.Details;
			listView1.GridLines = true;
			listView1.FullRowSelect = true;

			listView1.Columns.Add("Площадь", 60);
			listView1.Columns.Add("Кол-во комнат", 90);
			listView1.Columns.Add("Кухня", 45);
			listView1.Columns.Add("Ванна", 45);
			listView1.Columns.Add("Туалет", 50);
			listView1.Columns.Add("Подвал", 50);
			listView1.Columns.Add("Балкон", 50);
			listView1.Columns.Add("Год", 40);
			listView1.Columns.Add("Материал", 65);
			listView1.Columns.Add("Этаж", 40);
			listView1.Columns.Add("Страна", 100);
			listView1.Columns.Add("Город", 100);
			listView1.Columns.Add("Район", 100);
			listView1.Columns.Add("Улица", 100);
			listView1.Columns.Add("Дом", 50);
			listView1.Columns.Add("Корпус", 50);
			listView1.Columns.Add("Квартира", 60);
			listView1.Columns.Add("Стоимость (BYN)", 100);
		}

		[Serializable]
		public class Apartment
		{
			public static Form1 form;
			public int area;
			public int amount;
			public int[] options;
			public int year;
			public int material;
			public int floor;
			public Adress adress;
			public int price;

			[Serializable]
			public class Adress
			{
				public string country;
				public string city;
				public string region;
				public string street;
				public int house;
				public int corps;
				public int number;

				public Adress()
				{

				}

				public Adress(string Country, string City, string Region, string Street, int House, int Corps, int Number)
				{
					country = Country;
					city = City;
					region = Region;
					street = Street;
					house = House;
					corps = Corps;
					number = Number;
				}
			}

			public Apartment()
			{

			}

			public Apartment(int Area, int Amount, int[] Options, int Year, int Material, int Floor, Adress Adress, int Price)
			{
				area = Area;
				amount = Amount;
				options = Options;
				year = Year;
				material = Material;
				floor = Floor;
				adress = Adress;
				price = Price;
			}
		}

		static bool isLetter(char ch)
		{
			if ((ch >= 'А' && ch <= 'Я') || (ch >= 'а' && ch <= 'я'))
				return true;
			else
				return false;
		}

		static bool isNumber(char ch)
		{
			if (ch >= '0' && ch <= '9')
				return true;
			else
				return false;
		}

		static bool letterBoxCheck(string str)
		{
			bool check = true;

			for (int i = 0; i < str.Length; i++)
			{
				if (check)
					check = isLetter(str[i]);
			}

			return check;
		}

		static bool numberBoxCheck(string str)
		{
			bool check = true;

			for (int i = 0; i < str.Length; i++)
			{
				if (check)
					check = isNumber(str[i]);
			}

			return check;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void hScrollBar1_Scroll(Object sender, ScrollEventArgs e)
		{
			label2.Text = e.NewValue.ToString();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label4.Text = trackBar1.Value.ToString();
		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			label9.Text = ((-1) * (e.NewValue - 16)).ToString();
		}

		int price()
		{
			int sum = 0;

			sum += hScrollBar1.Value * 1000;
			sum += trackBar1.Value * 10000;
			sum += checkedListBox1.CheckedItems.Count * 5000;
			sum += (-1) * (DateTime.Now.Year - (int)numericUpDown1.Value - 121) * 500;
			sum += (comboBox1.SelectedIndex + 1) * 15000;

			return sum;
		}

		bool isValid()
		{
			bool check = true;
			if (String.IsNullOrEmpty(textBox1.Text))
			{
				check = false;
				errorProvider1.SetError(textBox1, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox2.Text))
			{
				check = false;
				errorProvider1.SetError(textBox2, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox3.Text))
			{
				check = false;
				errorProvider1.SetError(textBox3, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox4.Text))
			{
				check = false;
				errorProvider1.SetError(textBox4, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox5.Text))
			{
				check = false;
				errorProvider1.SetError(textBox5, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox6.Text))
			{
				check = false;
				errorProvider1.SetError(textBox6, "Поле не заполнено!");
			}
			if (String.IsNullOrEmpty(textBox7.Text))
			{
				check = false;
				errorProvider1.SetError(textBox7, "Поле не заполнено!");
			}
			if (comboBox1.SelectedIndex == -1)
			{
				check = false;
				errorProvider1.SetError(comboBox1, "Поле не заполнено!");
			}

			return check;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (isValid())
				textBox8.Text = price().ToString() + " рублей";
			else
				MessageBox.Show(
					"Проверьте введенные данные!",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
		}

		public Apartment apartCreator()
		{
			Apartment.Adress adress = new Apartment.Adress
					(
					textBox1.Text,
					textBox2.Text,
					textBox3.Text,
					textBox4.Text,
					Convert.ToInt32(textBox5.Text),
					Convert.ToInt32(textBox6.Text),
					Convert.ToInt32(textBox7.Text)
					);

			Apartment apart = new Apartment
				(
				hScrollBar1.Value,
				trackBar1.Value,
				checkedListBox1.CheckedIndices.Cast<int>().ToArray(),
				(int)numericUpDown1.Value,
				comboBox1.SelectedIndex,
				(-1) * (vScrollBar1.Value - 16),
				adress,
				price()
				);

			return apart;
		}

		public string[] apartFiller(Apartment apart)
		{
			string[] arr = new string[18];

			arr[0] = apart.area.ToString();
			arr[1] = apart.amount.ToString();
			if (apart.options.Contains(0))
				arr[2] = "Есть";
			else
				arr[2] = "Нет";
			if (apart.options.Contains(1))
				arr[3] = "Есть";
			else
				arr[3] = "Нет";
			if (apart.options.Contains(2))
				arr[4] = "Есть";
			else
				arr[4] = "Нет";
			if (apart.options.Contains(3))
				arr[5] = "Есть";
			else
				arr[5] = "Нет";
			if (apart.options.Contains(4))
				arr[6] = "Есть";
			else
				arr[6] = "Нет";
			arr[7] = apart.year.ToString();
			arr[8] = materials[apart.material];
			arr[9] = apart.floor.ToString();
			arr[10] = apart.adress.country;
			arr[11] = apart.adress.city;
			arr[12] = apart.adress.region;
			arr[13] = apart.adress.street;
			arr[14] = apart.adress.house.ToString();
			arr[15] = apart.adress.corps.ToString();
			arr[16] = apart.adress.number.ToString();
			arr[17] = apart.price.ToString();

			return arr;
		}

		public void apartSender(string[] arr)
		{
			ListViewItem item;
			item = new ListViewItem(arr);
			listView1.Items.Add(item);
		}

		public void elementsClear()
		{
			hScrollBar1.Value = 1;
			vScrollBar1.Value = 15;
			trackBar1.Value = 1;
			numericUpDown1.Value = 1900;
			comboBox1.SelectedIndex = -1;
			foreach (int i in checkedListBox1.CheckedIndices)
			{
				checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
			}
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			label2.Text = "1";
			label4.Text = "1";
			label9.Text = "1";
		}

		List<Apartment> apartList = new List<Apartment>();

		private void button2_Click(object sender, EventArgs e)
		{
			if (isValid())
			{
				Apartment apart = apartCreator();
				apartList.Add(apart);

				listView1.Items.Clear();

				elementsClear();

				foreach (Apartment tempApart in apartList)
				{
					string[] arr = apartFiller(tempApart);
					apartSender(arr);
				}
			}
			else
				MessageBox.Show(
					"Проверьте введенные данные!",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Apartment[]));

			Apartment[] newAparts = new Apartment[apartList.Count];
			int apartIndex = 0;

			foreach (Apartment tempApart in apartList)
			{
				newAparts[apartIndex] = tempApart;
				apartIndex++;
			}

			using (FileStream fs = new FileStream("Apartments.xml", FileMode.Create))
			{
				formatter.Serialize(fs, newAparts);
			}

			listView1.Items.Clear();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			listView1.Items.Clear();

			XmlSerializer formatter = new XmlSerializer(typeof(Apartment[]));

			using (FileStream fs = new FileStream("Apartments.xml", FileMode.OpenOrCreate))
			{
				apartList.Clear();

				Apartment[] newAparts = (Apartment[])formatter.Deserialize(fs);

				for (int i = 0; i < newAparts.Length; i++)
				{
					apartList.Add(newAparts[i]);
				}

				foreach (Apartment tempApart in apartList)
				{
					string[] arr = apartFiller(tempApart);
					apartSender(arr);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e) { }

		private void textBox2_TextChanged(object sender, EventArgs e) { }

		private void textBox3_TextChanged(object sender, EventArgs e) { }

		private void textBox4_TextChanged(object sender, EventArgs e) { }

		private void textBox5_TextChanged(object sender, EventArgs e) { }

		private void textBox6_TextChanged(object sender, EventArgs e) { }

		private void textBox7_TextChanged(object sender, EventArgs e) { }

		private void textBox8_TextChanged(object sender, EventArgs e) { }

		private void textBox1_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox1.Text))
			{
				errorProvider1.SetError(textBox1, "Поле не заполнено!");
			}
			else if (textBox1.Text.Length < 3)
			{
				errorProvider1.SetError(textBox1, "Слишком короткое название!");
			}
			else if (!letterBoxCheck((textBox1.Text).ToString()))
			{
				errorProvider1.SetError(textBox1, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox1, "");
			}
		}

		private void textBox2_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox2.Text))
			{
				errorProvider1.SetError(textBox2, "Поле не заполнено!");
			}
			else if (textBox2.Text.Length < 3)
			{
				errorProvider1.SetError(textBox2, "Слишком короткое название!");
			}
			else if (!letterBoxCheck((textBox2.Text).ToString()))
			{
				errorProvider1.SetError(textBox2, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox2, "");
			}
		}

		private void textBox3_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox3.Text))
			{
				errorProvider1.SetError(textBox3, "Поле не заполнено!");
			}
			else if (textBox3.Text.Length < 3)
			{
				errorProvider1.SetError(textBox3, "Слишком короткое название!");
			}
			else if (!letterBoxCheck((textBox3.Text).ToString()))
			{
				errorProvider1.SetError(textBox3, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox3, "");
			}
		}

		private void textBox4_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox4.Text))
			{
				errorProvider1.SetError(textBox4, "Поле не заполнено!");
			}
			else if (textBox4.Text.Length < 3)
			{
				errorProvider1.SetError(textBox4, "Слишком короткое название!");
			}
			else if (!letterBoxCheck((textBox4.Text).ToString()))
			{
				errorProvider1.SetError(textBox4, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox4, "");
			}
		}

		private void textBox5_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox5.Text))
			{
				errorProvider1.SetError(textBox5, "Поле не заполнено!");
			}
			else if (!numberBoxCheck((textBox5.Text).ToString()))
			{
				errorProvider1.SetError(textBox5, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox5, "");
			}
		}

		private void textBox6_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox6.Text))
			{
				errorProvider1.SetError(textBox6, "Поле не заполнено!");
			}
			else if (!numberBoxCheck((textBox6.Text).ToString()))
			{
				errorProvider1.SetError(textBox6, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox6, "");
			}
		}

		private void textBox7_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(textBox7.Text))
			{
				errorProvider1.SetError(textBox7, "Поле не заполнено!");
			}
			else if (!numberBoxCheck((textBox7.Text).ToString()))
			{
				errorProvider1.SetError(textBox7, "Неверный формат ввода!");
			}
			else
			{
				errorProvider1.SetError(textBox7, "");
			}
		}

		private void comboBox1_Validating(object sender, CancelEventArgs e)
		{
			if (comboBox1.SelectedIndex == -1)
			{
				errorProvider1.SetError(comboBox1, "Поле не заполнено!");
			}
			else
			{
				errorProvider1.SetError(comboBox1, "");
			}
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
