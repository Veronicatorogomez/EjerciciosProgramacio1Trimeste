using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        int a;
        a = int.Parse(Console.ReadLine());
        bool Impar = true;
        for(int i=0; i<=a * 2; i++)
        {
            Impar = i % 2 != 0;
            if (Impar)
            {
                Console.WriteLine(i);
            }
        }
    }
}