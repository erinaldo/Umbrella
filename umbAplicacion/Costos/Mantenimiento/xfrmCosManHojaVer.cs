using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using umbAplicacion.Inventario.Listado;
using umbNegocio;
using umbNegocio.Inventario;
using umbNegocio.Produccion;
using Umbrella;
using umbNegocio.Costos;
using umbNegocio.Seguridad;

namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManHojaVer : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        class clsGastos
        {
            public int varCodVariante { get; set; }
            public decimal varCantGasto { get; set; }

            public clsGastos(int varCodigo, decimal varCantidad) { varCodVariante = varCodigo; varCantGasto = varCantidad; }
        }

        public int varCabCodigo;
        public int varPrsCodigo;
        
        public bool varCabRuta = false;
        public bool varCabProfundizar = false;

        private DataTable dtHojaCosto;
        private List<clsGastos> lstGastos = new List<clsGastos>();

        public xfrmCosManHojaVer()
        {
            InitializeComponent();
        }
        public xfrmCosManHojaVer(int varFormulario, int varOperacion, int varRegistro)
        {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            try
            {
                this.Text = "Hoja de costos";
                this.lueCosto.Properties.DataSource = clsDiccionario.Listar("COSHOJCOSTO");
                this.lueArea.Properties.DataSource = clsDiccionario.Listar("PROFORMULACION");
                this.luePrecosteo.Properties.DataSource = clsDiccionario.Listar("COSPRECOSTEO");
                this.cmbVariante.Properties.Items.Clear();

                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar

                        DataTable dtDocumentos = clsSegAccFormulario.funListarDtDocumento(clsVariablesGlobales.varCodUsuario, varForCodigo, varOpeCodigo);

                        var frmFormulario = new frmAccDocumento(dtDocumentos) { StartPosition = FormStartPosition.CenterParent };
                        frmFormulario.ShowDialog();

                        if (frmFormulario.DrVarFila == null) { this.btnCancelar.PerformClick(); return; }

                        this.txtCodSerie.EditValue = varDocCodigo = int.Parse(((DataRowView)frmFormulario.DrVarFila)["DocCodigo"].ToString());
                        this.txtNomSerie.Text = varDocNombre =  ((DataRowView)frmFormulario.DrVarFila)["DocNombre"].ToString();

                        this.lueCosto.ItemIndex = 0;
                        this.luePrecosteo.ItemIndex = 0;
                        this.datFecha.DateTime = DateTime.Now;
                        this.txtCodEscenario.Text = "0";
                        this.txtNomEscenario.Text = "ESCENARIO ACTUAL";
                        this.chkRuta.Checked = true;
                        break;
                //    case 2: //Opcion 2 para la operacion de modificar
                //        var csFormulario = new clsProFormulacion();
                //        foreach (clsProFormulacion csRegistro in csFormulario.funListar(varRegCodigo))
                //        {
                //            this.txtCodigo.Text = varRegCodigo.ToString();
                //            this.bedItem.Text = csRegistro.IteCodigo;
                //            this.txtNombre.Text = csRegistro.IteNombre;
                //            this.lueArea.EditValue = csRegistro.CabArea;
                //            this.cmbVariante.Text = csRegistro.CabVariante;
                //            this.chkProfundizar.Checked = csRegistro.CabProfundizar;
                //            this.chkRendimiento.Checked = csRegistro.CabRendimiento;
                //            this.memObservacion.Text = csRegistro.CabObservacion;

                //            foreach (clsInvItem csItem in lisItem.funListar(csRegistro.IteCodigo))
                //            {
                //                this.txtGrupo.Text = csItem.ItmsGrpNam;
                //                this.txtUndInventario.Text = csItem.InvntryUom;
                //                this.txtUndVenta.Text = csItem.SalUnitMsr;
                //                this.txtPsoStdVenta.Text = csItem.SWeight1.ToString();
                //            }

                //            int varFila = 0;


                //            foreach (DataRow drMaterial in csFormulario.funListarMaterial(csRegistro.CabCodigo).Rows) { this.proAñadirDtMateriales(int.Parse(drMaterial["DetLinea"].ToString()), drMaterial["CabVariante"].ToString(), drMaterial["IteCodigo"].ToString(), drMaterial["IteNombre"].ToString(), drMaterial["IteUndInventario"].ToString(), decimal.Parse(drMaterial["DetCantidad"].ToString()), decimal.Parse(drMaterial["DetCantidadPor"].ToString()), decimal.Parse(drMaterial["DetPorcentaje"].ToString()), drMaterial["DetTipo"].ToString()); }
                //            varFila = (dtMateriales.Compute("Max(DfmLinea)", "") == DBNull.Value ? 0 : int.Parse(dtMateriales.Compute("Max(DfmLinea)", "").ToString())) + 1;
                //            if (dtMateriales.Rows.Count.Equals(0)) this.dtMateriales.Rows.Add(varFila, this.cmbVariante.Text, "", "", "", 0, 0);

                //            foreach (DataRow drRuta in csFormulario.funListarRuta(csRegistro.CabCodigo).Rows) { this.proAñadirDtRuta(int.Parse(drRuta["DetLinea"].ToString()), drRuta["CabVariante"].ToString(), drRuta["OprCodigo"].ToString(), drRuta["OprNombre"].ToString(), drRuta["RecCodigo"].ToString(), drRuta["RecNombre"].ToString(), decimal.Parse(drRuta["DetTiempo"].ToString()), decimal.Parse(drRuta["DetTiempoPor"].ToString())); }
                //            varFila = (dtRuta.Compute("Max(DfrLinea)", "") == DBNull.Value ? 0 : int.Parse(dtRuta.Compute("Max(DfrLinea)", "").ToString())) + 1;
                //            if (dtRuta.Rows.Count.Equals(0)) this.dtRuta.Rows.Add(varFila, this.cmbVariante.Text, "", "", "", 0, 0);

                //            foreach (DataRow drMerma in csFormulario.funListarMerma(csRegistro.CabCodigo).Rows) { this.proAñadirDtMerma(int.Parse(drMerma["DetLinea"].ToString()), drMerma["CabVariante"].ToString(), int.Parse(drMerma["MerCodigo"].ToString()), decimal.Parse(drMerma["DetPorcentaje"].ToString()), drMerma["DetTipo"] == DBNull.Value ? "" : drMerma["DetTipo"].ToString()); }
                //            varFila = (dtMerma.Compute("Max(DfeLinea)", "") == DBNull.Value ? 0 : int.Parse(dtMerma.Compute("Max(DfeLinea)", "").ToString())) + 1;
                //            if (dtMerma.Rows.Count.Equals(0)) this.dtMerma.Rows.Add(varFila, this.cmbVariante.Text, 0, 0, "");
                //        }
                //        break;
                //    default:
                //        break;
                }
                var csValidaciones = new clsValidacionesControles();
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo , varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                var csRegistro = new clsCosHojVertical()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    CabCodigoFrm = varPrsCodigo,
                    CabVarianteFrm = this.cmbVariante.Text.Equals("") ? "" : this.cmbVariante.Text,
                    CabFecha = (DateTime)this.datFecha.EditValue,
                    CabPrecosteo = this.luePrecosteo.EditValue.ToString().Equals("") ? 0 : int.Parse(this.luePrecosteo.EditValue.ToString()),
                    EscCodigo = this.txtCodEscenario.Text.Equals("") ? 0 : int.Parse(this.txtCodEscenario.Text),
                    IteCodigo = this.bedItem.Text,
                    IteNombre = this.txtNombre.Text,
                    IteNueCodigo = this.txtNueItem.Text,
                    IteNueNombre = this.txtNueNombre.Text,
                    CabTipoCosto = int.Parse(this.lueCosto.EditValue.ToString()),
                    CabTotMatPrima = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 100").ToString()),
                    CabTotEmpPrimario = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 200").ToString()),
                    CabTotEmpSecundario = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 300").ToString()),
                    CabTotProcesosMOD = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 400").ToString()),
                    CabTotGstIndFabricacion = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 600").ToString()),
                    CabTotCstProduccion = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 700").ToString()),
                    CabTotGstAdmVta = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 800").ToString()),
                    CabTotCstKilo = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 900").ToString()),
                    CabTotCstPresentacion = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 1000").ToString()),
                    CabTotPrcBase = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 1101").ToString()),
                    CabTotPrcSugPVD = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 1102").ToString()),
                    CabTotPrcSugPVP = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetSecuencia = 1103").ToString()),
                    CabObservacion = this.memObservacion.Text,
                    CabRuta = this.chkRuta.Checked,
                    EstCodigo = "Nor",
                    DetHojCstVertical = dtHojaCosto
                };

                int varCodigo = 0;

                switch (varOpeCodigo)
                {
                    case 1:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show(string.Format("Registro ingresado con el nro: {0}", varCodigo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                    case 2:
                        varCodigo = csRegistro.funMantenimiento(csRegistro, varOpeCodigo);
                        XtraMessageBox.Show("Registro ha sido actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bedItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (xfrmInvLisProducto frmFormulario = new xfrmInvLisProducto(true))
                {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null) this.bedItem.Text = ((clsInvItem)frmFormulario.DrVarFila[0]).ItemCode;
                    else bedItem.Text = "";
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void bedItem_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string varItemCode = this.bedItem.Text.Trim();

                if (varItemCode.Length < 8) { proLimpiarItem(); return; }
                
                proLimpiarItem();
                
                foreach (clsInvItem csRegistro in clsInvItem.funListar(varItemCode))
                {
                    this.txtNombre.Text = csRegistro.ItemName;
                    this.txtGrupo.Text = csRegistro.ItmsGrpNam;
                    this.txtUndInventario.Text = csRegistro.InvntryUom;
                    this.txtUndVenta.Text = csRegistro.SalUnitMsr;
                    this.txtPsoStdVenta.Text = csRegistro.SWeight1.ToString();
                    this.txtCantKilo.EditValue = 1;
                    this.txtCantPresentacion.EditValue = decimal.Round(csRegistro.SWeight1, 4);

                    this.cmbVariante.Properties.Items.Clear();
                    foreach (DataRow drFormulacion in clsProFormulacion.funListarVariante(varItemCode).Rows) this.cmbVariante.Properties.Items.Add(drFormulacion["CabVariante"].ToString());
                    this.cmbVariante.SelectedIndex = 0;
                    foreach (clsProFormulacion csFormulacion in clsProFormulacion.funListar(string.Format("Where a.IteCodigo = '{0}' and a.CabVariante = '{1}'",varItemCode, this.cmbVariante.Text)))
                    {
                        varCabCodigo = csFormulacion.CabCodigo;
                        varCabRuta = this.chkRuta.Checked;
                        varCabProfundizar = csFormulacion.CabProfundizar;
                        varPrsCodigo = csFormulacion.PrsCodigo;
                        lueArea.EditValue = csFormulacion.CabArea;
                    }
                }
                
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                this.proDtHojaCosto();
                this.lstGastos.Clear();

                string varIteCodigo = this.bedItem.Text.Trim();
                string varIteUndInventario = this.txtUndInventario.Text.Trim();

                decimal varItePsoStandar = decimal.Parse(this.txtPsoStdVenta.Text);
                decimal varCantKilo = decimal.Parse(this.txtCantKilo.Text);
                decimal varCantPresentacion = decimal.Parse(this.txtCantPresentacion.Text);

                decimal varCantidad = varIteUndInventario.ToLower().Equals("unidad") ? decimal.Round(varCantKilo / varItePsoStandar, 6) : varCantKilo;
                
                //proCalculoMODCIF(varPrsCodigo);
                lstGastos.Add(new clsGastos(varCabCodigo, varCantidad));

                foreach (DataRow drMateriales in clsProFormulacion.funListarMaterial(varCabCodigo).Rows) proCalculoHojaCosto(drMateriales, varCantidad, varCabProfundizar, varPrsCodigo);

                decimal varAuxCantidad = 0;
                int varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 100").ToString()) + 1;
                int varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 100").ToString()) + 1;
                decimal varDetCantidad = varAuxCantidad = decimal.Parse(this.dtHojaCosto.Compute("Sum(DetCantidad)", "DetPadre = 100").ToString());
                decimal varDetTotal =  decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetPadre = 100").ToString()), 4);
                decimal varAuxDetTotal = 0;
                
                //CALCULO DE TOTALES Y MERMAS DE MATERIA PRIMA
                dtHojaCosto.Rows.Add(varDetSecuencia, 100, "", "", "", "SUB-TOTAL MATERIA PRIMA E INSUMOS", "", 0, 0, varDetCantidad, 0, varDetTotal, 0, varDetOrden, "SN");

                foreach (DataRow drMerma in clsProFormulacion.funListarMerma(varCabCodigo).Select("DetTipo = 'I'"))
                {
                    varDetSecuencia++;
                    varDetOrden++;
                    varDetCantidad = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Max(DetCantidad)", "DetPadre = 100 And IteNombre = 'SUB-TOTAL MATERIA PRIMA E INSUMOS'").ToString()) * (decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100), 6);
                    dtHojaCosto.Rows.Add(varDetSecuencia, 100, "", "", drMerma["MerCodigo"].ToString(), drMerma["MerNombre"].ToString().ToUpper(), "", decimal.Round( decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100, 4), 0,  varDetCantidad, 0, 0, 0, varDetOrden, "N");
                    varAuxDetTotal = varAuxDetTotal + varDetCantidad;
                }

                varDetSecuencia++;
                varDetOrden++;
                varDetCantidad = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Max(DetCantidad)", "DetPadre = 100 And IteNombre = 'SUB-TOTAL MATERIA PRIMA E INSUMOS'").ToString()) + varAuxDetTotal, 6);
                varDetTotal = varAuxCantidad != varDetCantidad ? decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Max(DetTotal)", "DetPadre = 100 And IteNombre = 'SUB-TOTAL MATERIA PRIMA E INSUMOS'").ToString()) / varDetCantidad, 4) : decimal.Parse(this.dtHojaCosto.Compute("Max(DetTotal)", "DetPadre = 100 And IteNombre = 'SUB-TOTAL MATERIA PRIMA E INSUMOS'").ToString());
                dtHojaCosto.Rows.Add(varDetSecuencia, 100, "", "", "","TOTAL MATERIA PRIMA E INSUMOS", "", 0, 0, varDetCantidad, 0, varDetTotal, 0, varDetOrden, "SN");

                //CALCULO DE TOTALES Y MERMAS DE EMPAQUES PRIMARIOS
                varDetSecuencia =  int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 200").ToString()) + 1;
                varDetOrden =  int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 200").ToString()) + 1;
                varDetCantidad = 0;
                varDetTotal = 0;
                //dtHojaCosto.Rows.Add(varDetSecuencia, 200, "", "", "", "SUB-TOTAL EMPAQUE PRIMARIO", "", 0, 0, varDetCantidad, 0, varDetTotal, 0, varDetOrden, "SN");

                varAuxDetTotal = 0;

                foreach (DataRow drMerma in clsProFormulacion.funListarMerma(varCabCodigo).Select("DetTipo = 'P'"))
                {
                    varDetSecuencia++;
                    varDetOrden++;
                    varDetTotal = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Max(DetTotal)", "DetPadre = 200 And IteNombre = 'SUB-TOTAL EMPAQUE PRIMARIO'").ToString()) * (decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100), 4);
                    dtHojaCosto.Rows.Add(varDetSecuencia, 200, "", "", drMerma["MerCodigo"].ToString(), drMerma["MerNombre"].ToString().ToUpper(), "", decimal.Round(decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100, 4), 0, 0, 0,  varDetTotal, 0, varDetOrden, "N");
                    varAuxDetTotal = varAuxDetTotal + varDetTotal;
                }

                varDetSecuencia++;
                varDetOrden++;
                varDetTotal = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetPadre = 200").ToString()) + varAuxDetTotal, 4);
                dtHojaCosto.Rows.Add(varDetSecuencia, 200, "", "", "", "TOTAL EMPAQUE PRIMARIO", "", 0, 0, 0, 0, varDetTotal, 0, varDetOrden, "SN");

                //CALCULO DE TOTALES Y MERMAS DE EMPAQUES SECUNDARIO
                varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 300").ToString()) + 1;
                varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 300").ToString()) + 1;
                varDetCantidad = 0;
                varDetTotal = 0;
                //dtHojaCosto.Rows.Add(varDetSecuencia, 300, "", "", "", "SUB-TOTAL EMPAQUE SECUNDARIO", "", 0, 0, varDetCantidad, 0, varDetTotal, 0, varDetOrden, "SN");

                varAuxDetTotal = 0;

                foreach (DataRow drMerma in clsProFormulacion.funListarMerma(varCabCodigo).Select("DetTipo = 'S'"))
                {
                    varDetSecuencia++;
                    varDetOrden++;
                    varDetTotal = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Max(DetTotal)", "DetPadre = 300 And IteNombre = 'SUB-TOTAL EMPAQUE SECUNDARIO'").ToString()) * (decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100), 4);
                    dtHojaCosto.Rows.Add(varDetSecuencia, 300, "", "", drMerma["MerCodigo"].ToString(), drMerma["MerNombre"].ToString().ToUpper(), "", decimal.Round(decimal.Parse(drMerma["DetPorcentaje"].ToString()) / 100, 4), 0, 0, 0, varDetTotal, 0, varDetOrden, "N");
                    varAuxDetTotal = varAuxDetTotal + varDetTotal;
                }

                varDetSecuencia++;
                varDetOrden++;
                varDetTotal = decimal.Round(decimal.Parse(this.dtHojaCosto.Compute("Sum(DetTotal)", "DetPadre = 300").ToString()) + varAuxDetTotal, 4);
                dtHojaCosto.Rows.Add(varDetSecuencia, 300, "", "", "", "TOTAL EMPAQUE SECUNDARIO", "", 0, 0, 0, 0, varDetTotal, 0, varDetOrden, "SN");
                
                DataRow[] drSubtotal;
                //CALCULO DE GASTOS DE MANO DE OBRA Y GIF
                proCalculoMODCIF();

                // CALCULO DE MANO DE OBRA
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 400");
                drSubtotal[0]["DetTotal"] = dtHojaCosto.Compute("Sum(DetTotal)", "(DetSecuencia >= 401 and DetSecuencia <= 499) and (IteCodigo >= '1' and IteCodigo<= '99')") == DBNull.Value ? 0 : decimal.Parse(dtHojaCosto.Compute("Sum(Isnull(DetTotal, 0))", "(DetSecuencia >= 401 and DetSecuencia <= 499) and (IteCodigo >= '1' and IteCodigo<= '99')").ToString());
                dtHojaCosto.AcceptChanges();

                // CALCULO DE GASTOS DE FABRICACION
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 600");
                drSubtotal[0]["DetTotal"] = dtHojaCosto.Compute("Sum(DetTotal)", "(DetSecuencia >= 601 and DetSecuencia <= 699) and (IteCodigo >= '1' and IteCodigo<= '99')") == DBNull.Value ? 0 : decimal.Parse(dtHojaCosto.Compute("Sum(DetTotal)", "(DetSecuencia >= 601 and DetSecuencia <= 699) and (IteCodigo >= '1' and IteCodigo<= '99')").ToString());
                dtHojaCosto.AcceptChanges();

               
                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL MATERIA PRIMA E INSUMOS'").ToString()) + 
                                         decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL EMPAQUE PRIMARIO'").ToString()) + 
                                         decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL EMPAQUE SECUNDARIO'").ToString()) + 
                                         decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL PROCESOS - MOD'").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 500");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

              

                // CALCULO DEL COSTO DE PRODUCCION
                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 500").ToString()) +
                                         decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 600").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 700");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                // CALCULO DE GASTOS OPERACIONALES
                foreach (clsProRutaStd drRuta in clsProRutaStd.funListar(varPrsCodigo))
                {
                    varDetTotal = decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 700").ToString()) *
                                        (drRuta.PrsGstOperacional / 100), 4);
                    drSubtotal = dtHojaCosto.Select("DetSecuencia = 800");
                    drSubtotal[0]["DetTotal"] = varDetTotal;
                    drSubtotal[0]["IteNombre"] = string.Format("GASTOS DE ADMINISTRACION Y VENTAS {0}%", decimal.Round(drRuta.PrsGstOperacional, 2));
                    dtHojaCosto.AcceptChanges();
                }
               
                // CALCULO DE COSTO TOTAL KILO
                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 700").ToString()) +
                                         decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 800").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 900");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                // CALCULO DEL COSTO DE PRESENTACION
                varDetTotal = decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 900").ToString()) *
                                                                  (this.txtUndVenta.Text.ToLower().Equals("kilo") ? 1 : decimal.Parse(this.txtCantPresentacion.Text)), 4);
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 1000");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                // CALCULO DE LOS PRECIOS SUGERIDOS PVD Y PVP
                varDetTotal = decimal.Round(decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 1000").ToString()), 2) / (decimal)0.90, 2);
                dtHojaCosto.Rows.Add(1101, 1100, "", "MARGEN 10%", "", "PRECIO SUGERIDO (BASE)", "", 0, 0, 0, 0, varDetTotal, 0, 1101, "SN");
                varDetTotal = decimal.Round(decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 1101").ToString()), 2) / (decimal)0.82, 2);
                dtHojaCosto.Rows.Add(1102, 1100, "", "MARGEN 18%", "", "PRECIO SUGERIDO (P.V.D.)", "", 0, 0, 0, 0, varDetTotal, 0, 1102, "SR");
                varDetTotal = decimal.Round(decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 1102").ToString()), 2) / (decimal)0.80, 2);
                dtHojaCosto.Rows.Add(1103, 1100, "", "MARGEN 20%", "", "PRECIO SUGERIDO (P.V.P.)", "", 0, 0, 0, 0, varDetTotal, 0, 1103, "SR");

                // CALCULO DE LOS PRECIOS SUGERIDOS DE PRESENTACION
                varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 1100").ToString());
                varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 1100").ToString());
                foreach (DataRow drPrecio in clsDiccionario.Listar("PRECIOSHC").Rows)
                {
                    varDetTotal = clsInvItem.funPrecioItem(varIteCodigo, int.Parse(drPrecio["Codigo"].ToString()));
                    dtHojaCosto.Rows.Add(++varDetSecuencia, 1100, "", "", drPrecio["Codigo"].ToString(), "PRECIO ACTUAL (P.V.D.) " + drPrecio["Descripcion"], "", 0, 0, 0, 0, varDetTotal, 0, ++varDetOrden, "SN");
                }

                varDetCantidad = decimal.Parse(dtHojaCosto.Compute("Max(DetCantidad)", "IteNombre = 'TOTAL MATERIA PRIMA E INSUMOS'").ToString());
                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL MATERIA PRIMA E INSUMOS'").ToString()) ;
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 100");
                drSubtotal[0]["DetCantidad"] = varDetCantidad;
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL EMPAQUE PRIMARIO'").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 200");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL EMPAQUE SECUNDARIO'").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 300");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "IteNombre = 'TOTAL PROCESOS - MOD'").ToString());
                drSubtotal = dtHojaCosto.Select("DetSecuencia = 400");
                drSubtotal[0]["DetTotal"] = varDetTotal;
                dtHojaCosto.AcceptChanges();

                

                this.proCalculoPorcentaje();
                this.dtHojaCosto.DefaultView.Sort = "DetOrden Asc, DetCantidad Desc";
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void cmbVariante_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (clsProFormulacion csFormulacion in clsProFormulacion.funListar(string.Format("Where a.IteCodigo = '{0}' and a.CabVariante = '{1}'",this.bedItem.Text.Trim(), this.cmbVariante.Text)))
                {
                    varCabCodigo = csFormulacion.CabCodigo;
                    varCabRuta = this.chkRuta.Checked;
                    varCabProfundizar = csFormulacion.CabProfundizar;
                    varPrsCodigo = csFormulacion.PrsCodigo;
                    lueArea.EditValue = csFormulacion.CabArea;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void treListado_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.treListado.FocusedColumn.Equals(treDetTotal))
                {
                    object varNombre = this.treListado.FocusedNode[treIteNombre];
                    if (varNombre.ToString().Equals("PRECIO ACTUAL (P.V.D.)") || varNombre.ToString().Equals("PRECIO APROBADO (P.V.D.)") || varNombre.ToString().Equals("PRECIO APROBADO (P.V.P.)"))
                        this.treDetTotal.OptionsColumn.ReadOnly = false;
                    else
                        this.treDetTotal.OptionsColumn.ReadOnly = true;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void proCalculoHojaCosto(DataRow drFila, decimal varCantidad, bool varProfundizar, int varCodRutaStd)
        {
            try
            {
                int varCabCodigoHijo = 0;
                
                decimal varDetCantNueva = 0;
                DataTable dtVariante = null;

                if (varProfundizar) dtVariante = clsProFormulacion.funListarVariante(drFila["IteCodigo"].ToString());

                if (dtVariante == null) this.proIngDetHojaCosto(drFila, drFila["IteCodigo"].ToString(), varCantidad);
                else if (dtVariante.Rows.Count.Equals(1))
                {
                    //PARA EL CALCULO DE PROCESOS DE MOD
                    
                    varCabCodigoHijo = int.Parse(dtVariante.Rows[0]["CabCodigo"].ToString());
                    varProfundizar = bool.Parse(dtVariante.Rows[0]["CabProfundizar"].ToString());
                    varDetCantNueva = (decimal.Parse(drFila["DetCantidadPor"].ToString()).Equals(0) ? 0 : decimal.Round(((decimal.Parse(drFila["DetCantidad"].ToString()) * varCantidad) / decimal.Parse(drFila["DetCantidadPor"].ToString())), 6));
                    //varCodRutaStd = int.Parse(dtVariante.Rows[0]["PrsCodigo"].ToString());
                    //proCalculoMODCIF(varCodRutaStd);
                    this.lstGastos.Add(new clsGastos(varCabCodigoHijo, varDetCantNueva));
                    foreach (DataRow drMateriales in clsProFormulacion.funListarMaterial(varCabCodigoHijo).Rows) proCalculoHojaCosto(drMateriales, varDetCantNueva, varProfundizar, varCodRutaStd);
                }
                else if (dtVariante.Rows.Count > 1)
                {
                    var frmFormulario = new frmAccVariante(dtVariante) { StartPosition = FormStartPosition.CenterParent };
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null)
                    {
                        varCabCodigoHijo = int.Parse(((DataRowView)frmFormulario.DrVarFila)["CabCodigo"].ToString());
                        varDetCantNueva = (decimal.Parse(drFila["DetCantidadPor"].ToString()).Equals(0) ? 0 : decimal.Round(((decimal.Parse(drFila["DetCantidad"].ToString()) * varCantidad) / decimal.Parse(drFila["DetCantidadPor"].ToString())), 6));
                        varProfundizar = bool.Parse(((DataRowView)frmFormulario.DrVarFila)["CabProfundizar"].ToString());
                        //varCodRutaStd = int.Parse(((DataRowView)frmFormulario.DrVarFila)["PrsCodigo"].ToString());
                        //proCalculoMODCIF(varCodRutaStd);
                        this.lstGastos.Add(new clsGastos(varCabCodigoHijo, varDetCantNueva));
                        foreach (DataRow drMateriales in clsProFormulacion.funListarMaterial(varCabCodigoHijo).Rows) proCalculoHojaCosto(drMateriales, varDetCantNueva, varProfundizar, varCodRutaStd);
                    }
                }
                else this.proIngDetHojaCosto(drFila, drFila["IteCodigo"].ToString(), varCantidad);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proCalculoMODCIF()
        {
            try
            {
                foreach (clsGastos csGasto in lstGastos)
                {
                    foreach (clsProFormulacion csFormula in clsProFormulacion.funListar(string.Format("Where a.CabVariante = '{0}'",csGasto.varCodVariante)))
                    {
                        int varCuantos = 0;
                        int varDetSecuencia = 0;
                        int varDetOrden = 0;
                        decimal varDetCantidad = 0;
                        decimal varDetTotal = 0;
                        DataRow[] drSubtotal;

                        foreach (clsProRutaStd drRuta in clsProRutaStd.funListar(csFormula.PrsCodigo))
                        {
                            if (this.chkRuta.Checked)
                            {
                                varCuantos = this.dtHojaCosto.Select(string.Format("DetPadre = 400 and IteCodigo = '{0}'", drRuta.PrsCodigo)).Length;
                                if (varCuantos.Equals(0))
                                {
                                    varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 400").ToString()) + 1;
                                    varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 400").ToString()) + 1;
                                    
                                    varDetCantidad = decimal.Parse(this.txtCantKilo.Text);
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsManoObra, 4);
                                    dtHojaCosto.Rows.Add(varDetSecuencia, 400, "", "", drRuta.PrsCodigo, drRuta.PrsNombre.ToUpper(), "$/Kg", 0, 0, varDetCantidad, drRuta.PrsManoObra, varDetTotal, 0, varDetOrden, "A");

                                    varDetCantidad = decimal.Parse(this.txtCantKilo.Text);
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsCstFabricacion, 4);
                                    dtHojaCosto.Rows.Add(varDetSecuencia + 200, 600, "", "", drRuta.PrsCodigo, drRuta.PrsNombre.ToUpper(), "$/Kg", 0, 0, varDetCantidad, drRuta.PrsCstFabricacion, varDetTotal, 0, varDetOrden + 200, "A");
                                }
                                else
                                {
                                    DataRow[] drFila = this.dtHojaCosto.Select(string.Format("DetPadre = 400 and IteCodigo = '{0}'", drRuta.PrsCodigo));
                                    varDetCantidad = decimal.Parse(drFila[0]["DetCantidad"].ToString()) + decimal.Parse(this.txtCantKilo.Text);
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsManoObra, 4);
                                    drFila[0]["DetCantidad"] = varDetCantidad;
                                    drFila[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();

                                    drFila = this.dtHojaCosto.Select(string.Format("DetPadre = 600 and IteCodigo = '{0}'", drRuta.PrsCodigo));
                                    varDetCantidad = decimal.Parse(drFila[0]["DetCantidad"].ToString()) + decimal.Parse(this.txtCantKilo.Text);
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsCstFabricacion, 4);
                                    drFila[0]["DetCantidad"] = varDetCantidad;
                                    drFila[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();
                                }
                            }
                            else
                            {
                                varCuantos = this.dtHojaCosto.Select(string.Format("DetPadre = 400 and IteCodigo = '{0}'", drRuta.PrsCodigo)).Length;
                                if (varCuantos.Equals(0))
                                {
                                    int i = 0;
                                    varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetSecuencia >= 400 and DetSecuencia <= 499").ToString()) + 1;
                                    varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetPadre = 400").ToString()) + 1;
                                    foreach (DataRow drRutaProceso in clsProFormulacion.funListarRuta(csGasto.varCodVariante).Rows)
                                    {
                                        if (i.Equals(0))
                                        {
                                            i++;
                                            dtHojaCosto.Rows.Add(varDetSecuencia, 400, "", "", drRuta.PrsCodigo, drRuta.PrsNombre.ToUpper(), "$/min", 0, 0, 0, 0, 0, 0, varDetOrden, "A");

                                            varDetCantidad = decimal.Round((csGasto.varCantGasto * decimal.Parse(drRutaProceso["DetTiempo"].ToString())) / decimal.Parse(drRutaProceso["DetTiempoPor"].ToString()), 4);
                                            varDetTotal = decimal.Round(varDetCantidad * decimal.Round(decimal.Parse(drRutaProceso["RecManObra"].ToString()) / 60, 4), 4);
                                            dtHojaCosto.Rows.Add(varDetSecuencia + i, varDetSecuencia, "", "", drRutaProceso["OprCodigo"],
                                                                                       drRutaProceso["OprNombre"].ToString().ToUpper() + " - " + drRutaProceso["RecNombre"].ToString().ToUpper(),
                                                                                       "$/min", 0, 0, varDetCantidad, decimal.Round(decimal.Parse(drRutaProceso["RecManObra"].ToString()) / 60, 4), varDetTotal, 0, ++varDetOrden, "A");

                                            dtHojaCosto.Rows.Add(varDetSecuencia + 200, 600, "", "", drRuta.PrsCodigo, drRuta.PrsNombre.ToUpper(), "$/min", 0, 0, 0, 0, 0, 0, varDetOrden, "A");

                                            varDetCantidad = decimal.Round((csGasto.varCantGasto * decimal.Parse(drRutaProceso["DetTiempo"].ToString())) / decimal.Parse(drRutaProceso["DetTiempoPor"].ToString()), 4);
                                            varDetTotal = decimal.Round(varDetCantidad * decimal.Round(decimal.Parse(drRutaProceso["RecGstFabricacion"].ToString()) / 60, 4), 4);
                                            dtHojaCosto.Rows.Add((varDetSecuencia + 200) + i, varDetSecuencia + 200, "", "", drRutaProceso["OprCodigo"],
                                                                                       drRutaProceso["OprNombre"].ToString().ToUpper() + " - " + drRutaProceso["RecNombre"].ToString().ToUpper(),
                                                                                       "$/min", 0, 0, varDetCantidad, decimal.Round(decimal.Parse(drRutaProceso["RecGstFabricacion"].ToString()) / 60, 4), varDetTotal, 0, ++varDetOrden + 200, "A");
                                        }
                                        else
                                        {
                                            i++;
                                            varDetCantidad = decimal.Round((csGasto.varCantGasto * decimal.Parse(drRutaProceso["DetTiempo"].ToString())) / decimal.Parse(drRutaProceso["DetTiempoPor"].ToString()), 4);
                                            varDetTotal = decimal.Round(varDetCantidad * decimal.Round(decimal.Parse(drRutaProceso["RecManObra"].ToString()) / 60, 4), 4);
                                            dtHojaCosto.Rows.Add(varDetSecuencia + i, varDetSecuencia, "", "", drRutaProceso["OprCodigo"],
                                                                                       drRutaProceso["OprNombre"].ToString().ToUpper() + " - " + drRutaProceso["RecNombre"].ToString().ToUpper(),
                                                                                       "$/min", 0, 0, varDetCantidad, decimal.Round(decimal.Parse(drRutaProceso["RecManObra"].ToString()) / 60, 4), varDetTotal, 0, ++varDetOrden, "A");

                                            varDetCantidad = decimal.Round((csGasto.varCantGasto * decimal.Parse(drRutaProceso["DetTiempo"].ToString())) / decimal.Parse(drRutaProceso["DetTiempoPor"].ToString()), 4);
                                            varDetTotal = decimal.Round(varDetCantidad * decimal.Round(decimal.Parse(drRutaProceso["RecGstFabricacion"].ToString()) / 60, 4), 4);
                                            dtHojaCosto.Rows.Add((varDetSecuencia + 200) + i, varDetSecuencia + 200, "", "", drRutaProceso["OprCodigo"],
                                                                                       drRutaProceso["OprNombre"].ToString().ToUpper() + " - " + drRutaProceso["RecNombre"].ToString().ToUpper(),
                                                                                       "$/min", 0, 0, varDetCantidad, decimal.Round(decimal.Parse(drRutaProceso["RecGstFabricacion"].ToString()) / 60, 4), varDetTotal, 0, ++varDetOrden + 200, "A");

                                        }
                                        
                                    }
                                    varDetCantidad = decimal.Parse(dtHojaCosto.Compute("Sum(DetCantidad)", string.Format("DetPadre = {0}", varDetSecuencia)).ToString());
                                    varDetTotal = decimal.Parse(dtHojaCosto.Compute("Sum(DetTotal)", string.Format("DetPadre = {0}", varDetSecuencia)).ToString());
                                    drSubtotal = dtHojaCosto.Select(string.Format("DetSecuencia = {0}", varDetSecuencia));
                                    drSubtotal[0]["DetCantidad"] = varDetCantidad;
                                    drSubtotal[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();

                                    varDetCantidad = decimal.Parse(dtHojaCosto.Compute("Sum(DetCantidad)", string.Format("DetPadre = {0}", varDetSecuencia + 200)).ToString());
                                    varDetTotal = decimal.Parse(dtHojaCosto.Compute("Sum(DetTotal)", string.Format("DetPadre = {0}", varDetSecuencia + 200)).ToString());
                                    drSubtotal = dtHojaCosto.Select(string.Format("DetSecuencia = {0}", varDetSecuencia + 200));
                                    drSubtotal[0]["DetCantidad"] = varDetCantidad;
                                    drSubtotal[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();
                                }
                            }
                        }
                    }
                }
                proCalculoMODCIFCarnes();
            }
            catch (Exception) { throw; }
        }
        private void proCalculoMODCIFCarnes()
        {
            try
            {
                int varCuantos = 0;
                int varDetSecuencia = 0;
                int varDetOrden = 0;
                decimal varDetCantidad = 0;
                decimal varDetTotal = 0;

                foreach (DataRow drFilaGst in dtHojaCosto.Select("DetPadre = 100"))
                {
                    List<clsInvItem> lstItem = clsInvItem.funListar(drFilaGst["IteCodigo"].ToString());
                    foreach (clsInvItem drItem in lstItem)
                    {
                        if (drItem.GstCarnicoHojaCst.Equals("S"))
                        {
                            foreach (clsProRutaStd drRuta in clsProRutaStd.funListar(1))
                            {
                                varCuantos = this.dtHojaCosto.Select(string.Format("DetPadre = 400 and IteCodigo = '{0}'", 1)).Length;

                                if (varCuantos.Equals(0))
                                {
                                    varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetSecuencia >=400 and DetSecuencia <= 499").ToString()) + 1;
                                    varDetOrden = int.Parse(dtHojaCosto.Compute("Max(DetOrden)", "DetSecuencia >=400 and DetSecuencia <= 499").ToString()) + 1;
                                    
                                    varDetCantidad = decimal.Parse(drFilaGst["DetCantidad"].ToString());
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsManoObra, 4);
                                    dtHojaCosto.Rows.Add(varDetSecuencia, 400, "", "", "1", drRuta.PrsNombre.ToUpper(), "$/Kg", 0, 0, varDetCantidad, drRuta.PrsManoObra, varDetTotal, 0, varDetOrden, "A");

                                    varDetCantidad = decimal.Parse(drFilaGst["DetCantidad"].ToString());
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsCstFabricacion, 4);
                                    dtHojaCosto.Rows.Add(varDetSecuencia + 200, 600, "", "", "1", drRuta.PrsNombre.ToUpper(), "$/Kg", 0, 0, varDetCantidad, drRuta.PrsCstFabricacion, varDetTotal, 0, varDetOrden + 200, "A");
                                }
                                else
                                {
                                    DataRow[] drFilaGstHoja = this.dtHojaCosto.Select(string.Format("DetPadre = 400 and IteCodigo = '{0}'", 1));
                                    varDetCantidad = decimal.Parse(drFilaGstHoja[0]["DetCantidad"].ToString()) + decimal.Parse(drFilaGst["DetCantidad"].ToString());
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsManoObra, 4);
                                    drFilaGstHoja[0]["DetCantidad"] = varDetCantidad;
                                    drFilaGstHoja[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();

                                    drFilaGstHoja = this.dtHojaCosto.Select(string.Format("DetPadre = 600 and IteCodigo = '{0}'", 1));
                                    varDetCantidad = decimal.Parse(drFilaGstHoja[0]["DetCantidad"].ToString()) + decimal.Parse(drFilaGst["DetCantidad"].ToString());
                                    varDetTotal = decimal.Round(varDetCantidad * drRuta.PrsCstFabricacion, 4);
                                    drFilaGstHoja[0]["DetCantidad"] = varDetCantidad;
                                    drFilaGstHoja[0]["DetTotal"] = varDetTotal;
                                    dtHojaCosto.AcceptChanges();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception) { throw; }
        }
        private void proCalculoPorcentaje()
        {
            try
            {
                decimal varDetTotal = decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 900").ToString());
                foreach (DataRow drFila in dtHojaCosto.Select("DetSecuencia < 1000")) drFila["DetPorcentaje"] = decimal.Round(decimal.Parse(drFila["DetTotal"].ToString()) / varDetTotal, 2);

                DataRow[] drPorcentaje;

                decimal varDetPorcentaje = decimal.Round(decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 1000").ToString()) / decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 900").ToString()), 2);
                drPorcentaje = dtHojaCosto.Select("DetSecuencia = 1000");
                drPorcentaje[0]["DetPorcentaje"] = varDetPorcentaje;

                drPorcentaje = dtHojaCosto.Select("DetSecuencia = 1101");
                drPorcentaje[0]["DetPorcentaje"] = (decimal)0.10; ;

                drPorcentaje = dtHojaCosto.Select("DetSecuencia = 1102");
                drPorcentaje[0]["DetPorcentaje"] = (decimal)0.18;

                drPorcentaje = dtHojaCosto.Select("DetSecuencia = 1103");
                drPorcentaje[0]["DetPorcentaje"] = (decimal)0.20;

                foreach (DataRow drFila in dtHojaCosto.Select("DetPadre = 1100 And DetPorcentaje = 0 And DetTotal > 0"))
                {
                    drFila["DetPorcentaje"] = ((decimal.Parse(drFila["DetTotal"].ToString()) -
                                                                   decimal.Parse(dtHojaCosto.Compute("Max(DetTotal)", "DetSecuencia = 1102").ToString()))) /
                                                                   decimal.Parse(drFila["DetTotal"].ToString());
                }

                this.dtHojaCosto.AcceptChanges();
            }
            catch (Exception) { throw; }
        }
        private void proDtHojaCosto()
        {
            dtHojaCosto = new DataTable { TableName = "Hoja" };
            dtHojaCosto.Columns.Add("DetSecuencia", typeof(int));
            dtHojaCosto.Columns.Add("DetPadre", typeof(int));
            dtHojaCosto.Columns.Add("GpiCodigo", typeof(string));
            dtHojaCosto.Columns.Add("GpiNombre", typeof(string));
            dtHojaCosto.Columns.Add("IteCodigo", typeof(string));
            dtHojaCosto.Columns.Add("IteNombre", typeof(string));
            dtHojaCosto.Columns.Add("IteUndInventario", typeof(string));
            dtHojaCosto.Columns.Add("DetMerma", typeof(decimal));
            dtHojaCosto.Columns.Add("DetCantEmp", typeof(decimal));
            dtHojaCosto.Columns.Add("DetCantidad", typeof(decimal));
            dtHojaCosto.Columns.Add("DetCosto", typeof(decimal));
            dtHojaCosto.Columns.Add("DetTotal", typeof(decimal));
            dtHojaCosto.Columns.Add("DetPorcentaje", typeof(decimal));
            dtHojaCosto.Columns.Add("DetOrden", typeof(int));
            dtHojaCosto.Columns.Add("DetColor", typeof(string));

            dtHojaCosto.Rows.Add(100, 100, "", "MATERIA PRIMA E INSUMOS", "", "TOTAL MATERIA PRIMA E INSUMOS", "", 0, 0, 0, 0, 0, 0, 100, "SR");
            dtHojaCosto.Rows.Add(200, 200, "", "MATERIAL DE EMPAQUE PRIMARIO", "", "TOTAL MATERIAL DE EMPAQUE PRIMARIO", "", 0, 0, 0, 0, 0, 0, 200, "SR");
            dtHojaCosto.Rows.Add(300, 300, "", "MATERIAL DE EMPAQUE SECUNDARIO", "", "TOTAL MATERIAL DE EMPAQUE SECUNDARIO", "", 0, 0, 0, 0, 0, 0, 300, "SR");
            dtHojaCosto.Rows.Add(400, 400, "", "PROCESOS - MOD", "", "TOTAL PROCESOS - MOD", "", 0, 0, 0, 0, 0, 0, 400, "SR");
            dtHojaCosto.Rows.Add(500, 500, "", "", "", "COSTO DIRECTO", "", 0, 0, 0, 0, 0, 0, 500, "SR");
            dtHojaCosto.Rows.Add(600, 600, "", "GASTOS INDIRECTOS DE FABRICACION", "", "TOTAL GASTOS INDIRECTOS DE FABRICACION", "", 0, 0, 0, 0, 0, 0, 600, "SA");
            dtHojaCosto.Rows.Add(700, 700, "", "", "", "COSTO DE PRODUCCION", "", 0, 0, 0, 0, 0, 0, 700, "SR");
            dtHojaCosto.Rows.Add(800, 800, "", "", "", "GASTOS DE ADMINISTRACION Y VENTAS", "", 0, 0, 0, 0, 0, 0, 800, "SA");
            dtHojaCosto.Rows.Add(900, 900, "", "", "", "COSTO TOTAL KILO", "", 0, 0, 0, 0, 0, 0, 900, "SR");
            dtHojaCosto.Rows.Add(1000, 1000, "", "", "", "COSTO TOTAL PRESENTACION", "", 0, 0, 0, 0, 0, 0, 1000, "SR");
            dtHojaCosto.Rows.Add(1100, 1100, "", "PRECIOS SUGERIDOS PRESENTACION", "", "", "", 0, 0, 0, 0, 0, 0, 1100, "SR");

            this.treListado.KeyFieldName = "DetSecuencia";
            this.treListado.ParentFieldName = "DetPadre";
            this.treListado.DataSource = dtHojaCosto;
        }
        private void proIngDetHojaCosto(DataRow drFila, string varIteCodigo, decimal varCantidad)
        {
            try
            {
                int varCuantos = int.Parse(this.dtHojaCosto.Compute("Count(IteCodigo)", string.Format("IteCodigo = '{0}'", varIteCodigo)).ToString());
                int varDetSecuencia = 0;
                int varDetPadre = 0;
                decimal varDetCosto = 0;
                decimal varDetCantidad = 0;
                decimal varDetCantNueva = 0;
                decimal varDetMerma = 0;
                decimal varDetTotal =0;

                List<clsInvItem> lstItem = clsInvItem.funListar(varIteCodigo);
                foreach (clsInvItem drItem in lstItem)
                {
                    if (this.lueCosto.EditValue.Equals("1")) varDetCosto = drItem.AvgReferencial;
                    else if (this.lueCosto.EditValue.Equals("2")) varDetCosto = drItem.AvgReferencialProyec;
                    if (varCuantos.Equals(0))
                    {
                        varDetMerma = decimal.Round(decimal.Parse(drFila["DetPorcentaje"].ToString()) / 100,2);
                        if (varDetMerma > 0) varDetCantidad = (decimal.Parse(drFila["DetCantidadPor"].ToString()).Equals(0) ? 0 : decimal.Round(((decimal.Parse(drFila["DetCantidad"].ToString()) * varCantidad) / decimal.Parse(drFila["DetCantidadPor"].ToString())), 6)) * (1 + varDetMerma);
                        else varDetCantidad = (decimal.Parse(drFila["DetCantidadPor"].ToString()).Equals(0) ? 0 : decimal.Round(((decimal.Parse(drFila["DetCantidad"].ToString()) * varCantidad) / decimal.Parse(drFila["DetCantidadPor"].ToString())), 6));

                        if (drItem.TipoHojaCst.Equals("I"))
                        {
                            varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 100").ToString()) + 1;
                            varDetPadre = 100;
                        }
                        if (drItem.TipoHojaCst.Equals("P"))
                        {
                            varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 200").ToString()) + 1;
                            varDetPadre = 200;
                        }
                        if (drItem.TipoHojaCst.Equals("S"))
                        {
                            varDetSecuencia = int.Parse(dtHojaCosto.Compute("Max(DetSecuencia)", "DetPadre = 300").ToString()) + 1;
                            varDetPadre = 300;
                        }
                        this.dtHojaCosto.Rows.Add(varDetSecuencia,
                                                                             varDetPadre,
                                                                             drItem.ItmsGrpCod,
                                                                             drItem.ItmsGrpNam.ToUpper(),
                                                                             drItem.ItemCode,
                                                                             drItem.ItemName.ToUpper(),
                                                                             drItem.InvntryUom,
                                                                             varDetMerma,
                                                                             (drItem.TipoHojaCst.Equals("P") || drItem.TipoHojaCst.Equals("S")) ? decimal.Round((varDetCantidad * decimal.Parse(this.txtCantPresentacion.Text)) / decimal.Parse(this.txtCantKilo.Text), 6) : 0,
                                                                             decimal.Round(varDetCantidad, 6),
                                                                             decimal.Round(varDetCosto, 4),
                                                                             decimal.Round(varDetCantidad * varDetCosto, 4),
                                                                             0,
                                                                             drItem.OrdenHojaCst + varDetPadre,
                                                                             "A");
                    }
                    else
                    {
                        DataRow[] drFilaBuscada = this.dtHojaCosto.Select(string.Format("IteCodigo = '{0}'", varIteCodigo));
                        varDetCantNueva = (decimal.Parse(drFila["DetCantidadPor"].ToString()).Equals(0) ? 0 : decimal.Round(((decimal.Parse(drFila["DetCantidad"].ToString()) * varCantidad) / decimal.Parse(drFila["DetCantidadPor"].ToString())), 6));
                        varDetCantidad = decimal.Parse(drFilaBuscada[0]["DetCantidad"].ToString()) + varDetCantNueva;
                        varDetTotal = decimal.Round(varDetCantidad * varDetCosto, 4);
                        drFilaBuscada[0]["DetCantidad"] = varDetCantidad;
                        if (drItem.TipoHojaCst.Equals("P") || drItem.TipoHojaCst.Equals("S")) drFilaBuscada[0]["DetCantEmp"] = decimal.Round((varDetCantidad * decimal.Parse(this.txtCantPresentacion.Text)) / decimal.Parse(this.txtCantKilo.Text), 6);
                        drFilaBuscada[0]["DetTotal"] = varDetTotal;
                    }

                    
                }
            }
            catch (Exception){ throw; }
        }
        private void proLimpiarItem()
        {
            this.txtNombre.Text = "";
            this.txtGrupo.Text = "";
            this.txtUndInventario.Text = "";
            this.txtUndVenta.Text = "";
            this.txtPsoStdVenta.EditValue = 0;
            varCabCodigo = 0;
            varCabRuta = false;
            varPrsCodigo = 0;
            lueArea.EditValue = "";
            cmbVariante.Properties.Items.Clear();
            cmbVariante.SelectedIndex = 0;
            this.txtCantKilo.EditValue = 0;
            this.txtCantPresentacion.EditValue = 0;
        }
        
    }
}
