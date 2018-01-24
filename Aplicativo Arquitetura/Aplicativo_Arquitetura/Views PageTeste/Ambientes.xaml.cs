using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo_Arquitetura.Views_PageTeste
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ambientes : ContentPage
	{
        int clicked;
		public Ambientes ()
		{
			InitializeComponent ();
		}

        private void Teste_Clicked(object sender, EventArgs e)
        {
            clicked += 1;
            if (clicked % 2 == 0)
            {

            }
            else
            {
            }
        }
    }
}