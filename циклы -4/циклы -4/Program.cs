using System;

namespace цикл_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти сумму цифр 3-ех значного числа");

            int num = int.Parse(Console.ReadLine());
            int values;
            int sum=0;

            Console.WriteLine("Данное число: " + num);
            Console.Write("Сумма цифр:");

            if (num > 99 & num < 1000)
            {
                do
                {

                    values = num % 10;
                    num = num / 10;
                    sum += values;

                }
                while (num > 0);
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Введите 3-ех значное,положительное число");
            }
        }
    }
}
    

