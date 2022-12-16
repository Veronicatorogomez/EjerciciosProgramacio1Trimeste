using System;
using System.ComponentModel.DataAnnotations.Schema;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("introduce una palabra");
        string palabra = Console.ReadLine();
        int i = 0;
        int j = palabra.Length - 1;
        char a = Convert.ToChar(palabra[i]);
        char b = Convert.ToChar(palabra[j]);
        for (i = 0; i > palabra.Length / 10; i++) 
        {
            
        }
            for (j = 0; j <= palabra.Length / 10; j++) 
            {
            bool nopalindromo = a != b || i != j;
            
            if (nopalindromo)
            {
                Console.WriteLine("NO es palindromo");
                    }
            else
            {
                Console.WriteLine("SI es palindromo");
            }
            }

        }
}
//i- esimo es el valor de i = 0,1,2,3...