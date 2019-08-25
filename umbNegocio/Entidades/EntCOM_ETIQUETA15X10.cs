using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Entidades
{
    public class EntCOM_ETIQUETA15X10 {
        public int atrEacCodigo { get; set; }
        public String atrIteCodigo { get; set; }
        public String atrIteNombre { get; set; }
        public String atrEacLote { get; set; } = null;
        public DateTime atrEacFechaProduccion { get; set; }
        public String atrEacLeyenda1 { get; set; } = null;
        public String atrEacLeyenda2 { get; set; } = null;
        public String atrEacLeyenda3 { get; set; } = null;
        public decimal? atrEacCantidad { get; set; } = null;
        
    }
}
