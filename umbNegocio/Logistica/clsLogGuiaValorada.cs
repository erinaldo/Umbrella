using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Logistica
{
    public class clsLogGuiaValorada {
        private int atrCabCodigo;
        private DateTime atrCabFecha;
        private decimal atrCabValor;
        private string atrCabGuias;
        private bool atrCabAgrupado;
        private clsLogRutGuia atrCabRuta;
        private List<clsLogDetGuiaValorada> atrDetalle;

        public clsLogGuiaValorada() {}
        public clsLogGuiaValorada(int atrCabCodigo, DateTime atrCabFecha, bool atrCabAgrupado, decimal atrCabValor, clsLogRutGuia atrCabRuta, List<clsLogDetGuiaValorada> atrDetalle) {
            this.atrCabCodigo = atrCabCodigo;
            this.atrCabFecha = atrCabFecha;
            this.atrCabAgrupado = atrCabAgrupado;
            this.atrCabValor = atrCabValor;
            this.atrCabRuta = atrCabRuta;
            this.atrDetalle = atrDetalle;
        }

        public int AtrCabCodigo {
            get { return atrCabCodigo; }
            set { atrCabCodigo = value; }
        }
        public DateTime AtrCabFecha {
            get { return atrCabFecha; }
            set { atrCabFecha = value; }
        }
        public decimal AtrCabValor {
            get { return atrCabValor; }
            set { atrCabValor = value; }
        }
        public List<clsLogDetGuiaValorada> AtrDetalle {
            get { return atrDetalle; }
            set { atrDetalle = value; }
        }
        public string AtrCabGuias {
            get { return atrCabGuias; }
            set { atrCabGuias = value; }
        }
        public clsLogRutGuia AtrCabRuta {
            get { return atrCabRuta; }
            set { atrCabRuta = value; }
        }
        public bool AtrCabAgrupado {
            get { return atrCabAgrupado; }
            set { atrCabAgrupado = value; }
        }
    }

    public class clsLogDetGuiaValorada {
        private int atrDetSecuencia;
        private int atrDetCabGuia;
        private String atrDetDocNombre;
        private int atrDetCabNumero;
        private DateTime atrDetCabFecha;
        private String atrDetChfNombre;
        private String atrDetAyuNombre;
        private String atrDetTrnPlaca;
        private double atrDetValor;

        public clsLogDetGuiaValorada() { }
        public clsLogDetGuiaValorada(int atrDetSecuencia, int atrDetCabGuia, String atrDetDocNombre, int atrDetCabNumero, DateTime atrDetCabFecha, String atrDetChfNombre, String atrDetAyuNombre, String atrDetTrnPlaca, double atrDetValor) {
            this.atrDetSecuencia = atrDetSecuencia;
            this.atrDetCabGuia = atrDetCabGuia;
            this.atrDetDocNombre = atrDetDocNombre;
            this.atrDetCabNumero = atrDetCabNumero;
            this.atrDetCabFecha = atrDetCabFecha;
            this.atrDetChfNombre = atrDetChfNombre;
            this.atrDetAyuNombre = atrDetAyuNombre;
            this.atrDetTrnPlaca = atrDetTrnPlaca;
            this.atrDetValor = atrDetValor;
        }

        public int AtrDetSecuencia
        {
            get { return atrDetSecuencia; }
            set { atrDetSecuencia = value; }
        }
        public int AtrDetCabGuia
        {
            get { return atrDetCabGuia; }
            set { atrDetCabGuia = value; }
        }
        public string AtrDetDocNombre {
            get { return atrDetDocNombre; }
            set { atrDetDocNombre = value; }
        }
        public int AtrDetCabNumero {
            get { return atrDetCabNumero; }
            set { atrDetCabNumero = value; }
        }
        public DateTime AtrDetCabFecha {
            get { return atrDetCabFecha; }
            set {   atrDetCabFecha = value; }
        }
        public string AtrDetChfNombre {
            get { return atrDetChfNombre; }
            set { atrDetChfNombre = value; }
        }
        public string AtrDetAyuNombre {
            get { return atrDetAyuNombre; }
            set { atrDetAyuNombre = value; }
        }
        public string AtrDetTrnPlaca {
            get { return atrDetTrnPlaca; }
            set { atrDetTrnPlaca = value; }
        }
        public double AtrDetValor {
            get { return atrDetValor; }
            set { atrDetValor = value; }
        }
    }
}
