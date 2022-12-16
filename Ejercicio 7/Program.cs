Console.WriteLine("Introduce los tres lados del triángulo:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a == b && b == c)
{
    Console.WriteLine("Triángulo equilátero. Todos iguales");
}
else if (a != b && a != c && b != c)
{
    Console.WriteLine("Triángulo escaleno. Ninguno igual");
}
else
{
    Console.WriteLine("Triángulo isósceles. Dos iguales");
}

Console.WriteLine("\nPulsa enter para cerrar");
Console.ReadLine();
