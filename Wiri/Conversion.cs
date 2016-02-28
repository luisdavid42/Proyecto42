using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiri
{
    /// <summary>
    /// Estructura representativa de una conversion de caracteres
    /// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Pone una cadena de caracteres alreves
        /// </summary>
        /// <param name="cadena">Cadena a alrevesar</param>
        /// <returns>Cadena Alrevesada</returns>
        public static String Alrevesar(String cadena)
        {
            String resultado="";
            for(int i=0;i<cadena.Length;i++)
            {
                resultado+= cadena[cadena.Length - i - 1];
            }


            return resultado;
        }

        /// <summary>
        /// Elimina un fragmento de texto de otro
        /// </summary>
        /// <param name="original">Cadena original</param>
        /// <param name="aBorrar">Texto a eliminar</param>
        /// <returns>Cadena resultante</returns>
        public static String Borrar(String original, String aBorrar)
        {
            String resultado = "";

            int j = 0;//para recorrer el resultado
            for (int i = 0; i < original.Length; i++)
            {
                if(original[i]!=aBorrar[0])
                {
                    resultado += original[i];
                        j++;
                }
            }

            return resultado;
        }
    }
}
