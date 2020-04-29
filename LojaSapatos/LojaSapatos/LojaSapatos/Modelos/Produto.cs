using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Double Preco { get; set; }
        public String Categoria { get; set; }
        public String Fabricante { get; set; }
        public int Estoque { get; set; }
        public String Cor { get; set; }
        public String Tamanho { get; set; }
        public String Imagem { get; set; }
    }
}
