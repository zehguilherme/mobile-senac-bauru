using System;
using System.Collections.Generic;
using System.Text;

namespace LojaSapatos.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Endereco Endereco { get; set; }
        public String Cpf { get; set; }
    }
}
