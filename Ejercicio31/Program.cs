using System;
using System.Diagnostics.CodeAnalysis;

class Ejercicio
{
    static void Main(string[] args)
    {
        int[] numbers = new int[100];
        int suma = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }
        foreach (int num in numbers)
        {
            suma += num;
        }
        /* for (int i = 0; i < numbers.Length; i++)
        {
            suma+= numbers[i]; */
        Console.WriteLine("media" + suma / numbers.Length);
    }
}