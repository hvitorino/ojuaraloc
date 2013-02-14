using System;
using System.Web.Mvc;
using Restfulie.Server.Results;
using ojuaraloc.data;

namespace ojuaraloc.Controllers
{
    public abstract class CrudController<T> : Controller where T : class
    {
        protected readonly Data<T> Data;

        protected CrudController()
        {
            
        }

        protected CrudController(Data<T> data)
        {
            this.Data = data;
        }

        [HttpGet]
        public virtual ActionResult Inicio()
        {
            return new OK(Data.Lista());
        }

        [HttpGet]
        public virtual ActionResult Novo()
        {
            return new OK();
        }

        [HttpGet]
        public virtual ActionResult Edicao(long id)
        {
            var carregado = Data.Carrega(id);

            if(carregado == null)
                return new NotFound();

            return new OK(Data.Carrega(id));
        }

        [HttpPost]
        public virtual ActionResult Inclui(T entidade)
        {
            Data.Inclui(entidade);

            //return new Created();
            return RedirectToAction("Novo");
        }

        [HttpPost]
        public virtual ActionResult Edita(T entidade)
        {
            Data.Altera(entidade);

            return RedirectToAction("Inicio");
        }

        [HttpGet]
        public virtual ActionResult Detalhes(long id)
        {
            var carregado = Data.Carrega(id);

            if (carregado == null)
                return new NotFound();

            return new OK(carregado);
        }

        [HttpDelete]
        public virtual ActionResult Exclui(long id)
        {
            var carregado = Data.Carrega(id);

            if (carregado == null)
                return new NotFound();

            Data.Exclui(carregado);

            return RedirectToAction("Inicio");
        }
    }
}