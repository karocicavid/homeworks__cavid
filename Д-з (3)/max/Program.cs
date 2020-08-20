using System;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа запрашивает 3 числа и выводит максимум из них.");
            Console.Write("Введите 3 разные числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine($"Максимальное число-{a}");
            }
            if (c > b & c > a)
            {
                Console.WriteLine($"Максимальное число-{c}");
            }
            if (b > a & b > c)
            {
                Console.WriteLine($"Максимальное число-{b}");
            }
            if(a == b)
            {
                Console.WriteLine("Есть равенство между чисел");
            }
            if (b == c)
            {
                Console.WriteLine("Есть равенство между чисел");
            }
            if (a == c)
            {
                Console.WriteLine("Есть равенство между чисел");
            }
        }
    }
}
