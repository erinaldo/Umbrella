using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Logistica {
    public class clsLogRutGuia {
        private int atrRguCodigo;
        private String atrRguNombre;

        public int AtrRguCodigo {
            get { return atrRguCodigo; }
            set { atrRguCodigo = value; }
        }
        public string AtrRguNombre {
            get { return atrRguNombre; }
            set { atrRguNombre = value; }
        }

        public clsLogRutGuia() { }
        public clsLogRutGuia(int atrRguCodigo, string atrRguNombre) {
            this.atrRguCodigo = atrRguCodigo;
            this.atrRguNombre = atrRguNombre;
        }

       
    }
}
