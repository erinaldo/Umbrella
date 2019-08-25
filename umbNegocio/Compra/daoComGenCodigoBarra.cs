using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;
using umbNegocio.Entidades;

namespace umbNegocio.Compra {
    public class daoComGenCodigoBarra {
        private static daoComGenCodigoBarra objInstancia;
        private object[] objResultado = new object[2];
        public daoComGenCodigoBarra() { } //Implementación del constructor
        public static daoComGenCodigoBarra getInstance() {
            //Implementación del método getInstance
            if (objInstancia == null)
                objInstancia = new daoComGenCodigoBarra();
            return objInstancia;
        }
        public object[] metInsertar(Entidades.EntCOM_CABGENCODBARRA objDocumento) {
            try {
                DataTable dtDetalle = objDocumento.atrDetalles.ToDataTable();

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCom_GenCodBarraInsertar", objDocumento.atrDocCodigo, objDocumento.atrCabFecha, objDocumento.atrPrvCodigo, objDocumento.atrPrvNombre, objDocumento.atrCabComentario, objDocumento.atrCabLote, clsVariablesGlobales.varCodUsuario, dtDetalle);
                csAccesoDatos.proFinalizarSesion();

                objResultado[0] = "ok";
                objResultado[1] = varCodigo.ToString() + ": Registro grabado con éxito";

                return objResultado;
            }
            catch (Exception ex) {
                objResultado[0] = "error";
                objResultado[1] = "-1 - " + ex.Message;

                return objResultado;
            }
        }
        public object[] metModificar(Entidades.EntCOM_CABGENCODBARRA objDocumento) {
            try {
                DataTable dtDetalle = objDocumento.atrDetalles.ToDataTable();

                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                int varCodigo = (int)csAccesoDatos.GDatos.funTraerValorEscalar("proCom_GenCodBarraModificar", objDocumento.atrCabCodigo, objDocumento.atrCabNumero,  objDocumento.atrCabFecha, objDocumento.atrPrvCodigo, objDocumento.atrPrvNombre, objDocumento.atrCabComentario, objDocumento.atrCabLote, clsVariablesGlobales.varCodUsuario, dtDetalle);
                csAccesoDatos.proFinalizarSesion();

                objResultado[0] = "ok";
                objResultado[1] = varCodigo.ToString() + ": Registro actualizado con éxito";

                return objResultado;
            }
            catch (Exception ex)
            {
                objResultado[0] = "error";
                objResultado[1] = "-1 - " + ex.Message;

                return objResultado;
            }
        }
       public object[] metEliminar(int varCabCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                csAccesoDatos.GDatos.funTraerValorEscalar("proCom_GenCodBarraEliminar", varCabCodigo);
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
        public List<EntCOM_CABGENCODBARRA> metListar() {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_GenCodBarraListar", clsVariablesGlobales.varCodUsuario);
                csAccesoDatos.proFinalizarSesion();

                List<EntCOM_CABGENCODBARRA> objListado = dtLista.ToListOf<EntCOM_CABGENCODBARRA>();
                return objListado;
            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public EntCOM_CABGENCODBARRA metConsultar(int varCabCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_GenCodBarraConsultar", varCabCodigo);
                csAccesoDatos.proFinalizarSesion();

                List<EntCOM_CABGENCODBARRA> objListado = dtLista.ToListOf<EntCOM_CABGENCODBARRA>();
                EntCOM_CABGENCODBARRA objCabecera = objListado.Count > 0 ? objListado[0] : null;
                return objCabecera;

            } catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<EntCOM_DETGENCODBARRA> metConsultarDetalle(int varCabCodigo) {
            try {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTable("dbo.proCom_GenCodBarraConsultarDetalle", varCabCodigo);
                csAccesoDatos.proFinalizarSesion();

                List<EntCOM_DETGENCODBARRA> objDetalle = dtLista.ToListOf<EntCOM_DETGENCODBARRA>();
                return objDetalle;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
