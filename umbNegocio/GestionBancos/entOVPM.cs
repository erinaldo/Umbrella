using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.GestionBancos
{
    public class entOVPM {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public String CardCode { get; set; }
        public String CardName { get; set; }
        public decimal DocTotal { get; set; }
        public String PayType { get; set; }
        public String PayAccount { get; set; }
        public String CheckNum { get; set; }

    }
}
