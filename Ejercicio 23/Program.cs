namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el dividendo");
                int dividendo = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el divisor");
                int divisor = int.Parse(Console.ReadLine());

                int cociente = dividendo / divisor;

                Console.WriteLine("El cociente es: {0}", cociente);
            }
            catch (Exception o)
            {
                Console.WriteLine("Se ha generado un error: {0}", o);
            }
        }
    }
}