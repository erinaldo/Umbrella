using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Etiquetas
{
    public class daoEtqNutricional {
        private static daoEtqNutricional objInstancia;
        private object[] objResultado = new object[2];
        public daoEtqNutricional() { } //Implementación del constructor
        public static daoEtqNutricional getInstance() {
            //Implementación del método getInstance
            if (objInstancia == null)
                objInstancia = new daoEtqNutricional();
            return objInstancia;
        }
        public object[] metInsertar(Entidades.EntETQ_NUTRICIONAL objRegistro) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proEtq_NutricionalInsertar", objRegistro.EtnLabel1 /*Nombre del producto*/,
                                                                                                                                                                                            objRegistro.EtnLabel2 /*Información del producto*/,
                                                                                                                                                                                            objRegistro.EtnLabel3 /*Registro sanitario*/,
                                                                                                                                                                                            objRegistro.EtnLabel4 /*Peso*/,
                                                                                                                                                                                            objRegistro.EtnLabel5 /*Codigo de barras*/,
                                                                                                                                                                                            objRegistro.EtnLabel6 /*Leyenda junto a la información nutricional*/,
                                                                                                                                                                                            objRegistro.EtnLabel7 /*Tamaño por ración*/,
                                                                                                                                                                                            objRegistro.EtnLabel8 /*Porciones por envase*/,
                                                                                                                                                                                            objRegistro.EtnLabel9 /*Energía calorías*/,
                                                                                                                                                                                            objRegistro.EtnLabel10 /*Energía calorías a la grasa*/,
                                                                                                                                                                                            objRegistro.EtnLabel11 /*Grasa total gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel12 /*Grasa total porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel13 /*Acidos grasos saturados gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel14 /*Acidos grasos saturados porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel15 /*Acidos grasos trans gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel16 /*Acidos grasos trans porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel17 /*Acidos grasos mono insaturados gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel18 /*Acidos grasos mono insaturados porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel19 /*Acidos grasos poli insaturados gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel20 /*Acidos grasos poli insaturados porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel21 /*Colesterol gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel22 /*Colesterol porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel23 /*Sodio gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel24 /*Sodio porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel25 /*Carbohidratos totales gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel26 /*Carbohidratos totales porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel27 /*Fibra gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel28 /*Fibra porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel29 /*Azucar gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel30 /*Azucar porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel31 /*Proteina gramos*/,
                                                                                                                                                                                            objRegistro.EtnLabel32 /*Proteina porcentaje*/,
                                                                                                                                                                                            objRegistro.EtnLabel33 /*Leyenda 2 requiere cocción*/,
                                                                                                                                                                                            clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();

                objResultado[0] = "ok";
                objResultado[1] = varCodigo.ToString() + ": Registro grabado con éxito";

                return objResultado;
            } catch (Exception ex) {
                objResultado[0] = "error";
                objResultado[1] = "-1 - " + ex.Message;

                return objResultado;
            }
        }
        public object[] metModificar(Entidades.EntETQ_NUTRICIONAL objRegistro) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proEtq_NutricionalModificar", objRegistro.EtnCodigo /*C;odigo de la etiqueta nutricional*/,
                                                                                                                                                                                                objRegistro.EtnLabel1 /*Nombre del producto*/,
                                                                                                                                                                                                objRegistro.EtnLabel2 /*Información del producto*/,
                                                                                                                                                                                                objRegistro.EtnLabel3 /*Registro sanitario*/,
                                                                                                                                                                                                objRegistro.EtnLabel4 /*Peso*/,
                                                                                                                                                                                                objRegistro.EtnLabel5 /*Codigo de barras*/,
                                                                                                                                                                                                objRegistro.EtnLabel6 /*Leyenda junto a la información nutricional*/,
                                                                                                                                                                                                objRegistro.EtnLabel7 /*Tamaño por ración*/,
                                                                                                                                                                                                objRegistro.EtnLabel8 /*Porciones por envase*/,
                                                                                                                                                                                                objRegistro.EtnLabel9 /*Energía calorías*/,
                                                                                                                                                                                                objRegistro.EtnLabel10 /*Energía calorías a la grasa*/,
                                                                                                                                                                                                objRegistro.EtnLabel11 /*Grasa total gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel12 /*Grasa total porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel13 /*Acidos grasos saturados gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel14 /*Acidos grasos saturados porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel15 /*Acidos grasos trans gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel16 /*Acidos grasos trans porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel17 /*Acidos grasos mono insaturados gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel18 /*Acidos grasos mono insaturados porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel19 /*Acidos grasos poli insaturados gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel20 /*Acidos grasos poli insaturados porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel21 /*Colesterol gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel22 /*Colesterol porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel23 /*Sodio gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel24 /*Sodio porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel25 /*Carbohidratos totales gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel26 /*Carbohidratos totales porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel27 /*Fibra gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel28 /*Fibra porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel29 /*Azucar gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel30 /*Azucar porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel31 /*Proteina gramos*/,
                                                                                                                                                                                                objRegistro.EtnLabel32 /*Proteina porcentaje*/,
                                                                                                                                                                                                objRegistro.EtnLabel33 /*Leyenda 2 requiere cocción*/,
                                                                                                                                                                                                clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();

                objResultado[0] = "ok";
                objResultado[1] = varCodigo.ToString() + ": Registro actualizado con éxito";

                return objResultado;
            } catch (Exception ex) {
                objResultado[0] = "error";
                objResultado[1] = "-1 - " + ex.Message;

                return objResultado;
            }
        }
        public object[] metEliminar(int varEtnCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proEtq_NutricionalEliminar", varEtnCodigo);
                csAccesoDatos.proFinalizarSesion();

                objResultado[0] = "ok";
                objResultado[1] = "El registro {0} - {1} ha sido eliminado";

                return objResultado;
            } catch (Exception ex) {
                objResultado[0] = "error";
                objResultado[1] = "-1 - " + ex.Message;

                return objResultado;
            }
        }
        public List<Entidades.EntETQ_NUTRICIONAL> metListar() {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proEtq_NutricionalListar");
                csAccesoDatos.proFinalizarSesion();

                List<Entidades.EntETQ_NUTRICIONAL> objListado = dtLista.ToListOf<Entidades.EntETQ_NUTRICIONAL>();
                return objListado;
            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Entidades.EntETQ_NUTRICIONAL metConsultar(int varEtnCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proEtq_NutricionalConsultar", varEtnCodigo);
                csAccesoDatos.proFinalizarSesion();

                List<Entidades.EntETQ_NUTRICIONAL> objListado = dtLista.ToListOf<Entidades.EntETQ_NUTRICIONAL>();
                Entidades.EntETQ_NUTRICIONAL objCabecera = objListado.Count > 0 ? objListado[0] : null;
                return objCabecera;
            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
