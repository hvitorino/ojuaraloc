using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restfulie.Server;
using Restfulie.Server.Results;
using RiaLibrary.Web;
using ojuaraloc.Models;

namespace ojuaraloc.Controllers
{
    [ActAsRestfulie]
    public class ClienteController : Controller
    {
        public static readonly List<Cliente> TodosOsClientes = new List<Cliente>
        {
            new Cliente 
            { 
                Id = 1, 
                Nome = "Ojuara", 
                Contas = new List<Conta>
                {
                    new Conta { Id = 1, Saldo = 1000 },
                    new Conta { Id = 2, Saldo = 2000 }
                }
            },
            new Cliente { Id = 1, Nome = "Bahiano"},
            new Cliente { Id = 1, Nome = "Leon"},
            new Cliente { Id = 1, Nome = "Toin"},
            new Cliente { Id = 1, Nome = "Elvis"},
            new Cliente { Id = 1, Nome = "Esconde"}
        };

        [HttpGet]
        public ActionResult Index()
        {
            return new OK(TodosOsClientes);
        }
    }
}
