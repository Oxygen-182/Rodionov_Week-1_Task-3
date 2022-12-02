using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3_2
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x < 3) y = x * x - 0.3;
            else if (x > 5) y = x * x + 1;
            else y = 0;
            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Параметр a не может быть больше параметра b");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Параметр h не может быть отрицательным");
                return;
            }

            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f2}", i, f(i));
        }
    }
}
