﻿using System;
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
                .Where(x => x.Lead != null && x.Lead.Atendido == false)
                .OrderBy(x => x.Lead.VencimentoLead)
                .ToList();

            return View(listClientes);
        }

        public IActionResult Atendimento(string idCliente)
        {
            ObjectId _id = new ObjectId(idCliente);

            MongoDbContext dbContext = new MongoDbContext();
            var cliente = dbContext.Cliente.Find(x => x.Id == _id).FirstOrDefault();

            cliente.Lead.Atendido = true;
            cliente.Lead.StatusLead = "Em andamento";
            var result = dbContext.Cliente.FindOneAndReplace<Cliente>(c => c.Id == _id, cliente);

            if (cliente != null && cliente.EnviarFormulario == "Sim")
            {
                return View("Atendimento", cliente);
            }
            else
            {
                return View("AtendimentoSimplificado", cliente);
            }
        }

        public IActionResult AtendimentoEmAndamento()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Cliente> listClientes = dbContext.Cliente
                .Find(_ => true).ToList()
                .Where(x => x.Lead != null && x.Lead.Atendido == true)
                .OrderBy(x => x.Lead.VencimentoLead != null)
                .ToList();

            return View("AtendimentoEmAndamento", listClientes);
        }
        public IActionResult Cardapio()
        {
            return View("cardapio");
        }

        public IActionResult AtendimentosConcluidos()
        {
            return View();
        }

        public IActionResult FiltrarAtendimentosConcluidos(DateTime dataInicio, DateTime dataFim)
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Cliente> listClientes = dbContext.Cliente
                .Find(x => x.Lead.Finalizado == true).ToList()
                .OrderBy(x => x.Lead.VencimentoLead)
                .ToList();

            return View("AtendimentosConcluidos", listClientes);
        }
    }
}