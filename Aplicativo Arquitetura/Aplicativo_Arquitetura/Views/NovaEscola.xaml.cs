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
    public partial class NovaEscola : ContentPage
    {
        public NovaEscola()
        {
            InitializeComponent();
        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)BindingContext;
            App.Database.db.Insert(pessoa);
            // Botão voltar para página inicial
            Navigation.PushModalAsync(new NavigationPage(new Página_Inicial()));
            //App.Database.db.QueryAsync<Pessoa>("SELECT * FROM [Pessoa] WHERE [Id] = 1");
            //Cria uma lista de pessoas cm Id = 1
        }
    }
}