using System;
using System.Linq;

namespace дз_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти индекс минимального числа массива");

            int[] mas = { 23, 5, -4, 3, 5, 6 };
            int value = mas.Min();
            int index = Array.IndexOf(mas, value);

            Console.Write(index);
            
            //более длинный спрособ в нахождении индекса макс числа
        }
    }
}
