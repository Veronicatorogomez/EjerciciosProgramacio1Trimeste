class Program
{
    static void Main()
    {
        Console.WriteLine("Introduzca un número");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine((num % 2) == 0 ? "Par" : "Impar");
    }
}