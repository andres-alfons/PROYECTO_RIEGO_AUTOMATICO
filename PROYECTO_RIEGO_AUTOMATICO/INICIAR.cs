using ENTITY;
using System.Security.Cryptography.X509Certificates;
namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class INICIAR : Form
    {
        public static List<Usuario> listaUsuario;

        public INICIAR()
        {
            listaUsuario = new List<Usuario>();
            //List<Usuario> listaUsuario = new List<Usuario>();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public bool ValidarInformacion(string nombreUsu, string contra)
        {
            if (listaUsuario == null || listaUsuario.Count == 0)
            {
                MessageBox.Show("No hay usuarios cargados.");
                
            }

            List<Usuario> lista = ObtenerTodas();

            foreach (var usuario in lista)
            {
                if (usuario.NombreUsuario == nombreUsu)
                {
                    if (usuario.Password == contra)
                    {
                        MessageBox.Show("ACCESO CONCEBIDO");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta. Por favor, revisar e intentar de nuevo...");
                        return false;
                    }
                }
            }
            MessageBox.Show("Usuario no encontrado. Verifique el nombre de usuario.");
            return false;
        }
        public List<Usuario> ObtenerTodas()
        {
            return listaUsuario;
        }
        

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
            MENUPRINCIPAL from = new MENUPRINCIPAL();
            from.Show();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            NuevoUsuario form3 = new NuevoUsuario();
            form3.Show();
            //this.Hide();

            

        }
    }
}
