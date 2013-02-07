using System.Collections.Generic;

namespace ojualoc.core
{
    public class Cliente : Entidade
    {
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}