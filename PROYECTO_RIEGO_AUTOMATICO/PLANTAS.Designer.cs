
namespace PROYECTO_RIEGO_AUTOMATICO
{
    partial class PLANTAS
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
            button1 = new Button();
            txtNivelTemperatura = new TextBox();
            txtNivelLuz = new TextBox();
            txtNivelHumedad = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            txtId = new TextBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            button2 = new Button();
            Identificación = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(39, 259);
            button1.Name = "button1";
            button1.Size = new Size(164, 39);
            button1.TabIndex = 27;
            button1.Text = "REGISTRAR PLANTA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNivelTemperatura
            // 
            txtNivelTemperatura.ForeColor = SystemColors.WindowFrame;
            txtNivelTemperatura.Location = new Point(237, 145);
            txtNivelTemperatura.Name = "txtNivelTemperatura";
            txtNivelTemperatura.Size = new Size(164, 23);
            txtNivelTemperatura.TabIndex = 25;
            txtNivelTemperatura.Text = "0.00";
            txtNivelTemperatura.TextChanged += txtNivelTemperatura_TextChanged;
            // 
            // txtNivelLuz
            // 
            txtNivelLuz.ForeColor = SystemColors.WindowFrame;
            txtNivelLuz.Location = new Point(55, 217);
            txtNivelLuz.Name = "txtNivelLuz";
            txtNivelLuz.Size = new Size(164, 23);
            txtNivelLuz.TabIndex = 24;
            txtNivelLuz.Text = "0.00";
            // 
            // txtNivelHumedad
            // 
            txtNivelHumedad.ForeColor = SystemColors.WindowFrame;
            txtNivelHumedad.Location = new Point(237, 217);
            txtNivelHumedad.Name = "txtNivelHumedad";
            txtNivelHumedad.Size = new Size(164, 23);
            txtNivelHumedad.TabIndex = 23;
            txtNivelHumedad.Text = "0.00";
            // 
            // txtDescripcion
            // 
            txtDescripcion.ForeColor = SystemColors.WindowFrame;
            txtDescripcion.Location = new Point(55, 145);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(164, 23);
            txtDescripcion.TabIndex = 22;
            txtDescripcion.Text = "Descripcion";
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(237, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 21;
            txtNombre.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Identificación);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtNivelHumedad);
            panel1.Controls.Add(txtNivelTemperatura);
            panel1.Controls.Add(txtNivelLuz);
            panel1.Location = new Point(29, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 399);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // txtId
            // 
            txtId.ForeColor = SystemColors.WindowFrame;
            txtId.Location = new Point(55, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 23);
            txtId.TabIndex = 30;
            txtId.Text = "Id";
            txtId.TextChanged += textBox1_TextChanged_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 255, 255);
            btnActualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(157, 316);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(164, 71);
            btnActualizar.TabIndex = 29;
            btnActualizar.Text = "ACTUALIZAR INFORMACION DE LA PLANTA";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(263, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 39);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "ELIMINAR PLANTA";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(29, 3);
            button2.Name = "button2";
            button2.Size = new Size(104, 39);
            button2.TabIndex = 31;
            button2.Text = "<-- ATRAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Identificación
            // 
            Identificación.AutoSize = true;
            Identificación.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Identificación.ForeColor = SystemColors.ActiveCaptionText;
            Identificación.Location = new Point(54, 49);
            Identificación.Name = "Identificación";
            Identificación.Size = new Size(99, 17);
            Identificación.TabIndex = 31;
            Identificación.Text = "Identificación";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(237, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 32;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(237, 125);
            label3.Name = "label3";
            label3.Size = new Size(178, 17);
            label3.TabIndex = 34;
            label3.Text = "Temperatura Optima ( C° )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(54, 125);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 35;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(54, 197);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 36;
            label5.Text = "Luz Optima";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(237, 197);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 37;
            label6.Text = "Humedad Optima";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(80, 6);
            label2.Name = "label2";
            label2.Size = new Size(307, 23);
            label2.TabIndex = 38;
            label2.Text = "AGREGAR UNA NUEVA PLANTA";
            label2.Click += label2_Click_1;
            // 
            // PLANTAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(button2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonShadow;
            Name = "PLANTAS";
            Text = "PLANTAS";
            Load += PLANTAS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtNivelHumedad_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox txtId;
        private Button button1;
        private TextBox txtNivelTemperatura;
        private TextBox txtNivelLuz;
        private TextBox txtNivelHumedad;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Panel panel1;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label Identificación;
        private Label label2;
    }
}