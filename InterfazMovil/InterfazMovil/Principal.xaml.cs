using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
//using WiriMovil;

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
            //var Cajita1 = this.FindByName<Editor>("Cajita1");
            //var Cajita2 = this.FindByName<Editor>("Cajita2");


            Cajita2.Text = Wiri.Strings.Alrevesar(Cajita1.Text);
            

        }

        
    }
}
