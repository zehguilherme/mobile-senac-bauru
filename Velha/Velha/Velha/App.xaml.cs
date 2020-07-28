using System;
using System.IO;
using Velha.Serviços;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Velha
{
    public partial class App : Application
    {
        static DB database;

        public static DB Database
        {
            get
            {
                if(database == null)
                {
                    database = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Jogadas.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
