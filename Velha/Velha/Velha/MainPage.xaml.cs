using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Velha
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Jogo Jogo;
        public MainPage()
        {
            InitializeComponent();
            Jogo = new Jogo();
            this.Mensagem.Text = Jogo.JogadorAtual == Jogador.X ? "Jogador X" : "Jogador O";
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var btn = sender as ImageButton;

            var jogador = Jogo.JogadorAtual;
            try
            {
                Jogo.Jogada(Grid.GetRow(btn), Grid.GetColumn(btn));
                btn.Source = jogador == Jogador.X ? "xis.png" : "bola.png";

                var vencedor = Jogo.Vencedor();

                if (vencedor != Jogador.NENHUM)
                {
                    await DisplayAlert("Vencedor", vencedor == Jogador.X ? "Jogador X" : "Jogador O", "Fechar");
                    Jogo.ZerarTabuleiro();
                    ZerarImagens();
                }

                this.Mensagem.Text = Jogo.JogadorAtual == Jogador.X ? "Jogador X" : "Jogador O";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Fechar");
            }
        }

        private void ZerarImagens()
        {
            
            foreach (var btn in Grid.Children)
            {
                if (btn is ImageButton)
                    (btn as ImageButton).Source = "vazio.png";
            }
        }

    }
}
