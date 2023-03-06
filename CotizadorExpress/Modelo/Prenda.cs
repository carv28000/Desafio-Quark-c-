using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    abstract internal class Prenda
    {
        // Atributos
        protected int codigoPrenda; // Codigo identificatorio de la prenda
        protected string nombrePrenda=""; // puede ser Camisa o Pantalon
        protected bool calidad; // 0 para "Standard" y 1 para "Premium"
        protected float precioUnitario;
        protected int cantidad;
        // Propiedades
        public string NombrePrenda { get => nombrePrenda; }
        public bool Calidad { get => calidad; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Cantidad { get => cantidad; }
        public int CodigoPrenda { get => codigoPrenda; }

        public void AjustarStock(int cantidad)
        {
            this.cantidad = cantidad;
        }

        protected float AjustePrecioPorCalidad(float precio)
        {
            float resultado;
            if (Calidad==true) // Calidad es Premium?
            {
                resultado = precio * 1.3f; // aumento 30%
            }
            else    // Si calidad es standar no se modifica resultado
            {   
                resultado = precio;
            }
            return resultado;
        }

        public abstract float AjustePrecio();
    }

    internal class Pantalon : Prenda
    {
        private bool tipoPantalon; // 0 para comunes y 1 para chupines
 
        public Pantalon(int codigoPrenda,string nombrePrenda,bool calidad, float precioUnitario, int cantidad, bool tipoPantalon )
        {
            this.codigoPrenda= codigoPrenda;
            this.nombrePrenda = nombrePrenda;
            this.calidad = calidad;
            this.precioUnitario= precioUnitario;
            this.cantidad = cantidad;
            this.tipoPantalon= tipoPantalon;
        }
        public override float AjustePrecio()
        {
            float resultado = PrecioUnitario;
            
            if (tipoPantalon == true) // Pantalon del tipo chupin?
            {
                resultado = resultado * 0.88f; // Rebaja del 12%
            }
            // Si el pantalon es del tipo comun no se modifica resultado
            resultado = AjustePrecioPorCalidad(resultado); //Aplicamos la regla de Calidad
            return resultado;
        }
    }

    internal class Camisa : Prenda
    {
        private bool tipoCuello; // 0 para cuello comun y 1 para cuello mao
        private bool tipoManga; // 0 para manga larga y 1 para manga corta

        public bool TipoCuello { get => tipoCuello; }
        public bool TipoManga { get => tipoManga; }

        public Camisa(int codigoPrenda,string nombrePrenda,bool calidad, float precioUnitario, int cantidad, bool tipoCuello, bool tipoManga)
        {
            this.codigoPrenda= codigoPrenda;    
            this.nombrePrenda = nombrePrenda;
            this.calidad = calidad;
            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;
            this.tipoCuello = tipoCuello;
            this.tipoManga= tipoManga;
        }
                
        public override float AjustePrecio()
        {
            float resultado=PrecioUnitario;
            
            if (TipoManga== true) // Si la camisa en manga corta?
            {
                resultado = resultado * 0.9f; // rebaja del 10%
            }
            
            if (TipoCuello == true) // Si la camisa tiene cuello mao?
            {
                resultado = resultado * 1.03f; // Aumento del 3%
            }

            resultado = AjustePrecioPorCalidad(resultado); //Aplicamos la regla de Calidad
            return resultado;
        }

    }
}
