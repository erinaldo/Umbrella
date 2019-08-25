using SAPbobsCOM;
using System;

namespace umbNegocio
{

    /// <summary>
    /// Interfaz para interactuar con DIAPI
    /// </summary>
    public interface IDIAPI
    {
        Company Company { get; set; }
        string MensajeError { get; set; }
        int NumeroError { get; set; }

        bool Conectar();
        void Desconectar();
    }

    public class DIAPI : IDIAPI
    {
        private Company _company;
        private string _mensajeError;
        private int _nroError;

        public Company Company
        {
            get { return _company; }
            set { }
        }
        public string MensajeError
        {
            get { return _mensajeError; }
            set { }
        }
        public int NumeroError
        {
            get { return _nroError; }
            set { }
        }

        public bool Conectar()
        {
            _nroError = 0;
            _mensajeError = "";

            bool res = false;
            try
            {
                // JP 20160627 Obtener desde AppSettings
                _company = new Company
                {
                    Server = Helper.getSetting("SAP_ServidorBD"),
                    DbServerType = BoDataServerTypes.dst_MSSQL2008,
                    CompanyDB = Helper.getSetting("SAP_NombreBD"),
                    DbUserName = Helper.getSetting("SAP_UsuarioBD"),
                    DbPassword = Helper.getSetting("SAP_PassBD"),
                    UserName = Helper.getSetting("SAP_UsuarioLogin"),
                    Password = Helper.getSetting("SAP_PassLogin"),
                    UseTrusted = false,
                };

                _nroError = _company.Connect();
                int nError = 0;
                string mError = "";
                if (_nroError != 0)
                {
                    _company.GetLastError(out nError, out mError);
                    _nroError = nError;
                    _mensajeError = mError;
                }
                else res = true;

            }
            catch (Exception ex)
            {
                _mensajeError = ex.Message;
            }
            return res;
        }

        public void Desconectar()
        {
            _mensajeError = "";
            _nroError = 0;
            if (_company != null && _company.Connected)
                _company.Disconnect();

            _company = null;
        }
    }
}
