using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress
{
    internal class ControladorStock
    {
        // Inicializa los datos de la Tienda, Vendedor, stock de camisas y pantalones
        private Tienda tienda1;
        private Vendedor vendedor1;
 
        public ControladorStock()
        {
            // Inicializa los datos de la Tienda y el Vendedor
            vendedor1 = new Vendedor("Carlos", "Aguirre", 24); // Instancio un vendedor
            tienda1 = new Tienda(vendedor1); // Instancio una Tienda
           
        }

        public void leeInformacionTienda(ref Label txtNomTienda, ref Label txtDirTienda, ref Label txtNomVendedor, ref Label txtCodVendedor,

                ref TextBox textBoxUnidadDisponible, ref TextBox textBoxPrecioUnitario, ref TextBox textBoxCantidad, bool tipoPrenda, bool tipoManga, bool tipoCuello, bool tipoPantalon, bool calidad)
        {
            txtNomTienda.Text = "Tienda:" + tienda1.Nombre;
            txtDirTienda.Text = tienda1.Direccion;
            txtNomVendedor.Text = "Vendedor:" + vendedor1.Nombre;
            txtCodVendedor.Text = "Codigo:" + vendedor1.CodigoVendedor.ToString();

            int codigoPrenda = DevuelveCodigoPrenda(tipoPrenda, tipoManga, tipoCuello, tipoPantalon,calidad);
            foreach(Prenda p in tienda1.Prendas)
            {
                if (p.CodigoPrenda==codigoPrenda)
                { 
                    textBoxUnidadDisponible.Text = p.Cantidad.ToString();
                    textBoxPrecioUnitario.Text = p.PrecioUnitario.ToString();
                }

            }
                               
        }
        public int DevuelveCodigoPrenda(bool tipoPrenda, bool tipoManga, bool tipoCuello, bool tipoPantalon, bool calidad)
        {
            int codigoPrenda = 0;
            if (tipoPrenda == true && calidad == true && tipoCuello == true && tipoManga == true) { codigoPrenda = 11; } // Camisa Premium Mao Corta  
            if (tipoPrenda == true && calidad == true && tipoCuello == true && tipoManga == false) { codigoPrenda = 15; } // Camisa Premium Mao Larga  
            if (tipoPrenda == true && calidad == false && tipoCuello == true && tipoManga == true) { codigoPrenda = 10; } // Camisa Standard Mao Corta  
            if (tipoPrenda == true && calidad == false && tipoCuello == true && tipoManga == false) { codigoPrenda = 14; } // Camisa Standard Mao Larga  
            if (tipoPrenda == true && calidad == true && tipoCuello == false && tipoManga == true) { codigoPrenda = 13; } // Camisa Premium Comun Corta  
            if (tipoPrenda == true && calidad == true && tipoCuello == false && tipoManga == false) { codigoPrenda = 17; } // Camisa Premium Comun Larga  
            if (tipoPrenda == true && calidad == false && tipoCuello == false && tipoManga == true) { codigoPrenda = 12; } // Camisa Standard Comun Corta  
            if (tipoPrenda == true && calidad == false && tipoCuello == false && tipoManga == false) { codigoPrenda = 16; } // Camisa Standard Comun Larga  
            if (tipoPrenda == false && calidad == true && tipoPantalon == true) { codigoPrenda = 21; } // Pantalon Premium Chupin  
            if (tipoPrenda == false && calidad == true && tipoPantalon == false) { codigoPrenda = 23; } // Pantalon Premium Comun  
            if (tipoPrenda == false && calidad == false && tipoPantalon == true) { codigoPrenda = 20; } // Pantalon Standard Chupin  
            if (tipoPrenda == false && calidad == false && tipoPantalon == false) { codigoPrenda = 22; } // Pantalon Standard Comun  

            return codigoPrenda;
        }
        public float Cotizar(int codigoPrenda, string precioUnitarioStr, string cantidadStr)
        {
            float resultado = 0;
            int cantidad = 0;
            int precioUnitario = 0;
            try
            {
                cantidad = Int32.Parse(cantidadStr);
                precioUnitario = Int32.Parse(precioUnitarioStr);
            }
            catch(Exception ex)
            {
                return resultado = -1; // Devuelvo un valor -1 que se interpretara en la Vista como un error
            }
            if (cantidad<=0 || precioUnitario<=0)  // Si hay valores negarivos o cero, devolvemos error
            {
                return resultado = -1; // Devuelvo un valor -1 que se interpretara en la Vista como un error
            } 
            foreach (Prenda p in tienda1.Prendas)
            {
                if (p.CodigoPrenda == codigoPrenda)
                {
                    if (cantidad <= p.Cantidad)
                    {
                        p.PrecioUnitario = precioUnitario; // reasigno el precio unitario a la prenda
                        resultado = cantidad * p.AjustePrecio(); // Calcula el resultado de la operacion
                        p.AjustarStock(p.Cantidad - cantidad); // Descuenta las unidades cotizadas del stock
                        vendedor1.armaCotizacion(p.NombrePrenda, cantidad, resultado); // Guardamos la cotizacion
                    }else
                    {
                        resultado = -1; // Devuelvo un valor -1 que se interpretara en la Vista como un error                        
                    }
                                        
                }

            }
            return resultado; // Devuelve el valor de la cotización, este siempre será >=0
        }

        public string mostrarHistorial()
        {
            // copncatena en un string cata cotizacion almacenada en el historial
            string informe="";
            foreach(Cotizacion cot in vendedor1.HistorialCotizaciones)
            {
                informe = informe + cot.informeCotizacion() + "\n";
            }
            return informe;
        }
    }
}
