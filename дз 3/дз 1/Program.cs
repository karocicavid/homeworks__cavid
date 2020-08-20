using System;
namespace дз_1
{class program
    {
        static void Main(string[] args)
        {
            Console.Write("Найти максимальное число массива:");

            int[] mas1 = { 2, 3, 1, 4, 6, 13, 2, 8, 9, 22 };
            Array.Sort(mas1);
            Console.WriteLine(mas1[mas1.Length-1]);
        }
    }
}
