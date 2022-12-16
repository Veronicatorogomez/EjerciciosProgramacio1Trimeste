using System;
using System.Globalization;

namespace Ejercicio18
{
    class Program
    {
        static int PedirNumero()
        {
            int resultado = -1;
            do
            {
                try
                {
                    resultado = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Introduzca un numero entero");
                }
            }
            while (resultado == -1);
            return resultado;
        }
        static double PedirNumeroDecimal()
        {
            double resultado = -1;
            do
            {
                try
                {
                    resultado = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("introduzca un numero real");
                }
            }
            while (resultado == -1);
            return resultado;
        }
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Indica cuantos numeros quiere introducir");
            int cantidad = PedirNumero();
            double cuadrados = 0;
            double resultado;
            double cuadratica;
            double number = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Introduce un numero");
                number = PedirNumeroDecimal();
                cuadrados += number * number;
            }
            resultado = cuadrados / number;
            cuadratica = Math.Sqrt(resultado);
            Console.WriteLine(cuadratica);
        }
    }
}