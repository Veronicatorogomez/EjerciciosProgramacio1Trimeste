using system;
namespace Ejercicio27
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(result);
        }
        static int Fibonacci(int x)
        {
            int result;
            if (x<= 1)
            {
                result = x;
            }
            else
            {
                result = Fibonacci(x - 1) + Fibonacci(x - 2);
            }
            return result;
        }
    }
}