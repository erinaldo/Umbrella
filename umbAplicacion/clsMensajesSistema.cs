using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace umbAplicacion
{
    public class clsMensajesSistema {
        public static string msgGuardar = "Registro ingresado con exito con el código: {0}";
        public static string msgActualizar = "Registro actualizado con exito";
        public static string msgEliminar = "Registro eliminado con exito";

        public static void metMsgInformativo(string varMensaje) {
            XtraMessageBox.Show(varMensaje, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void metMsgError(string varMensaje) {
            XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult metMsgPregunta(string varMensaje) {
            return XtraMessageBox.Show(varMensaje, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
