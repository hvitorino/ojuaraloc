using System.Collections.Generic;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using ojualoc.core;

namespace ojuaraloc.data.Configuration.MappingOverrides
{
    public class OverrideCliente : IAutoMappingOverride<Cliente>
    {
        public void Override(AutoMapping<Cliente> mapping)
        {
            var lista = new List<Cliente>();

            mapping.Id(cliente => cliente.Id);
        }
    }
}