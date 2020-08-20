using System;

namespace дз_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отсортировать массив методом пузырька.");
            int[] mas = { 2, 1, 4, 56, 22, 7 };//
            int temp;
            int n = mas.Length;
            
            for(int i = 0; i < n-1; i++)//i=0
            {
                for(int j =i+ 1; j < n; j++)
                {
                    if(mas[i] > mas[j])
                    {
                        temp = mas[j];
                        mas[j] = mas[i];
                        mas[i] = temp;
                    }
                }
            }
            foreach(int значении in mas)
            {
                Console.Write($"{значении},");
            }


        }
    }
}
