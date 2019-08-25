using pysDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace umbNegocio
{
    // 20160701 JP
    /// <summary>
    /// Administra las opciones de configuración del sistema
    /// </summary>
    public class clsOPCIONES
    {
        #region Propiedades
        #endregion

        #region Métodos públicos

        /// <summary>
        /// Devuelve Codigo, Descripcion, Valor, TipoDato, CodPadre, CodHijo de la lista de opciones
        /// </summary>
        /// <param name="Tipo"></param>
        /// <returns></returns>
        public DataTable Listar()
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGEN_OPCIONESListar");
            csAccesoDatos.proFinalizarSesion();
            return res;
        }

        public string CargarValor(string Codigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGEN_OPCIONESGetValor", Codigo);
            csAccesoDatos.proFinalizarSesion();
            if (res != null && res.Rows.Count > 0)
                return res.Rows[0][0].ToString();
            else
                return "";
        }

        public byte[] CargarValorBinary(string Codigo)
        {
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            DataTable res = csAccesoDatos.GDatos.funTraerDataTable("dbo.SPGEN_OPCIONESGetValorBinary", Codigo);
            csAccesoDatos.proFinalizarSesion();
            if (res != null && res.Rows.Count > 0)
                return (byte[])res.Rows[0][0];
            else
                return null;
        }

        public bool Grabar(string Codigo, string Valor)
        {
            int affectedRows = 0;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            affectedRows = csAccesoDatos.GDatos.funEjecutar("dbo.SPGEN_OPCIONESGrabar", Codigo, Valor);
            csAccesoDatos.proFinalizarSesion();
            return affectedRows > 0;
        }

        public bool GrabarBinary(string Codigo, byte[] Valor)
        {
            int affectedRows = 0;
            csAccesoDatos.funIniciarSesion("conDBUmbrella");
            affectedRows = csAccesoDatos.GDatos.funEjecutar("dbo.SPGEN_OPCIONESGrabarBinary", Codigo, Valor);
            csAccesoDatos.proFinalizarSesion();
            return affectedRows > 0;
        }

        #endregion
    }
}
