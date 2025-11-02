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
            label8 = new Label();
            lbDes = new Label();
            lbTemp = new Label();
            lbHum = new Label();
            lbVie = new Label();
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
            pictureBox1 = new PictureBox();
            tabPage5 = new TabPage();
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
            tabPage1.BackColor = Color.WhiteSmoke;
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
            tabPage1.Click += tabPage1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 209);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 22;
            label8.Text = "Graficos";
            // 
            // lbDes
            // 
            lbDes.AutoSize = true;
            lbDes.Location = new Point(258, 147);
            lbDes.Name = "lbDes";
            lbDes.Size = new Size(81, 15);
            lbDes.TabIndex = 21;
            lbDes.Text = "DESCRIPCION";
            // 
            // lbTemp
            // 
            lbTemp.AutoSize = true;
            lbTemp.Location = new Point(258, 41);
            lbTemp.Name = "lbTemp";
            lbTemp.Size = new Size(88, 15);
            lbTemp.TabIndex = 20;
            lbTemp.Text = "TEMPERATURA";
            // 
            // lbHum
            // 
            lbHum.AutoSize = true;
            lbHum.Location = new Point(55, 147);
            lbHum.Name = "lbHum";
            lbHum.Size = new Size(65, 15);
            lbHum.TabIndex = 19;
            lbHum.Text = "HUMEDAD";
            // 
            // lbVie
            // 
            lbVie.AutoSize = true;
            lbVie.Location = new Point(55, 41);
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
            tabPage4.Controls.Add(panel2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(624, 411);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "MIS PLANTAS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
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
            panel2.Controls.Add(pictureBox1);
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
            button1.Location = new Point(226, 109);
            button1.Name = "button1";
            button1.Size = new Size(100, 54);
            button1.TabIndex = 28;
            button1.Text = "Nueva Planta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // MDescripcion
            // 
            MDescripcion.AutoSize = true;
            MDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MDescripcion.Location = new Point(448, 291);
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
            label7.Location = new Point(44, 282);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 6;
            label7.Text = "Temperatura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 13;
            label1.Text = "BUSCA TU PLANTA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 179);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
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
            label5.Location = new Point(44, 97);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 4;
            label5.Text = "Identificación";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 284);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 3;
            label4.Text = "Luz Necesaria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 260);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 200);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 1;
            label2.Text = "Humedad";
            label2.Click += label2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(379, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 217);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // MENUPRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MENUPRINCIPAL";
            Text = "MENUPRINCIPAL";
            Load += MENUPRINCIPAL_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage4.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private Label MDescripcion;
        private Label label3;
        private Button button1;
    }
}