using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public float PrecoDeVenda { get; set; }
        public int QtdMinima { get; set; }
        public int QtdAtual { get; set; }
    }
}