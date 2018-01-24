using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaPessoa1 : ContentPage
    {
        public NovaPessoa1()
        {
            InitializeComponent();
        }

        public NovaPessoa1(Pessoa pessoa)
        {
            InitializeComponent();

            BindingContext = pessoa;
        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            // Botão voltar para página inicial
            Navigation.PopAsync();
        }
    }
}