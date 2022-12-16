using System;
namespace Ejercicio
{
    class Program
    {
        static void Main()
        {
            int n, m, fact;
            n = PedirNumero();
            m = PedirNumero();
            fact = Operacion(n,m);
            Resultado(n,m,fact);
        }
        static int PedirNumero()
        {
            Console.WriteLine("Introduzca dos numeros enteros");
            return int.Parse(Console.ReadLine());
        }
        static int Operacion(int n, int m)
        {
            return Factorial(n) - Factorial (m);

        }
        static int Factorial (int x)
        { 
            int fact = 1;
       
            for(int i = 2; i <= x; i++ )
            fact *= i;
            return fact;
        }
        static void Resultado(int n, int m, int fact)
        {
            Console.WriteLine(fact);
        }
    }
}
