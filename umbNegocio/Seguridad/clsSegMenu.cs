using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umbDatos;

namespace umbNegocio.Seguridad
{
    public class clsSegMenu
    {
        public int MenCodigo { get; set; }
        public string MenNombre { get; set; }
        public int MenPadre { get; set; }
        public string MenNomPadre { get; set; }
        public int FrmCodigo { get; set; }
        public string FrmRuta { get; set; }
        public bool MenVisible { get; set; }
        public string UsuCrea { get; set; }
        public DateTime UsuFechaCrea { get; set; }
        public string UsuModifica { get; set; }
        public DateTime UsuFechaModifica { get; set; }

        public static List<clsSegMenu> funListar()
        {
            try
            {
                const string varSql = "Select a.MenCodigo, a.MenNombre, a.MenPadre, b.MenNombre as MenNomPadre, a.FrmCodigo, FrmRuta, a.MenVisible, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_MENU a Left Join SEG_MENU b on a.MenPadre = b.MenCodigo Left Join SEG_FORMULARIO c on a.FrmCodigo = c.FrmCodigo";
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsSegMenu> funListar(int varMenCodigo)
        {
            try
            {
                string varSql = string.Format("Select a.MenCodigo, a.MenNombre, a.MenPadre, b.MenNombre as MenNomPadre, a.FrmCodigo, FrmRuta, a.MenVisible, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_MENU a Left Join SEG_MENU b on a.MenPadre = b.MenCodigo Left Join SEG_FORMULARIO c on a.FrmCodigo = c.FrmCodigo Where a.MenCodigo = {0}", varMenCodigo);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        public static List<clsSegMenu> funListarMenu(string varUsuario)
        {
            try
            {
                string varSql = string.Format("Select a.MenCodigo, a.MenNombre, a.MenPadre, c.MenNombre as MenNomPadre, d.FrmCodigo, FrmRuta, a.MenVisible, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_MENU a Inner Join SEG_ACCMENU b on a.MenCodigo = b.MenCodigo Left Join SEG_MENU c on a.MenPadre = c.MenCodigo Left Join SEG_FORMULARIO d on a.FrmCodigo = d.FrmCodigo Where a.MenCodigo > 0 And a.MenVisible = 1 And b.UsuCodigo = '{0}'", varUsuario);
                return funListarSql(varSql);
            }
            catch (Exception) { throw; }
        }
        private static List<clsSegMenu> funListarSql(string varSql)
        {
            try
            {
                List<clsSegMenu> objLista = new List<clsSegMenu>();
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                DataTable dtLista = csAccesoDatos.GDatos.funTraerDataTableSql(varSql);
                csAccesoDatos.proFinalizarSesion();
                foreach (DataRow drLista in dtLista.Rows)
                {
                    objLista.Add(funRegistro(drLista, new clsSegMenu()));
                }
                return objLista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //JP Programacion para grupos en el menu principal con el control Navigation.AccordionControl
        public static List<clsSegMenu> funListarGrupos(string varUsuario)
        {
            string varSql = string.Format("Select a.MenCodigo, a.MenNombre, a.MenPadre, c.MenNombre as MenNomPadre, d.FrmCodigo, FrmRuta, a.MenVisible, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_MENU a Inner Join SEG_ACCMENU b on a.MenCodigo = b.MenCodigo Left Join SEG_MENU c on a.MenPadre = c.MenCodigo Left Join SEG_FORMULARIO d on a.FrmCodigo = d.FrmCodigo Where a.MenCodigo > 0 And a.MenVisible = 1 and a.MenPadre='0' And b.UsuCodigo = '{0}'", varUsuario);
            return funListarSql(varSql);
        }
        public static List<clsSegMenu> funListarPorGrupo(string varUsuario, int IdPadre)
        {
            string varSql = string.Format("Select a.MenCodigo, a.MenNombre, a.MenPadre, c.MenNombre as MenNomPadre, d.FrmCodigo, FrmRuta, a.MenVisible, a.UsuCrea, a.UsuFechaCrea, a.UsuModifica, a.UsuFechaModifica From SEG_MENU a Inner Join SEG_ACCMENU b on a.MenCodigo = b.MenCodigo Left Join SEG_MENU c on a.MenPadre = c.MenCodigo Left Join SEG_FORMULARIO d on a.FrmCodigo = d.FrmCodigo Where a.MenCodigo > 0 And a.MenVisible = 1 and a.MenPadre='{1}' And b.UsuCodigo = '{0}'", varUsuario, IdPadre);
            return funListarSql(varSql);
        }

        public static clsSegMenu funRegistro(DataRow drLista, clsSegMenu objRegistro)
        {
            objRegistro.MenCodigo = int.Parse(drLista["MenCodigo"].ToString());
            objRegistro.MenNombre = drLista["MenNombre"] == null ? "" : drLista["MenNombre"].ToString();
            objRegistro.MenPadre = drLista["MenPadre"] == null ? 0 : int.Parse(drLista["MenPadre"].ToString());
            objRegistro.MenNomPadre = drLista["MenNomPadre"] == null ? "" : drLista["MenNomPadre"].ToString();
            objRegistro.FrmCodigo = drLista["FrmCodigo"] == System.DBNull.Value ? 0 : int.Parse(drLista["FrmCodigo"].ToString());
            objRegistro.FrmRuta = drLista["FrmRuta"] == null ? "" : drLista["FrmRuta"].ToString();
            objRegistro.MenVisible = (bool)drLista["MenVisible"]; 
            objRegistro.UsuCrea = drLista["UsuCrea"] == null ? "" : drLista["UsuCrea"].ToString();
            objRegistro.UsuFechaCrea = drLista["UsuFechaCrea"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaCrea"];
            objRegistro.UsuCrea = drLista["UsuModifica"] == null ? "" : drLista["UsuModifica"].ToString();
            objRegistro.UsuFechaModifica = drLista["UsuFechaModifica"] == DBNull.Value ? DateTime.Now : (DateTime)drLista["UsuFechaModifica"];

            return objRegistro;
        }
        public int funMantenimiento(clsSegMenu csRegistro, int varCodigo, int varOperacion)
        {
            try
            {
                csAccesoDatos.funIniciarSesion("conDBUmbrella");
                object sdrProcedimiento = csAccesoDatos.GDatos.funTraerValorOutput("proSeg_Menu", csRegistro.MenCodigo, csRegistro.MenNombre, csRegistro.MenPadre, csRegistro.FrmCodigo, csRegistro.MenVisible, varOperacion, clsVariablesGlobales.varCodUsuario, clsVariablesGlobales.varIpMaquina, 0);
                varCodigo = int.Parse(sdrProcedimiento.ToString());
                csAccesoDatos.proFinalizarSesion();
                return varCodigo;
            }
            catch (Exception) { throw; }
        }
    }
}
