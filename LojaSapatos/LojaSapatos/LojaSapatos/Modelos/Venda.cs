using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("Vendas")]
    public class Venda
    {
        private Loja loja;
        private Cliente cliente;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int LojaId { get; set; }

        [Ignore]
        public Loja Loja
        {
            get => loja;

            set
            {
                loja = value;
                this.LojaId = Id;
            }
        }

        public int ClienteId { get; set; }

        [Ignore]
        public Cliente Cliente 
        { 
            get => cliente;

            set
            {
                cliente = value;
                this.ClienteId = value.Id;
            }
        }


        public DateTime Data { get; set; }

        [MaxLength(50)]
        public String FormaPagamento { get; set; }
    }
}
