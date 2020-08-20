using System;

namespace циклы2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("проверить простое ли число:");
            bool check = true;
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; ++i)
            {
                if (num % i == 0)
                {
                    check = false;
                }
            }
            if(check)
            {
                Console.WriteLine("Простое число");
            }
            else
            {
                Console.WriteLine("Сложное число");
            }
        }
    }
}

