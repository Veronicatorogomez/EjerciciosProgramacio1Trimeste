using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        int numero = int.Parse(Console.ReadLine());
        int resultado;
        Random random = new Random();
        bool siguiente = false;
        for (int i = 1; i <= numero; i++) 
        {
            resultado = random.Next(i, numero+1);
            siguiente = i > 5;

            if (resultado <= numero ) 
            {
                Console.WriteLine(resultado + numero);
            }
            else Console.WriteLine(resultado);
        }
        
        

    }
}
//problema de lectura enunciado
