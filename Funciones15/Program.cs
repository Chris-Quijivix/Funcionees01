
using System;
class program
{
    static void EsPar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero ingresado es par");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("El numero ingresado no es par");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un numero:");
        int numero = int.Parse(Console.ReadLine());
        EsPar(numero);

        Console.ReadKey();
    }
}
