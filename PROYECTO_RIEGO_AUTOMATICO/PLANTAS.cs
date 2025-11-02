using BLL;
using ENTITY;


namespace PROYECTO_RIEGO_AUTOMATICO
{

    public partial class PLANTAS : Form
    {
        ServiciosPlanta serviciosPlanta;
        public PLANTAS()
        {
            InitializeComponent();
            serviciosPlanta = new ServiciosPlanta();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private bool RegistrarPlanta()
        {
            if (ValidarCampos() == false)
            {
                return false;
            }
            Cultivo nuevaPlanta = new Cultivo();

            nuevaPlanta.IdPlanta = int.Parse(txtId.Text);
            nuevaPlanta.Nombre = txtNombre.Text;
            nuevaPlanta.Descripcion = txtDescripcion.Text;
            nuevaPlanta.nivel_optimo_humedad = float.Parse(txtNivelHumedad.Text);
            nuevaPlanta.nivel_optimo_temperatura = float.Parse(txtNivelTemperatura.Text);
            nuevaPlanta.nivel_optimo_luz = float.Parse(txtNivelLuz.Text);
            if (serviciosPlanta.ObtenerPorId(nuevaPlanta.IdPlanta) != null)
            {
                MessageBox.Show("Ya hay una planta registrada con este id");
                return false;
            }
            serviciosPlanta.Guardar(nuevaPlanta);
            LimpiarCampos();
            return true;
        }
        private void ActualizarPlanta()
        {
            BuscarPlanta();

            Cultivo plantaActualizada = new Cultivo();
            if (!ValidarCampos())
            {
                return;
            }
            plantaActualizada.IdPlanta = int.Parse(txtId.Text);
            plantaActualizada.Nombre = txtNombre.Text.Trim();
            plantaActualizada.Descripcion = txtDescripcion.Text.Trim();
            plantaActualizada.nivel_optimo_humedad = float.Parse(txtNivelHumedad.Text.Trim());
            plantaActualizada.nivel_optimo_temperatura = float.Parse(txtNivelTemperatura.Text.Trim());
            plantaActualizada.nivel_optimo_luz = float.Parse(txtNivelLuz.Text.Trim());
            serviciosPlanta.Actualizar(plantaActualizada);
        }
        private void EliminarPlanta()
        {
            BuscarPlanta();
            Cultivo plantaExistente = serviciosPlanta.ObtenerPorId(int.Parse(txtId.Text));
            DialogResult resultado = MessageBox.Show(
                $"¿Seguro que quiere eliminar la planta con ID {plantaExistente.IdPlanta}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                serviciosPlanta.Eliminar(plantaExistente);
                LimpiarCampos();
            }
            else
            {
                return;
            }
        }
        private void BuscarPlanta()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, digite el id de la planta que quiere buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var plantaExistente = serviciosPlanta.ObtenerPorId(int.Parse(txtId.Text.Trim()));
            if (plantaExistente == null)
            {
                MessageBox.Show("No se encontró una planta con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtId.Text = plantaExistente.IdPlanta.ToString();
            txtNombre.Text = plantaExistente.Nombre;
            txtDescripcion.Text = plantaExistente.Descripcion;
            txtNivelHumedad.Text = plantaExistente.nivel_optimo_humedad.ToString();
            txtNivelTemperatura.Text = plantaExistente.nivel_optimo_temperatura.ToString();
            txtNivelLuz.Text = plantaExistente.nivel_optimo_luz.ToString();
        }

        private void LimpiarCampos()
        {
            txtId.ResetText();
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            txtNivelHumedad.ResetText();
            txtNivelTemperatura.ResetText();
            txtNivelLuz.ResetText();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNivelHumedad.Text) ||
                string.IsNullOrWhiteSpace(txtNivelTemperatura.Text) ||
                string.IsNullOrWhiteSpace(txtNivelLuz.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtId.Text.Trim(), out _))
            {
                MessageBox.Show("El ID debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.TryParse(txtNombre.Text.Trim(), out _))
            {
                MessageBox.Show("El nombre no puede ser solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!float.TryParse(txtNivelHumedad.Text.Trim(), out _) || !float.TryParse(txtNivelTemperatura.Text.Trim(), out _) || !float.TryParse(txtNivelLuz.Text.Trim(), out _))
            {
                MessageBox.Show("Los niveles deben ser números válidos (pueden tener decimales).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PLANTAS_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarPlanta();
        }

        private void txtNivelTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarPlanta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPlanta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MENUPRINCIPAL"] != null)
            {
                this.Hide();
            }
            else
            {
                MENUPRINCIPAL menu = new MENUPRINCIPAL();
                menu.Show();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
