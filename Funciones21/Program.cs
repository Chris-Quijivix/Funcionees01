
using System;
class program
{
    static int ContarVocales(string texto)
    {
        int contador = 0;

        foreach (char c in texto.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }

    static void Main()
    {
        Console.WriteLine("El texto tiene");
        Console.WriteLine(ContarVocales("Programacion"));
        Console.WriteLine("Vocales");

        Console.ReadKey();
    }
}
