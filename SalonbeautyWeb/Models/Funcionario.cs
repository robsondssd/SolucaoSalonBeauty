using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class Funcionario
    {
        public int ID { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Comisao { get; set; }
        public DateTime DataDeAdmisao { get; set; }
        public string Cargo { get; set; }
    }
}