using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    [Table("Produtos")]
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public String Nome { get; set; }

        public Double Preco { get; set; }

        [MaxLength(10)]
        public String Categoria { get; set; }

        [MaxLength(50)]
        public String Fabricante { get; set; }

        public int Estoque { get; set; }

        [MaxLength(10)]
        public String Cor { get; set; }

        [MaxLength(10)]
        public String Tamanho { get; set; }

        [MaxLength(200)]
        public String Imagem { get; set; }
    }
}
