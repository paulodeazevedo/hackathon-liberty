using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Liberty.Controllers
{
    public class GraficosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<object> BuscaGrafico()
        {
            var response = new List<object>();

            object[] res = new object[2];
            res[0] = "Task";
            res[1] = "Hours per Day";
            response.Add(res);

            res = new object[2];
            res[0] = "Work";
            res[1] = 11;
            response.Add(res);

            res = new object[2];
            res[0] = "Eat";
            res[1] = 2;
            response.Add(res);

            res = new object[2];
            res[0] = "Commute";
            res[1] = 2;
            response.Add(res);

            res = new object[2];
            res[0] = "Watch TV";
            res[1] = 2;
            response.Add(res);

            res = new object[2];
            res[0] = "Sleep";
            res[1] = 7;
            response.Add(res);

            return response;
        }
    }
}