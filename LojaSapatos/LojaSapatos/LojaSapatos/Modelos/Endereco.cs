using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("Enderecos")]
    public class Endereco
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public String Logradouro { get; set; }

        [MaxLength(100)]
        public String Bairro { get; set; }

        [MaxLength(50)]
        public String Cidade { get; set; }

        [MaxLength(2)]
        public String Estado { get; set; }

        [MaxLength(8)]
        public String Cep { get; set; }

        [MaxLength(5)]
        public String Numero { get; set; }
    }
}
