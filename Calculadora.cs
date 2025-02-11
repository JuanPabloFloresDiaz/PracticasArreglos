using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPotenciación
{
    /// <summary>
    /// Clase que realiza operaciones matemáticas.
    /// </summary>
    class Calculadora
    {
        public static double ElevarPotencia(double baseNumero, double exponente)
        {
            return Math.Pow(baseNumero, exponente);
        }

        public static double ElevarPotenciaSinMath(double baseNumero, int exponente)
        {
            if (exponente == 0) return 1;

            double resultado = 1;
            bool esExponenteNegativo = exponente < 0;
            int exp = Math.Abs(exponente);

            for (int i = 0; i < exp; i++)
            {
                resultado *= baseNumero;
            }

            return esExponenteNegativo ? 1 / resultado : resultado;
        }
    }
}
