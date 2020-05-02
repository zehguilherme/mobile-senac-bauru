using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("VendaItems")]
    public class VendaItem
    {
        private Produto produto;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int ProdutoID { get; set; }

        [Ignore]
        public Produto Produto 
        {
            get => produto;

            set
            { 
                produto = value;
                this.ProdutoID = value.Id;
            }
        }

        public int Quantidade { get; set; }

        public Double Preco { get; set; }
    }
}
