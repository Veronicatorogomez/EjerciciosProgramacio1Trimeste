using System;
using System.Text.RegularExpressions;

namespace Ejercicio20
{
    class Program
    {
        enum MonthOfYear { January = 1, February, March, April, May, june, July, Agust, September, Octuber, November, December }
        static void Main()
        {
            Console.WriteLine("Introduce un mes (1-12)");
            int month = int.Parse(Console.ReadLine());
            MonthOfYear mes= (MonthOfYear)month;
            Console.WriteLine(mes.ToString());
        }
        
        
    }
}


   