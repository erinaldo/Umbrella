﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace umbAplicacion.Etiquetas.Mantenimiento
{
    public partial class xfrmEtqManNutricional : umbAplicacion.Plantillas.Mantenimiento.xfrmPlaMantenimiento
    {
        public xfrmEtqManNutricional() { InitializeComponent(); }
        public xfrmEtqManNutricional(int varFormulario, int varOperacion, int varRegistro) {
            InitializeComponent();
            varForCodigo = varFormulario;
            varOpeCodigo = varOperacion;
            varRegCodigo = varRegistro;
        }
    }
}
