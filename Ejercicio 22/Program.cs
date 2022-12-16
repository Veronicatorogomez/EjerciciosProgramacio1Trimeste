using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Ejercicio
{
    class Program
    {
        enum Luz { On = 1, Off }
        static void Main()
        {
            Console.WriteLine("La luz esta apagada");
            Luz state = Luz.Off;
            while (true)
            {
                string estado = Console.ReadLine();
                Luz light = (Luz)Enum.Parse(typeof(Luz), estado, true);
                int numLuz = (int)light;
                if (light == Luz.On && state == Luz.Off)
                {
                    state = Luz.On;
                    Console.WriteLine("esta encendida");
                }
                else if (light == Luz.Off && state == Luz.On )
                {
                    state = Luz.Off;
                    Console.WriteLine("esta apagada");
                }
                else
                {
                    throw new Exception("ya estaba en ese estado cruck");
                }
            }
        }
    }
}