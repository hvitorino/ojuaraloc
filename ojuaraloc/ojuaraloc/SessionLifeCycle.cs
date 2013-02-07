using NHibernate.Context;
using ojuaraloc.data;
using System;
using System.Web;

namespace ojuaraloc
{
    public class SessionLifeCycle : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.EndRequest += ContextEndRequest;
            context.Error += ContextError;
        }

        public void Dispose() {}

        public void ContextError(object sender, EventArgs e)
        {
            var session = CurrentSessionContext.Unbind(SessionProvider.Factory);
            if (session != null && session.Transaction.IsActive)
                session.Transaction.Rollback();
        }

        private static void ContextEndRequest(object sender, EventArgs e)
        {
            var session = CurrentSessionContext.Unbind(SessionProvider.Factory);
            if (session == null)
                return;

            try
            {
                if (session.Transaction.IsActive)
                {
                    if (HttpContext.Current.Error != null)
                        session.Transaction.Rollback();
                    else
                        session.Transaction.Commit();
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Ocorreu um erro interno. Entre em contato com o administrador ou tente novamente.", exception);
            }
            finally
            {
                session.Dispose();
            }
        }
    }
}