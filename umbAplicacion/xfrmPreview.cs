using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbNegocio;
using umbAplicacion.Etiquetas.Impresion;
using umbNegocio.Entidades;

namespace umbAplicacion
{
    public partial class xfrmPreview : DevExpress.XtraEditors.XtraForm {
        private EntETQ_NUTRICIONAL objRegistro;
        public xfrmPreview() { InitializeComponent(); }
        public xfrmPreview(EntETQ_NUTRICIONAL varObjRegistro) {
            InitializeComponent();
            this.objRegistro = varObjRegistro;
        }
        private void xfrmPreview_Load(object sender, EventArgs e) {
            try {
                DataTable dtDatos = daoImpresion.getInstance().funEtiquetaNutricional(objRegistro);
                if (dtDatos != null && dtDatos.Rows.Count > 0) {
                    crtEtiquetaInformacionNutricional objImpresion = new crtEtiquetaInformacionNutricional();
                    objImpresion.SetDataSource(dtDatos);
                    crvImpresion.ReportSource = objImpresion;
                    crvImpresion.Zoom(200);
                }
            }catch (Exception ex) { clsMensajesSistema.metMsgError(ex.Message); }
            
        }
    }
}