
using System;
class program
{
    static void EsPrimo(int n)
    {
        int divisor = 0;

        for (int i = 2; i < n; i++)
        {
            if ( n % i  == 0 )
            {
                divisor++;
            }
        }

        if  ( divisor == 0 )
        {
            Console.WriteLine("Es numero primo ");
        }
        else
        {
            Console.WriteLine("No es mnumero primo");
        }


    }

    static void Main ()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse( Console.ReadLine() );
        Console.WriteLine();
        EsPrimo(n);

        Console.ReadKey();
    }

}
