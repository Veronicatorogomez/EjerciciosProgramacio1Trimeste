using System;
using System.Globalization;

namespace Ejercicio28
{
    class Program
    {   enum Option { circle= 1, triangle,square};
        static void Main(string[]args)
        {   
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Elige opcion(circulo=1,triangulo=2,square=3):");
            Option option =(Option) int.Parse(Console.ReadLine());
            double area = 0;

            switch(option)
            {
                case Option.circle:
                    area = CalcularCirculo;
                    break;

                case Option.triangle:
                    break;

                case Option.square:
                    break;
            }
            Console.WriteLine("el areaes :{0}",area);
        }
        static double CalcularCirculo()
        {
            Console.WriteLine("Introduce el radio del circulo:");
            double radio = double.Parse(Console.ReadLine());

            return Math.PI * radio * radio;
            //return Math.PI* Math.POW(radio,2);
        }
        static double CalcularTriangulo()
        {
            Console.WriteLine("Introduce el radio del circulo:");
            double @base = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());
            return (@base * altura) / 2;
        }

    }
}