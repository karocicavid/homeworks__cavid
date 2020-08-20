using System;
using System.Linq;

namespace дз_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Индекс максимального элемента массива:");
            int[] mas = { 2, 4, 1, 5, 6, 9, 8 };
            int temp=0;

            for(int i = 0; i < mas.Length; i++)
            {
                for(int j = 1; j < mas.Length - 1; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                    }
                    
                    else if (mas[j] > mas[i])
                    {
                        temp = mas[j];
                    }
                    

                }
            }

            Console.Write(Array.IndexOf(mas,temp));
        }
    }
}
