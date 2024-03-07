﻿//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for NHibernate model.
// Code is generated on: 1/3/2024 16:43:22
//
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Linq;

namespace DAO
{
    public partial class UsuarioRepository : NHibernateRepository<Domain.Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ISession session) : base(session)
        {
        }
        public virtual IList<Domain.Usuario> GetAll()
        {
            return session.CreateQuery(string.Format("from Usuario")).List<Domain.Usuario>();
        }

        public virtual Domain.Usuario GetByEmail(string userEmail)
        {
            Domain.Usuario lista;
            lista = session.CreateQuery(string.Format("from Usuario WHERE lower(Email) = :email and Activo='true'"))
                .SetParameter("email", userEmail.ToLower())
                .UniqueResult<Domain.Usuario>();
            if (lista != null)
            {
                //foreach (Rol ra in lista.Rols)
                //{
                //    NHibernateUtil.Initialize(ra.RolModulos);
                //}
            }
            return lista;
        }

        public virtual Domain.Usuario GetEmail(string email)
        {
            Domain.Usuario lista;
            lista = session.CreateQuery(string.Format("from Usuario where lower(Email) = :email ")).SetParameter("email", email).UniqueResult<Domain.Usuario>();
            //if (lista != null)
            //{
            //    foreach (Rol ra in lista.Rols)
            //    {
            //        NHibernateUtil.Initialize(ra.RolModulos);
            //    }
            //}
            return lista;
        }

        public virtual Domain.Usuario ExisteEmailUser(string email)
        {
            return session.CreateQuery(string.Format("from Usuario WHERE lower(Email) = :email and Activo='true'"))
                .SetParameter("email", email.ToLower())
                .UniqueResult<Domain.Usuario>();
        }

        public virtual Domain.Usuario GetByKey(int _Id)
        {
            return session.Get<Domain.Usuario>(_Id);
        }
    }
}
