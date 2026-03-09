
using System;
class program
{
    static int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        Console.WriteLine($"El numero mayor entre 5 y 10 es: "+ Mayor(5, 10));

        Console.ReadKey();
    }
}
