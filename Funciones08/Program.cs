

using System;
class program
{
    static void MostrarCuadrado(int numero)
    {
        Console.Write("El cuadrado del numero es: " + (numero * numero));
    }

    static void Main()
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero;
        numero = int.Parse(Console.ReadLine());
        MostrarCuadrado(numero);

        Console.ReadKey();
    }
}
