using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ojuaraloc.data;
using ojuaraloc.data.Configuration;

namespace ojuaraloc.Windsor
{
    public class DataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromAssemblyContaining<AutoMapper>()
                    .BasedOn(typeof(Data<>))
                    .LifestyleSingleton());
        }
    }
}