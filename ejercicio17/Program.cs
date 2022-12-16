using System;
class ejercicio17
{
    static void Main()
    {
        Console.WriteLine("introduzca un texto");
        string texto = (Console.ReadLine());
        texto = texto.ToUpper();
        string leido = "";

        for (int i = 0; i < texto.Length; i++)
        {
            int frecuencialetra = 0;
            string resultado = "";
            char letra = texto[i];
            if (leido.Contains(letra))
            {
            }
            else
            {
                leido += letra;
                //texto.Contains(letra);
                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto[j] == letra)
                    {
                        frecuencialetra++;

                    }
                }

                resultado = texto[i] + frecuencialetra.ToString();
                Console.WriteLine(resultado);





            }
        }
    }
}