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
            return new Created();
        }

        [HttpPut]
        public virtual ActionResult Edita(T entidade)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public virtual ActionResult Exclui(long id)
        {
            var carregado = Data.Carrega(id);

            if (carregado == null)
                return new NotFound();

            Data.Exclui(carregado);

            return new OK();
        }
    }
}