using NHibernate;
using ojualoc.core;
using System.Collections.Generic;

namespace ojuaraloc.data
{
    public class ClienteData
    {
        public ISession NhSession
        {
            get { return SessionProvider.CurrentSession; }
        }

        public void Exclui(Cliente cliente)
        {
            NhSession.Delete(cliente);
        }

        public void Inclui(Cliente cliente)
        {
            NhSession.Save(cliente);
        }

        public IEnumerable<Cliente> Lista()
        {
            return NhSession.CreateCriteria<Cliente>().List<Cliente>();
        }
    }
}
