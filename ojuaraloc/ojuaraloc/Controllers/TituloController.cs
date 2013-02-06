using NHibernate.Context;
using NHibernate.Criterion;
using NHibernate.Transform;
using ojuaraloc.Configuration;
using ojuaraloc.Models;
using System.Web.Mvc;

namespace ojuaraloc.Controllers
{
    public class TituloController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Títulos";

            var session = SessionProvider.CurrentSession;

            var titulos = session.CreateCriteria<Titulo>()
                .List<Titulo>();

            return View(titulos);
        }
    }
}