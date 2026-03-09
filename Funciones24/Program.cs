
using System;
class program
{
    static int Factorial(int n)
    {
        int resultado = 1;

        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;

    }

    static void Main()
    {
        Console.WriteLine("El factorial del numero (5) es: ");
        Console.WriteLine(Factorial(5));

        Console.ReadKey();
    }
}