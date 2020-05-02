using LojaSapatos.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LojaSapatos.Servicos
{
    public class DB
    {
        private static SQLiteConnection conexao;

        //Pega a conexao
        public static SQLiteConnection getConnection()
        {
            //Se a conexão não tiver sido criada
            if(conexao == null)
            {
                //salva em dbPath o caminho da pasta especial do usuário do aparelho onde será criado o banco de dados local
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    "loja.db3");

                //conecta o banco com o arquivo do caminho especificado anteriormente
                DB.conexao = new SQLiteConnection(dbPath);

                //Criação de tabelas - gera os comandos SQL
                DB.conexao.CreateTable<Cliente>();
                DB.conexao.CreateTable<Loja>();
                DB.conexao.CreateTable<Venda>();
                DB.conexao.CreateTable<Endereco>();
                DB.conexao.CreateTable<VendaItem>();
                DB.conexao.CreateTable<Produto>();
            }

            return conexao;
        }
    }
}
