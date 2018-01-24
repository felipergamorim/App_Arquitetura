using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura.ViewsTodo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaEscola : ContentPage
    {
        public ListaEscola()
        {
            InitializeComponent();

            Lista.ItemsSource = App.Database.db.Table<Escola>().ToList();
        }
    }
}