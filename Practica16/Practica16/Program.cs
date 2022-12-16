using System;
namespace Practica16;
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca un numero natural");
        int natural = int.Parse(Console.ReadLine());
        Console.WriteLine(" Introduzca un numero base");
        int b = int.Parse(Console.ReadLine());
        int resultado;
        if (b > 2 || b < 9)
        {
            Console.WriteLine("Introduzca un numero de rango 2 a 9");
        }
        else
        {
            while (natural / b > 0)
            {
                natural /= b;
            }
        }
    }
}