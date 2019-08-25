using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using umbAplicacion.Costos.Listado;
using umbNegocio;
using umbNegocio.Seguridad;
using umbNegocio.Costos;
using Umbrella;
using umbNegocio.Inventario;

namespace umbAplicacion.Costos.Mantenimiento
{
    public partial class xfrmCosManHojaHor : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        DataTable dtHojHorizontal;

        public xfrmCosManHojaHor()
        {
            InitializeComponent();
        }
        public xfrmCosManHojaHor(int varFormulario, int varOperacion, int varRegistro)
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
                this.Text = "Hoja de costos horizontal";
                
                switch (varOpeCodigo)
                {
                    case 1: //Opcion 1 para la operacion de insertar

                        DataTable dtDocumentos = clsSegAccFormulario.funListarDtDocumento(clsVariablesGlobales.varCodUsuario, varForCodigo, varOpeCodigo);

                        var frmFormulario = new frmAccDocumento(dtDocumentos) { StartPosition = FormStartPosition.CenterParent };
                        frmFormulario.ShowDialog();

                        if (frmFormulario.DrVarFila == null) { this.btnCancelar.PerformClick(); return; }

                        this.txtCodSerie.EditValue = varDocCodigo = int.Parse(((DataRowView)frmFormulario.DrVarFila)["DocCodigo"].ToString());
                        this.txtNomSerie.Text = varDocNombre = ((DataRowView)frmFormulario.DrVarFila)["DocNombre"].ToString();
                        this.lueListPrecios.Properties.DataSource = clsDiccionario.Listar("PRECIOSHC");

                        this.proDtHojaCosto();
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
                csValidaciones.proAccesoCampos(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
                csValidaciones.proControlColor(this, clsVariablesGlobales.varCodUsuario, varForCodigo, varDocCodigo, varOpeCodigo);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public override void proGrabar()
        {
            base.proGrabar();
            try
            {
                var csRegistro = new clsCosHojHorizontal()
                {
                    CabCodigo = this.txtCodigo.Text.Equals("") ? 0 : int.Parse(this.txtCodigo.Text),
                    DocCodigo = this.txtCodSerie.Text.Equals("") ? 0 : int.Parse(this.txtCodSerie.Text),
                    CabNumero = this.txtNumero.Text.Equals("") ? 0 : int.Parse(this.txtNumero.Text),
                    CabFecha = (DateTime)this.datFecha.EditValue,
                    CabDescripcion = this.txtDescripcion.Text,
                    CabObservacion = this.memObservacion.Text,
                    EstCodigo = "Nor",
                    DetHojCstHorizontal = dtHojHorizontal
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var lisItem = new clsInvItem();

                using (xfrmCosLisHojaVer frmFormulario = new xfrmCosLisHojaVer(true))
                {
                    frmFormulario.ShowDialog();
                    if (frmFormulario.DrVarFila != null)
                        foreach (clsCosHojVertical drHojasVerticales in frmFormulario.DrVarFila)
                        {
                            foreach (clsCosHojVertical drHojaVertical in clsCosHojVertical.funListar(string.Format("Where a.CabCodigo = '{0}'", drHojasVerticales.CabCodigo)))
                            {
                                DataTable dtDetHojaVertical = clsCosHojVertical.funListarHojVertical(string.Format("Where a.CabCodigo = '{0}'", drHojasVerticales.CabCodigo));
                                foreach (clsInvItem drItem in clsInvItem.funListar(drHojaVertical.IteCodigo))
                                {
                                    int varDetSecuencia = dtHojHorizontal.Compute("Max(DetSecuencia)", "") == System.DBNull.Value ? 1 : int.Parse(dtHojHorizontal.Compute("Max(DetSecuencia)", "").ToString()) + 1;
                                    decimal varPrecioPVD = drHojaVertical.CabTotPrcSugPVD;
                                    decimal varPorcenPVD = dtDetHojaVertical.Compute("Sum(DetPorcentaje)", "DetSecuencia = 1102") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetPorcentaje)", "DetSecuencia = 1102").ToString());
                                    decimal varPrecioPVP = drHojaVertical.CabTotPrcSugPVP;
                                    decimal varPorcenPVP = dtDetHojaVertical.Compute("Sum(DetPorcentaje)", "DetSecuencia = 1103") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetPorcentaje)", "DetSecuencia = 1103").ToString());
                                    decimal varPrecioPVD1 = dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '1'") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '1'").ToString());
                                    decimal varPrecioPVD2 = dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo ='2'") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo ='2'").ToString());
                                    decimal varPrecioPVD3 = dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '3'") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '3'").ToString());
                                    decimal varPrecioPVD4 = dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '4'") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '4'").ToString());
                                    decimal varPrecioPVD5 = dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '5'") == System.DBNull.Value ? 0 : decimal.Parse(dtDetHojaVertical.Compute("Sum(DetTotal)", "DetPadre = 1100 And IteCodigo = '5'").ToString());

                                    dtHojHorizontal.Rows.Add(varDetSecuencia,
                                                                                 drHojaVertical.IteCodigo,
                                                                                 drHojaVertical.IteNombre,
                                                                                 drItem.SalUnitMsr,
                                                                                 drItem.SWeight1,
                                                                                 drHojaVertical.CabTotMatPrima,
                                                                                 drHojaVertical.CabTotEmpPrimario,
                                                                                 drHojaVertical.CabTotEmpSecundario,
                                                                                 drHojaVertical.CabTotProcesosMOD,
                                                                                 drHojaVertical.CabTotGstIndFabricacion,
                                                                                 drHojaVertical.CabTotCstProduccion,
                                                                                 drItem.SalUnitMsr.ToLower().Equals("kilo") ? drHojaVertical.CabTotCstProduccion : decimal.Round(decimal.Round(drItem.SWeight1, 2) * drHojaVertical.CabTotCstProduccion, 4),
                                                                                 drHojaVertical.CabTotGstAdmVta,
                                                                                 drHojaVertical.CabTotCstKilo,
                                                                                 drHojaVertical.CabTotCstPresentacion,
                                                                                 drHojaVertical.CabTotPrcBase,
                                                                                 drHojaVertical.CabTotPrcSugPVD,
                                                                                 varPorcenPVD,
                                                                                 varPrecioPVP,
                                                                                 varPorcenPVP,
                                                                                 varPrecioPVD1,
                                                                                 varPrecioPVD.Equals(0) ? 0 : varPrecioPVD1.Equals(0) ? 0 : (varPrecioPVD1 - varPrecioPVD) / varPrecioPVD1,
                                                                                 varPrecioPVD1.Equals(0) ? 0 : varPrecioPVD1 / (1 - varPorcenPVP),
                                                                                 varPrecioPVD1.Equals(0) ? 0 : varPorcenPVP,
                                                                                 varPrecioPVD2,
                                                                                 varPrecioPVD.Equals(0) ? 0 : varPrecioPVD2.Equals(0) ? 0 : (varPrecioPVD2 - varPrecioPVD) / varPrecioPVD2,
                                                                                 varPrecioPVD2.Equals(0) ? 0 : varPrecioPVD2 / (1 - varPorcenPVP),
                                                                                 varPrecioPVD2.Equals(0) ? 0 : varPorcenPVP,
                                                                                 varPrecioPVD3,
                                                                                 varPrecioPVD.Equals(0) ? 0 : varPrecioPVD3.Equals(0) ? 0 : (varPrecioPVD3 - varPrecioPVD) / varPrecioPVD3,
                                                                                 varPrecioPVD3.Equals(0) ? 0 : varPrecioPVD3 / (1 - varPorcenPVP),
                                                                                 varPrecioPVD3.Equals(0) ? 0 : varPorcenPVP,
                                                                                 varPrecioPVD4,
                                                                                 varPrecioPVD.Equals(0) ? 0 : varPrecioPVD4.Equals(0) ? 0 : (varPrecioPVD4 - varPrecioPVD) / varPrecioPVD4,
                                                                                 varPrecioPVD4.Equals(0) ? 0 : varPrecioPVD4 / (1 - varPorcenPVP),
                                                                                 varPrecioPVD4.Equals(0) ? 0 : varPorcenPVP,
                                                                                 varPrecioPVD5,
                                                                                 varPrecioPVD.Equals(0) ? 0 : varPrecioPVD5.Equals(0) ? 0 : (varPrecioPVD5 - varPrecioPVD) / varPrecioPVD5,
                                                                                 varPrecioPVD5.Equals(0) ? 0 : varPrecioPVD5 / (1 - varPorcenPVP),
                                                                                 varPrecioPVD5.Equals(0) ? 0 : varPorcenPVP,
                                                                                 0,
                                                                                 0,
                                                                                 0,
                                                                                 0,
                                                                                 false);
                                }
                            }
                        }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proDtHojaCosto()
        {
            dtHojHorizontal = new DataTable { TableName = "Hoja" };
            dtHojHorizontal.Columns.Add("DetSecuencia", typeof(int));
            dtHojHorizontal.Columns.Add("IteCodigo", typeof(string));
            dtHojHorizontal.Columns.Add("IteNombre", typeof(string));
            dtHojHorizontal.Columns.Add("IteUndVenta", typeof(string));
            dtHojHorizontal.Columns.Add("ItePsoStd", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetMatPrima", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetEmpPrimario", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetEmpSecundario", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetGstMOD", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetGstFabricacion", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetCstProKg", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetCstProPre", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetGstAdmVta", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetCstTotKg", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetCstTotPre", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcBase", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD1", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD1", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP1", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP1", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD2", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD2", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP2", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP2", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD3", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD3", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP3", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP3", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD4", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD4", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP4", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP4", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVD5", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVD5", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcSugPVP5", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorSugPVP5", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcAprPVD", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorAprPVD", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPrcAprPVP", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetPorAprPVP", typeof(decimal));
            dtHojHorizontal.Columns.Add("DetActualizar", typeof(bool));

            foreach (DataRow drPrecio in clsDiccionario.Listar("PRECIOSHC").Rows)
            {
                switch (int.Parse(drPrecio["Codigo"].ToString()))
                {
                    case 1:
                        grbLista1.Visible = true;
                        grbLista1.Caption = drPrecio["Descripcion"].ToString();
                        break;
                    case 2:
                        grbLista2.Visible = true;
                        grbLista2.Caption = drPrecio["Descripcion"].ToString();
                        break;
                    case 3:
                        grbLista3.Visible = true;
                        grbLista3.Caption = drPrecio["Descripcion"].ToString();
                        break;
                    case 4:
                        grbLista4.Visible = true;
                        grbLista4.Caption = drPrecio["Descripcion"].ToString();
                        break;
                    case 5:
                        grbLista5.Visible = true;
                        grbLista5.Caption = drPrecio["Descripcion"].ToString();
                        break;
                }
            }
            this.grbPrecioApr.Visible = true;

            this.grcListado.DataSource = dtHojHorizontal;
        }
        private void bngListado_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                DataRow drFila = ((System.Data.DataRowView)(this.bngListado.GetFocusedRow())).Row;

                decimal varPrecioPVDApr = 0;
                decimal varPrecioPVDSug = 0;
                decimal varPorcenPVDApr = 0;
                decimal varPrecioPVPApr = 0;
                decimal varPorcenPVPApr = 0;

                if (this.bngListado.FocusedColumn.Equals(colDetPrcAprPVD))
                {
                    varPrecioPVDApr = decimal.Parse(e.Value.ToString());
                    varPrecioPVDSug = decimal.Parse(drFila["DetPrcSugPVD"].ToString());
                    varPorcenPVPApr = decimal.Parse(drFila["DetPorSugPVP"].ToString());
                    drFila["DetPorAprPVD"] = varPrecioPVDSug.Equals(0) ? 0 : varPrecioPVDApr.Equals(0) ? 0 : (varPrecioPVDApr - varPrecioPVDSug) / varPrecioPVDApr;
                    drFila["DetPrcAprPVP"] = varPrecioPVDApr.Equals(0) ? 0 : varPorcenPVPApr.Equals(0) ? 0 : varPrecioPVDApr / (1 - varPorcenPVPApr);
                    drFila["DetPorAprPVP"] = varPorcenPVPApr;

                }
                if (this.bngListado.FocusedColumn.Equals(colDetPorAprPVD))
                {
                    varPorcenPVDApr = decimal.Parse(e.Value.ToString());
                    varPrecioPVDSug = decimal.Parse(drFila["DetPrcSugPVD"].ToString());
                    varPorcenPVPApr = decimal.Parse(drFila["DetPorSugPVP"].ToString());
                    drFila["DetPrcAprPVD"] = varPrecioPVDSug.Equals(0) ? 0 : varPorcenPVDApr.Equals(0) ? 0 : varPrecioPVDSug / (1 - varPorcenPVDApr);
                    drFila["DetPrcAprPVP"] = varPorcenPVDApr.Equals(0) ? 0 : varPorcenPVPApr.Equals(0) ? 0 : decimal.Parse(drFila["DetPrcAprPVD"].ToString()) / (1 - varPorcenPVPApr);
                    drFila["DetPorAprPVP"] = varPorcenPVPApr;
                }
                if (this.bngListado.FocusedColumn.Equals(colDetPrcAprPVP))
                {
                    varPrecioPVPApr = decimal.Parse(e.Value.ToString());
                    varPrecioPVDApr = decimal.Parse(drFila["DetPrcAprPVD"].ToString());
                    drFila["DetPorAprPVP"] = varPrecioPVPApr.Equals(0) ? 0 : varPrecioPVDApr.Equals(0) ? 0 : (varPrecioPVPApr - varPrecioPVDApr) / varPrecioPVPApr;
                }
                if (this.bngListado.FocusedColumn.Equals(colDetPorAprPVP))
                {
                    varPorcenPVPApr = decimal.Parse(e.Value.ToString());
                    varPrecioPVDApr = decimal.Parse(drFila["DetPrcSugPVD"].ToString());
                    drFila["DetPrcAprPVP"] = varPrecioPVDApr.Equals(0) ? 0 : varPorcenPVPApr.Equals(0) ? 0 : varPrecioPVDApr / (1 - varPorcenPVPApr);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                var lisGeneral = new clsCosHojHorizontal();
                DataTable dtPrecios = new DataTable { TableName = "Precios" };
                dtPrecios.Columns.Add("IteCodigo", typeof(string));
                dtPrecios.Columns.Add("LisPrecio", typeof(string));
                dtPrecios.Columns.Add("ItePrecio", typeof(string));

                foreach (DataRow drHojHorizontal in dtHojHorizontal.Select("DetActualizar = true"))
                {
                    drHojHorizontal["DetActualizar"] = false;
                    dtPrecios.Rows.Add(drHojHorizontal["IteCodigo"].ToString(),
                                                          lueListPrecios.EditValue == null ? "0" : radSap.SelectedIndex.Equals(1) ? 0 : lueListPrecios.EditValue,
                                                          radSap.SelectedIndex.Equals(0) ? drHojHorizontal["DetPrcAprPVD"] : drHojHorizontal["DetCstTotPre"]);
                }
                this.dtHojHorizontal.AcceptChanges();


                string varMensaje = "";
                if (radSap.SelectedIndex.Equals(0)) varMensaje = lisGeneral.funEnviarPreciosSAP(dtPrecios);
                else varMensaje = lisGeneral.funEnviarCostosSAP(dtPrecios);

                if (varMensaje.Equals("")) XtraMessageBox.Show("Actualizacion completa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else XtraMessageBox.Show(varMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
