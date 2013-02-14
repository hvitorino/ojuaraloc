using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using System.Linq;

namespace ojuaraloc.data
{
    public class Data<T> where T : class
    {
        public ISession NhSession
        {
            get { return SessionProvider.CurrentSession; }
        }

        public T Carrega(long id)
        {
            return NhSession.CreateCriteria<T>()
                .Add(Restrictions.Eq("Id", id))
                .List<T>()
                .FirstOrDefault();
        }

        public void Exclui(T entidade)
        {
            NhSession.Delete(entidade);
        }

        public void Inclui(T entidade)
        {
            NhSession.Save(entidade);
        }

        public void Altera(T entidade)
        {
            NhSession.Update(entidade);
        }

        public IEnumerable<T> Lista()
        {
            return NhSession.CreateCriteria<T>().List<T>();
        }
    }
}