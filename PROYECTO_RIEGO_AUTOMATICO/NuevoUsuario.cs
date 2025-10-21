using BLL;
using ENTITY;


namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class NuevoUsuario : Form
    {
        ServiciosUsuario serviciosUsuario = new ServiciosUsuario();
        public NuevoUsuario()
        {
            InitializeComponent();
        }
        public bool Obtenerdatos()
        {
            string id_usuario = txtId.Text;
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string email = txtEmail.Text.Trim();
            string nombreUsuario = txtUusario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string rol;
            rol = cbRol.SelectedIndex.ToString();
            if (string.IsNullOrEmpty(id_usuario) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.IdUsuario= id_usuario;
            nuevoUsuario.Nombre = nombre;
            nuevoUsuario.Apellido = apellido;
            nuevoUsuario.Email = email;
            nuevoUsuario.NombreUsuario = nombreUsuario;
            nuevoUsuario.Password = contraseña;
            nuevoUsuario.Rol = rol;
            
            var mensaje = serviciosUsuario.Guardar(nuevoUsuario);
            return true;

        }
        public void LimpiarCampos()
        {
            
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtEmail.ResetText();
            txtContraseña.ResetText();
            txtId.ResetText();
            txtUusario.ResetText();
            cbRol.SelectedIndex=-1;
             


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
            //INICIAR form = new INICIAR();
            //form.Show();
            this.Hide();


        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
