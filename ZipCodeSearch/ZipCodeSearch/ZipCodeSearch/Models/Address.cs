using System;
using System.Collections.Generic;
using System.Text;

namespace ZipCodeSearch.Models
{
    public class Address
    {
        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string Uf { get; set; }
    }
}
