using FluentNHibernate.Automapping;
using System;
using ojualoc.core;

namespace ojuaraloc.data.Configuration
{
    public class MappedModels : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.BaseType == typeof (Entidade);
        }
    }
}