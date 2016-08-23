using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class NotaFiscal
    {
        public int ID { get; set; }
        public int Numero { get; set; }
        public int NumeroDaEncomenda { get; set; }
        public DateTime DataDaEncomenda { get; set; }
        public string Situcao { get; set; }
    }
}