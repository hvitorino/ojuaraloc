using Restfulie.Server;
using ojualoc.core;
using ojuaraloc.data;

namespace ojuaraloc.Controllers
{
    [ActAsRestfulie]
    public class TituloController : CrudController<Titulo>
    {
        public TituloController()
        {
            
        }

        public TituloController(Data<Titulo> data)
            : base(data)
        {
        }
    }
}