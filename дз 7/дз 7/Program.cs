using System;
using System.Linq;

namespace дз_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Масив:");
            int[] mas = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int i in mas)
            {
                Console.Write($"{i},");
            }
            int temp;
            int n = mas.Length;
            for(int i = 0; i < n/2 ; i++)
            {
                temp = mas[i];
                mas[i] = mas[n - i - 1];
                mas[n - i - 1] = temp;
            }
            Console.Write("\nРеверс масива:");
            foreach (int i in mas)
            {
                Console.Write($"{i},");
            }
        }   
    }
}
