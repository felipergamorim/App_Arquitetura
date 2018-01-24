using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicativo_Arquitetura.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageTeste2 : ContentPage
	{
		public PageTeste2 ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            StyleId = (string)frame.StyleId;
            if (StyleId == "1")
            {
                Navigation.PushAsync(new Views_PageTeste2.Entorno(),true);
            }
            else if (StyleId == "2")
            {
                Navigation.PushAsync(new Views_PageTeste2.Acesso_e_Estacionamento(),true);
            }
            else if (StyleId == "3")
            {
                Navigation.PushAsync(new Views_PageTeste2.Ambientes(),true);
            }
            else if (StyleId == "4")
            {
                Navigation.PushAsync(new Views_PageTeste2.Circulação(),true);
            }
            else if (StyleId == "5")
            {
                Navigation.PushAsync(new Views_PageTeste2.Informações_e_Sinalização(),true);
            }
        }
    }
}