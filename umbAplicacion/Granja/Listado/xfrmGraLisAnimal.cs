using System.Windows.Forms;
using umbAplicacion.Granja.Mantenimiento;
using umbNegocio;
using umbNegocio.Granja;
using umbNegocio.Seguridad;
using umbAplicacion.Granja;
using System;
using DevExpress.XtraEditors;
using umbAplicacion.Granja.Auxiliar;
using System.Data;

namespace umbAplicacion.Granja.Listado
{
    public partial class xfrmGraLisAnimal : umbAplicacion.Plantillas.Listado.xfrmPlaListado
    {
        private ToolStripMenuItem tsmDosis = new ToolStripMenuItem();
        public xfrmGraLisAnimal()
        {
            InitializeComponent();
        }

        public override void proIniciarFormulario()
        {
            base.proIniciarFormulario();
            //Cargamos controles para las dosis del animal
            this.tsmDosis.Enabled = true;
            this.tsmDosis.Image = global::umbAplicacion.Properties.Resources.imgDosis16;
            this.tsmDosis.Name = "tsmMenu";
            this.tsmDosis.Size = new System.Drawing.Size(152, 22);
            this.tsmDosis.Text = "Aplicar dosis";
            this.tsmDosis.Click += new System.EventHandler(this.tsmDosis_Click);
            cmsMenuListado.Items.Add(tsmDosis);
            //Asignamos el titulo que tendra el formulario
            this.Text = "Registro de animales";
            const string varNomFormulario = "umbAplicacion.Granja.Listado.xfrmGraLisAnimal";
            foreach (clsSegFormulario csRegistro in clsSegFormulario.funListar(varNomFormulario)) { varCodFormulario = csRegistro.FrmCodigo; }
            //Accesos del formulario para el usuario ingresado
            varCodDocumento = 1;
            this.proAccesoFormulario();
            //Actualizamos los datos del listado despues de realizar los cambios
            grcListado.DataSource = clsGraAnimal.funListar("");
        }
        public override void proNuevo()
        {
            base.proNuevo();
            xfrmGraManAnimal frmFormulario = new xfrmGraManAnimal(varCodFormulario, varCodOperacion, 0);
            frmFormulario.StartPosition = FormStartPosition.CenterParent;
            frmFormulario.ShowDialog();

            //Actualizamos los datos del listado despues de realizar los cambios
            grcListado.DataSource = clsGraAnimal.funListar("");
        }
        public override void proModificar()
        {
            //Recuperamos el codigo del documento
            varCodDocumento = 1;
            base.proModificar();
            if (!varBanAcceso) return;

            try
            {
                int varRegistro = 0;
                //Verificamos si selecciono una sola fila
                if (this.grvListado.GetSelectedRows().Length.Equals(0)) {
                    varRegistro = int.Parse(this.grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["AnmCodigo"].ToString());
                    xfrmGraManAnimal frmFormulario = new xfrmGraManAnimal(varCodFormulario, varCodOperacion, varRegistro);
                    frmFormulario.StartPosition = FormStartPosition.CenterParent;
                    frmFormulario.ShowDialog();
                }
                //Actualizamos los datos del listado despues de realizar los cambios
                grcListado.DataSource = clsGraAnimal.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /*
       

      
        public override void proEliminar()
        {
           base.proEliminar();
           foreach (int varPosicion in this.grvListado.GetSelectedRows())
           {
               clsGraAnimal obj = new clsGraAnimal();
               obj.Id = ((clsGraAnimal)this.grvListado.GetRow(varPosicion)).Id;
               if (MessageBox.Show("Desea eliminar el elemento seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                    && obj.ejecutarMantenimiento(3) >= 0)
                   grcListado.DataSource = clsGraAnimal.Listar("");
           }
        }

        private void tmrDataChanged_Tick(object sender, System.EventArgs e)
        {
             Recargar listado cuando se ha agregado o modificado desde el formulario de mantenimiento.
            if (clsVariablesGlobales.clsANIMALRecargar)
            {
                grcListado.DataSource = clsGraAnimal.Listar("");
                clsVariablesGlobales.clsANIMALRecargar = false;
            }
        }
        */
        private void grcListado_DoubleClick(object sender, System.EventArgs e)
        {
            //int varRegistro = ((clsGraAnimal)this.grvListado.GetRow(grvListado.FocusedRowHandle)).Id;
            //xfrmGraManAnimal frmFormulario = new xfrmGraManAnimal(varCodFormulario, 2, varRegistro);
            //frmFormulario.MdiParent = this.MdiParent;
            //frmFormulario.Show();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try {
                int varAnmCodigo = 0;
                string varMensaje = "";
                //Verificamos si selecciono una sola fila
                if (grvListado.GetSelectedRows().Length.Equals(0)) {
                    //Instanciamos el formulario para pedir al usuario informacion para la activacion
                    xfrmGraAuxActivacion objFormulario = new xfrmGraAuxActivacion();
                    //Instanciamos la clase animal
                    clsGraAnimal objAnimal = new clsGraAnimal();
                    //Recuperamos informacion de la fila selecionada
                    varAnmCodigo = int.Parse(grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["AnmCodigo"].ToString());
                    //Recuperamos los datos del animal de la fila selecionada
                    objAnimal = clsGraAnimal.funListar(varAnmCodigo)[0];
                    if (objAnimal.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION")) { XtraMessageBox.Show(string.Format("Registro nro {0} ya ha sido activado", objAnimal.AnmAlternativo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (objFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                        //Recuperemos informacion de la activacion
                        objAnimal.AnmFecActivacion = objFormulario.varFecActivacion;
                        objAnimal.AnmPsoFormacion = objFormulario.varPsoActivacion;
                        //Enviamos la informacion de SAP
                        proEnviarSAP(varMensaje, objAnimal);
                    }
                }
                else {
                    foreach (int varPosicion in this.grvListado.GetSelectedRows()) {
                        //Instanciamos el formulario para pedir al usuario informacion para la activacion
                        xfrmGraAuxActivacion objFormulario = new xfrmGraAuxActivacion();
                        //Instanciamos la clase animal
                        clsGraAnimal objAnimal = new clsGraAnimal();
                        //Recuperamos informacion de la fila selecionada
                        varAnmCodigo = int.Parse(grvListado.GetDataRow(varPosicion)["AnmCodigo"].ToString());
                        //Recuperamos los datos del animal de la fila selecionada
                        objAnimal = clsGraAnimal.funListar(varAnmCodigo)[0];
                        if (objAnimal.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION")) 
                            XtraMessageBox.Show(string.Format("Registro nro {0} ya ha sido activado", objAnimal.AnmAlternativo), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        else {
                            if (objFormulario.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                                //Recuperemos informacion de la activacion
                                objAnimal.AnmFecActivacion = objFormulario.varFecActivacion;
                                objAnimal.AnmPsoFormacion = objFormulario.varPsoActivacion;
                                //Enviamos la informacion de SAP
                                proEnviarSAP(varMensaje, objAnimal);
                            }
                        }
                    }
                }
                //Actualizamos los datos del listado despues de realizar los cambios
                grcListado.DataSource = clsGraAnimal.funListar("");
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void proEnviarSAP(string varMensaje, clsGraAnimal objAnimal)
        {
            try {
                //Verificamos si el documento ya ha sido ingresado en SAP
                DataTable objDtVerificarSAP;
                //Verificamos si hay documento de salida
                objDtVerificarSAP = clsGraAnimal.funVerificarSalInventarioSAP(objAnimal.AnmCodigo, objAnimal.AnmAlternativo);
                //Verifico si el documento no haya sido enviado a SAP Salida
                if (objAnimal.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION") || objDtVerificarSAP.Rows.Count > 0) {
                    //Actualizacion en el formulario de movimientos de inventario
                    objAnimal.AnmDocEntrySAPSalida = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                    objAnimal.AnmNumeroSAPSalida = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                    //Actualizamos la informacion en el animal
                    clsGraAnimal.proActMovInventarioSalida(objAnimal.AnmDocEntrySAPSalida, objAnimal.AnmNumeroSAPSalida, objAnimal.AnmCodigo);
                }
                else {
                    //Enviamos la información de salida a SAP
                    varMensaje = objAnimal.funEnviarSalMercanciaSAP();
                }
                if (varMensaje.Equals("")) {
                    //Verificamos si hay documento de entrada
                    objDtVerificarSAP = clsGraAnimal.funVerificarEntInventarioSAP(objAnimal.AnmCodigo, objAnimal.AnmAlternativo);
                    //Verifico si el documento no haya sido enviado a SAP entrada
                    if (objAnimal.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION") || objDtVerificarSAP.Rows.Count > 0) {
                        //Actualizacion en el formulario de movimientos de inventario
                        objAnimal.AnmDocEntrySAPEntrada = int.Parse(objDtVerificarSAP.Rows[0]["DocEntry"].ToString());
                        objAnimal.AnmNumeroSAPEntrada = int.Parse(objDtVerificarSAP.Rows[0]["DocNum"].ToString());
                        //Actualizamos la informacion en el animal
                        clsGraAnimal.proActMovInventarioEntrada(objAnimal.AnmDocEntrySAPEntrada, objAnimal.AnmNumeroSAPEntrada, objAnimal.AnmCodigo);
                    }
                    else{
                        //Enviamos la información de entrada a SAP
                        varMensaje = objAnimal.funEnviarEntMercanciaSAP();
                    }
                    if (varMensaje.Equals(""))
                    {
                        //Verificamos si hay documento de diario
                        objDtVerificarSAP = clsGraAnimal.funVerificarDiarioSAP(objAnimal.AnmCodigo, objAnimal.AnmAlternativo);
                        if (objAnimal.AnmEstDesarrollo.ToUpper().Equals("PRODUCCION") || objDtVerificarSAP.Rows.Count > 0) {
                            //Actualizacion en el formulario de movimientos de inventario
                            objAnimal.AnmDocEntrySAPDiario = int.Parse(objDtVerificarSAP.Rows[0]["TransId"].ToString());
                            objAnimal.AnmNumeroSAPDiario = int.Parse(objDtVerificarSAP.Rows[0]["Number"].ToString());
                            //Actualizamos la informacion en el animal
                            clsGraAnimal.proActMovInventarioDiario(objAnimal.AnmDocEntrySAPDiario, objAnimal.AnmNumeroSAPDiario, objAnimal.AnmCodigo);
                        }
                        else {
                            //Enviamos la información de diario a SAP
                            varMensaje = objAnimal.funEnviaDiaContableSAP();
                        }
                        if (varMensaje.Equals(""))
                        {
                            clsGraAnimal.proActEstDesarrollo(objAnimal.AnmCodigo);
                            XtraMessageBox.Show(string.Format("Registro nro {0} enviado a SAP", objAnimal.AnmAlternativo), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objAnimal.AnmAlternativo, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objAnimal.AnmAlternativo, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    XtraMessageBox.Show(string.Format("Registro nro {0} presento el siguiente error: {1}", objAnimal.AnmAlternativo, varMensaje), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        private void tsmDosis_Click(object sender, EventArgs e)
        {
            try {
                int varAnmCodigo = int.Parse(grvListado.GetDataRow(this.grvListado.FocusedRowHandle)["AnmCodigo"].ToString());
                clsGraAnimal objAnimal = clsGraAnimal.funListar(varAnmCodigo)[0];
                
                string varAnmEstDesarrollo = objAnimal.AnmEstDesarrollo;
                string varAnmEstCiclo = objAnimal.AnmEstCiclo;
                string varGenero = objAnimal.Genero;
                //Verificamos si el animal es de genero hembra
                if (!varGenero.Equals("HEMBRA")) { XtraMessageBox.Show("Al animal seleccionado no se puede aplicar dosis, genero incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                //Verificamos que el animal ya se encuentre en estado de produccion
               // if (!varAnmEstDesarrollo.Equals("PRODUCCION")) { XtraMessageBox.Show("El animal debe estar en estado desarrollo productivo para aplicar dosis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                //Verificamos que el animal ya se encuentre en estado vacio
                if (!varAnmEstCiclo.Equals("VACIO")) { XtraMessageBox.Show("El animal debe estar en estado ciclo vacio para aplicar dosis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                using (xfrmGraAuxDosis objFormulario = new xfrmGraAuxDosis(objAnimal.AnmCodigo, objAnimal.AnmAlternativo, objAnimal.IteNombre, false, false, 0)) objFormulario.ShowDialog();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}