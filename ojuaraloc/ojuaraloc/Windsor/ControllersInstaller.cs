using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ojuaraloc.Controllers;

namespace ojuaraloc.Windsor
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromAssemblyContaining<ClienteController>()
                    .BasedOn<Controller>()
                    .LifestyleTransient());
        }
    }
}