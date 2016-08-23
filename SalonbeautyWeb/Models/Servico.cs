using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalonbeautyWeb.Models
{
    public class Servico
    {
        public int ID { get; set; }
        public DateTime DatMarcada { get; set; }
        public DateTime DatSolicitacao { get; set; }
        public string Situacao { get; set; }
        public string Horario { get; set; }

    }
}