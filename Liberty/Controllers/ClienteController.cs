using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Liberty.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Liberty.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cliente entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            //entity.Id = Guid.NewGuid();
            if (!string.IsNullOrWhiteSpace(entity.EnviarFormulario) && entity.EnviarFormulario.Equals("Sim"))
            {
                return View("Formulario", entity);
            }
            else
            {
                entity.Lead = new Lead()
                {
                    CriacaoLead = DateTime.Now,
                    EmailCorretor = "corretorseguro@corretora.com",
                    IdCorretorResponsavel = 1,
                    NomeCorretor = "João Silva",
                    Ramo = "Auto",
                    StatusLead = "Pendente",
                    VencimentoLead = DateTime.Now.AddHours(2)
                };

                dbContext.Cliente.InsertOne(entity);
            }

            return RedirectToAction("Index", "Cliente");
        }

        [HttpPost]
        public IActionResult Upload(Cliente entity)
        {
            MongoDbContext dbContext = new MongoDbContext();

            entity.Lead = new Lead()
            {
                CriacaoLead = DateTime.Now,
                EmailCorretor = "corretorseguro@corretora.com",
                IdCorretorResponsavel = 1,
                NomeCorretor = "João Silva",
                Ramo = "Auto",
                StatusLead = "Pendente",
                VencimentoLead = DateTime.Now.AddHours(2)
            };

            dbContext.Cliente.InsertOne(entity);
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Cliente> listClientes = dbContext.Cliente.Find(_ => true).ToList();
            return View("GetAll", listClientes);
        }
    }
}