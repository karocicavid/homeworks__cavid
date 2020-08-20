using System;
using System.Linq;

namespace дз_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сумма нечетных чисел массива:");
            int[] mas = { 2, 4, 1, 5, 6, 9, 8 };
            int total = 0;
            for(int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    total += mas[i];
                }

            }
            Console.Write(total);


        }
    }
}
