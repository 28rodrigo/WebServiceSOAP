using System;

namespace WebServiceSOAP.DTO
{
    public class Produto
    {
        public string Referencia { get; set; }
        public string Nome { get; set; }
        public TimeSpan Cyclo { get; set; }
    }
}