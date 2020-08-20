using System;

namespace дз_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполнить массив из 20 элементов Фибоначчи.");
            int u, u1 = 1,u2 = 0;
            Console.Write($"{0},");
            for(int i = 1 ;i<20 ; i += 1)
            {
                u = u1 + u2;//1+0//0+1//1+1//2+1
                u1 = u2;//1=0//0=1//1=1//1=2
                u2 = u;//0=1//1=1//1=2//2=3
                Console.Write($"{u},");
            }
        }
    }
}
