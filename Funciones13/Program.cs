
using System;
class program
{
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        Console.WriteLine($"La multiplicacion de 5*5 es: " + Multiplicar(5,5));

        Console.ReadKey();
    }
}
