using System;
namespace Diamante1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("introduzca el tamaño");
            int tamaño = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamaño; i++)
            {
                /* if (i == 0 || i == tamaño)
                 {
                     Console.WriteLine(new string(' ', tamaño - i));
                 }
                 else
                 {

                 }*/
                

                for (int j = 0; j < tamaño - i; j++)
                {
                    Console.Write(' ');

                }

                for (int j = 0; j < i*2 +1; j++)
                {
                    Console.Write('*');

                }

                Console.WriteLine();
            }
        }
    }
}