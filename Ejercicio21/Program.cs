using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;

namespace Ejercicio21
{
    class Program
    {   enum DayOfWeek { monday = 1, tuesday, wednesday, thrusday, friday, saturday, sunday }
   /* aplicar el try catch hay que crear un enumerado previo que sea none=-1 para que dayofweek tenga como valor todo lo que no sea el enumerado ira a el valor 
        -*/
   
        static void Main()
        {
            Console.WriteLine("Introduzca un dia de la semana");
            string dia = Console.ReadLine();
            DayOfWeek dias = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dia, true );
            //El true es por si lo ponen en mayuscula o minuscula lo ignore.
            int numDia = (int)dias;
           /*do
            {
                try
                {
                    string dia = Console.ReadLine();
           dayOfWeek = (DayOfWeek Enum.Parse(typeof(DarOfWeek), dia , true);
                }
                catch
                { }
            } while (dayofweek != DaOfWeek.None);*/
            
            if(numDia <= 5)
            {
                Console.WriteLine("Laboral");
              
            }
            else
            {
                Console.WriteLine("No laboral");
                }



        }
        
    }
}
/* if (dayOfWeek == DayOfWeek.Saturday) || dayofweek == DayOfWeek.sunday);
 * Cosnole.WriteLane ( "No laboral"); */