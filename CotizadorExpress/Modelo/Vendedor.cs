using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    internal class Vendedor
    {
        // Atributos
        private string nombre;
        private string apellido;
        private int codigoVendedor;
        private List<Cotizacion> historialCotizaciones = new List<Cotizacion>();
        // Propiedades de acceso
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int CodigoVendedor { get => codigoVendedor; }
        internal List<Cotizacion> HistorialCotizaciones { get => historialCotizaciones; }

        public Vendedor(string nombre,string apellido,int codigoVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
        }
        public void armaCotizacion(string nombrePrenda,int cantidad,float resultado)
        {
            // Agrego a la lista un objeto Cotizacio
            historialCotizaciones.Add(new Cotizacion(codigoVendedor,nombrePrenda,cantidad,resultado));
        }

    }
}
