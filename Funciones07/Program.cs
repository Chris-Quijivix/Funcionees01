

using System;
class program
{
    static void MostrarDoble(int numero)
    {
        Console.WriteLine("El doble del numero es: " + (numero*2));
    }

    static void Main()
    {
        Console.Write("Ingrese un numero:");
        int numero;
        numero = int.Parse(Console.ReadLine());
        MostrarDoble(numero);

        Console.ReadKey();
    }
}
