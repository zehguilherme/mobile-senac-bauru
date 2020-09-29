using Reciclagem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reciclagem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private LoginViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent();

            //Indica a tela ao qual o dados estão sendo consultados
            BindingContext = new LoginViewModel();
            BindingContext = viewModel;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        }

        private void Entrar(object sender, EventArgs e)
        {
            viewModel.Entrar();
        }
    }
}