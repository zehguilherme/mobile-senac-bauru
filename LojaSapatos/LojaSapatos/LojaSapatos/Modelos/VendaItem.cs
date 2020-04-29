using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    public class VendaItem
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Double Preco { get; set; }
    }
}
