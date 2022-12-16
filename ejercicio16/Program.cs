class ejercicio16
{
    static void Main()
    {
        Console.WriteLine("Introduzca un numero entero");
        int natural = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca la base");
        int @base = int.Parse(Console.ReadLine());
        // el @ es pa usar palabras que estan reservadas.
        string texto = "";
        string textoAlReves = "";

        if (@base < 2 || @base > 9)
        {
            Console.WriteLine("numero entre 2 y 9");
        }
        else
        {
           /* while (natural / b > 0)
            {
                int i = natural % b;
                texto += i;
                natural /= b;
            }
           */

            for (; natural / @base > 0; natural /= @base)
            {
                int i = natural % @base;
                texto += i;
            }

            int j = natural % @base;
            texto = texto + j;
            // Console.WriteLine(texto);
            for (int x = texto.Length - 1; x >= 0; x--)
            {
                textoAlReves += texto[x];
            }

            Console.WriteLine(textoAlReves);
        }
    }
}
