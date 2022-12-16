class Ejercicio
{
    const int SIZE = 10;
    static void Main()
    {
        int[] numbers = new int[SIZE];

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = int.Parse(Console.ReadLine());
        MostrarArray(numbers);
    }

    static void MostrarArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(i + "" + numbers[i]);
        }
    }
    static int CrearArray;
}