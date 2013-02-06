using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RiaLibrary.Web;

namespace ojuaraloc.Controllers
{
    public class ContasController : Controller
    {
        [Url("clientes/{id}/contas")]
        public ActionResult Index(long id)
        {
            var ojuara = ClienteController.TodosOsClientes.First(cliente => cliente.Id == id);

            return View(ojuara.Contas);
        }

    }
}
