using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DDL
{
    [Serializable]
    public class ItemCombo
    {
        private string id;
        private string descripcion;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
