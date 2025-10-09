namespace PROYECTO_RIEGO_AUTOMATICO
{
    partial class NuevoUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cbRol = new ComboBox();
            label7 = new Label();
            btnCrearUsuario = new Button();
            label8 = new Label();
            txtUusario = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(272, 24);
            label1.TabIndex = 0;
            label1.Text = "CREAR NUEVO USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 97);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Identificacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 260);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 220);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 180);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 140);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(202, 89);
            txtId.Name = "txtId";
            txtId.Size = new Size(234, 23);
            txtId.TabIndex = 6;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(202, 252);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(234, 23);
            txtContraseña.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(202, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(234, 23);
            txtApellido.TabIndex = 10;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Cuidador", "Espectador", "Dueño" });
            cbRol.Location = new Point(564, 94);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(121, 23);
            cbRol.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 97);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 12;
            label7.Text = "Rol del usuario";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = SystemColors.ActiveCaption;
            btnCrearUsuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.Location = new Point(522, 220);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(156, 36);
            btnCrearUsuario.TabIndex = 13;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 140);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 14;
            label8.Text = "Usuario";
            // 
            // txtUusario
            // 
            txtUusario.Location = new Point(564, 137);
            txtUusario.Name = "txtUusario";
            txtUusario.Size = new Size(137, 23);
            txtUusario.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(552, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 16;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtUusario);
            Controls.Add(label8);
            Controls.Add(btnCrearUsuario);
            Controls.Add(label7);
            Controls.Add(cbRol);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoUsuario";
            Text = "NuevoUsuario";
            Load += NuevoUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtEmail;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cbRol;
        private Label label7;
        private Button btnCrearUsuario;
        private Label label8;
        private TextBox txtUusario;
        private Button button1;
    }
}