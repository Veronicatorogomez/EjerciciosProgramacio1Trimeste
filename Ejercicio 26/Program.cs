using System;
namespace Ejercicio
{
    class Program
    {
        static void Main()
        {
            int n = PedirNumero();
            int sum,fact, result;
            sum = Sumatorio(n);
            fact = Factorial(sum);
            result = Operacion(n, sum);
            ImprimirResultado(result);
        }
        static int PedirNumero()
        {
            Console.WriteLine("Introduzca un numero entero");
            return int.Parse(Console.ReadLine());
        }
        static int Operacion(int n,int sum)
        {
            return Sumatorio(n) * Factorial (sum);
        }
        static int Sumatorio(int n)
        {   int x = 0;
            for(int i = 0; i <= n; i++)
            {
                x += Factorial(i) + i;
            }
            return x;
        }
      
        static int Factorial( int sum)
        {   
            int x = 1;
            for(int i = 2 ;i <= sum ; i++)
            {
                x *= i;
            }
            return x;
        }
        static void ImprimirResultado (int result)
        {
            Console.WriteLine(result);
        }

    }
}