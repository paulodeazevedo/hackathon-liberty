using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liberty.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Liberty.Controllers
{
    public class AtendimentoLeadController : Controller
    {
        public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Cliente> listClientes = dbContext.Cliente
                .Find(_ => true).ToList()
                .Where(x => x.Lead != null)
                .OrderBy(x => x.Lead.VencimentoLead != null)
                .ToList();

            return View(listClientes);
        }

        public IActionResult Atendimento(string idCliente)
        {
            ObjectId _id = new ObjectId(idCliente);
            
            MongoDbContext dbContext = new MongoDbContext();
            Cliente listClientes = dbContext.Cliente.Find(x => x.Id == _id).FirstOrDefault();

            if(listClientes.EnviarFormulario == "Sim")
            {
                return View("Atendimento", listClientes);
            }
            else
            {
                return View("AtendimentoSimplificado", listClientes);
            }
            
        }
    }
}