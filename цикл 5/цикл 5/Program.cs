using System;

namespace цикл_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int values;


            Console.WriteLine("Данное число: " + num);
            Console.Write("Перевернутое число:");


            do
            {

                values = num % 10;

                Console.Write(values);

                num = num / 10;

            } 
            while (num > 0);

            Console.Write("");

        }
    }
}
    

