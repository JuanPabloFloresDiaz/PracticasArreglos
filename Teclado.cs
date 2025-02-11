using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPotenciación
{
    internal class Teclado
    {
        public static double LeerDouble()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo:");
            }
            return numero;
        }

        public static int LeerInt()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo:");
            }
            return numero;
        }

        public static string LeerTexto()
        {
            string texto;
            do
            {
                texto = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(texto))
                {
                    Console.WriteLine("El nombre no puede estar vacío. Intente de nuevo:");
                }
            } while (string.IsNullOrEmpty(texto));

            return texto;
        }
    }
}
