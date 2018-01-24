using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Página_Inicial : ContentPage
    {
        public Página_Inicial()
        {
            InitializeComponent();
        }

        void Nova_Escola(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovaEscola
            {
                BindingContext = new Escola()
            });
        }

        private void Ajuda_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NovaEscola(), true);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            StyleId = (string)frame.StyleId;
            if (StyleId == "1")
            {
                Navigation.PushModalAsync(new PageTeste(), true);
            }
            else if (StyleId == "2")
            {
                Navigation.PushAsync(new Views.PageTeste2(), true);
            }
            else if (StyleId == "3")
            {
                Navigation.PushAsync(new ViewsTodo.ListaEscola(), true);
            }
        }
    }
}