using FilmeMania.Data;
using FilmeMania.Models;
using FilmeMania.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FilmeMania
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private OMDbRest rest = new OMDbRest();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Movie movie = await rest.GetMovieAsync(TitleEntry.Text);

            if (movie != null)
            {
                var page = new MoviePage();
                page.BindingContext = movie;
                await Navigation.PushAsync(page);
            }
        }
    }
}
