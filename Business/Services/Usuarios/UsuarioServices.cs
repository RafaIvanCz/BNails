using DAO;
using Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Usuarios
{
    public class UsuarioServices
    {
        public static Usuario GetByEmail(string userEmail)
        {
            Usuario lista;

            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                lista = new UsuarioRepository(sess).GetByEmail(userEmail);

                sess.Close();
                sess.Dispose();
                return lista;
            }
        }

        public static IList<Usuario> GetAll()
        {

            IList<Usuario> lista;
            IList<Usuario> listaSalida = new List<Usuario>();
            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {

                lista = (IList<Usuario>)new UsuarioRepository(sess).GetAll();


                //foreach (Usuario us in lista)
                //{
                //    if (us.Eliminado == false)
                //    {
                //        NHibernateUtil.Initialize(us.Rols);

                //        listaSalida.Add(us);
                //    }
                //}

                var list = (from row in listaSalida
                            orderby row.Id descending
                            select row).ToList<Usuario>();

                listaSalida = list;
                sess.Close();
                sess.Dispose();
                return listaSalida;
            }

        }

        public static bool ExisteEmailUser(string email)
        {
            bool salida = false;
            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                Domain.Usuario user = new UsuarioRepository(sess).ExisteEmailUser(email);
                if (user != null)
                {
                    salida = true;
                }

                sess.Close();
                sess.Dispose();
                return salida;
            }
        }

        public static Usuario getByIdNoInitialize(int id)
        {
            Usuario u;

            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                u = new UsuarioRepository(sess).GetByKey(id);
                //if (u != null)
                //{
                //    NHibernateUtil.Initialize(u.Rols);
                //}
                sess.Close();
                sess.Dispose();
                return u;
            }

        }

        public static void SaveOrUpdate(Usuario u)
        {
            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                using (NHibernate.ITransaction tx = sess.BeginTransaction())
                {
                    try
                    {
                        new UsuarioRepository(sess).Add(u);

                        tx.Commit();
                    }
                    catch (Exception e)
                    {
                        tx.Rollback();
                        throw e;
                    }
                    finally
                    {
                        sess.Close();
                        sess.Dispose();
                    }
                }
            }
        }

        public static void Delete(Usuario u)
        {
            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                using (NHibernate.ITransaction tx = sess.BeginTransaction())
                {
                    try
                    {
                        new UsuarioRepository(sess).Remove(u);
                        tx.Commit();
                    }
                    catch (Exception e)
                    {
                        tx.Rollback();
                        throw e;
                    }
                    finally
                    {
                        sess.Close();
                        sess.Dispose();
                    }
                }
            }
        }
    }
}
