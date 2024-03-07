using DAO;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Config
{
    public class ConfiguracionServices
    {
        public static Configuraciones getFirst()
        {
            Configuraciones u;
            using (NHibernate.ISession sess = NHibernateSessionProvider.GetSession())
            {
                u = new ConfiguracionesRepository(sess).GetFirst();


                sess.Close();
                sess.Dispose();
                return u;
            }
        }
    }
}
