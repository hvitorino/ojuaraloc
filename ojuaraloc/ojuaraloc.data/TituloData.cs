using System;
using System.Collections.Generic;
using NHibernate;
using ojualoc.core;

namespace ojuaraloc.data
{
    public class TituloData
    {
        public ISession NhSession
        {
            get { return SessionProvider.CurrentSession; }
        }

        public void Exclui(Titulo titulo)
        {
            NhSession.Delete(titulo);
        }

        public void Inclui(Titulo titulo)
        {
            NhSession.Save(titulo);
        }

        public IEnumerable<Titulo> Lista()
        {
            return NhSession.CreateCriteria<Titulo>().List<Titulo>();
        }
    }
}