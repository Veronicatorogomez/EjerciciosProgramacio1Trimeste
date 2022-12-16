namespace ejercicios;
   class Programa
{
    static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        double media = 0;
        int a = int.Parse(Console.ReadLine());
        
    for(int i= 0; i < a; i++)
        {
            media += double.Parse(Console.ReadLine());   
            
        }
        double result = media / a;
        Console.WriteLine($"La media es igual {result}");
    }
}
