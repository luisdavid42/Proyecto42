using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiri
{
    public static class Matematicas
    {
        /// <summary>
        /// Retorna todas las posibles combinaciones de una cadena de caracteres.
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static string Permutacion(String original)
        {
            String resultado = "";



            return resultado;
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        //separados por comas
        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        


        public static int RandomNum()
        {
            return 0;
        }

        public static int RandomString()
        {            //delimitar rango y caracteres permitidos
            return 0;
        }

        

        public static int ContarLineas()
        {
            return 0;
        }

        public static String Contar(int limInf,int limSup)
        {
            return "";
        }
    }
}
