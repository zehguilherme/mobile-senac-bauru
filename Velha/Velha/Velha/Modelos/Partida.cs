using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Velha.Modelos
{
    public class Partida
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime DataFinal { get; set; }

        public string NomeVencedor { get; set; }
    }
}
