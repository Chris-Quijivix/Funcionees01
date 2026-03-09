
using System;
class program
{
    static int MenorDeTres(int a, int b, int c)
    {
        int menor;

        if (a < b && a <  c)
        {
            menor = a;
        }
        else if(b < c && b < a)
        {
            menor = b;
        }
        else
        {
            menor = c;
        }

        return menor;

    }

    static void Main()
    {
        Console.WriteLine($"El numero menor entre 5,6,1 es:" + MenorDeTres(5, 6, 1));

        Console.ReadKey();
    }
}
