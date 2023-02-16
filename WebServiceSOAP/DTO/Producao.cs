using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceSOAP.DTO
{
    public class Producao
    {
        public string WorkCenter { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Objetivo { get; set; }
        public int Turno { get; set; }
        public string Ordem { get; set; }
        public Produto _Produto { get; set; }
    }
}