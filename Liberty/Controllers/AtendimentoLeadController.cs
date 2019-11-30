using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liberty.Models;
using Microsoft.AspNetCore.Mvc;

namespace Liberty.Controllers
{
    public class AtendimentoLeadController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<Cliente>()
            {
                new Cliente()
                {
                    Segurado = new DadosCliente()
                    {
                        Nome = "João Silva"
                    },
                    Lead = new Lead()
                    {
                        IdCorretorResponsavel = 1,
                        CriacaoLead = DateTime.Now,
                        EmailCorretor = "paulocorretor@corretora.com",
                        NomeCorretor = "Paulo Corretor",
                        StatusLead = "Pendente",
                        VencimentoLead = DateTime.Now.AddHours(1).AddMinutes(32),
                        Ramo = "Auto"
                    }
                },
                new Cliente()
                {
                    Segurado = new DadosCliente()
                    {
                        Nome = "Camila Insegura"
                    },
                    Lead = new Lead()
                    {
                        IdCorretorResponsavel = 1,
                        CriacaoLead = DateTime.Now,
                        EmailCorretor = "paulocorretor@corretora.com",
                        NomeCorretor = "Paulo Corretor",
                        StatusLead = "Pendente",
                        VencimentoLead = DateTime.Now.AddHours(2),
                        Ramo = "Vida"
                    }
                }
            };
            return View(model.OrderBy(x => x.Lead.VencimentoLead).ToList());
        }
    }
}