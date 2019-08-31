using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbNegocio.Etiquetas;

namespace umbNegocio
{
    public class daoImpresion {
        private static daoImpresion objInstancia;
        public static daoImpresion getInstance() {
            //Implementación del método getInstance
            if (objInstancia == null)
                objInstancia = new daoImpresion();
            return objInstancia;
        }
        public DataTable funEtiquetaNutricional(Entidades.EntETQ_NUTRICIONAL objRegistro) {
            try { return daoEtqNutricional.getInstance().metImprimirEtiqueta(objRegistro); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
