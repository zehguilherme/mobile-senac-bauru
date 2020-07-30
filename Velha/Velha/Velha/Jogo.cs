using System;
using System.Collections.Generic;
using System.Text;

namespace Velha
{

    public enum Jogador
    {
        NENHUM,
        X,
        O
    }

    public class Jogo
    {
        private Jogador[,] tabuleiro = new Jogador[3,3];

        public Jogo()
        {
            ZerarTabuleiro();
            JogadorAtual = Jogador.O;
        }

        public Jogador JogadorAtual { get; set; }

        public void Jogada(int linha, int coluna)
        {
            if (tabuleiro[linha, coluna] != Jogador.NENHUM)
                throw new Exception("Jogada inválida");

            tabuleiro[linha, coluna] = JogadorAtual;
            JogadorAtual = JogadorAtual == Jogador.O ? Jogador.X : Jogador.O;
        }

        public Jogador Vencedor()
        {
            int totX, totO;

            // Verificando as linhas
            for (int l = 0; l < 3; l++)
            {
                totX = 0;
                totO = 0;

                for (int c = 0; c < 3; c++)
                {
                    totX += tabuleiro[l, c] == Jogador.X ? 1 : 0;
                    totO += tabuleiro[l, c] == Jogador.O ? 1 : 0;
                }

                if (totX > 2)
                    return Jogador.X;

                if (totO > 2)
                    return Jogador.O;
            }


            //Verificando as Colunas
            for (int c = 0; c < 3; c++)
            {
                totX = 0;
                totO = 0;

                for (int l = 0; l < 3; l++)
                {
                    totX += tabuleiro[l, c] == Jogador.X ? 1 : 0;
                    totO += tabuleiro[l, c] == Jogador.O ? 1 : 0;
                }

                if (totX > 2)
                    return Jogador.X;

                if (totO > 2)
                    return Jogador.O;
            }

            //Diagonais Principal
            totX = 0;
            totO = 0;
            for (int l=0, c=0; l < 3; l++,c++)
            {
                totX += tabuleiro[l, c] == Jogador.X ? 1 : 0;
                totO += tabuleiro[l, c] == Jogador.O ? 1 : 0;
            }

            if (totX > 2)
                return Jogador.X;

            if (totO > 2)
                return Jogador.O;

            //Diagonais Secundária
            totX = 0;
            totO = 0;
            for (int l = 0, c = 2; l < 3; l++,c--)
            {
                totX += tabuleiro[l, c] == Jogador.X ? 1 : 0;
                totO += tabuleiro[l, c] == Jogador.O ? 1 : 0;
            }

            if (totX > 2)
                return Jogador.X;

            if (totO > 2)
                return Jogador.O;


            return Jogador.NENHUM;
        }

        public bool Finalizado()
        {
            for (int l = 0; l < 3; l++)
                for (int c = 0; c < 3; c++)
                    if (tabuleiro[l, c] == Jogador.NENHUM)
                        return false;

            return true;
        }

        public void ZerarTabuleiro()
        {
            for (int l=0; l < 3; l++)
                for (int c = 0; c < 3; c++)
                    tabuleiro[l, c] = Jogador.NENHUM;
        }
    }
}
