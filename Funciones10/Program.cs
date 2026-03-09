

using System;
class program
{
    static void ImprimirRepetido(string texto,int cantidad)
    {
        for (int i =0; i < cantidad; i++)
        {
            Console.WriteLine(texto);
        }
    }

    static void Main ()
    {
        Console.Write("Ingrese el texto a mostrar: ");
        string texto = Console.ReadLine();

        Console.Write("Cuantas veces se repetira el texto?: ");
        int cantidad = int.Parse(Console.ReadLine());
        Console.WriteLine();

        ImprimirRepetido(texto, cantidad);

        Console.ReadKey();
    }
}
