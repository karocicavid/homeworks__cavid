using System;

namespace циклы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("количество и сумма четных чисел от 1-99");
            Console.WriteLine("Циклы");
            int total_num = 0;
            int sum = 0;

            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    total_num += 1;
                    sum += i;

                }


                else { }
                {
                    continue;
                }
            }
            Console.WriteLine($"сумма-{sum},количество четных чисел-{total_num}");
        }
    }
}
