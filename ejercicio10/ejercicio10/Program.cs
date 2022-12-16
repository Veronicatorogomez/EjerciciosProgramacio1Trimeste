using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("introduzca un numero entero");
        //separemos las variables
        int a;
        
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
        {   
            if (i % 2 == 0 && i % 3 == 0) 
            {
                Console.WriteLine(i);
            }
        }
    }
}




