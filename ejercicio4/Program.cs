using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        int a, b;
        a = int.Parse(Console.ReadLine());
        b =a %  10;
        Console.WriteLine(b);



    }
}