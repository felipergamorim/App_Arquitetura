using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Aplicativo_Arquitetura.Views;
using Aplicativo_Arquitetura.Data;
using Aplicativo_Arquitetura.Models;

namespace Aplicativo_Arquitetura
{
    public partial class App : Application
    {
        static DataBase database;

        //public static Escola escola_atual;
        //Implementar qual escola está sendo avaliada -- Conferir todos os comentários

        public App()
        {   
            InitializeComponent();

            //escola_atual = new Escola();

            MainPage = new NavigationPage(new Página_Inicial());
        }

        public static DataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("Banco.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
