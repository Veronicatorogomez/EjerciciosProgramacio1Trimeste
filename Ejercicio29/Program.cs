using System;
using System.Globalization;

namespace Ejercicio29
{
    class Program
    {
        enum Moneda { libra,dolar,yen}
        const double EURO_A_LIBRA = 0.86;
        const double EURO_A_DOLAR = 1.28611;
        const double EURO_A_YEN = 129.852;
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Elige opcion (libra,dolar,yen");
            string moneda =Console.ReadLine();
            Console.WriteLine("introduce la cantidad de euros");
            double euros = double.Parse(Console.ReadLine());
            Convertir(euros,moneda.ToString());
        }
        static void Convertir(double euros, string moneda)
        {   object currency;
           if (Enum.TryParse(typeof(Moneda), moneda, true, out currency))
            { double result;
                switch ((Moneda)currency)
                {
                    case Moneda.libra:
                        result = euros * EURO_A_LIBRA;
                        break;
                    case Moneda.dolar:
                        result = euros * EURO_A_DOLAR;
                        break;
                    default:
                        result = euros * EURO_A_YEN;
                        break;
                        Console.WriteLine($" {euros} son {result}{currency}");
                }
            }
                else
                {
                    Console.WriteLine("No se que moneda es");
                }
        }
    }
}