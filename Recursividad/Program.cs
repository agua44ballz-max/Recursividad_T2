using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursividad.Logica;

namespace Recursividad.UI.Consola
{
    /// <summary>
    /// Entry point for the console UI that demonstrates recursive algorithms.
    /// </summary>
    /// <remarks>
    /// This class is intentionally minimal: it writes introductory text to the console,
    /// creates an instance of the recursive algorithm class <see cref="Factorial"/>, 
    /// and waits for a key press. The actual demonstration logic (such as calling methods
    /// on the <see cref="Factorial"/> instance) should be implemented in the <see cref="Recursividad.Logica"/>
    /// layer or added here as needed.
    /// </remarks>
    internal class Program
    {
        /// <summary>
        /// Program entry method for the console application.
        /// </summary>
        /// <param name="args">Command-line arguments passed to the application. Currently unused.</param>
        /// <remarks>
        /// The method:
        /// - Prints headings to the console to indicate available recursion cases.
        /// - Instantiates <see cref="Factorial"/> from the logic layer to prepare for demonstrations.
        /// - Pauses execution with <see cref="Console.ReadKey"/> so the user can view output.
        /// </remarks>
        static void Main(string[] args)
        {
            Console.WriteLine("\nCasos de recursividad: ");
            Console.WriteLine("\nCaso 1 Factorial");

            // Instantiate the Factorial demonstration class from the logic layer.
            // Add calls to methods on 'oFactorial' here to perform demonstrations (e.g., calculate and print factorials).
            Factorial oFactorial = new Factorial();

            // Pause so the user can see the console output before the application exits.
            Console.ReadKey();
        }
    }
}
