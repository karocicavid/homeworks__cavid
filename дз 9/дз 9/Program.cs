using System;

namespace дз_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменять местами первую и вторую половину массива.");
            int[] mas = { 1, 2, 3, 4, 5, 6 };
            int n = mas.Length;
            int k = mas.Length / 2;
            int temp;

            for(int i = 0; i < k; i++)
            {
                temp = mas[k + i];
                mas[k + i] = mas[i];
                mas[i] = temp;
            }
            
            foreach(int i in mas)
            {
                Console.Write($"{i},");
            }
        }
    }
}
