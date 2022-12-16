using System;
namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numeros separados por coma");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');
            int[] numerosDeVerdad = new int[numerosDivididos.Length];
            for (int i = 0; i < numerosDivididos.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);
            }
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            foreach(int numero in numerosDeVerdad)
            {
                if (numero > maximo) maximo = numero;
                if (numero < minimo) minimo = numero;
            }
        }
    }
}