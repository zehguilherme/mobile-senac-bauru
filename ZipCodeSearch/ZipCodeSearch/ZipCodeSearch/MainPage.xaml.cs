using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZipCodeSearch.Data;
using ZipCodeSearch.Models;

namespace ZipCodeSearch
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ViaCepREST rest = new ViaCepREST();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void SearchByZipCode(object sender, EventArgs e)
        {
            Address address = await rest.GetZipCodeAsync(ZipCodeEntry.Text);

            if (address != null)
            {
                PublicPlaceEntry.Text = address.Logradouro;
                ComplementEntry.Text = address.Complemento;
                NeighborhoodEntry.Text = address.Bairro;
                LocalityEntry.Text = address.Localidade;
                UfEntry.Text = address.Uf;
            }
        }
    }
}
