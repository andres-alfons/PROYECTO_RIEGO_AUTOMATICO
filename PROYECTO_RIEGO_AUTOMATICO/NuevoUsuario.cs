using BLL;
using ENTITY;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class NuevoUsuario : Form
    {
        ServiciosUsuario serviciosUsuario;
        public NuevoUsuario()
        {
            InitializeComponent();
            serviciosUsuario = new ServiciosUsuario();

        }
        public bool Obtenerdatos()
        {
            if (validarCampos() == false)
            {
                return false;
            }
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.IdUsuario = int.Parse(txtId.Text);
            nuevoUsuario.Nombre = txtNombre.Text.Trim();
            nuevoUsuario.Email = txtEmail.Text.Trim();
            nuevoUsuario.NombreUsuario = txtUusario.Text.Trim();
            nuevoUsuario.Password = txtContraseña.Text.Trim();
            nuevoUsuario.Rol = cbRol.GetItemText(cbRol.SelectedItem);
            if (!ValidarUsuario())
            {
                return false;
            }
            if (serviciosUsuario.ObtenerPorId(nuevoUsuario.IdUsuario)!=null)
            {
                MessageBox.Show("El ID de usuario ya existe. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            serviciosUsuario.Guardar(nuevoUsuario);
            return true;

        }
        private bool ValidarUsuario()
        {
            if (!serviciosUsuario.ExisteUsuario(txtUusario.Text.Trim()))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void LimpiarCampos()
        {
            txtNombre.ResetText();
            txtEmail.ResetText();
            txtContraseña.ResetText();
            txtId.ResetText();
            txtUusario.ResetText();
            cbRol.SelectedIndex = -1;
        }
        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUusario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.Parse(txtId.Text) <= 0)
            {
                MessageBox.Show("El ID de usuario debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Obtenerdatos())
            {
                LimpiarCampos();
                MessageBox.Show("El Usuario ha sido agregado con exito...");
                return;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            INICIAR form = new INICIAR();
            form.Show();
            this.Hide();


        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
