
using System;
class program
{
    static string Repetir(String texto, int veces)
    {
        string mostrar = "";

        for (int i = 0; i < veces; i++)
        {
            mostrar += texto;
        }

        return mostrar;
    }

    static void Main()
    {
        Console.WriteLine(Repetir("Programacion ", 3));

        Console.ReadKey();
    }
}