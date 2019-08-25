using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Entidades
{
    public class EntCOM_DETGENCODBARRA {
        public int atrDetSecuencia { get; set; }
        public String atrIteCodigo { get; set; }
        public String atrIteNombre { get; set; }
        public String atrIteUndInventario { get; set; }
        public decimal? atrDetCantidad { get; set; } = null;
        public int? atrDetPiezas { get; set; } = null;
        public String atrDetTieneLote { get; set; } = null;
        public String atrDetLote { get; set; } = null;
        public int atrDetNroImpresion { get; set; } 
        public String atrEstCodigo { get; set; }
        public String atrUsuCrea { get; set; } = null;
        public String atrUsuFechaCrea { get; set; } = null;
        public String atrUsuIpCrea { get; set; } = null;
        public String atrUsuModifica { get; set; } = null;
        public String atrUsuFechaModifica { get; set; } = null;
        public String atrUsuIpModifica { get; set; } = null;

        public EntCOM_DETGENCODBARRA() { }

        public EntCOM_DETGENCODBARRA(int varAtrDetSecuencia) {
            atrDetSecuencia = varAtrDetSecuencia + 1;
            atrIteCodigo = "";
            atrIteNombre = "";
            atrIteUndInventario = "";
            atrDetNroImpresion = 1;
        }

        public string funValidarFila() {
            string varMensaje = "";
            //Validamos si la fila no tiene errores o inconsistencias
            if (atrIteCodigo.Equals("")) return varMensaje = "atrIteCodigo: El campo item es requerido";
            if (atrIteNombre.Equals("")) return varMensaje = "atrIteNombre: El campo descripción es requerido";
            if (atrDetTieneLote.Equals("Y") && atrDetLote.Equals("")) return varMensaje = "atrDetLote: El campo lote es requerido";
            return varMensaje;
        }
    }
}
