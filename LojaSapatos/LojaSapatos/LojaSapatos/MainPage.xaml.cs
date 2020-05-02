using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using SQLite;
using LojaSapatos.Modelos;
using LojaSapatos.Servicos;

namespace LojaSapatos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Pegar a conexão com o banco local
            var db = DB.getConnection();

            //Consultando todos os registros de cliente
            var clientes = from c in db.Table<Cliente>()
                           select c;

            //Atribuição da consulta no banco para a origem dos item da lista de clientes
            ClientesList.ItemsSource = clientes;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = NomeCliente.Text;  //nome do input é atribuido ao objeto nome de cliente

            var db = DB.getConnection();  //busca a conexão

            db.Insert(cliente); //insere o cliente

            NomeCliente.Text = "";

            /************************************Atualização dos clientes**********************************/

            //Consultando todos os registros de cliente
            var clientes = from c in db.Table<Cliente>()
                           select c;

            //Atribuição da consulta no banco para a origem dos item da lista de clientes
            ClientesList.ItemsSource = clientes;
        }
    }
}
