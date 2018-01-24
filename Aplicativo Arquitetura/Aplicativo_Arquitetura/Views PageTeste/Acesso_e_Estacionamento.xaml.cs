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
	public partial class Acesso_e_Estacionamento : ContentPage
	{
        int clicked;
		public Acesso_e_Estacionamento ()
		{
			InitializeComponent ();
		}

        private void Teste_Clicked(object sender, EventArgs e)
        {
            clicked += 1;
            if (clicked % 2 == 0)
            {
                Equipamentos.IsVisible = true;
                Rotas.IsVisible = true;
            }
            else
            {
                Equipamentos.IsVisible = false;
                Rotas.IsVisible = false;
            }
        }

    }
}