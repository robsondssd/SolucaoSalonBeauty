using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class Fatura
    {
        public int ID { get; set; }
        public int Situcao { get; set; }
        public double Valor { get; set; }
        public string FormaDePagameto { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public DateTime DataDePagamento { get; set; }
                
    }
}