using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazMovil.Droid;
using Xamarin.Forms;

namespace InterfazMovil
{
	public partial class Principal : ContentPage
	{
		public Principal()
		{
			InitializeComponent();
		}

        public void OnButtonClicked(object sender, EventArgs args)
        {
            //var cajita1 = this.FindByName<Editor>("Cajita1");
            Cajita2.Text = Alrevesar(Cajita1.Text);

            
        }

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
