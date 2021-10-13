using System;

namespace Lab2_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость");
            double a = double.Parse(Console.ReadLine());
            if (a > 1000 && a < 2000) a = a - a * 0.05;
            else if (a > 2000 && a < 5000) a = a - a * 0.1;
            Console.WriteLine($"Цена с учетом скидки: {a}");
        }
    }
}
