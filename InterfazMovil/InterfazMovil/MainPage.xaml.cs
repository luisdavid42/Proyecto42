using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace InterfazMovil
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        public void OnButtonClicked(object sender, EventArgs args)
        {
            //count++;

            //((Button)sender).Text =
            //    String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
        }
    }
}
