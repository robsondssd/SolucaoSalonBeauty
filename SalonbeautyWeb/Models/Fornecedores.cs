using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class Fornecedores
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Cep { get; set; }
        public string Email { get; set; }
        public int Cnpj { get; set; }
        public int Telefone { get; set; }
    }
}