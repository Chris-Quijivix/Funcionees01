using System;
class program
{
    static void EsPositivo(int numero)
    {
        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else if (numero < 0) 
        {
            Console.WriteLine("El numero no es positivo");
        }
        else
        {
            Console.WriteLine("El numero es cero");
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        EsPositivo(numero);

        Console.ReadKey();
    }
}
