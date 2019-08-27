using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umbNegocio.Entidades
{
    public class EntETQ_NUTRICIONAL {
        public int EtnCodigo { get; set; } //Código de la etiqueta nutricional
        public String EtnLabel1 { get; set; } //Nombre del producto
        public String EtnLabel2 { get; set; } //Información del producto
        public String EtnLabel3 { get; set; } //Registro sanitario
        public String EtnLabel4 { get; set; } //Peso
        public String EtnLabel5 { get; set; } //Codigo de barras
        public String EtnLabel6 { get; set; } //Leyenda junto a la información nutricional
        public String EtnLabel7 { get; set; } //Tamaño por ración
        public String EtnLabel8 { get; set; } //Porciones por envase
        public String EtnLabel9 { get; set; } //Energía calorías
        public String EtnLabel10 { get; set; } //Energía calorías a la grasa
        public String EtnLabel11 { get; set; } //Grasa total gramos
        public String EtnLabel12 { get; set; } //Grasa total porcentaje
        public String EtnLabel13 { get; set; } //Acidos grasos saturados gramos
        public String EtnLabel14 { get; set; } //Acidos grasos saturados porcentaje
        public String EtnLabel15 { get; set; } //Acidos grasos trans gramos
        public String EtnLabel16 { get; set; } //Acidos grasos trans porcentaje
        public String EtnLabel17 { get; set; } //Acidos grasos mono insaturados gramos
        public String EtnLabel18 { get; set; } //Acidos grasos mono insaturados porcentaje
        public String EtnLabel19 { get; set; } //Acidos grasos poli insaturados gramos
        public String EtnLabel20 { get; set; } //Acidos grasos poli insaturados porcentaje
        public String EtnLabel21 { get; set; } //Colesterol gramos
        public String EtnLabel22 { get; set; } //Colesterol porcentaje
        public String EtnLabel23 { get; set; } //Sodio gramos
        public String EtnLabel24 { get; set; } //Sodio porcentaje
        public String EtnLabel25 { get; set; } //Carbohidratos totales gramos
        public String EtnLabel26 { get; set; } //Carbohidratos totales porcentaje
        public String EtnLabel27 { get; set; } //Fibra gramos
        public String EtnLabel28 { get; set; } //Fibra porcentaje
        public String EtnLabel29 { get; set; } //Azucar gramos
        public String EtnLabel30 { get; set; } //Azucar porcentaje
        public String EtnLabel31 { get; set; } //Proteina gramos
        public String EtnLabel32 { get; set; } //Proteina porcentaje
        public String EtnLabel33 { get; set; } //Leyenda 2 requiere cocción
        public String UsuCrea { get; set; } //Usuario creador del registro
        public DateTime UsuFechaCrea { get; set; } //Fecha y hora de creación
        public String UsuIpCrea { get; set; } //Ip de donde fue creado el registro
        public String UsuModifica { get; set; } //Usuario que modifica el registro
        public DateTime UsuFechaModifica { get; set; } //Fecha y hora de modificación
        public String UsuIpModifica { get; set; } //Ip de donde fue modificado el registro

    }
}
