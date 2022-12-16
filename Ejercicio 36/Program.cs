using System;
namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numeros separados por coma");
            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');
            int[] numerosDeVerdad = new int[numerosDivididos.Length];
            int aux;
            for (int i = 0; i < numerosDivididos.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);
            }
            for (int i = 0; i < numerosDeVerdad.Length - 1; i++)
            {
                for (int j = 0; j < numerosDeVerdad.Length - 1; j++)
                {
                    if (numerosDeVerdad[j] < numerosDeVerdad[j + 1])
                    {
                        aux = numerosDeVerdad[j];
                        numerosDeVerdad[j] = numerosDeVerdad[j + 1];
                        numerosDeVerdad[j + 1] = aux;

                    }
                }
            }
            Console.WriteLine(string.Join(',', numerosDeVerdad));
        }
    }
}
