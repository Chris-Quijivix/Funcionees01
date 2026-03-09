
using System;
class program
{
    static void EsMultiplo(int a, int b)
    {
        if (a %  b == 0)
        {
            Console.WriteLine($" {a} Es multiplo de :" + b);
        }
        else
        {
            Console.WriteLine($" {a} No es multiplo de : " + b);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        int a = int.Parse( Console.ReadLine() );
        Console.WriteLine();

        Console.Write("Ingrese el segundo numero: ");
        int b = int.Parse( Console.ReadLine() );    
        Console.WriteLine();

        EsMultiplo(a, b);

        Console.ReadKey();
    }
}
