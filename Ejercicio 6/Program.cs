namespace Ejercicio_6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce tu edad:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else
            {
                Console.WriteLine(age < 18 ? "Menor de edad" : "Activo");
            }
            Console.ReadLine();
        }
    }
}