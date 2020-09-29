using ListaMvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaMvvm.ViewModel
{
    public class ListaItemViewModel : ViewModel
    {
        private string descricao;
        private ObservableCollection<Item> itens;
        private bool isEnviarParaServidor;
        private bool isAdicionando;
        private bool isNotAdicionando;

        public string Descricao
        {
            get => descricao; set => SetProperty(ref descricao, value);
        }
        public ObservableCollection<Item> Itens 
        {
            get => itens; set => SetProperty(ref itens, value);
        }
        public bool IsEnviarParaServidor
        {
            get => isEnviarParaServidor; set => SetProperty(ref isEnviarParaServidor, value);
        }
        public bool IsAdicionando
        {
            get => isAdicionando;
            set
            {
                SetProperty(ref isAdicionando, value);
                IsNotAdicionando = !IsAdicionando;
            }
        }
        public bool IsNotAdicionando
        {
            get => isNotAdicionando; set => SetProperty(ref isNotAdicionando, value);
        }

        public ICommand InserirCommand { get; set; }

        public ListaItemViewModel()
        {
            InserirCommand = new Command(() => Inserir());

            Itens = new ObservableCollection<Item>();
            IsEnviarParaServidor = Itens.Count > 0;
            IsAdicionando = false;
        }

        public void Inserir()
        {
            if (this.Descricao == "") return;

            Item item = new Item();
            item.Descricao = this.Descricao;

            Itens.Add(item);
            IsEnviarParaServidor = Itens.Count > 0;

            this.Descricao = "";
            IsAdicionando = false;
        }

        public void Remover(Item item)
        {
            this.itens.Remove(item);
            IsEnviarParaServidor = Itens.Count > 0;
        }
    }
}
