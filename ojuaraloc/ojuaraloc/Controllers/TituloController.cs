using System.Collections.Generic;
using ojualoc.core;
using ojuaraloc.data;
using System.Web.Mvc;

namespace ojuaraloc.Controllers
{
    public class TituloController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Títulos";

            return View(new List<Titulo>());
        }
    }
}