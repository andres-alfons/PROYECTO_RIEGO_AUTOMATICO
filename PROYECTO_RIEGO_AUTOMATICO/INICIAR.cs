using BLL;
using ENTITY;
using System.Security.Cryptography.X509Certificates;
namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class INICIAR : Form
    {
        private int intentos = 3;
        ServiciosUsuario serviciosusuario;
        List<Usuario> listaUsuario;
        public INICIAR()
        {
            InitializeComponent();
            serviciosusuario = new ServiciosUsuario();
            listaUsuario = serviciosusuario.MostrarTodos().ToList();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool ValidarInformacion(string nombreUsu, string contra)
        {
            if (listaUsuario == null || listaUsuario.Count == 0)
            {
                MessageBox.Show("No hay usuarios cargados.");
                return false;
            }

            if (intentos <= 0)
            {
                MessageBox.Show("Ha excedido el número máximo de intentos fallidos. La aplicación se cerrará.");
                Application.Exit();
            }

            foreach (var usuario in listaUsuario)
            {
                if (usuario.NombreUsuario == nombreUsu)
                {
                    if (usuario.Password == contra)
                    {
                        MessageBox.Show("ACCESO CONCEBIDO");
                        MENUPRINCIPAL from = new MENUPRINCIPAL();
                        from.Show();
                        return true;
                    }
                    else
                    {
                        intentos--;
                        MessageBox.Show("La contraseña es incorrecta. Te quedan " + intentos + " Intentos.");
                        return false;
                    }
                }
            }

            intentos--;
            MessageBox.Show("Usuario no encontrado. Verifique el nombre de usuario. " + intentos + " Intentos.");
            return false;
        }
        //public List<Usuario> ObtenerTodas()
        //{
        //    listaUsuario = serviciosusuario.MostrarTodos().ToList();
        //    return listaUsuario;
        //}



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarInformacion(txtUsuario.Text, txtContraseña.Text);
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            NuevoUsuario form3 = new NuevoUsuario();
            form3.Show();
            this.Hide();



        }
    }
}
