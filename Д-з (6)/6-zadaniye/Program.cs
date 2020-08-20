using System;

namespace _6_zadaniye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Магазин делает скидку,если больше 500-50,если больше 1000-100.");
            int total = int.Parse(Console.ReadLine());

            if (total>500 && total<1000)
            {
                Console.WriteLine($"Total is:{total - 50}");
            }
            if (total > 1000)
            {
                Console.WriteLine($"Total is:{total - 100}");
            }
            if (total<500) 
            {
                Console.WriteLine($"Total is:{total}");
            }
        }
    }
}
