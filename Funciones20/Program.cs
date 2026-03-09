
using System;
class program
{
    static int ContarCaracteres(string texto)
    {
        Console.WriteLine($"El texto tiene: " );
        return texto.Length;
    }

    static void Main()
    {
        Console.WriteLine(ContarCaracteres("Programacion"));

        Console.ReadKey();
    }
}
