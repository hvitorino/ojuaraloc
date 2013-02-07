using Restfulie.Server;
using Restfulie.Server.Results;
using System.Web.Mvc;

namespace ojuaraloc.Controllers
{
    [ActAsRestfulie]
    public class ClienteController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return new OK();
        }
    }
}
