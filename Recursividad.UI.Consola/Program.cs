using System;
using Recursividad.Logica;

namespace Recursividad.UI.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Casos de recursividad");
            Console.WriteLine("\n Casos 1 Factorial");

            Factorial oFactorial = new Factorial();
            int numero = 5;
            int resultado = oFactorial.MiFactorial(numero);

            Console.WriteLine($"EL factorial de {numero} es: {resultado}");

            Console.ReadKey();
        }
    }
}