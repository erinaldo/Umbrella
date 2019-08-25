using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Seguridad
{
    public class clsSegAccMenu
    {
        public string UsuCodigo { get; set; }
        public int MenCodigo { get; set; }
        public string MenNombre { get; set; }
        public int MenPadre { get; set; }
        public bool MenAcceso { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }
        public DataTable dtAccMenu { get; set; }

        public List<clsSegAccMenu> funListarMenuFor(string varUsuCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.MenCodigo, a.MenNombre, 0 as MenPadre, Case When b.UsuCodigo is null Then 0 else 1 end as MenAcceso, b.UsuCrea, b.UsuFechaCrea, b.UsuModifica, b.UsuFechaModifica From SEG_MENU a Left Join SEG_ACCMENU b on a.MenCodigo = b.MenCodigo and b.UsuCodigo = '{0}' Where a.MenPadre > 0 And a.FrmCodigo is not null ", varUsuCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public List<clsSegAccMenu> funListar(string varUsuCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.MenCodigo, b.MenNombre, b.MenPadre, 0 as MenAcceso, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_ACCMENU a inner join SEG_MENU b on a.MenCodigo = b.MenCodigo Where UsuCodigo = '{0}'", varUsuCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private List<clsSegAccMenu> funListarSql(string varSql)
        {
            try
            {
                List<clsSegAccMenu> objLista = new List<clsSegAccMenu>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegAccMenu()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable funListarDt(string varUsuCodigo)
        {
            DataTable dtAccMenu = csAccesoDatos.GDatos.funTraerDataTableSql(string.Format("Select a.MenCodigo, MenNombre, b.FrmCodigo From SEG_ACCMENU a inner join SEG_MENU b on a.MenCodigo = b.MenCodigo inner join SEG_FORMULARIO c on b.FrmCodigo = c.FrmCodigo Where a.UsuCodigo = '{0}' ", varUsuCodigo));
            return dtAccMenu;
        }
        public clsSegAccMenu funRegistro(DataRow drLista, clsSegAccMenu objRegistro)
        {
            objRegistro.UsuCodigo = drLista["MenCodigo"].ToString();
            objRegistro.MenCodigo = int.Parse(drLista["MenCodigo"].ToString());
            objRegistro.MenNombre = drLista["MenNombre"].ToString();
            objRegistro.MenPadre = int.Parse(drLista["MenPadre"].ToString());
            objRegistro.MenAcceso = drLista["MenAcceso"].ToString().Equals("0") ? false : true;
           objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public void funMantenimiento(clsSegAccMenu csRegistro)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            csAccesoDatos.GDatos.funEjecutar("proSeg_AccMenu", csRegistro.UsuCodigo, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, csRegistro.dtAccMenu);
            csAccesoDatos.proFinalizarSesion();
        }
    }
}
