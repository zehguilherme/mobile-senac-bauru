using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("Clientes")]
    public class Cliente
    {
        private Endereco endereco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(15)]
        public String Nome { get; set; }

        public int EnderecoId { get; set; }

        [Ignore]
        public Endereco Endereco
        { 
            get => endereco;

            set
            {
                endereco = value;
                this.EnderecoId = value.Id;
            }
        }

        [MaxLength(14)]
        public String Cpf { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
