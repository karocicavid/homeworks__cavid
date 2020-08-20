using System;

namespace дз_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сумма элементов массива с нeчетными индексами = ");
            int[] mas = { 1, 4, 2, 5, 6, 88, 7, 9 };
            int total = 0;
            for(int i=0;i<mas.Length;i++)
            {
                if (i % 2!=0)
                {
                    total+=mas[i];
                }
                else
                {
                    continue;
                }
               
            }
            Console.WriteLine(total);
        }
    }
}
