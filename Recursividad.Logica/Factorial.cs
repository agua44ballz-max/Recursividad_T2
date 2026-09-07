using System;
using System.Collections.Generic;
using System.Text;


namespace Recursividad.Logica
{
    public class Factorial
    {

        public int MiFactorial(int numero)
        {
            // CASO BASE: Si el número llega a 1 o 0, se detiene la recursión y devuelve 1
            if (numero <= 1)
            {
                return 1;
            }


            //Caso general
            return numero = numero * MiFactorial(numero - 1);

        }

    }
}
