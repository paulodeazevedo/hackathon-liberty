using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liberty.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Liberty.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Cliente> listClientes = dbContext.Cliente.Find(m => true).ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Cliente entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            entity.Id = Guid.NewGuid();
            dbContext.Cliente.InsertOne(entity);
            return RedirectToAction("Index", "Cliente");
        }
    }
}