using System.Collections.Generic;

namespace ojuaraloc.Models
{
    public class Cliente
    {
        public virtual long Id { get; set; }
        public virtual string Nome { get; set; }

        public virtual List<Conta> Contas { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    public class Conta
    {
        public virtual long Id { get; set; }
        public virtual double Saldo { get; set; }
    }
}