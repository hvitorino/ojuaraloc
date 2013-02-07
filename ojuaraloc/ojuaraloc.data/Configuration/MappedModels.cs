using FluentNHibernate.Automapping;
using System;

namespace ojuaraloc.data.Configuration
{
    public class MappedModels : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "ojuaraloc.Models";
        }
    }
}