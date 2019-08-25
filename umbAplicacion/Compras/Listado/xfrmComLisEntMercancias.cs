using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Compras.Mantenimiento;
using umbNegocio;
using umbNegocio.Compra;
using umbNegocio.Seguridad;
using Umbrella;

namespace umbAplicacion.Compras.Listado
{
    public partial class xfrmComLisEntMercancias : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        private int varCabCodigo = 0;

        public xfrmComLisEntMercancias()
        {
            InitializeComponent();
        }
        public xfrmComLisEntMercancias(bool varBandera)
        {
            InitializeComponent();
            varBanListado = varBandera;
        }
        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Entrada de mercancias";
                //Variable q contendra el nombre del formulario
                const string varNomFormulario = "umbAplicacion.Compras.Listado.xfrmComLisEntMercancias";
                //Recuperamos el codigo del formulario para las respectivos accesos
                foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
                //Accesos del formulario para el usuario ingresado
                this.proAccesoFormulario();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion nuevo
        public override void proNuevo()
        {
            base.proNuevo();
            try {
                xfrmComManEntMercancias objFormulario = new xfrmComManEntMercancias(varCodFormulario, varCodOperacion, 0);
                objFormulario.ShowDialog();
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion modificar
        public override void proModificar()
        {
            try {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";

                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proModificar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsComEntMercanciasCab.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        xfrmComManEntMercancias objFormulario = new xfrmComManEntMercancias(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proModificar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsComEntMercanciasCab.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser modificado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            xfrmComManEntMercancias objFormulario = new xfrmComManEntMercancias(varCodFormulario, varCodOperacion, varRegistro);
                            objFormulario.ShowDialog();
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion consultar
        public override void proConsultar()
        {
            int varRegistro = 0;
            try {
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proConsultar();
                    if (!varBanAcceso) return;
                    
                    varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    xfrmComManEntMercancias objFormulario = new xfrmComManEntMercancias(varCodFormulario, varCodOperacion, varRegistro);
                    objFormulario.ShowDialog();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proConsultar();
                        if (!varBanAcceso) return;

                        varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        xfrmComManEntMercancias objFormulario = new xfrmComManEntMercancias(varCodFormulario, varCodOperacion, varRegistro);
                        objFormulario.ShowDialog();
                    }
                }
                this.grvListado.ClearSelection();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion eliminar
        public override void proEliminar()
        {
            try
            {
                int varRegistro = 0;
                int varCabNumero = 0;
                string varDocNombre = "";
                string varEstCodigo = "";

                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    base.proEliminar();
                    if (!varBanAcceso) return;
                    //Recuperamos en la variable registro el codigo del documento
                    varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    varCabNumero = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabNumero;
                    varDocNombre = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocNombre;
                    varEstCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).EstCodigo;
                    //Verificamos si el documento ya ha sido ingresado en SAP
                    DataTable objDtVerificarSAP;
                    objDtVerificarSAP = clsComEntMercanciasCab.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                    //Verifico si el documento no haya sido enviado a SAP
                    if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0) {
                        XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                            clsComEntMercanciasCab.proAnular(varRegistro);
                            XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        base.proEliminar();
                        if (!varBanAcceso) return;
                        //Recuperamos en la variable registro el codigo del documento
                        varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        varCabNumero = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabNumero;
                        varDocNombre = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocNombre;
                        varEstCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).EstCodigo;
                        //Verificamos si el documento ya ha sido ingresado en SAP
                        DataTable objDtVerificarSAP;
                        objDtVerificarSAP = clsComEntMercanciasCab.funVerificarEntMercanciaSAP(varDocNombre, varCabNumero);
                        //Verifico si el documento no haya sido enviado a SAP
                        if (varEstCodigo.ToUpper().Equals("SAP") || objDtVerificarSAP.Rows.Count > 0)
                            XtraMessageBox.Show(string.Format("El registro nro. {0} no puede ser anulado el mismo ya ha sido enviado a SAP", varCabNumero), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else {
                            if (XtraMessageBox.Show("Esta seguro de eliminar los registro seleccionados", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                                clsComEntMercanciasCab.proAnular(varRegistro);
                                XtraMessageBox.Show(string.Format("El registro nro. {0} ha sido anulado", varCabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       //Operacion imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvListado.GetSelectedRows().Length.Equals(0))
                {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 12);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para imprimir el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varCabCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    this.impDocumento.Print();
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Recuperamos el codigo del documento seleccionado
                        varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                        int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 12);
                        //Si ya ha sido enviado a SAP terminamos el proceso
                        if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        //Recuperamos el codigo interno del registro de laboratorio
                        varCabCodigo = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                        this.impDocumento.Print();
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion enviar a SAP
        private void btnEnviarSAP_Click(object sender, EventArgs e)
        {
            try
            {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).DocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(this.grvListado.FocusedRowHandle)).CabCodigo;
                    clsComEntMercanciasCab csComEntMercancias = clsComEntMercanciasCab.funListar(varRegistro)[0];
                    string varMensaje = "";
                    if (csComEntMercancias.CabTipCompra.Equals("EXTERNO")) varMensaje = csComEntMercancias.funEnviarDocPreliminarSAP();
                    else 
                        clsComEntMercanciasCab.proActEstado(varRegistro);

                    if (varMensaje.Equals(""))
                        XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", csComEntMercancias.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", csComEntMercancias.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                    //Recuperamos el codigo del documento seleccionado
                    varCodDocumento = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).DocCodigo;
                    int varCuantos = clsSegAccFormulario.funAccesoOperacion(clsVariablesGlobales.varCodUsuario, varCodFormulario, varCodDocumento, 10);
                    //Si ya ha sido enviado a SAP terminamos el proceso
                    if (varCuantos.Equals(0)) { XtraMessageBox.Show("El usuario no tiene acceso para enviar a SAP el documento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    //Recuperamos el codigo interno del registro de laboratorio
                    varRegistro = ((clsComEntMercanciasCab)this.grvListado.GetRow(varPosicion)).CabCodigo;
                    clsComEntMercanciasCab csComEntMercancias = clsComEntMercanciasCab.funListar(varRegistro)[0];
                    string varMensaje = "";
                    if (csComEntMercancias.CabTipCompra.Equals("EXTERNO")) varMensaje = csComEntMercancias.funEnviarDocPreliminarSAP();
                    else
                        clsComEntMercanciasCab.proActEstado(varRegistro);

                    if (varMensaje.Equals(""))
                        XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", csComEntMercancias.CabNumero), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", csComEntMercancias.CabNumero, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Actualizamos los datos de listado despues de realizar los cambios
                this.proActListado();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void impDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try {
                foreach (clsComEntMercanciasCab csComEntMercancias in clsComEntMercanciasCab.funListar(varCabCodigo)) {
                    int y = 0;
                    StringFormat str = new StringFormat();
                    str.Alignment = StringAlignment.Far;
                    str.LineAlignment = StringAlignment.Center;
                    str.Trimming = StringTrimming.EllipsisCharacter;
                    Pen p = new Pen(Color.Black, 2.5f);
                    Font drawFont = new Font("Times New Roman", 10);
                    Font drawFont2 = new Font("Times New Roman", 12);
                    Font drawFont3 = new Font("Lucida Console", 8);
                    //Cabecera de la impresion 
                    e.Graphics.DrawString("ITALIMENTOS CIA. LTDA.", drawFont2, Brushes.Black, new RectangleF(80, 10, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Recepcion materia prima:", drawFont, Brushes.Black, new RectangleF(5, 30, 500, 26), new StringFormat());
                    e.Graphics.DrawString(csComEntMercancias.CabNumero.ToString(), drawFont, Brushes.Black, new RectangleF(250, 30, 300, 26), new StringFormat());
                    e.Graphics.DrawString("Proveedor:", drawFont, Brushes.Black, new RectangleF(5, 45, 500, 26), new StringFormat());
                    e.Graphics.DrawString(csComEntMercancias.PrvCodigo, drawFont2, Brushes.Black, new RectangleF(100, 45, 500, 26), new StringFormat());
                    e.Graphics.DrawString(csComEntMercancias.PrvNombre.Length <= 29 ? csComEntMercancias.PrvNombre : csComEntMercancias.PrvNombre.Substring(0, 30), drawFont2, Brushes.Black, new RectangleF(100, 60, 600, 26), new StringFormat());
                    e.Graphics.DrawString("Fecha impresion:", drawFont2, Brushes.Black, new RectangleF(5, 85, 500, 26), new StringFormat());
                    e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd"), drawFont2, Brushes.Black, new RectangleF(250, 85, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Fecha contabilizacion:", drawFont2, Brushes.Black, new RectangleF(5, 100, 500, 26), new StringFormat());
                    e.Graphics.DrawString(((DateTime)csComEntMercancias.CabFecha).ToString("yyyy/MM/dd"), drawFont2, Brushes.Black, new RectangleF(250, 100, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Fecha documento:", drawFont2, Brushes.Black, new RectangleF(5, 115, 500, 26), new StringFormat());
                    e.Graphics.DrawString(((DateTime)csComEntMercancias.CabFecha).ToString("yyyy/MM/dd"), drawFont2, Brushes.Black, new RectangleF(250, 115, 500, 26), new StringFormat());
                    e.Graphics.DrawString("----------------------------------------", drawFont2, Brushes.Black, new RectangleF(5, 135, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Item", drawFont2, Brushes.Black, new RectangleF(5, 150, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Descripcion", drawFont2, Brushes.Black, new RectangleF(100, 150, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Cantidad", drawFont2, Brushes.Black, new RectangleF(330, 150, 500, 26), new StringFormat());
                    e.Graphics.DrawString("----------------------------------------", drawFont2, Brushes.Black, new RectangleF(5, 170, 500, 26), new StringFormat());
                    //Recuperamos los detalles de la entrada de mercancia
                    List<clsComEntMercanciasDet> objDetalle = new List<clsComEntMercanciasDet>();
                    clsComEntMercanciasDet.proListar(varCabCodigo, out objDetalle);
                    //Detalle de la impresion
                    y = 170 + 20;
                    foreach (clsComEntMercanciasDet objFilaDetalle in objDetalle) {
                        e.Graphics.DrawString(objFilaDetalle.IteCodigo, drawFont2, Brushes.Black, new RectangleF(5, y, 500, 26), new StringFormat());
                        e.Graphics.DrawString(objFilaDetalle.IteNombre.Length >= 22 ? objFilaDetalle.IteNombre.Substring(0, 22) : objFilaDetalle.IteNombre, drawFont2, Brushes.Black, new RectangleF(100, y, 500, 26), new StringFormat());
                        e.Graphics.DrawString(String.Format("{0:0.00}", objFilaDetalle.DetCantNeta), drawFont2, Brushes.Black, new RectangleF(330, y, 80, 26), str);
                        y = y + 20;
                    }
                    //Resumen de la impresion
                    y = y + 20;
                    e.Graphics.DrawString("Resumen", drawFont2, Brushes.Black, new RectangleF(5, y, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Descripcion", drawFont2, Brushes.Black, new RectangleF(5, y + 20, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Pza", drawFont2, Brushes.Black, new RectangleF(250, y + 20, 500, 26), new StringFormat());
                    e.Graphics.DrawString("Peso", drawFont2, Brushes.Black, new RectangleF(360, y + 20, 500, 26), new StringFormat());
                    e.Graphics.DrawString("----------------------------------------", drawFont2, Brushes.Black, new RectangleF(5, y + 40, 500, 26), new StringFormat());
                    y = y + 60;
                    //Debemos instanciar la clase a la grilla para el ingreso de resumen
                    List<clsComEntMercanciasRes> objDetalleRes = new List<clsComEntMercanciasRes>();
                    clsComEntMercanciasRes.proListar(varCabCodigo, out objDetalleRes);
                    foreach (clsComEntMercanciasRes objFilaResumen in objDetalleRes) {
                        e.Graphics.DrawString(objFilaResumen.IteNombre.Length >= 22 ? objFilaResumen.IteNombre.Substring(0, 22) : objFilaResumen.IteNombre, drawFont2, Brushes.Black, new RectangleF(5, y, 500, 26), new StringFormat());
                        e.Graphics.DrawString(String.Format("{0:0.00}", objFilaResumen.DetUnidad), drawFont2, Brushes.Black, new RectangleF(250, y, 500, 26), new StringFormat());
                        e.Graphics.DrawString(String.Format("{0:0.00}", objFilaResumen.DetCantidad), drawFont2, Brushes.Black, new RectangleF(315, y, 80, 26), str);
                        y = y + 20;
                    }
                    //Pie de la impresion
                    e.Graphics.DrawString("Peso Italimentos:", drawFont2, Brushes.Black, new RectangleF(150, y + 20, 500, 26), new StringFormat());
                    e.Graphics.DrawString(String.Format("{0:0.00}", csComEntMercancias.CabTotNeto), drawFont2, Brushes.Black, new RectangleF(310, y + 20, 80, 26), str);
                    e.Graphics.DrawString("Peso Proveedor:", drawFont2, Brushes.Black, new RectangleF(150, y + 40, 500, 26), new StringFormat());
                    e.Graphics.DrawString(String.Format("{0:0.00}", csComEntMercancias.CabTotCamal), drawFont2, Brushes.Black, new RectangleF(310, y + 40, 80, 26), str);
                    e.Graphics.DrawString("Diferencia:", drawFont2, Brushes.Black, new RectangleF(150, y + 60, 500, 26), new StringFormat());
                    e.Graphics.DrawString(String.Format("{0:0.00}", csComEntMercancias.CabDiferencia), drawFont2, Brushes.Black, new RectangleF(310, y + 60, 80, 26), str);
                    e.Graphics.DrawString("Observacion", drawFont2, Brushes.Black, new RectangleF(5, y + 80, 500, 26), new StringFormat());
                    e.Graphics.DrawString(csComEntMercancias.CabComentario, drawFont2, Brushes.Black, new RectangleF(150, y + 80, 500, 52), new StringFormat());
                    e.Graphics.DrawString("            ", drawFont2, Brushes.Black, new RectangleF(5, y + 100, 500, 26), new StringFormat());
                    e.HasMorePages = false;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region Procedimiento
        private void proActListado()
        {
            try {
                string varDocumento = clsSegAccFormulario.funAccesoDocumento(varCodFormulario);

                if (varDocumento.Equals("")) { XtraMessageBox.Show("El usuario no tiene acceso al formulario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string varWhere = string.Format("Where a.DocCodigo in ({0})", varDocumento);
                this.grcListado.DataSource = clsComEntMercanciasCab.funListar(varWhere);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        #endregion
    }
}
