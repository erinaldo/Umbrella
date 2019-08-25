using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Activos.model
{
    public class EntDetalleCompra {
        public String atrCodigoTipoActivo { get; set; }
        public String atrTipoActivo { get; set; }
        public String atrCodigoClase { get; set; }
        public String atrClase { get; set; }
        public String atrCodigoItem { get; set; }
        public String atrItem { get; set; }
        public String atrCodigoCentroCosto { get; set; }
        public String atrCentroCosto { get; set; }
        public int atrCantidad { get; set; }
        public double atrValorCompra { get; set; }
        public double atrCostoLiquidacion { get; set; }
        public double atrValorNetoCompra { get; set; }
    }
}
