using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Activos.model
{
    public class EntCabeceraCompra {
        public int atrId { get; set; }
        public String atrNumeroSAP { get; set; }
        public String atrTipoDocumento { get; set; }
        public String atrNumeroFactura { get; set; }
        public DateTime atrFechaFactura { get; set; }
        public String atrCodigoProveedor { get; set; }
        public String atrProveedor { get; set; }
        public String atrEstado { get; set; }
        public List<EntDetalleCompra> atrDetalles { get; set; }
}
}
