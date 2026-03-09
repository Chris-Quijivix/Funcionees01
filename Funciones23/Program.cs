
using System;
class program
{
    static int SumarDel1AlN(int n)
    {
        int suma = 0;

        for (int i = 1; i < n; i++)
        {
            suma += i;
        }

        return suma;
        
    }

    static void Main()
    {
        Console.WriteLine(SumarDel1AlN(5));
    }
}
