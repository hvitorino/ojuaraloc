using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using ojuaraloc.Models;

namespace ojuaraloc.Configuration.MappingOverrides
{
    public class OverrideCliente : IAutoMappingOverride<Cliente>
    {
        public void Override(AutoMapping<Cliente> mapping)
        {
            var lista = new List<Cliente>();

            mapping.Id(cliente => cliente.IdCliente);
        }
    }
}