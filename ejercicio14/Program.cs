using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main()
    {
        Console.WriteLine("indroduzca un numero entero");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("indroduzca un numero entero");
        int b = int.Parse(Console.ReadLine());
        Random random = new Random(a);
        for (int i = 0; i < b; i++)
        {
            int result = random.Next(256);

            Console.WriteLine((char)result);
        }
     
    } 
}