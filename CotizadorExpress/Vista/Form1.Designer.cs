namespace CotizadorExpress
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomTienda = new System.Windows.Forms.Label();
            this.txtDirTienda = new System.Windows.Forms.Label();
            this.txtNomVendedor = new System.Windows.Forms.Label();
            this.txtCodVendedor = new System.Windows.Forms.Label();
            this.butHistCotizaciones = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.radioButPantalon = new System.Windows.Forms.RadioButton();
            this.radioButCamisa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnidadDisponible = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButCalidadPrem = new System.Windows.Forms.RadioButton();
            this.radioButCalidadStd = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.butCotizar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotizador Express";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomTienda
            // 
            this.txtNomTienda.AutoSize = true;
            this.txtNomTienda.Location = new System.Drawing.Point(161, 102);
            this.txtNomTienda.Name = "txtNomTienda";
            this.txtNomTienda.Size = new System.Drawing.Size(135, 25);
            this.txtNomTienda.TabIndex = 1;
            this.txtNomTienda.Text = "Nombre Tienda";
            // 
            // txtDirTienda
            // 
            this.txtDirTienda.AutoSize = true;
            this.txtDirTienda.Location = new System.Drawing.Point(579, 102);
            this.txtDirTienda.Name = "txtDirTienda";
            this.txtDirTienda.Size = new System.Drawing.Size(185, 25);
            this.txtDirTienda.TabIndex = 2;
            this.txtDirTienda.Text = "Direccion de la Tienda";
            // 
            // txtNomVendedor
            // 
            this.txtNomVendedor.AutoSize = true;
            this.txtNomVendedor.Location = new System.Drawing.Point(161, 153);
            this.txtNomVendedor.Name = "txtNomVendedor";
            this.txtNomVendedor.Size = new System.Drawing.Size(157, 25);
            this.txtNomVendedor.TabIndex = 3;
            this.txtNomVendedor.Text = "nombre Vendedor";
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.AutoSize = true;
            this.txtCodVendedor.Location = new System.Drawing.Point(407, 153);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.Size = new System.Drawing.Size(116, 25);
            this.txtCodVendedor.TabIndex = 4;
            this.txtCodVendedor.Text = "Codigo Vend";
            // 
            // butHistCotizaciones
            // 
            this.butHistCotizaciones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butHistCotizaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.butHistCotizaciones.Location = new System.Drawing.Point(550, 149);
            this.butHistCotizaciones.Name = "butHistCotizaciones";
            this.butHistCotizaciones.Size = new System.Drawing.Size(209, 33);
            this.butHistCotizaciones.TabIndex = 5;
            this.butHistCotizaciones.Text = "Historial Cotizaciones";
            this.butHistCotizaciones.UseVisualStyleBackColor = false;
            this.butHistCotizaciones.Click += new System.EventHandler(this.butHistCotizaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxChupin);
            this.groupBox1.Controls.Add(this.checkBoxCuelloMao);
            this.groupBox1.Controls.Add(this.checkBoxMangaCorta);
            this.groupBox1.Controls.Add(this.radioButPantalon);
            this.groupBox1.Controls.Add(this.radioButCamisa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(149, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(621, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(261, 95);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(94, 29);
            this.checkBoxChupin.TabIndex = 4;
            this.checkBoxChupin.Text = "Chupín";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(466, 38);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(128, 29);
            this.checkBoxCuelloMao.TabIndex = 3;
            this.checkBoxCuelloMao.Text = "Cuello mao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            this.checkBoxCuelloMao.CheckedChanged += new System.EventHandler(this.checkBoxCuelloMao_CheckedChanged);
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(261, 38);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(141, 29);
            this.checkBoxMangaCorta.TabIndex = 2;
            this.checkBoxMangaCorta.Text = "Manga Corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            this.checkBoxMangaCorta.CheckedChanged += new System.EventHandler(this.checkBoxMangaCorta_CheckedChanged);
            // 
            // radioButPantalon
            // 
            this.radioButPantalon.AutoSize = true;
            this.radioButPantalon.Location = new System.Drawing.Point(47, 93);
            this.radioButPantalon.Name = "radioButPantalon";
            this.radioButPantalon.Size = new System.Drawing.Size(105, 29);
            this.radioButPantalon.TabIndex = 1;
            this.radioButPantalon.TabStop = true;
            this.radioButPantalon.Text = "Pantalon";
            this.radioButPantalon.UseVisualStyleBackColor = true;
            this.radioButPantalon.CheckedChanged += new System.EventHandler(this.radioButPantalon_CheckedChanged);
            // 
            // radioButCamisa
            // 
            this.radioButCamisa.AutoSize = true;
            this.radioButCamisa.Location = new System.Drawing.Point(47, 38);
            this.radioButCamisa.Name = "radioButCamisa";
            this.radioButCamisa.Size = new System.Drawing.Size(94, 29);
            this.radioButCamisa.TabIndex = 0;
            this.radioButCamisa.TabStop = true;
            this.radioButCamisa.Text = "Camisa";
            this.radioButCamisa.UseVisualStyleBackColor = true;
            this.radioButCamisa.CheckedChanged += new System.EventHandler(this.radioButCamisa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Unidades de Stock Disponible:";
            // 
            // textBoxUnidadDisponible
            // 
            this.textBoxUnidadDisponible.Location = new System.Drawing.Point(429, 369);
            this.textBoxUnidadDisponible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUnidadDisponible.Name = "textBoxUnidadDisponible";
            this.textBoxUnidadDisponible.ReadOnly = true;
            this.textBoxUnidadDisponible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUnidadDisponible.ShortcutsEnabled = false;
            this.textBoxUnidadDisponible.Size = new System.Drawing.Size(90, 31);
            this.textBoxUnidadDisponible.TabIndex = 8;
            this.textBoxUnidadDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButCalidadPrem);
            this.groupBox2.Controls.Add(this.radioButCalidadStd);
            this.groupBox2.Location = new System.Drawing.Point(149, 425);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(301, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad Prenda";
            // 
            // radioButCalidadPrem
            // 
            this.radioButCalidadPrem.AutoSize = true;
            this.radioButCalidadPrem.Location = new System.Drawing.Point(150, 35);
            this.radioButCalidadPrem.Name = "radioButCalidadPrem";
            this.radioButCalidadPrem.Size = new System.Drawing.Size(108, 29);
            this.radioButCalidadPrem.TabIndex = 6;
            this.radioButCalidadPrem.TabStop = true;
            this.radioButCalidadPrem.Text = "Premium";
            this.radioButCalidadPrem.UseVisualStyleBackColor = true;
            this.radioButCalidadPrem.CheckedChanged += new System.EventHandler(this.radioButCalidadPrem_CheckedChanged);
            // 
            // radioButCalidadStd
            // 
            this.radioButCalidadStd.AutoSize = true;
            this.radioButCalidadStd.Location = new System.Drawing.Point(13, 35);
            this.radioButCalidadStd.Name = "radioButCalidadStd";
            this.radioButCalidadStd.Size = new System.Drawing.Size(97, 29);
            this.radioButCalidadStd.TabIndex = 5;
            this.radioButCalidadStd.TabStop = true;
            this.radioButCalidadStd.Text = "Standar";
            this.radioButCalidadStd.UseVisualStyleBackColor = true;
            this.radioButCalidadStd.CheckedChanged += new System.EventHandler(this.radioButCalidadStd_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxCantidad);
            this.groupBox3.Controls.Add(this.textBoxPrecioUnitario);
            this.groupBox3.Location = new System.Drawing.Point(459, 425);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(300, 107);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(221, 43);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(65, 31);
            this.textBoxCantidad.TabIndex = 12;
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(26, 43);
            this.textBoxPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(88, 31);
            this.textBoxPrecioUnitario.TabIndex = 11;
            // 
            // butCotizar
            // 
            this.butCotizar.BackColor = System.Drawing.Color.Teal;
            this.butCotizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butCotizar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.butCotizar.FlatAppearance.BorderSize = 5;
            this.butCotizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butCotizar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.butCotizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.butCotizar.Location = new System.Drawing.Point(190, 563);
            this.butCotizar.Name = "butCotizar";
            this.butCotizar.Size = new System.Drawing.Size(237, 68);
            this.butCotizar.TabIndex = 11;
            this.butCotizar.Text = "Cotizar";
            this.butCotizar.UseVisualStyleBackColor = false;
            this.butCotizar.Click += new System.EventHandler(this.butCotizar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(483, 568);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(37, 45);
            this.txtResultado.TabIndex = 12;
            this.txtResultado.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(784, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.butCotizar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxUnidadDisponible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butHistCotizaciones);
            this.Controls.Add(this.txtCodVendedor);
            this.Controls.Add(this.txtNomVendedor);
            this.Controls.Add(this.txtDirTienda);
            this.Controls.Add(this.txtNomTienda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CotizadorExpress";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label txtNomTienda;
        private Label txtDirTienda;
        private Label txtNomVendedor;
        private Label txtCodVendedor;
        private Button butHistCotizaciones;
        private GroupBox groupBox1;
        private CheckBox checkBoxChupin;
        private CheckBox checkBoxCuelloMao;
        private CheckBox checkBoxMangaCorta;
        private RadioButton radioButPantalon;
        private RadioButton radioButCamisa;
        private Label label2;
        private TextBox textBoxUnidadDisponible;
        private GroupBox groupBox2;
        private RadioButton radioButCalidadPrem;
        private RadioButton radioButCalidadStd;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecioUnitario;
        private Button butCotizar;
        private Label txtResultado;
        private PictureBox pictureBox1;
    }
}