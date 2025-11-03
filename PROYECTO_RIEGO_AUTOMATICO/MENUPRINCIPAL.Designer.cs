namespace PROYECTO_RIEGO_AUTOMATICO
{
    partial class MENUPRINCIPAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            PanelPrincipal = new TabPage();
            PanelHumedad = new Panel();
            I = new PictureBox();
            label10 = new Label();
            lbHum = new Label();
            PanelPronostico = new Panel();
            ImagenPronostico = new PictureBox();
            label11 = new Label();
            lbDes = new Label();
            PanelViento = new Panel();
            ImagenViento = new PictureBox();
            lbVie = new Label();
            PanelTemperatura = new Panel();
            panel3 = new Panel();
            ImagenTemperatura = new PictureBox();
            label13 = new Label();
            lbTemperatura = new Label();
            label9 = new Label();
            lbTemp = new Label();
            label8 = new Label();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            panel2 = new Panel();
            button1 = new Button();
            MDescripcion = new Label();
            Mnombre = new Label();
            Mluz = new Label();
            Mtemperatura = new Label();
            Mhumedad = new Label();
            MId = new Label();
            button2 = new Button();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            cbPlantas = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pbPlanta = new PictureBox();
            tabPage5 = new TabPage();
            label12 = new Label();
            tabControl1.SuspendLayout();
            PanelPrincipal.SuspendLayout();
            PanelHumedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)I).BeginInit();
            PanelPronostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenPronostico).BeginInit();
            PanelViento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenViento).BeginInit();
            PanelTemperatura.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagenTemperatura).BeginInit();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlanta).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PanelPrincipal);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(143, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(632, 439);
            tabControl1.TabIndex = 14;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.FromArgb(20, 20, 20);
            PanelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            PanelPrincipal.Controls.Add(PanelHumedad);
            PanelPrincipal.Controls.Add(PanelPronostico);
            PanelPrincipal.Controls.Add(PanelViento);
            PanelPrincipal.Controls.Add(PanelTemperatura);
            PanelPrincipal.Controls.Add(label8);
            PanelPrincipal.Controls.Add(panel1);
            PanelPrincipal.Location = new Point(4, 24);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Padding = new Padding(3);
            PanelPrincipal.Size = new Size(624, 411);
            PanelPrincipal.TabIndex = 0;
            PanelPrincipal.Text = "INICIO";
            PanelPrincipal.Click += tabPage1_Click;
            // 
            // PanelHumedad
            // 
            PanelHumedad.BackColor = Color.FromArgb(40, 40, 40);
            PanelHumedad.BorderStyle = BorderStyle.FixedSingle;
            PanelHumedad.Controls.Add(I);
            PanelHumedad.Controls.Add(label10);
            PanelHumedad.Controls.Add(lbHum);
            PanelHumedad.Location = new Point(8, 146);
            PanelHumedad.Name = "PanelHumedad";
            PanelHumedad.Padding = new Padding(5);
            PanelHumedad.Size = new Size(238, 134);
            PanelHumedad.TabIndex = 24;
            // 
            // I
            // 
            I.Image = Properties.Resources.humedad;
            I.Location = new Point(80, 12);
            I.Name = "I";
            I.Size = new Size(50, 50);
            I.SizeMode = PictureBoxSizeMode.StretchImage;
            I.TabIndex = 21;
            I.TabStop = false;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.DeepSkyBlue;
            label10.Location = new Point(6, 65);
            label10.Name = "label10";
            label10.Size = new Size(200, 20);
            label10.TabIndex = 22;
            label10.Text = "HUMEDAD";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHum
            // 
            lbHum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbHum.ForeColor = Color.White;
            lbHum.Location = new Point(0, 80);
            lbHum.Name = "lbHum";
            lbHum.Size = new Size(200, 40);
            lbHum.TabIndex = 19;
            lbHum.Text = "H";
            lbHum.TextAlign = ContentAlignment.MiddleCenter;
            lbHum.Click += lbHum_Click;
            // 
            // PanelPronostico
            // 
            PanelPronostico.BackColor = Color.FromArgb(40, 40, 40);
            PanelPronostico.BorderStyle = BorderStyle.FixedSingle;
            PanelPronostico.Controls.Add(ImagenPronostico);
            PanelPronostico.Controls.Add(label11);
            PanelPronostico.Controls.Add(lbDes);
            PanelPronostico.Location = new Point(265, 146);
            PanelPronostico.Name = "PanelPronostico";
            PanelPronostico.Padding = new Padding(5);
            PanelPronostico.Size = new Size(238, 134);
            PanelPronostico.TabIndex = 24;
            // 
            // ImagenPronostico
            // 
            ImagenPronostico.Image = Properties.Resources.pronostico_del_tiempo;
            ImagenPronostico.Location = new Point(90, 12);
            ImagenPronostico.Name = "ImagenPronostico";
            ImagenPronostico.Size = new Size(40, 40);
            ImagenPronostico.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenPronostico.TabIndex = 0;
            ImagenPronostico.TabStop = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(-5, 65);
            label11.Name = "label11";
            label11.Size = new Size(238, 20);
            label11.TabIndex = 23;
            label11.Text = "PRONÓSTICO";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // lbDes
            // 
            lbDes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbDes.ForeColor = Color.White;
            lbDes.Location = new Point(0, 80);
            lbDes.Name = "lbDes";
            lbDes.Size = new Size(238, 30);
            lbDes.TabIndex = 24;
            lbDes.Text = "Despejado";
            lbDes.TextAlign = ContentAlignment.MiddleCenter;
            lbDes.Click += lbDes_Click;
            // 
            // PanelViento
            // 
            PanelViento.BackColor = Color.FromArgb(40, 40, 40);
            PanelViento.BorderStyle = BorderStyle.FixedSingle;
            PanelViento.Controls.Add(ImagenViento);
            PanelViento.Controls.Add(label12);
            PanelViento.Controls.Add(lbVie);
            PanelViento.Location = new Point(265, 6);
            PanelViento.Name = "PanelViento";
            PanelViento.Padding = new Padding(5);
            PanelViento.Size = new Size(238, 134);
            PanelViento.TabIndex = 25;
            // 
            // ImagenViento
            // 
            ImagenViento.Image = Properties.Resources.norte;
            ImagenViento.Location = new Point(91, 10);
            ImagenViento.Name = "ImagenViento";
            ImagenViento.Size = new Size(50, 50);
            ImagenViento.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenViento.TabIndex = 23;
            ImagenViento.TabStop = false;
            // 
            // lbVie
            // 
            lbVie.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbVie.ForeColor = Color.White;
            lbVie.Location = new Point(0, 80);
            lbVie.Name = "lbVie";
            lbVie.Size = new Size(238, 30);
            lbVie.TabIndex = 2;
            lbVie.Text = "Norte";
            lbVie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelTemperatura
            // 
            PanelTemperatura.BackColor = Color.FromArgb(30, 30, 30);
            PanelTemperatura.BorderStyle = BorderStyle.FixedSingle;
            PanelTemperatura.Controls.Add(panel3);
            PanelTemperatura.Controls.Add(label9);
            PanelTemperatura.Controls.Add(lbTemp);
            PanelTemperatura.Location = new Point(8, 6);
            PanelTemperatura.Name = "PanelTemperatura";
            PanelTemperatura.Padding = new Padding(5);
            PanelTemperatura.Size = new Size(238, 134);
            PanelTemperatura.TabIndex = 26;
            PanelTemperatura.Paint += PanelTemperatura_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(ImagenTemperatura);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(lbTemperatura);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 134);
            panel3.TabIndex = 27;
            // 
            // ImagenTemperatura
            // 
            ImagenTemperatura.Image = Properties.Resources.temperatura_alta;
            ImagenTemperatura.Location = new Point(80, 7);
            ImagenTemperatura.Name = "ImagenTemperatura";
            ImagenTemperatura.Size = new Size(50, 50);
            ImagenTemperatura.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenTemperatura.TabIndex = 23;
            ImagenTemperatura.TabStop = false;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.ForeColor = Color.Orange;
            label13.Location = new Point(-5, 57);
            label13.Name = "label13";
            label13.Size = new Size(238, 20);
            label13.TabIndex = 1;
            label13.Text = "TEMPERATURA";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTemperatura
            // 
            lbTemperatura.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTemperatura.ForeColor = Color.White;
            lbTemperatura.Location = new Point(-13, 77);
            lbTemperatura.Name = "lbTemperatura";
            lbTemperatura.Size = new Size(238, 30);
            lbTemperatura.TabIndex = 2;
            lbTemperatura.Text = "90.0 °C";
            lbTemperatura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(0, 55);
            label9.Name = "label9";
            label9.Size = new Size(238, 20);
            label9.TabIndex = 1;
            label9.Text = "TEMPERATURA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTemp
            // 
            lbTemp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTemp.ForeColor = Color.White;
            lbTemp.Location = new Point(0, 80);
            lbTemp.Name = "lbTemp";
            lbTemp.Size = new Size(238, 30);
            lbTemp.TabIndex = 2;
            lbTemp.Text = "28.0 °C";
            lbTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(533, 91);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "Graficos";
            // 
            // panel1
            // 
            panel1.Location = new Point(-64, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 100);
            panel1.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(624, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "HISTORIALES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(624, 411);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "RIEGO MANUAL";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gainsboro;
            tabPage4.Controls.Add(panel2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(624, 411);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "MIS PLANTAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(MDescripcion);
            panel2.Controls.Add(Mnombre);
            panel2.Controls.Add(Mluz);
            panel2.Controls.Add(Mtemperatura);
            panel2.Controls.Add(Mhumedad);
            panel2.Controls.Add(MId);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbPlantas);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pbPlanta);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(3, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 384);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(220, 97);
            button1.Name = "button1";
            button1.Size = new Size(119, 54);
            button1.TabIndex = 28;
            button1.Text = "MANIPULAR PLANTAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // MDescripcion
            // 
            MDescripcion.AutoSize = true;
            MDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MDescripcion.Location = new Point(392, 299);
            MDescripcion.Name = "MDescripcion";
            MDescripcion.Size = new Size(94, 21);
            MDescripcion.TabIndex = 27;
            MDescripcion.Text = "Descripción";
            // 
            // Mnombre
            // 
            Mnombre.AutoSize = true;
            Mnombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Mnombre.Location = new Point(61, 207);
            Mnombre.Name = "Mnombre";
            Mnombre.Size = new Size(68, 21);
            Mnombre.TabIndex = 26;
            Mnombre.Text = "Nombre";
            Mnombre.Click += label13_Click;
            // 
            // Mluz
            // 
            Mluz.AutoSize = true;
            Mluz.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Mluz.Location = new Point(248, 319);
            Mluz.Name = "Mluz";
            Mluz.Size = new Size(35, 21);
            Mluz.TabIndex = 25;
            Mluz.Text = "Luz";
            // 
            // Mtemperatura
            // 
            Mtemperatura.AutoSize = true;
            Mtemperatura.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Mtemperatura.Location = new Point(58, 315);
            Mtemperatura.Name = "Mtemperatura";
            Mtemperatura.Size = new Size(103, 21);
            Mtemperatura.TabIndex = 24;
            Mtemperatura.Text = "Temperatura";
            // 
            // Mhumedad
            // 
            Mhumedad.AutoSize = true;
            Mhumedad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Mhumedad.Location = new Point(246, 228);
            Mhumedad.Name = "Mhumedad";
            Mhumedad.Size = new Size(80, 21);
            Mhumedad.TabIndex = 23;
            Mhumedad.Text = "Humedad";
            // 
            // MId
            // 
            MId.AutoSize = true;
            MId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MId.Location = new Point(58, 123);
            MId.Name = "MId";
            MId.Size = new Size(24, 21);
            MId.TabIndex = 22;
            MId.Text = "Id";
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(226, 44);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 21;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(44, 282);
            label7.Name = "label7";
            label7.Size = new Size(109, 23);
            label7.TabIndex = 6;
            label7.Text = "Temperatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 13;
            label1.Text = "BUSCA TU PLANTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(44, 179);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // cbPlantas
            // 
            cbPlantas.FormattingEnabled = true;
            cbPlantas.Location = new Point(173, 9);
            cbPlantas.Name = "cbPlantas";
            cbPlantas.Size = new Size(166, 29);
            cbPlantas.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(44, 97);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 4;
            label5.Text = "Identificación";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(230, 284);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 3;
            label4.Text = "Luz Necesaria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(432, 265);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(230, 200);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Humedad";
            label2.Click += label2_Click_1;
            // 
            // pbPlanta
            // 
            pbPlanta.BorderStyle = BorderStyle.FixedSingle;
            pbPlanta.Location = new Point(366, 32);
            pbPlanta.Name = "pbPlanta";
            pbPlanta.Size = new Size(237, 217);
            pbPlanta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlanta.TabIndex = 0;
            pbPlanta.TabStop = false;
            pbPlanta.Click += pbPlanta_Click;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(624, 411);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "CONFIGURACION";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = Color.LightSkyBlue;
            label12.Location = new Point(-1, 60);
            label12.Name = "label12";
            label12.Size = new Size(238, 20);
            label12.TabIndex = 1;
            label12.Text = "VIENTO";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MENUPRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MENUPRINCIPAL";
            Text = "MENUPRINCIPAL";
            Load += MENUPRINCIPAL_Load;
            tabControl1.ResumeLayout(false);
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            PanelHumedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)I).EndInit();
            PanelPronostico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImagenPronostico).EndInit();
            PanelViento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImagenViento).EndInit();
            PanelTemperatura.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ImagenTemperatura).EndInit();
            tabPage4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPlanta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage PanelPrincipal;
        private TabPage tabPage2;
        private Label lbDes;
        private Label lbTemp;
        private Label lbHum;
        private Label lbVie;
        private Panel panel1;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private Label label8;
        private TabPage tabPage4;
        private Panel panel2;
        private Label Mnombre;
        private Label Mluz;
        private Label Mtemperatura;
        private Label Mhumedad;
        private Label MId;
        private Button button2;
        private Label label7;
        private Label label1;
        private Label label6;
        private ComboBox cbPlantas;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pbPlanta;
        private Label MDescripcion;
        private Label label3;
        private Button button1;
        private Panel PanelTemperatura;
        private Panel PanelHumedad;
        private Label label10;
        private Panel PanelPronostico;
        private Label label11;
        private Panel PanelViento;
        private Label label12;
        private Label label9;
        private PictureBox ImagenPronostico;
        private PictureBox I;
        private PictureBox ImagenViento;
        private Panel panel3;
        private Label label13;
        private Label lbTemperatura;
        private PictureBox ImagenTemperatura;
    }
}