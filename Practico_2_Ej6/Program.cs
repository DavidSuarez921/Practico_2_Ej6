using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra (desde a hasta f) para saber cuál es la siguiente letra del abecedario");
            string letra = Console.ReadLine().ToLower();

            char siguienteLetra = ObtenerSiguienteLetra(letra);
            Console.WriteLine($"La siguiente letra del abecedario es la '{siguienteLetra}'");
        }

        static char ObtenerSiguienteLetra(string letra)
        {
            switch (letra)
            {
                case "a":
                    return 'b';
                case "b":
                    return 'c';
                case "c":
                    return 'd';
                case "d":
                    return 'e';
                case "e":
                    return 'f';
                case "f":
                    return 'g';
                default:
                    throw new ArgumentOutOfRangeException("La letra ingresada está fuera del rango esperado (a - f).");
            }
        }
    }
}


