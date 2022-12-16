Console.WriteLine("Introduce tu estado civil:");
string input = Console.ReadLine();
char state = input[0];

string result;

switch (state)
{
    case 'C':
        result = "Casado";
        break;

    case 'S':
        result = "Soltero";
        break;

    case 'V':
        result = "Viudo";
        break;

    case 'D':
        result = "Divorciado";
        break;

    default:
        result = "Estado no existe";
        break;
}

// Otra alternativa
/*
result = state switch
{
    'C' => "Casado",
    'S' => "Soltero",
    'V' => "Viudo",
    'D' => "Divorciado",
    _ => "Estado no existe"
};
*/


Console.WriteLine($"Tu estado civil es: {result}");

Console.WriteLine("\nPulsa enter para cerrar");
Console.ReadLine();
