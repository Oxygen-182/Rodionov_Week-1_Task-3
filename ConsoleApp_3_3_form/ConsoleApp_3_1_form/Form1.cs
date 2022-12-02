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
        static void f(double x1, double y1, double x2, double y2, out double y)
        {
            double w = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            y = w;
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

            double y = 0;
            f(x1, y1, x2, y2, out y);
            double x = 0;
            f(x3, y3, x4, y4, out x);
            double q = 0;
            f(x5, y5, x6, y6, out q);

            textBox13.Text += $"Сторона a = {Math.Round(y, 2)}";
            textBox13.Text += Environment.NewLine;
            textBox13.Text += $"Сторона b = {Math.Round(x, 2)}";
            textBox13.Text += Environment.NewLine;
            textBox13.Text += $"Сторона c = {Math.Round(q, 2)}";
            textBox13.Text += Environment.NewLine;

            int n = t(y, x, q);

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
