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

            var fluentNh = new AutoMapper();
            var factory = fluentNh.GetSessionFactory();
            var session = factory.OpenSession();

            CurrentSessionContext.Bind(session);

            //var titulos = session.CreateCriteria<Titulo>()
            //    .Add(Restrictions.Eq("Nome", "Ojuara"))
            //    .List<Titulo>();

            //var titulos = session.QueryOver<Titulo>()
            //    .Where(titulo => titulo.NomeDoTitulo == "Ciço")
            //    .List<Titulo>();

            var titulos = session.CreateSQLQuery("select * from titulo")
                .SetResultTransformer(Transformers.AliasToBean(typeof(Titulo)))
                .List<Titulo>();

            return View(titulos);
        }
    }
}