namespace PROYECTO_RIEGO_AUTOMATICO
{
    partial class INICIAR
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            tbnIniciar = new Button();
            label5 = new Label();
            btnCrearCuenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 76);
            label1.Name = "label1";
            label1.Size = new Size(2, 29);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 63);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 1;
            label2.Text = "INICIO DE SESION";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 139);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "USUARIO";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(174, 186);
            label4.Name = "label4";
            label4.Size = new Size(117, 21);
            label4.TabIndex = 3;
            label4.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(297, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(197, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(297, 184);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(197, 23);
            txtContraseña.TabIndex = 5;
            // 
            // tbnIniciar
            // 
            tbnIniciar.BackColor = Color.DarkSeaGreen;
            tbnIniciar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbnIniciar.Location = new Point(297, 291);
            tbnIniciar.Name = "tbnIniciar";
            tbnIniciar.Size = new Size(131, 42);
            tbnIniciar.TabIndex = 6;
            tbnIniciar.Text = "INICIAR";
            tbnIniciar.UseVisualStyleBackColor = false;
            tbnIniciar.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(304, 231);
            label5.Name = "label5";
            label5.Size = new Size(135, 14);
            label5.TabIndex = 7;
            label5.Text = "NO TENGO CUENTA";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuenta.Location = new Point(445, 222);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(133, 30);
            btnCrearCuenta.TabIndex = 8;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // INICIAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_iniciosession;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(718, 421);
            Controls.Add(btnCrearCuenta);
            Controls.Add(label5);
            Controls.Add(tbnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "INICIAR";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button tbnIniciar;
        private Label label5;
        private Button btnCrearCuenta;
    }
}
