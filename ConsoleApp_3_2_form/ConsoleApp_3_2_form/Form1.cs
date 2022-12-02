using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_3_2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double y;
            if (x < 3) y = x * x - 0.3;
            else if (x > 5) y = x * x + 1;
            else y = 0;
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);

            if(a > b)
            {
                textBox4.Text += "Параметр a не может быть больше параметра b";
                return;
            }
            if (h < 0)
            {
                textBox4.Text += "Параметр h не может быть отрицательным";
                return;
            }

            textBox4.Text += "Значения функции f(x)";
            textBox4.Text += Environment.NewLine;

            for (double i = a; i <= b; i += h)
            {
                textBox4.Text += Environment.NewLine;
                textBox4.Text += ($"f({i:f2})={f(i):f2}");
            }
        }
    }
}
