

using System;
class program
{
    static void SumarMostrar(int a, int b)
    {
        Console.WriteLine("La suma total es: " + (a+b));
    }

    static void Main()
    {
        Console.Write("Ingres el primer numero: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        int b = int.Parse(Console.ReadLine());

        SumarMostrar(a, b);
    }
}

