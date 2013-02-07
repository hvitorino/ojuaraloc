using ojuaraloc.data.Configuration;
using NHibernate;
using NHibernate.Context;

namespace ojuaraloc.data
{
    public static class SessionProvider
    {
        private static ISessionFactory _factory;

        public static ISessionFactory Factory
        {
            get
            {
                return _factory ?? (_factory = new AutoMapper().GetSessionFactory());
            }
        }

        public static ISession CurrentSession
        {
            get
            {
                if (CurrentSessionContext.HasBind(Factory))
                    return Factory.GetCurrentSession();

                var session = Factory.OpenSession();
                session.BeginTransaction();

                CurrentSessionContext.Bind(session);

                return session;
            }
        }
    }
}