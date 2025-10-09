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
            tabPage1 = new TabPage();
            lbDes = new Label();
            lbTemp = new Label();
            lbHum = new Label();
            lbVie = new Label();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            txtNivelTemperatura = new TextBox();
            txtNivelLuz = new TextBox();
            txtNivelHumedad = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            tabPage5 = new TabPage();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
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
            // tabPage1
            // 
            tabPage1.BackgroundImageLayout = ImageLayout.Center;
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(lbDes);
            tabPage1.Controls.Add(lbTemp);
            tabPage1.Controls.Add(lbHum);
            tabPage1.Controls.Add(lbVie);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(624, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "INICIO";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // lbDes
            // 
            lbDes.AutoSize = true;
            lbDes.Location = new Point(383, 160);
            lbDes.Name = "lbDes";
            lbDes.Size = new Size(81, 15);
            lbDes.TabIndex = 21;
            lbDes.Text = "DESCRIPCION";
            // 
            // lbTemp
            // 
            lbTemp.AutoSize = true;
            lbTemp.Location = new Point(383, 128);
            lbTemp.Name = "lbTemp";
            lbTemp.Size = new Size(88, 15);
            lbTemp.TabIndex = 20;
            lbTemp.Text = "TEMPERATURA";
            // 
            // lbHum
            // 
            lbHum.AutoSize = true;
            lbHum.Location = new Point(383, 90);
            lbHum.Name = "lbHum";
            lbHum.Size = new Size(65, 15);
            lbHum.TabIndex = 19;
            lbHum.Text = "HUMEDAD";
            // 
            // lbVie
            // 
            lbVie.AutoSize = true;
            lbVie.Location = new Point(383, 59);
            lbVie.Name = "lbVie";
            lbVie.Size = new Size(47, 15);
            lbVie.TabIndex = 18;
            lbVie.Text = "VIENTO";
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
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(txtNivelTemperatura);
            tabPage4.Controls.Add(txtNivelLuz);
            tabPage4.Controls.Add(txtNivelHumedad);
            tabPage4.Controls.Add(txtDescripcion);
            tabPage4.Controls.Add(txtNombre);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(panel2);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(624, 411);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "MIS PLANTAS";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(21, 78);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 21;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(19, 340);
            button1.Name = "button1";
            button1.Size = new Size(164, 39);
            button1.TabIndex = 20;
            button1.Text = "REGISTRAR PLANTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.WindowFrame;
            textBox3.Location = new Point(19, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 19;
            textBox3.Text = "Ubicacion de Origen (Opcional)";
            // 
            // txtNivelTemperatura
            // 
            txtNivelTemperatura.ForeColor = SystemColors.WindowFrame;
            txtNivelTemperatura.Location = new Point(19, 249);
            txtNivelTemperatura.Name = "txtNivelTemperatura";
            txtNivelTemperatura.Size = new Size(151, 23);
            txtNivelTemperatura.TabIndex = 18;
            txtNivelTemperatura.Text = "Nivel de temperatura Optimo";
            // 
            // txtNivelLuz
            // 
            txtNivelLuz.ForeColor = SystemColors.WindowFrame;
            txtNivelLuz.Location = new Point(19, 278);
            txtNivelLuz.Name = "txtNivelLuz";
            txtNivelLuz.Size = new Size(151, 23);
            txtNivelLuz.TabIndex = 17;
            txtNivelLuz.Text = "Nivel de Luz Optima";
            // 
            // txtNivelHumedad
            // 
            txtNivelHumedad.ForeColor = SystemColors.WindowFrame;
            txtNivelHumedad.Location = new Point(19, 220);
            txtNivelHumedad.Name = "txtNivelHumedad";
            txtNivelHumedad.Size = new Size(151, 23);
            txtNivelHumedad.TabIndex = 16;
            txtNivelHumedad.Text = "Nivel de humedad Optimo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.ForeColor = SystemColors.WindowFrame;
            txtDescripcion.Location = new Point(19, 191);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(151, 23);
            txtDescripcion.TabIndex = 15;
            txtDescripcion.Text = "Descripcion de la planta";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(19, 162);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 23);
            txtNombre.TabIndex = 14;
            txtNombre.Text = "Nombre de la planta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 13;
            label1.Text = "BUSCA TU PLANTA";
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(197, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 361);
            panel2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 324);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 6;
            label7.Text = "Temperatura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 74);
            label5.Name = "label5";
            label5.Size = new Size(25, 21);
            label5.TabIndex = 4;
            label5.Text = "id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 324);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 3;
            label4.Text = "Caracteristicas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 267);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 2;
            label3.Text = "Lugar de Origen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 267);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Hunedad";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 11;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(147, 90);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "Graficos";
            // 
            // MENUPRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MENUPRINCIPAL";
            Text = "MENUPRINCIPAL";
            Load += MENUPRINCIPAL_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lbDes;
        private Label lbTemp;
        private Label lbHum;
        private Label lbVie;
        private Panel panel1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox txtNivelTemperatura;
        private TextBox txtNivelLuz;
        private TextBox txtNivelHumedad;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label8;
    }
}