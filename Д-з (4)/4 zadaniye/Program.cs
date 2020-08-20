using System;

namespace _4_zadaniye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа дает строковое значение дни недели.");
            int week = Convert.ToInt32(Console.ReadLine());
            if (week == 1)
            {
               Console.WriteLine("Monday");
            }
            if (week == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (week == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (week == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (week == 5)
            {
                Console.WriteLine("Friday");
            }
            if (week == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (week == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (week>7 || week<0)
            {
                Console.WriteLine("There is 7 days in a week,don't forget!");
            }
        }
    }
}


