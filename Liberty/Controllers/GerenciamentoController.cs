using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Liberty.Controllers
{
    public class GerenciamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<object> BuscaRenovacaoUltimoMes()
        {
            var response = new List<object>();

            object[] res = new object[2];
            res[0] = "Renovações aceitas";
            res[1] = "Renovações declinadas";
            response.Add(res);

            res = new object[2];
            res[0] = "Aceitas";
            res[1] = 57;
            response.Add(res);

            res = new object[2];
            res[0] = "Declinadas";
            res[1] = 12;
            response.Add(res);

            return response;
        }

        public List<object> BuscaRenovacaoMesAtual()
        {
            var response = new List<object>();

            object[] res = new object[2];
            res[0] = "Renovações aceitas";
            res[1] = "Renovações declinadas";
            response.Add(res);

            res = new object[2];
            res[0] = "Aceitas";
            res[1] = 86;
            response.Add(res);

            res = new object[2];
            res[0] = "Declinadas";
            res[1] = 52;
            response.Add(res);

            return response;
        }

        public List<object> BuscaGraficoBar()
        {
            var response = new List<object>();

            object[] res = new object[3];
            res[0] = "Mês";
            res[1] = "Leads";
            res[2] = "Convertidos";
            response.Add(res);

            res = new object[3];
            res[0] = "Dez";
            res[1] = 100;
            res[2] = 80;
            response.Add(res);

            res = new object[3];
            res[0] = "Jan";
            res[1] = 120;
            res[2] = 90;
            response.Add(res);

            res = new object[3];
            res[0] = "Fev";
            res[1] = 90;
            res[2] = 60;
            response.Add(res);

            res = new object[3];
            res[0] = "Mar";
            res[1] = 98;
            res[2] = 67;
            response.Add(res);

            res = new object[3];
            res[0] = "Abr";
            res[1] = 113;
            res[2] = 95;
            response.Add(res);

            res = new object[3];
            res[0] = "Mai";
            res[1] = 102;
            res[2] = 88;
            response.Add(res);

            res = new object[3];
            res[0] = "Jun";
            res[1] = 91;
            res[2] = 78;
            response.Add(res);

            res = new object[3];
            res[0] = "Jul";
            res[1] = 101;
            res[2] = 75;
            response.Add(res);

            res = new object[3];
            res[0] = "Ago";
            res[1] = 115;
            res[2] = 99;
            response.Add(res);

            res = new object[3];
            res[0] = "Set";
            res[1] = 110;
            res[2] = 92;
            response.Add(res);

            res = new object[3];
            res[0] = "Out";
            res[1] = 107;
            res[2] = 95;
            response.Add(res);

            res = new object[3];
            res[0] = "Nov";
            res[1] = 118;
            res[2] = 93;
            response.Add(res);

            return response;
        }


    }
}