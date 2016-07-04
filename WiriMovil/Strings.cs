using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiriMovil
{
    public static class Strings
    {
        /// <summary>
        /// Pone una cadena de caracteres alreves
        /// </summary>
        /// <param name="cadena">Cadena a alrevesar</param>
        /// <returns>Cadena Alrevesada</returns>
        public static String Alrevesar(String cadena)
        {
            String resultado = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                resultado += cadena[cadena.Length - i - 1];
            }


            return resultado;
        }

    }
}
