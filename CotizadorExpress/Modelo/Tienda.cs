using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    internal class Tienda
    {
        // Atributos
        private string nombre;
        private string direccion;
        private List<Prenda> prendas = new List<Prenda>();
        private Vendedor vendedor;
        // Propiedad de acceso
        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        internal Vendedor Vendedor { get => vendedor;  }
        internal List<Prenda> Prendas { get => prendas; }

        public Tienda(Vendedor vendedor)
        {
            nombre = "Ropa Clasica SRL";
            direccion = "Belgrano 579";
            
            this.vendedor = vendedor; //relacionamos el vendedor

            // Damos de altas las camisas
            // 100 camisas cuello mao mangas cortas standard - $0 precio base unidad por defecto
            prendas.Add(new Camisa(10,"Camisa Corta Mao Std",false, 0, 100, true, true));
            // 100 camisas cuello mao mangas cortas premium - $0 precio base unidad por defecto
            prendas.Add(new Camisa(11,"Camisa Corta Mao Prm", true, 0, 100, true, true));
            // 150 camisas cuello comun mangas cortas standard - $0 precio base unidad por defecto
            prendas.Add(new Camisa(12,"Camisa Corta Comun Std", false, 0, 150, false, true));
            // 150 camisas cuello comun mangas cortas premium - $0 precio base unidad por defecto
            prendas.Add(new Camisa(13,"Camisa Corta Comun Prm",true, 0, 150, false, true));
            // 75 camisas cuello mao mangas largas standard - $0 precio base unidad por defecto
            prendas.Add(new Camisa(14,"Camisa Larga Mao Std", false, 0, 75, true, false));
            // 75 camisas cuello mao mangas largas premium - $0 precio base unidad por defecto
            prendas.Add(new Camisa(15,"Camisa Larga Mao Prm", true, 0, 75, true, false));
            // 175 camisas cuello comun mangas largas standard - $0 precio base unidad por defecto
            prendas.Add(new Camisa(16,"Camisa Larga Comun Std",false, 0, 175, false, false));
            // 175 camisas cuello comun mangas largas premium - $0 precio base unidad por defecto
            prendas.Add(new Camisa(17,"Camisa Larga Comun Prm", true, 0, 175, false, false));

            // Damos de alta los pantalones
            // 750 pantalones chupin standard - $0 precio base unidad por defecto
            prendas.Add(new Pantalon(20,"Pantalon Chupin Std",false, 0, 750, true));
            // 750 pantalones chupin premium - $0 precio base unidad por defecto
            prendas.Add(new Pantalon(21,"Pantalon Chupin Prm", true, 0, 750, true));
            // 250 pantalones comun standard - $0 precio base unidad por defecto
            prendas.Add(new Pantalon(22,"Pantalon Comun Std", false, 0, 250, false));
            // 250 pantalones comun premium - $0 precio base unidad por defecto
            prendas.Add(new Pantalon(23,"Pantalon Comun Prm",true, 0, 250, false));
        }
    }
}
