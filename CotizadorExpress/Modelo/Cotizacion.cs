using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    internal class Cotizacion
    {
        // Atributos
        private static int numeroIdentificacion=1;
        private int Id;
        private int codigoVendedor;
        private string nombrePprenda;
        private int cantPrendas;
        private float resultado;
        private string fechaHora;

        public Cotizacion(int codVendedor,string nombrePrenda, int cantidad, float resultado)
        {
            Id = numeroIdentificacion;
            codigoVendedor= codVendedor;
            this.nombrePprenda = nombrePrenda;
            cantPrendas= cantidad;
            this.resultado = resultado;
            fechaHora = DateTime.Now.ToString();
            numeroIdentificacion += 1;
        }
        public string informeCotizacion()
        {
            // Devuelve en un string una cadena de caracteres con la información de cotización concatenada
            string cadenaTexto;

            cadenaTexto = "ID:" + Id + "  -  Fecha y Hora:" + fechaHora +"  -  CodVr:" + codigoVendedor;
            cadenaTexto = cadenaTexto + "  -  Prenda:" + nombrePprenda + "  -  Cant:" + cantPrendas + "  -  Total $" + resultado;

            return cadenaTexto;
        }


    }
}
