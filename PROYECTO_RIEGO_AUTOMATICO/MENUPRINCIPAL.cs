using BLL;
using ENTITY;
using System.Data;
using System.Text.Json;

namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class MENUPRINCIPAL : Form
    {
        ServiciosPlanta serviciosPlanta;
        ServicioHistorial servicioHistorial;
        ServiciosUsuario serviciosUsuario;
        private float humedad_actual, temperatura_actual;
        private bool puedeRegar = true;
        private int IdDelUsuario;

        public MENUPRINCIPAL()
        {
            serviciosPlanta = new ServiciosPlanta();
            servicioHistorial = new ServicioHistorial();
            serviciosUsuario = new ServiciosUsuario();
            InitializeComponent();
            _ = ObtenerDatosClimaAsync();
            this.StartPosition = FormStartPosition.CenterScreen;
            cargarPlantas();



        }
        public async Task ObtenerDatosClimaAsync()
        {
            string apiKey = "91c59362a4519b067f3be52b6fe361f3";
            string ciudad = "Valledupar";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={ciudad}&appid={apiKey}&units=metric&lang=es";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var weatherInfo = JsonSerializer.Deserialize<ENTITY.WeatherInfo>(responseBody);
                    lbTemperatura.Text = $"{weatherInfo.main.temp}°C";
                    lbHum.Text = $"{weatherInfo.main.humidity} %";
                    lbVie.Text = $"{weatherInfo.wind.speed} M/S";
                    lbDes.Text = $"{weatherInfo.weather[0].description.ToUpper()}";

                    temperatura_actual = (float)weatherInfo.main.temp;
                    humedad_actual = (float)weatherInfo.main.humidity;
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Error al obtener datos del clima: {e.Message}");
                }

            }
        }

        public void cargarPlantas()
        {
            var lista = serviciosPlanta.MostrarTodos();

            cbPlantas.DataSource = null;
            cbPlantas.Items.Clear();

            cbPlantas.DataSource = lista;
            cbPlantas.DisplayMember = "NombrePlanta"; // Lo que se muestra en el ComboBox
            cbPlantas.ValueMember = "IdPlanta";       // Valor interno (opcional)
        }
        private void BuscarPlanta()
        {
            if (cbPlantas.SelectedItem is Cultivo cultivo)
            {
                MId.Text = cultivo.IdPlanta.ToString();
                Mnombre.Text = cultivo.NombrePlanta;
                MDescripcion.Text = cultivo.Descripcion;
                Mhumedad.Text = cultivo.nivel_optimo_humedad.ToString("0.00") + "%";
                Mtemperatura.Text = cultivo.nivel_optimo_temperatura.ToString("0.00") + "C°";
                Mluz.Text = cultivo.nivel_optimo_luz.ToString("0.00") + "%";
                if (!string.IsNullOrEmpty(cultivo.RutaImagen) && File.Exists(cultivo.RutaImagen))
                {
                    pbPlanta.Image = Image.FromFile(cultivo.RutaImagen);
                }
                else
                {
                    pbPlanta.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una planta primero.");
            }
        }
        private void ultimoRegado()
        {
            var lista = servicioHistorial.MostrarTodos();
            Historial_Riego ultimo = null;

            foreach (var item in lista)
            {
                ultimo = item;
            }

            if (ultimo != null)
            {
                lbUltimoRegado.Text = ultimo.Fecha.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                lbUltimoRegado.Text = "Sin registros";

            }

        }
        private void HacerCambios()
        {
            txtIdUsuario.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtNombreUsuariodelUsuario.Enabled = true;
            txtEmailUsu.Enabled = true;
            cbRol.Enabled = true;

        }
        private void GuardarCambios()
        {
            DialogResult resultado = MessageBox.Show($"¿Seguro que quiere hacer estos cambios?",
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var usu = serviciosUsuario.ObtenerPorId(IdDelUsuario);
                if (int.Parse(txtIdUsuario.Text) != usu.IdUsuario && serviciosUsuario.ExisteId(int.Parse(txtIdUsuario.Text)))
                {
                    MessageBox.Show("El ID ingresado ya pertenece a otro usuario. Cámbialo por favor.");
                    return;
                }

                // Validar que no exista otro usuario con el mismo nombre de usuario
                if (txtNombreUsuariodelUsuario.Text != usu.NombreUsuario && serviciosUsuario.ExisteNombreUsuario(txtNombreUsuariodelUsuario.Text))
                {
                    MessageBox.Show("El nombre de usuario ya está en uso. Cámbialo por favor.");
                    return;
                }



                usu.IdUsuario = int.Parse(txtIdUsuario.Text);
                usu.NombreUsuario = txtNombreUsuariodelUsuario.Text;
                usu.Nombre = txtNombreUsuario.Text;
                usu.Email = txtEmailUsu.Text;
                usu.Rol = cbRol.GetItemText(cbRol.SelectedItem);


                if (serviciosUsuario.Actualizar(usu))
                {
                    MessageBox.Show($"El/La Usuari@ {usu.NombreUsuario} fue actualizad@ correctamente");

                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar los cambios: ");
                }
                CargarUsuario();
            }
            return;
        }
        private void CargarUsuario()
        {
            Usuario usuario = new Usuario();
            var list = serviciosUsuario.MostrarTodos();
            foreach (var item in list)
            {
                if (item.Accedio == 1)
                {
                    IdDelUsuario = item.IdUsuario;
                    serviciosUsuario.Actualizar(item);
                    break;
                }
            }

            usuario = serviciosUsuario.ObtenerPorId(IdDelUsuario);
            txtIdUsuario.Text = usuario.IdUsuario.ToString();
            txtNombreUsuario.Text = usuario.Nombre;
            txtNombreUsuariodelUsuario.Text = usuario.NombreUsuario;
            cbRol.Text = usuario.Rol;
            txtEmailUsu.Text = usuario.Email;
            if (!string.IsNullOrEmpty(usuario.RutaImagen) && File.Exists(usuario.RutaImagen))
            {
                pbImagenUsuario.Image = Image.FromFile(usuario.RutaImagen);
            }
            txtIdUsuario.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtNombreUsuariodelUsuario.Enabled = false;
            txtEmailUsu.Enabled = false;
            cbRol.Enabled = false;


        }
        private void ActualizarEstadoConexion()
        {
            if (Application.OpenForms["MENUPRINCIPAL"] != null)
            {
                label14.Text = "ACTIVO";
                label14.BackColor = ColorTranslator.FromHtml("#21864B"); // Verde
            }
            else
            {
                label14.Text = "DESCONECTADO";
                label14.BackColor = ColorTranslator.FromHtml("#8B0000"); // Rojo oscuro
            }
        }
        private void ActivarRiego()
        {
            try
            {
                DialogResult resultado = MessageBox.Show($"¿Seguro que quiere iniciar el riego?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    var lis = servicioHistorial.MostrarTodos();
                    Historial_Riego historial = new Historial_Riego();
                    historial.Id = lis.Count() + 1;
                    historial.Temperatura = temperatura_actual;
                    historial.Humedad = humedad_actual;
                    historial.Fecha = DateTime.Now;
                    servicioHistorial.Guardar(historial);
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error..." + ex);
            }


        }
        private async Task CicloRiegoAsync()
        {
            if (puedeRegar)
            {
                puedeRegar = false;
                btnRiegoAuto.Enabled = false;

                ActivarRiego(); // Ejecuta el riego

                await Task.Delay(TimeSpan.FromSeconds(10));

                puedeRegar = true;
                btnRiegoAuto.Enabled = true;
                MessageBox.Show("Ya puedes volver a regar.");
            }
            else
            {
                MessageBox.Show("Debes esperar antes de volver a regar.");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MENUPRINCIPAL_Load(object sender, EventArgs e)
        {
            ActualizarEstadoConexion();
            ultimoRegado();
            CargarHistorial();
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            CargarUsuario();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PLANTAS from = new PLANTAS();
            from.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarPlanta();
        }

        private void pbPlanta_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbDes_Click(object sender, EventArgs e)
        {

        }

        private void lbHum_Click(object sender, EventArgs e)
        {

        }

        private void PanelTemperatura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CicloRiegoAsync();
            ultimoRegado();
        }
        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            servicioHistorial.MostrarTodos();
        }
        private bool CargarHistorial()
        {
            grilla.DataSource = servicioHistorial.MostrarTodos();
            return true;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuTrancicion.Start();
        }

        bool Expandir = false;
        private void MenuTrancicion_Tick(object sender, EventArgs e)
        {
            if (Expandir)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width <= 70)
                {
                    Expandir = false;
                    MenuTrancicion.Stop();
                }

            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width >= 216)
                {
                    Expandir = true;
                    MenuTrancicion.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            BuscarHistorialGrilla();
        }

        private void BuscarHistorialGrilla()
        {
            DateTime fechaSeleccionada = dtpFechaBusqueda.Value.Date;

            var lista = servicioHistorial.MostrarTodos();

            var resultados = lista.Where(x => x.Fecha.Date == fechaSeleccionada).ToList();

            if (resultados.Any())
            {
                grilla.DataSource = null; // limpiar primero
                grilla.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("No se encontraron registros para esa fecha.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CargarHistorial();
            dtpFechaBusqueda.ResetText();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lbFechaActual_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaActual.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            var usu = serviciosUsuario.ObtenerPorId(IdDelUsuario);
            dialogo.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                usu.RutaImagen = dialogo.FileName;
                serviciosUsuario.Actualizar(usu);
                pbImagenUsuario.Image = Image.FromFile(usu.RutaImagen);
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna imagen.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HacerCambios();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
