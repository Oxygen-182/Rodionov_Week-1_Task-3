using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_3_1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        static int t(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            double x1 = double.Parse(textBox1.Text);
            double y1 = double.Parse(textBox2.Text);
            double x2 = double.Parse(textBox3.Text);
            double y2 = double.Parse(textBox4.Text);

            double x3 = double.Parse(textBox5.Text);
            double y3 = double.Parse(textBox6.Text);
            double x4 = double.Parse(textBox7.Text);
            double y4 = double.Parse(textBox8.Text);

            double x5 = double.Parse(textBox9.Text);
            double y5 = double.Parse(textBox10.Text);
            double x6 = double.Parse(textBox11.Text);
            double y6 = double.Parse(textBox12.Text);

            double len1 = f(x1, y1, x2, y2);
            double len2 = f(x3, y3, x4, y4);
            double len3 = f(x5, y5, x6, y6);

            textBox13.Text += $"Сторона a = {Math.Round(len1, 2)}";
            textBox13.Text += Environment.NewLine;
            textBox13.Text += $"Сторона b = {Math.Round(len2, 2)}";
            textBox13.Text += Environment.NewLine;
            textBox13.Text += $"Сторона c = {Math.Round(len3, 2)}";
            textBox13.Text += Environment.NewLine;

            int n = t(len1, len2, len3);

            if (n == 1)
            {
                textBox13.Text += "\nТреугольник с заданными сторонами существует";
            }
            if (n == 0)
            {
                textBox13.Text += "\nТреугольник с заданными сторонами НЕ существует";
            }
        }
    }
}
