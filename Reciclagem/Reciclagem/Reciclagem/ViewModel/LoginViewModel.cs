using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Reciclagem.ViewModel
{
    public class LoginViewModel : BindableObject
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public string ErrorMessage { get; set; }
        public bool IsError { get; set; }

        public LoginViewModel()
        {
            IsError = false;
        }

        public void Entrar()
        {
            IsError = false;
            OnPropertyChanged("IsError");

            if(Email != "teste" || Senha != "123")
            {
                ErrorMessage = "Usuário ou senha inválidos";
                OnPropertyChanged("ErrorMessage");
                IsError = true;
                OnPropertyChanged("IsError");
            }
        }
    }
}
