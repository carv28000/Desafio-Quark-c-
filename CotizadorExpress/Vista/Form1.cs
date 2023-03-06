namespace CotizadorExpress
{
    public partial class Form1 : Form
    {
        ControladorStock controlador = new ControladorStock();

        public Form1()
        {
            InitializeComponent();
        }
                       

        private void butCotizar_Click(object sender, EventArgs e)
        {
            bool tipoPrenda = radioButCamisa.Checked; // 0 para Pantalon 1 para Camisa
            bool tipoManga = checkBoxMangaCorta.Checked; // 0 para Larga 1 para Corta
            bool tipoCuello = checkBoxCuelloMao.Checked; // 0 para Comun 1 para Mao
            bool tipoPantalon = checkBoxChupin.Checked; // 0 para Comun 1 para Chupin
            bool calidad = radioButCalidadPrem.Checked; // 0 Standard, 1 Premium
            int codigoPrenda;
            float resultado;
            codigoPrenda= controlador.DevuelveCodigoPrenda(tipoPrenda,tipoManga,tipoCuello,tipoPantalon,calidad);
            
            resultado = controlador.Cotizar(codigoPrenda, textBoxPrecioUnitario.Text.ToString(), textBoxCantidad.Text.ToString());
            if (resultado== -1) // Si el valor es -1, entendemos que hubo un error
            {
                txtResultado.Text = "";
                MessageBox.Show("Alguno de los Datos ingresados es incorrecto:\n" +
                                "*La Cantidad no puede ser mayor a la existente en Stock\n" +
                                "*La Cantidad no puede ser un valor menor o igual a cero\n" +
                                "*La Cantidad no permite valores decimales\n" +
                                "*El Precio unitario no puede ser menor o igual a cero\n"+
                                "*Contiene letras o simbolos",
                                "Error en la carga de Datos!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                txtResultado.Text="$ " + resultado.ToString();
                leeInformacionDeLaTienda();
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opciones seleccionadas por defecto al cargar el formulario
            radioButCamisa.Checked = true;
            radioButCalidadStd.Checked = true;
            
            leeInformacionDeLaTienda();
         
        }

        private void radioButCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButCamisa.Checked == true)
            {
                checkBoxChupin.Enabled = false;
                checkBoxChupin.Checked = false;
                checkBoxMangaCorta.Enabled = true;
                checkBoxCuelloMao.Enabled = true;
                                
            }
            leeInformacionDeLaTienda();

        }

        private void radioButPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButPantalon.Checked == true)
            {
                checkBoxChupin.Enabled = true;
                checkBoxMangaCorta.Enabled = false;
                checkBoxMangaCorta.Checked= false;
                checkBoxCuelloMao.Enabled = false;
                checkBoxCuelloMao.Checked= false;
            }
            leeInformacionDeLaTienda();
        }

        private void leeInformacionDeLaTienda()
        {

            bool tipoPrenda = radioButCamisa.Checked; // 0 para Pantalon 1 para Camisa
            bool tipoManga = checkBoxMangaCorta.Checked; // 0 para Larga 1 para Corta
            bool tipoCuello = checkBoxCuelloMao.Checked; // 0 para Comun 1 para Mao
            bool tipoPantalon = checkBoxChupin.Checked; // 0 para Comun 1 para Chupin
            bool calidad = radioButCalidadPrem.Checked; // 0 Standard, 1 Premium

            // Pasamos toda la información al controlador
            controlador.leeInformacionTienda(ref txtNomTienda, ref txtDirTienda, ref txtNomVendedor, ref txtCodVendedor,
          ref textBoxUnidadDisponible, ref textBoxPrecioUnitario, ref textBoxCantidad,tipoPrenda,tipoManga,tipoCuello,tipoPantalon,calidad);


        }
        private void checkBoxMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            leeInformacionDeLaTienda();
        }

        private void checkBoxCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            leeInformacionDeLaTienda();
        }

        private void checkBoxChupin_CheckedChanged(object sender, EventArgs e)
        {
            leeInformacionDeLaTienda();
        }

        private void butHistCotizaciones_Click(object sender, EventArgs e)
        {
            // Instancio un nuevo Form y le agrego un RichTextBox
            Form form2 = new Form();
            RichTextBox historialCotizacion = new RichTextBox();
            historialCotizacion.Location = new Point(10, 10);
            historialCotizacion.Size = new Size(990, 720);
            historialCotizacion.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar; // ScrollBar Visible
            historialCotizacion.ReadOnly = true;
            form2.Controls.Add(historialCotizacion);
            form2.Width = 1050;
            form2.Height = 800;
            form2.Name = "HistorialCotizacion";
            form2.Text = "HistorialCotizacion";
            historialCotizacion.Text = controlador.mostrarHistorial(); // Devuelve un un string el historial de las cotizaciones
            form2.ShowDialog();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Dibuja los rectangulos azules
            Pen pen =new Pen(Color.DarkBlue);
            pen.Width = 5;
            e.Graphics.DrawRectangle(pen , 145, 15, 628, 74);
            e.Graphics.DrawRectangle(pen, 145, 89, 628, 45);
            e.Graphics.DrawRectangle(pen, 145, 134, 628, 60);
            e.Graphics.DrawRectangle(pen, 145, 194, 628, 160);
            e.Graphics.DrawRectangle(pen, 145, 354, 628, 60);
            e.Graphics.DrawRectangle(pen, 145, 414, 628, 130);
            e.Graphics.DrawRectangle(pen, 145, 544, 628, 110);
        }

        private void radioButCalidadStd_CheckedChanged(object sender, EventArgs e)
        {
            leeInformacionDeLaTienda();
        }

        private void radioButCalidadPrem_CheckedChanged(object sender, EventArgs e)
        {
            leeInformacionDeLaTienda();
        }
    }
}