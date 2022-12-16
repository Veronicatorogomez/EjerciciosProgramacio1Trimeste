namespace Ejercicio38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.WriteLine(numbers[i] = random.Next());
            }
        }
    }
}