using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Permisos
{
    [Serializable]
    public class PermisoModulo
    {
        private bool visible;

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }
     

    
    }
}
