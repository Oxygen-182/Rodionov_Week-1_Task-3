using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3_1
{
    class Program
    {
        static void f(double x1, double y1, double x2, double y2, out double y)
        {
            double w = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            y = w;
        }
        static void t(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("\nТреугольник с заданными сторонами существует");
            }
            else
            {
                Console.WriteLine("\nТреугольник с заданными сторонами  НЕ существует");
            }
        }
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите координату x1 для первого отрезка:");
                    x1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y1 для первого отрезка:");
                    y1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату x2 для первого отрезка:");
                    x2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y2 для первого отрезка:");
                    y2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nВведите координату x1 для второго отрезка:");
                    x3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y1 для второго отрезка:");
                    y3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату x2 для второго отрезка:");
                    x4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y2 для второго отрезка:");
                    y4 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nВведите координату x1 для третьего отрезка:");
                    x5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y1 для третьего отрезка:");
                    y5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату x2 для третьего отрезка:");
                    x6 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату y2 для третьего отрезка:");
                    y6 = double.Parse(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n\n");
                }
            }
            double y = 0;
            f(x1, y1, x2, y2, out y);
            double x = 0;
            f(x3, y3, x4, y4, out x);
            double q = 0;
            f(x5, y5, x6, y6, out q);

            Console.WriteLine($"\nСторона a = {Math.Round(y, 2)}");
            Console.WriteLine($"Сторона b = {Math.Round(x, 2)}");
            Console.WriteLine($"Сторона c = {Math.Round(q, 2)}");

            t(y, x, q);
        }
    }
}
