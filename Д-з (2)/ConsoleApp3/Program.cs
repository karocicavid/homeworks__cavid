using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определить век по введению числа.");
            Console.WriteLine("Введите 4-ех значное число");
            int num = int.Parse(Console.ReadLine());
            if(num%100==0)
                {
                Console.WriteLine($"Вы в {num/100} веке");
                }
            else
            {
                Console.WriteLine($"Вы в {num/100 + 1} веке");
            }
        }
    }
}   
    
