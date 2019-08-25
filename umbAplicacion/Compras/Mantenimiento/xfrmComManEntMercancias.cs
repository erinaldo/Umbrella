using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using umbAplicacion.Compras.Listado;
using umbNegocio;
using umbNegocio.Compra;
using umbNegocio.Inventario;
using umbNegocio.Seguridad;
using Umbrella;
using System.Linq;
using umbAplicacion.Compras.Impresion;
using System.Configuration;

namespace umbAplicacion.Compras.Mantenimiento
{
    public partial class xfrmComManEntMercancias : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        private List<clsComEntMercanciasDet> objDetalle;
        private List<clsComEntMercanciasAbr> objDetalleAbr;
        private List<clsComEntMercanciasRes> objDetalleRes;

        private string varConsola = "";

        private bool varBandGuardar = false;
            
        public xfrmComManEntMercancias()
        {
            InitializeComponent();
        }
        public xfrmComManEntMercancias(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
        //Procedimiento para iniciar el formulario
        public override void proIniciarFormulario()
        {
            try {
                //Asignamos el titulo que tendra el formulario
                this.Text = "Entrada de mercancia";
                //Recuperacion a la base de datos de la informacion que va hacer utilizada en el sistema
                this.lueBodega.Properties.DataSource = clsDiccionario.Listar("COMENTBODEGA");
                this.gluItem.DataSource = clsInvItem.funListar();
                 //Debemos instanciar la clase a la grilla para el ingreso de detalles
                 this.objDetalleAbr = new List<clsComEntMercanciasAbr>();
                 clsComEntMercanciasAbr.proListar(out objDetalleAbr);

                //Verificamos la opcion a escogida por el usuario
                switch (varOpeCodigo) {
                    case 1: //Opcion 1 para la operacion de insertar
                        //Procedimiento para que el usuario escoja el documento a ingresar la informacion
                        clsValidacionesControles.proAccUsuarioDocumento(txtCodSerie, txtNomSerie, btnCancelar, varForCodigo, varOpeCodigo);
                        //Asignamos los valores recuperados del codigo del documento y nombre del documento
                        varDocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text.ToString());
                        varDocNombre = this.txtNomSerie.Text;

                        //Inicializamos los campos con valores predefinidos
                        this.datFecha.EditValue = DateTime.Now;
                        this.txtTolerancia.EditValue = 0;
                        this.cmbTipo.SelectedIndex = 0;
                        this.cmbBalanza.SelectedIndex = 0;
                        this.lueBodega.ItemIndex = 0;
                        //Debemos instanciar la clase a la grilla para el ingreso de detalles
                        this.objDetalle = new List<clsComEntMercanciasDet>();
                        this.objDetalle.Add(new clsComEntMercanciasDet(0));
                        this.grcListado.DataSource = objDetalle;
                        break;
                    case 2: //Opcion 2 para la operacion de modificar
                        foreach (clsComEntMercanciasCab csRegistro in clsComEntMercanciasCab.funListar(varRegCodigo)){
                            this.txtCodigo.EditValue = csRegistro.CabCodigo;
                            this.txtCodSerie.EditValue = csRegistro.DocCodigo;
                            this.txtNumero.EditValue = csRegistro.CabNumero;
                            this.txtListaPrecio.EditValue = csRegistro.CabLstPrecio;
                            this.txtCodSerie.EditValue = varDocCodigo = csRegistro.DocCodigo;
                            this.datFecha.EditValue = (DateTime)csRegistro.CabFecha;
                            this.cmbTipo.Text = csRegistro.CabTipCompra;
                            this.txtNomSerie.Text = csRegistro.DocNombre;
                            this.bedProveedor.EditValue = csRegistro.PrvCodigo;
                            this.txtNombre.Text = csRegistro.PrvNombre;
                            this.lueBodega.EditValue = csRegistro.BodCodigo;
                            this.txtImportacion.EditValue = csRegistro.CabImportacion;
                            this.memObservacion.Text = csRegistro.CabComentario;
                            this.txtLote.Text = csRegistro.CabLote;
                            this.cmbTipo.Text = csRegistro.CabTipCompra;
                            this.txtTotalNeto.EditValue = csRegistro.CabTotNeto;
                            this.txtTotalCamal.EditValue = csRegistro.CabTotCamal;
                            this.txtDiferencia.EditValue = csRegistro.CabDiferencia;
                            this.txtTolerancia.EditValue = csRegistro.CabTolerancia;
                            
                            //Debemos instanciar la clase a la grilla para el ingreso de detalles
                            this.objDetalle = new List<clsComEntMercanciasDet>();
                            clsComEntMercanciasDet.proListar(varRegCodigo, out objDetalle);
                            //Recuperamos la ultima secuencia 
                            if (objDetalle.Count.Equals(0)) this.objDetalle.Add(new clsComEntMercanciasDet(0));
                            this.grcListado.DataSource = objDetalle;
                            //Debemos instanciar la clase a la grilla para el ingreso de resumen
                            this.objDetalleRes = new List<clsComEntMercanciasRes>();
                            clsComEntMercanciasRes.proListar(varRegCodigo, out objDetalleRes);
                            this.grcResumen.DataSource = objDetalleRes;
                            this.colDetImprimir.Visible = true;
                        }
                        //Si es la operacion de consultar bloquemos el boton de grabar
                        if (varOpeCodigo.Equals(4)) { this.btnGrabar.Enabled = false; }
                        this.cmbBalanza.SelectedIndex = 0;
                        break;
                }
                //Verificamos los acceso del usuario al formulario\
                this.proAccesoFormulario();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void xfrmComManEntMercancias_KeyDown(object senDet, KeyEventArgs e)
        {
            try
            {
                if (e.Control){
                    if (e.KeyCode == Keys.F4) btnCancelar.PerformClick();
                }
                if (e.KeyCode == Keys.Enter) {
                    if (this.grcListado.IsFocused) {
                        if (this.grvListado.FocusedColumn != colDetCantBruta &&
                             this.grvListado.FocusedColumn != colDetCantNeta) return;
                        //Recuperamos la fila
                        clsComEntMercanciasDet objFilaDetalle;
                        if (this.grvListado.FocusedColumn == colDetCantBruta) {
                            //if (!this.puertoSerial.IsOpen)
                            //{
                            //    this.puertoSerial.Close();
                            //    this.puertoSerial.PortName = "COM1";
                            //    this.puertoSerial.Open();
                            //}

                            //puertoSerial.NewLine = Environment.NewLine;
                            //puertoSerial.WriteLine("P" + System.Convert.ToChar(13));
                            //XtraMessageBox.Show("Peso capturado");
                            //Thread.Sleep(1000);

                            int o = 0;
                            int posicionpb = 0;
                            string varCadena = "";

                            while (posicionpb == 0) {
                                this.butCapturar.PerformClick();
                                XtraMessageBox.Show("Peso capturado");
                                //this.butCapturar.PerformClick();
                                varCadena = varConsola.Replace(" ", "");

                                posicionpb = varCadena.IndexOf("kg?G\r\n") == -1 ? varCadena.IndexOf("kgG\r\n") : varCadena.IndexOf("kg?G\r\n");
                                if (posicionpb == -1) posicionpb = 0;
                                o++;
                                if (o.Equals(2)) return;
                            }

                            int posicion = varCadena.IndexOf("\r\n");
                            varCadena = varCadena.Substring(posicion + 2, varCadena.Length - (posicion + 2));
                            int posicion2 = varCadena.IndexOf("\r\n");
                            posicionpb = varCadena.IndexOf("kg?G\r\n") == -1 ? varCadena.IndexOf("kgG\r\n") : varCadena.IndexOf("kg?G\r\n");
                            if (posicion2 < posicionpb) varCadena = varCadena.Substring(posicion2 + 2, varCadena.Length - (posicion2 + 2));
                            posicionpb = varCadena.IndexOf("kg?G\r\n") == -1 ? varCadena.IndexOf("kgG\r\n") : varCadena.IndexOf("kg?G\r\n");

                            string varPesBruto = varCadena.Substring(0, posicionpb).Trim();

                            this.grvListado.SetRowCellValue(this.grvListado.FocusedRowHandle, "DetCantBruta", decimal.Parse(varPesBruto));
                            objFilaDetalle = (clsComEntMercanciasDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                            objFilaDetalle.DetCantBruta = decimal.Parse(varPesBruto.ToString());
                            objFilaDetalle.DetCantNeta = objFilaDetalle.DetCantBruta - objFilaDetalle.DetTara - objFilaDetalle.DetTolerancia;
                            this.puertoSerial.DiscardInBuffer();
                            this.puertoSerial.DiscardOutBuffer();
                            this.proCalcularTotales();

                            this.grvListado.FocusedColumn = colDetCantNeta;
                            this.txtConsola.Text = "";
                        }
                        else if (this.grvListado.FocusedColumn == colDetCantNeta)
                        {
                            objFilaDetalle = (clsComEntMercanciasDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                            int varSecuencia = objDetalle.Max(p => p.DetSecuencia);
                            int varPosicionFila = this.grvListado.FocusedRowHandle;
                            object varFilaNueva = this.grvListado.GetRowCellValue(this.grvListado.RowCount - 1, colIteCodigo);

                            //Validamos que los campos ha sido debidamente ingresados
                            string varMensaje = objFilaDetalle.funValidarFila();
                            if (!varMensaje.Equals("")) {
                                string varControl = varMensaje.Split(':')[0];
                                string varError = varMensaje.Split(':')[1].Trim();
                                this.grvListado.SetColumnError(this.grvListado.Columns[varControl], varError);
                                this.grvListado.FocusedColumn = this.grvListado.Columns[varControl];
                                return;
                            }

                            if (varFilaNueva == null || varFilaNueva == DBNull.Value) {
                                if (this.grvListado.RowCount - 1 == 0)
                                    this.objDetalle.Add(new clsComEntMercanciasDet(varSecuencia));
                            }
                            else if (this.grvListado.FocusedRowHandle == this.grvListado.RowCount - 1) {
                                 if (varOpeCodigo.Equals(2)) //Para la operacion de modificar
                                {
                                     //Setencias utilizadas para guardar cada 5 registros
                                    int varCuantasLineas = this.grvListado.RowCount;
                                    if ((((decimal)varCuantasLineas / 10) - Math.Truncate((decimal)varCuantasLineas / 10)) == 0)
                                    {
                                        this.grvListado.FocusedColumn = colDetSecuencia;
                                        this.grvListado.FocusedColumn = colDetCantNeta;
                                        int varPosicion = this.grvListado.FocusedRowHandle;
                                        this.grvListado.FocusedRowHandle = varPosicion - 5;
                                        this.grvListado.FocusedRowHandle = varPosicion;
                                        varBandGuardar = true;
                                        this.proGrabar();
                                        varBandGuardar = false;
                                    }
                                }

                                string varTotal = decimal.Round(objFilaDetalle.DetCantBruta - objFilaDetalle.DetTara - objFilaDetalle.DetTolerancia, 2).ToString() + " KG";
                                //proImprimirEtiqueta(bedProveedor.EditValue.ToString(), txtNombre.Text, (DateTime)datFecha.EditValue, varTotal);

                                clsComEntMercanciasDet objNewFilaDetalle = new clsComEntMercanciasDet();
                                objNewFilaDetalle.DetSecuencia = varSecuencia + 1;
                                objNewFilaDetalle.IteCodigo = objFilaDetalle.IteCodigo;
                                objNewFilaDetalle.IteNombre = objFilaDetalle.IteNombre;
                                objNewFilaDetalle.IteUndInventario = objFilaDetalle.IteUndInventario;
                                objNewFilaDetalle.DetCantBruta = 0;
                                objNewFilaDetalle.DetTara = objFilaDetalle.DetTara;
                                objNewFilaDetalle.DetCantNeta = 0;
                                objNewFilaDetalle.DetLote = objFilaDetalle.DetTieLote.Equals("N") ? "" : this.txtLote.Text;
                                objNewFilaDetalle.DetTieLote = objFilaDetalle.DetTieLote;
                                objNewFilaDetalle.DetAbreviatura = objFilaDetalle.DetAbreviatura;
                                objNewFilaDetalle.DetTolerancia = objFilaDetalle.DetTolerancia;
                                objNewFilaDetalle.DetTotTara = objFilaDetalle.DetTotTara;
                                objNewFilaDetalle.DetUnidad = 0;
                                objNewFilaDetalle.DetCantidad = 0;
                                objNewFilaDetalle.DetCosto = 0;
                                objNewFilaDetalle.DetTotal = 0;
                                objDetalle.Add(objNewFilaDetalle);
                                
                            }
                            if (varPosicionFila < 0){
                                this.grvListado.FocusedRowHandle = 0;
                                this.grvListado.FocusedColumn = colIteCodigo;
                            }
                            else {
                                this.grvListado.FocusedRowHandle = varPosicionFila + 1;
                                this.grvListado.FocusedColumn = colDetCantBruta;
                            }
                        }
                        //Refrescamos el detalle
                        this.grcListado.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //Operacion de cancelar
        public override void proCancelar()
        {
            base.proCancelar();
            try
            {
                if (this.puertoSerial.IsOpen) this.puertoSerial.Close();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Operacion de guardar
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                //Eliminamos las filas vacias del detalle
                objDetalle.RemoveAll(p => p.DetCantNeta.Equals(0) && p.DetCantBruta.Equals(0));
                //Verificamos las validaciones de los campos requeridos
                if (!varBanValidaciones) return;
                //Modificamos la informacion de los resumentes
                foreach (clsComEntMercanciasDet objFilaDetalle in objDetalle) {
                    clsComEntMercanciasRes objFilaResumen = objDetalleRes.Where(p => p.IteCodigo == objFilaDetalle.IteCodigo).ToList<clsComEntMercanciasRes>()[0];
                    objFilaDetalle.DetUnidad = objFilaResumen.DetUnidad;
                    objFilaDetalle.DetCantidad = objFilaResumen.DetCantidad;
                    objFilaDetalle.DetCosto = objFilaResumen.DetCosto;
                    objFilaDetalle.DetTotal = objFilaResumen.DetTotal;
                }
                //Refrescamos el detalle despues de eliminar
                this.grcListado.RefreshDataSource();
                var csRegistro = new clsComEntMercanciasCab()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    DocNombre = this.txtNomSerie.Text,
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    CabLstPrecio = this.txtListaPrecio.Text.Equals("") ? 0 : int.Parse(this.txtListaPrecio.Text),
                    CabEntrySap = 0,
                    CabNumSap = 0,
                    CabFecha = (DateTime)this.datFecha.EditValue,
                    PrvCodigo = this.bedProveedor.EditValue.ToString(),
                    PrvNombre = this.txtNombre.Text,
                    BodCodigo = this.lueBodega.EditValue.ToString(),
                    CabImportacion = this.txtImportacion.Text,
                    CabComentario = this.memObservacion.Text,
                    CabLote = this.txtLote.Text,
                    CabTipCompra = this.cmbTipo.Text,
                    CabTotNeto = decimal.Parse(this.txtTotalNeto.Text),
                    CabTotCamal = this.txtTotalCamal.Text.Equals("") ? 0 : decimal.Parse(this.txtTotalCamal.Text),
                    CabDiferencia = decimal.Parse(this.txtDiferencia.Text),
                    CabTolerancia = this.txtTolerancia.Text.Equals("") ? 0 : decimal.Parse(this.txtTolerancia.Text),
                };

                int varCodigo = csRegistro.funMantenimiento(varOpeCodigo, objDetalle);
                if (!varCodigo.Equals(0))
                {
                    this.txtNumero.EditValue = varCodigo;
                    if (!varBandGuardar) { if (XtraMessageBox.Show("Desea imprimir la tirilla", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) this.impDocumento.Print(); }
                    if (varOpeCodigo.Equals(1)) XtraMessageBox.Show(string.Format("El registro actual ha sido grabado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Registro grabado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!varBandGuardar)
                    {
                        if (this.puertoSerial.IsOpen) this.puertoSerial.Close();
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbBalanza_SelectedIndexChanged(object senDet, EventArgs e)
        {
            try {
                this.puertoSerial.Close();
                this.puertoSerial.PortName = this.cmbBalanza.Text.Equals("BALANZA RIEL") ? "COM1" : "COM3";
                this.puertoSerial.Open();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedProveedor_ButtonClick(object senDet, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try{
                using (xfrmComLisProveedor frmFormulario = new xfrmComLisProveedor(true)) {
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null && frmFormulario.DrVarFila.Count > 0) {
                        this.bedProveedor.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvCodigo;
                        this.txtNombre.Text = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvNombre;
                        this.txtListaPrecio.EditValue = ((clsComProveedor)frmFormulario.DrVarFila[0]).PrvLstPrecio;
                        this.bedProveedor.Focus();
                    }
                    else {
                        this.txtNombre.Text = "";
                        this.txtListaPrecio.Text = "";
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedProveedor_EditValueChanged(object senDet, EventArgs e)
        {
            try {
                string varPrvCodigo = this.bedProveedor.Text.Trim();

                if (varPrvCodigo.Length < 9) { this.txtNombre.Text = ""; this.txtListaPrecio.Text = ""; return; }

                this.txtNombre.Text = "";
                this.txtListaPrecio.Text = "";
                foreach (clsComProveedor csRegistro in clsComProveedor.funListar(varPrvCodigo)) {
                    this.txtNombre.Text = csRegistro.PrvNombre;
                    this.txtListaPrecio.EditValue = csRegistro.PrvLstPrecio;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        delegate void Delegado(string s);
        private void puertoSerial_DataReceived(object senDet, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(1000);
                string s = puertoSerial.ReadExisting();
                Delegado delEscritor = new Delegado(this.proMostrar);
                this.Invoke(delEscritor, s);

            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void impDocumento_PrintPage(object senDet, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                foreach (clsComEntMercanciasCab csComEntMercancias in clsComEntMercanciasCab.funListar(string.Format("Where a.CabCodigo = {0}", this.txtNumero.Text)))
                {
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
                    clsComEntMercanciasDet.proListar(varRegCodigo, out objDetalle);
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
                    objDetalleRes = new List<clsComEntMercanciasRes>();
                    clsComEntMercanciasRes.proListar(varRegCodigo, out objDetalleRes);
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
        private void gluItem_Popup(object sender, EventArgs e)
        {
            (sender as GridLookUpEdit).Properties.View.ClearColumnsFilter();
        }
        private void gluItem_Leave(object sender, EventArgs e)
        {
            try
            {
                string varIteCodigo = (sender as GridLookUpEdit).Text;
                if (varIteCodigo.Equals("")) return;
                //Instanciamos la clase de items
                List<clsInvItem> lisItem = clsInvItem.funListar(varIteCodigo);
                //Recuperamos la posicion en la que nos encontramos
                int varFila = this.grvListado.FocusedRowHandle;
                if (!lisItem.Equals(null)) {
                    foreach (var regItem in lisItem) {
                        this.grvListado.SetRowCellValue(varFila, colIteCodigo, regItem.ItemCode);
                        this.grvListado.SetRowCellValue(varFila, colIteNombre, regItem.ItemName);
                        this.grvListado.SetRowCellValue(varFila, colIteUndInventario, regItem.InvntryUom);
                        this.grvListado.SetRowCellValue(varFila, colDetTieLote, regItem.ManBtchNum);
                        this.grvListado.SetRowCellValue(varFila, colDetLote, regItem.ManBtchNum == "Y" ? this.txtLote.Text : "");
                    }
                }
                else {
                    this.grvListado.SetRowCellValue(varFila, colIteNombre, "");
                    this.grvListado.SetRowCellValue(varFila, colIteUndInventario, "");
                    this.grvListado.SetRowCellValue(varFila, colDetTieLote, "");
                    this.grvListado.SetRowCellValue(varFila, colDetLote, "");
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void grvListado_ShowingEditor(object senDet, CancelEventArgs e)
        {
            if (this.grvListado.FocusedColumn == colIteCodigo)
            {
                this.colIteCodigo.OptionsColumn.ReadOnly = false;
                this.gluItem.ImmediatePopup = true;
            }
            else if (this.grvListado.FocusedColumn == colDetLote)
            {
                if (this.grvListado.GetRowCellDisplayText(this.grvListado.FocusedRowHandle, colDetTieLote).Equals("Y"))
                    this.colDetLote.OptionsColumn.ReadOnly = false;
                else 
                    this.colDetLote.OptionsColumn.ReadOnly = true;
            }
        }
        private void grvListado_ValidatingEditor(object senDet, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                clsComEntMercanciasDet objFilaDetalle = (clsComEntMercanciasDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);

                if (this.grvListado.FocusedColumn == colDetCantBruta) {
                    objFilaDetalle.DetCantBruta = decimal.Parse(e.Value.ToString());
                    objFilaDetalle.DetTotTara = objFilaDetalle.DetTara + objFilaDetalle.DetTolerancia;
                    objFilaDetalle.DetCantNeta = objFilaDetalle.DetCantBruta - objFilaDetalle.DetTotTara;
                    this.proCalcularTotales();
                }
                else if (this.grvListado.FocusedColumn == colDetTara) {
                    objFilaDetalle.DetTara = decimal.Parse(e.Value.ToString());
                    objFilaDetalle.DetTotTara = objFilaDetalle.DetTara + objFilaDetalle.DetTolerancia;
                    objFilaDetalle.DetCantNeta = objFilaDetalle.DetCantBruta - objFilaDetalle.DetTotTara;
                    this.proCalcularTotales();
                }
                else if (this.grvListado.FocusedColumn == colDetAbreviatura)
                {
                    string varAenCodigo = e.Value.ToString();
                    var objFilaAbreviatura = objDetalleAbr.Where(p => p.AenCodigo == varAenCodigo).Select(p => new { p.AenCodigo, p.IteCodigo, p.AenTara }).ToList();
                    //Verificamos si existe la abreviatura digitada
                    if (objFilaAbreviatura.Count > 0) {
                        clsInvItem csItem = clsInvItem.funListar(objFilaAbreviatura[0].IteCodigo)[0];
                        objFilaDetalle.DetAbreviatura = objFilaAbreviatura[0].AenCodigo;
                        objFilaDetalle.IteCodigo = csItem.ItemCode;
                        objFilaDetalle.IteNombre = csItem.ItemName;
                        objFilaDetalle.IteUndInventario = csItem.InvntryUom;
                        objFilaDetalle.DetTara = objFilaAbreviatura[0].AenTara;
                        objFilaDetalle.DetTieLote = csItem.ManBtchNum;
                        objFilaDetalle.DetLote = csItem.ManBtchNum.Equals("Y") ? this.txtLote.Text : "";
                        objFilaDetalle.DetCantNeta = objFilaDetalle.DetCantBruta - objFilaDetalle.DetTara - objFilaDetalle.DetTolerancia;
                    }
                    else {
                        objFilaDetalle.DetAbreviatura = "";
                        objFilaDetalle.IteCodigo = "";
                        objFilaDetalle.IteNombre = "";
                        objFilaDetalle.IteUndInventario = "";
                        objFilaDetalle.DetTara = 0;
                        objFilaDetalle.DetTieLote = "N";
                        objFilaDetalle.DetLote = "";
                        objFilaDetalle.DetCantNeta = 0;
                    }
                    this.proCalcularTotales();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void butCapturar_Click(object senDet, EventArgs e)
        {
            if (!this.puertoSerial.IsOpen)
            {
                this.puertoSerial.Close();
                this.puertoSerial.PortName = this.cmbBalanza.Text.Equals("BALANZA RIEL") ? "COM1" : "COM3";
                this.puertoSerial.Open();
            }

            puertoSerial.NewLine = Environment.NewLine;
            puertoSerial.WriteLine("P" + System.Convert.ToChar(13));
            // Thread.Sleep(1000);
        }
        private void txtTotalCamal_Validating(object senDet, CancelEventArgs e)
        {
            try {
                this.txtTotalNeto.EditValue = objDetalleRes.Sum(p => p.DetCantidad);
                this.txtDiferencia.EditValue = decimal.Parse(this.txtTotalNeto.Text) - decimal.Parse(this.txtTotalCamal.Text);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtTolerancia_Validating(object senDet, CancelEventArgs e)
        {
            try {
                decimal varTolerancia = this.txtTolerancia.Text .Equals("") ? 0 : decimal.Parse(this.txtTolerancia.Text);
                foreach (clsComEntMercanciasDet objFilaDetalle in objDetalle) {
                    objFilaDetalle.DetTolerancia = varTolerancia;
                    objFilaDetalle.DetTotTara = varTolerancia +objFilaDetalle.DetTara;
                    objFilaDetalle.DetCantNeta = objFilaDetalle.DetCantBruta - objFilaDetalle.DetTotTara;
                }
                this.grcListado.RefreshDataSource();
                this.proCalcularTotales();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtLote_Validating(object senDet, CancelEventArgs e)
        {
            try {
                foreach (clsComEntMercanciasDet objFilaDetalle in objDetalle)
                    objFilaDetalle.DetLote = this.txtLote.Text;
                this.grcListado.RefreshDataSource();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proMostrar(string varCadena)
        {
            varConsola = varCadena;
        }
       
        private void proCalcularTotales()
        {
            try
            {
                
                //Obtenemos los items unicos
                var objResumenDistinct = objDetalle.Where(p => p.IteCodigo != "").GroupBy(p => new { p.IteCodigo, p.IteNombre }).ToList();
                //Instanciamos el objeto de resumen 
                objDetalleRes = new List<clsComEntMercanciasRes>();
                this.grcResumen.DataSource = objDetalleRes;
                int i = 0;
                int varListaPrecio = 0;
                string varIteCodigo = "";
                decimal varPrecio = 0;
                //Recoremos los items unicos obtenidos
                foreach (var objFilaResumenDistinct in objResumenDistinct) {

                    clsComEntMercanciasRes objFilaResumen = new clsComEntMercanciasRes(); 
                    varIteCodigo = objFilaResumenDistinct.Key.IteCodigo.ToString();
                    varListaPrecio = int.Parse(this.txtListaPrecio.Text);
                    varPrecio = clsInvItem.funPrecioItem(varIteCodigo, varListaPrecio);

                    objFilaResumen.DetSecuencia = ++i;
                    objFilaResumen.IteCodigo = objFilaResumenDistinct.Key.IteCodigo.ToString();
                    objFilaResumen.IteNombre = objFilaResumenDistinct.Key.IteNombre.ToString();
                    objFilaResumen.DetPiezas = objDetalle.Count(p => p.IteCodigo == varIteCodigo);
                    objFilaResumen.DetCantidad = objDetalle.Where(p => p.IteCodigo == varIteCodigo).Sum(p => p.DetCantNeta);
                    objFilaResumen.DetCosto = varPrecio;
                    objFilaResumen.DetTotal = decimal.Round(objFilaResumen.DetCantidad * varPrecio, 2);
                    objFilaResumen.DetNro = objDetalle.Count(p => p.IteCodigo == varIteCodigo);
                    objDetalleRes.Add(objFilaResumen);
                 }
                this.grcResumen.RefreshDataSource();
                this.txtTotalNeto.EditValue = objDetalle.Sum(p => p.DetCantNeta);
                this.txtDiferencia.EditValue = decimal.Parse(this.txtTotalNeto.Text) - decimal.Parse(this.txtTotalCamal.Text);
            }
            catch (Exception) { throw; }
        }

        private void smiEliminar_Click(object sender, EventArgs e)
        {
            try {
                if (this.grvListado.IsFocusedView) {
                    clsComEntMercanciasDet objFilaDetalle = (clsComEntMercanciasDet)this.grvListado.GetRow(this.grvListado.FocusedRowHandle);
                    objDetalle.Remove(objFilaDetalle);
                    this.grcListado.RefreshDataSource();
                    this.proCalcularTotales();
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void xfrmComManEntMercancias_FormClosed(object sender, FormClosedEventArgs e)
        {
            try{ if (this.puertoSerial.IsOpen) this.puertoSerial.Close(); }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void proImprimirEtiqueta(string varCodProveedor, string varProveedor, DateTime varFecha, string varTotalNeto) {
            crtEtiquetaCarnes objImpresionEtiqueta = new crtEtiquetaCarnes();
            DataTable dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiqueta(varCodProveedor, varProveedor, varFecha, varTotalNeto);
            objImpresionEtiqueta.SetDataSource(dtValoresEtiqueta);
            objImpresionEtiqueta.PrintOptions.PrinterName = "ZDesigner GC420d (EPL)";
            objImpresionEtiqueta.PrintToPrinter(1, false, 0, 1);
            
        }

        private void ibuImpresion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            try {
                string varDocNombre = this.txtNomSerie.Text;
                int varCabNumero = int.Parse(this.txtNumero.Text);
                string varPrvCodigo = this.bedProveedor.EditValue.ToString();
                string varPrvNombre = this.txtNombre.Text;
                DateTime varCabFecha = (DateTime)datFecha.EditValue;
                string varIteCodigo = ((clsComEntMercanciasRes)grvResumen.GetRow(grvResumen.FocusedRowHandle)).IteCodigo;
                string varIteNombre = ((clsComEntMercanciasRes)grvResumen.GetRow(grvResumen.FocusedRowHandle)).IteNombre;
                string varDetLote = this.txtLote.Text;
                decimal varDetCantidad = ((clsComEntMercanciasRes)grvResumen.GetRow(grvResumen.FocusedRowHandle)).DetCantidad;
                int varNroImpresion = ((clsComEntMercanciasRes)grvResumen.GetRow(grvResumen.FocusedRowHandle)).DetNro;
                int varAuxCodigoBarra = clsComEntMercanciasCab.funRecuperarCodigoBarra(varDocNombre, varCabNumero, varIteCodigo);
                int varCodigoBarra = 0;
                if (varAuxCodigoBarra > 0) varCodigoBarra = varAuxCodigoBarra;
                else varCodigoBarra = clsComCodigoBarraRep.funMantenimiento(varDocNombre, varCabNumero, varCabFecha, varPrvCodigo, varPrvNombre, varIteCodigo, varIteNombre, varDetLote, varDetCantidad);
                crtEtiquetaCarnesBPM objImpresionEtiquetaBPM = new crtEtiquetaCarnesBPM();
                DataTable dtValoresEtiqueta = clsComEntMercanciasCab.funImprimirEtiquetaBPM(varCodigoBarra);
                objImpresionEtiquetaBPM.SetDataSource(dtValoresEtiqueta);
                objImpresionEtiquetaBPM.PrintOptions.PrinterName = ConfigurationManager.AppSettings["ImpresoraEtiqueta"];
                objImpresionEtiquetaBPM.PrintToPrinter(varNroImpresion, false, 0, 1);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
