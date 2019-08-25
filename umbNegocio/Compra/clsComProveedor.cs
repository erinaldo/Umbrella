using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Compra
{
    public class clsComProveedor
    {
        public string PrvCodigo { get; set; }
        public string PrvNombre { get; set; }
        public int PrvLstPrecio { get; set; }

        public static List<clsComProveedor> funListar()
        {
            try
            {
                const string varSql = "Select CardCode, CardName, a.ListNum From OCRD a Where a.CardType = 'S' And a.FrozenFor = 'N'";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsComProveedor> funListar(string varProveedor)
        {
            try
            {
                string varSql = string.Format("Select CardCode, CardName, a.ListNum From OCRD a Where a.CardType = 'S' And a.FrozenFor = 'N' And CardCode = '{0}'", varProveedor);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsComProveedor> funListarSql(string varSql)
        {
            try
            {
                List<clsComProveedor> objLista = new List<clsComProveedor>();
                csAccesoDatos.funIniciarSesion("conDBItalimentos");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsComProveedor()));
                }
                return objLista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static clsComProveedor funRegistro(DataRow drLista, clsComProveedor objRegistro)
        {
            objRegistro.PrvCodigo = drLista["CardCode"].ToString();
            objRegistro.PrvNombre = drLista["CardName"].ToString();
            objRegistro.PrvLstPrecio = int.Parse(drLista["ListNum"].ToString());
            return objRegistro;
        }
    }
}
