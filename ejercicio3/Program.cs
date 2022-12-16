using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("introduzca una temperatura en grados  Fahrenheit");
        int a = int.Parse(Console.ReadLine());
        int b;
        b = (a - 32) * 5 / 9;
        Console.WriteLine("la pasamos a Celsius" + " " + b);
        


    }
}