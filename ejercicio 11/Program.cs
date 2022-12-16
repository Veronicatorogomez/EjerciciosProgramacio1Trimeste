using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 2; i < numero; i++)
        { bool isPrime = true;
            for (int j = 2;j<= i-1 && isPrime; j++)
            {
                isPrime = i % j != 0;
                {
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
        }

    }
}

//si divido el i entre cualquier numero y da 0 no es primo (no se pone)