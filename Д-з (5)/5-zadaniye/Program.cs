using System;

namespace _5_zadaniye
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Деление двух чисел.");
         double a = double.Parse(Console.ReadLine());
         double b = double.Parse(Console.ReadLine());

            if ( b !=0)
        {
                Console.WriteLine($"{a / b}");
        }
        else
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
        }
    }
}
