using System;


namespace дз_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти минимальное число массива:");

            int[] mas = { 2, 3, 6, -1, 7, 4 };
            Array.Sort(mas);
            Console.WriteLine(mas[0]);
        }
    }
}
