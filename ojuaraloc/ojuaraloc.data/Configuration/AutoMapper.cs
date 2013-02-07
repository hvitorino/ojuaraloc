using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ojualoc.core;

namespace ojuaraloc.data.Configuration
{
    public class AutoMapper
    {
        public ISessionFactory GetSessionFactory()
        {
            const string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=ojuaraloc;Integrated Security=true";
            const string context = "web";

            var conventions = AutoMap.Assemblies(new MappedModels(), typeof(Titulo).Assembly);
            
            var factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString))
                .CurrentSessionContext(context)
                .Mappings(m => m.AutoMappings.Add(conventions))
                .ExposeConfiguration(UpdateDatabase)
                .BuildSessionFactory();

            return factory;
        }

        private void UpdateDatabase(NHibernate.Cfg.Configuration configuration)
        {
            new SchemaUpdate(configuration).Execute(false, true);
        }
    }
}