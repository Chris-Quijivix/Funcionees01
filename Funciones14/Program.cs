
using System;
class program
{
    static double Dividir(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine($"La division de 5/5 es:" + Dividir(5, 5));

        Console.ReadKey();
    }
}