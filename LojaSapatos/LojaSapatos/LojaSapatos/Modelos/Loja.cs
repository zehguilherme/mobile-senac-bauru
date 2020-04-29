using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    public class Loja
    {
        public int Id { get; set; }
        public String Cnpj { get; set; }
        public String Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
