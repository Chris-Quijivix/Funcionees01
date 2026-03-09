

using System;
class program
{
    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre);
    }

    static void Main()
    {
        Console.Write("Ingrese un nombre:");
        string nombre;
        nombre = Console.ReadLine();
        Saludar(nombre);
    }
}
