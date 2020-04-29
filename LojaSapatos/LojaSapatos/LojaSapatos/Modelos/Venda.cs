using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    public class Venda
    {
        public int Id { get; set; }
        public Loja Loja { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public String FormaPagamento { get; set; }
    }
}
