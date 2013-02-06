using System.Collections.Generic;
using System.Reflection;
using NHibernate;
using NHibernate.Context;
using ojuaraloc.Configuration;

namespace ojuaraloc
{
    public static class SessionProvider
    {
        private static ISessionFactory factory;

        public static ISessionFactory Factory
        {
            get
            {
                return factory ?? (factory = new AutoMapper().GetSessionFactory());
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