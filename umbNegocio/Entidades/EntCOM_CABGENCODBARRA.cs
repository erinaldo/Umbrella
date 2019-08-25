using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Entidades
{
    public class EntCOM_CABGENCODBARRA {
        public int atrCabCodigo { get; set; }
        public int atrDocCodigo { get; set; }
        public String atrDocNombre { get; set; } = null;
        public int atrCabNumero { get; set; }
        public int? atrDocEntrySAP { get; set; } = null;
        public int? atrDocNumSAP { get; set; } = null;
        public int? atrSeriesSAP { get; set; } = null;
        public DateTime atrCabFecha { get; set; }
        public String atrPrvCodigo { get; set; } = null;
        public String atrPrvNombre { get; set; } = null;
        public String atrCabComentario { get; set; } = null;
        public String atrCabLote { get; set; } = null;
        public String atrEstCodigo { get; set; }
        public String atrUsuCrea { get; set; } = null;
        public String atrUsuFechaCrea { get; set; } = null;
        public String atrUsuIpCrea { get; set; } = null;
        public String atrUsuModifica { get; set; } = null;
        public String atrUsuFechaModifica { get; set; } = null;
        public String atrUsuIpModifica { get; set; } = null;
        public List<EntCOM_DETGENCODBARRA> atrDetalles { get; set; } = null;

        public string funValidar() {
            string varMensaje = "";
            if (atrPrvNombre.Equals("")) return varMensaje = "bedProveedor: El campo proveedor es requerido";
            if (atrCabLote.Equals("")) return varMensaje = "txtLote: El campo lote es requerido";
            if (atrDetalles.Count.Equals(0)) return varMensaje = "grcDetalle: Debe ingresar al menos un item en el detalle";
            return varMensaje;
        }
    }
}
