using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSOAP.DTO
{
    public class Paragem
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Motivo { get; set; }
        public string WorkCenter { get; set; }
        public int Turno { get; set; }
        public string Referencia { get; set; }
        public string Duracao { get; set; }
        public string Ordem { get; set; }
    }
}