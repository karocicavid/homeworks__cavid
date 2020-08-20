using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу которая спрашивает погоду на улице:");
            int weather = int.Parse(Console.ReadLine());
            if (weather > -20 & weather < 5)
            {  
                Console.WriteLine("холодно");
            }           
            if (weather > 6 & weather < 15)
            {
                Console.WriteLine("прохладно");
            }
            if (weather > 16 & weather < 20)
            {
                Console.WriteLine("тепло");
            }
            if (weather > 21 & weather < 35)
            {
                Console.WriteLine("жарко");
            }
            if( weather > 35)
            {
                Console.WriteLine("Ваш градус не входит в наши лимиты.");
            }
            if (weather < -20)
            {
                Console.WriteLine("Ваш градус не входит в наши лимиты.");
            }
        }      
            
    }

}

