using ojualoc.core;
using ojuaraloc.data;
using Restfulie.Server;
using Restfulie.Server.Results;
using System.Web.Mvc;

namespace ojuaraloc.Controllers
{
    [ActAsRestfulie]
    public class ClienteController : CrudController<Cliente>
    {
        public ClienteController()
        {
            
        }

        public ClienteController(Data<Cliente> data)
            : base(data)
        {
        }
    }
}
