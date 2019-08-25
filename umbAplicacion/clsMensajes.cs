using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace umbAplicacion
{
    public class clsMensajes {
        public static string varMsgGuardarSC = "Registro ingresado con el código: {0}";
        public static string varMsgActualizar = "Registro ha sido actualizado";

        public static void metMsgInformativo(string varMensaje) {
            XtraMessageBox.Show(varMensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void metMsgError(string varMensaje) {
            XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
