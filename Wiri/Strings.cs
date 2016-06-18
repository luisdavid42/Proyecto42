using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wiri
{
    /// <summary>
    /// Estructura representativa de una conversion de caracteres
    /// </summary>
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

        /// <summary>
        /// Elimina un fragmento de texto de otro
        /// </summary>
        /// <param name="original">Cadena original</param>
        /// <param name="aBorrar">Texto a eliminar</param>
        /// <returns>Cadena resultante</returns>
        public static String Borrar(String original, String aBorrar)
        {
            String resultado = "";

            resultado = original.Replace(aBorrar, "");

            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="original"></param>
        /// <param name="aBuscar"></param>
        /// <param name="aReemplazar"></param>
        /// <returns></returns>
        public static String Reemplazar(String original, String aBuscar, String aReemplazar)
        {
            String resultado = "";

            resultado = original.Replace(aBuscar, aReemplazar);

            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="original"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public static String Regex(String original, String regex)
        {
            String resultado = "";

            if (System.Text.RegularExpressions.Regex.IsMatch(original, regex))
            {
                resultado += " - valid";
            }

            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String Mayusculizar(String original)
        {
            return original.ToUpper();
        }

        /// <summary>
        /// Convierte todos los caracteres a letras minúsculas
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String Minusculizar(String original)
        {
            return original.ToLower();
        }

        /// <summary>
        /// Invierte todos los caracteres a letras minusculas
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String InvertirCase(String original)
        {
            String resultado = "";

            for (int i = 0; i < original.Length; i++)
            {
                if (char.IsLower(original[i]))
                    resultado += char.ToUpper(original[i]);
                else if (char.IsUpper(original[i]))
                    resultado += char.ToLower(original[i]);
                else
                    resultado += original[i];
            }

            //resultado = new String(
            //    original.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
            //                      char.ToLower(c) : char.ToUpper(c)) : c).ToArray());


            return resultado;
        }

        /// <summary>
        /// Retorna el string enumerado
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String Enumerar(String original)
        {
            String resultado = "";

            using (StringReader lector = new StringReader(original))
            {
                string linea = string.Empty;
                int cant = 1;
                do
                {
                    linea = lector.ReadLine();
                    if (linea != null)
                    {
                        resultado += cant + ". " + linea + "\r\n";
                    }
                    cant++;
                } while (linea != null);
            }

            return resultado;
        }

        /// <summary>
        /// Retorna el string en formato Montaña Rusa(case alternos)
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String MontanaRusa(String original)
        {
            String resultado = "";

            for (int i = 0; i < original.Length; i++)
            {
                if (i % 2 == 0)
                    resultado+=char.ToLower(original[i]);
                else
                    resultado+=char.ToUpper(original[i]);
            }

            return resultado;
        }

        /// <summary>
        /// Retorna el string en formato Atigereao
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static String Atigerear(String original)
        {
            String resultado = "";


            resultado += original + " nobulto";
            return resultado;
        }

        public static int CantCaracteres()
        {
            return 0;
        }

        public static int CantLineas()
        {
            return 0;
        }


        public static String OrdenarAsc(String original)
        {
            String resultado = "";


            
            return resultado;
        }

        public static String OrdenarDesc(String original)
        {
            String resultado = "";



            return resultado;
        }

        public static String Desordenar(String original)
        {
            String resultado = "";



            return resultado;
        }

        public static int ContarChar()
        {
            return 0;
        }

        public static int ContarChar(char c)
        {
            return 0;
        }

        public static int ContarPalabras()
        {
            return 0;
        }

        public static int ContarPalabras(String s)
        {

            return 0;
        }
    }
}
