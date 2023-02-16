using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceSOAP.DTO;

namespace WebServiceSOAP
{
    /// <summary>
    /// Summary description for ContiMethods
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ContiMethods : System.Web.Services.WebService
    {

        [WebMethod]
        public List<DTO.Producao> Plano_de_Producao(string WorkCenter,string date)
        {

            return new List<Producao>()
            {
                new Producao(){Start = new DateTime(2023, 02, 15, 06, 15, 00), End = new DateTime(2023, 02, 15, 06, 30, 00),Objetivo="130",Ordem="123",Turno=1,WorkCenter="1",_Produto= new Produto(){Cyclo=new TimeSpan(00,00,45),Nome="Produto A",Referencia="12345"} }
            };
        }
        [WebMethod]
        public List<DTO.PecasBoas> Pecas_Boas(string WorkCenter)
        {

            return new List<PecasBoas>()
            {
                new PecasBoas(){Hora="6h-7h",Qtd=10}
            };
        }
        [WebMethod]
        public List<DTO.Paragem> Paragens_Planeadas(string WorkCenter,string datainicio,string datafim)
        {

            return new List<Paragem>()
            {
                new Paragem(){Duracao=new TimeSpan(00,15,00).ToString(),Start=new DateTime(2023,02,15,06,15,00),End=new DateTime(2023,02,15,06,30,00),Motivo="Paragem 1",Ordem="123",Referencia="1123",Turno=1,WorkCenter=WorkCenter}
            };
        }
        [WebMethod]
        public List<DTO.Paragem> Paragens__Nao_Planeadas(string WorkCenter, string datainicio, string datafim)
        {

            return new List<Paragem>()
            {
                new Paragem(){Duracao=new TimeSpan(00,15,00).ToString(),Start=new DateTime(2023,02,15,06,15,00),End=new DateTime(2023,02,15,06,30,00),Motivo="Paragem 1",Ordem="123",Referencia="1123",Turno=1,WorkCenter=WorkCenter}
            };
        }

    }
}
