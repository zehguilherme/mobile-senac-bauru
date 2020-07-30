using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Velha.Listagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaVencedor : ContentPage
    {
        public ListaVencedor()
        {
            InitializeComponent();
        }

        //Executado quando aparece a tela do ListView
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //lista do banco todos os itens para o ListView
            Vencedores.ItemsSource = await App.Database.GetPartidasAsync();
        }
    }
}