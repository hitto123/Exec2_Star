using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}



		public void button1_Click(object sender, EventArgs e)
		{

			int? number1=GetNumber();
			string stars = Genstars(number1.Value);
			textBox2.Text = stars;

		}
		private void button2_Click(object sender, EventArgs e)
		{
			int? number1=GetNumber();
			string stars2=Genstars2(number1.Value);
			textBox2.Text = stars2;
		}
		private void button3_Click(object sender, EventArgs e)
		{	
			int? number1=GetNumber();
			string stars3=Genstars3(number1.Value);
			textBox2.Text=stars3;

		}
		public int?  GetNumber()
		{
			int? rows = GetRows();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				
			}
			if (rows <= 0)
			{
				MessageBox.Show("請輸入正數");
				
			}
			return rows.Value;

		}

		//靠左三角形
		public string Genstars(int rows)
		{	
			string value=string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				value += new string('*', i) +"\r\n";
			}
			return value;
		}
		//靠右三角形
		public string Genstars2(int rows)
		{
			string value2 = string.Empty;
			
			for (int g = 1; g <= rows; g++)
			{
				int space=rows-g;
				int stars = g;
				value2+=new string(' ',space)+ new string(' ', space)+
					new string('*',stars)+("\r\n");
				
			}
			return value2;
		}
		//等腰三角形
		public string Genstars3(int rows)
		{
			string value3 = string.Empty;

			for (int a = 1; a <= rows; a++)
			{
				for (int b = 1; b <= rows - a; b++)
				{
					value3 += "  ";
				}
				for (int c = 1; c < 2 * a; c++)
				{
					value3 += "*";
				}
				value3 += "\r\n";

			}
			return value3;
		}


		public int? GetRows()
		{
			string input = textBox1.Text;
			bool isint = int.TryParse(input, out int rows);

			if (isint)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
