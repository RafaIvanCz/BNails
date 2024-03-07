using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Permisos
{
    [Serializable]
    public class PermisoControl
    {
        private bool lectura;

        public bool Lectura
        {
            get { return lectura; }
            set { lectura = value; }
        }
        private bool escritura;

        public bool Escritura
        {
            get { return escritura; }
            set { escritura = value; }
        }
        private bool eliminar;

        public bool Eliminar
        {
            get { return eliminar; }
            set { eliminar = value; }
        }
    }
}
