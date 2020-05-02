using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("Lojas")]
    public class Loja
    {
        private Endereco endereco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(14)]
        public String Cnpj { get; set; }

        [MaxLength(20)]
        public String Nome { get; set; }

        public int EnderecoID { get; set; }

        [Ignore]
        public Endereco Endereco 
        {
            get => endereco;
            set
            {
                endereco = value;
                this.EnderecoID = value.Id;
            }
        }
    }
}
