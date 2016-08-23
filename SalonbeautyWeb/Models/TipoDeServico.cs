using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class TipoDeServico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int TempoDeDuracao { get; set; }
        public string Descricao { get; set; }
    }
}