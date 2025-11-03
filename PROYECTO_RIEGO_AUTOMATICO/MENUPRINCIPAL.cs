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
        private float humedad_actual, temperatura_actual;
        private bool puedeRegar = true;

        public MENUPRINCIPAL()
        {
            serviciosPlanta = new ServiciosPlanta();
            servicioHistorial = new ServicioHistorial();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MENUPRINCIPAL_Load(object sender, EventArgs e)
        {
            ActualizarEstadoConexion();

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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CicloRiegoAsync();

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

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error..." + ex);
            }
            
            
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarHistorialEnGrid();
        }
        private void CargarHistorialEnGrid()
        {
            var lista = servicioHistorial.MostrarTodos(); // Devuelve la lista desde el archivo

            // Crear una tabla temporal
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Fecha", typeof(DateTime));
            tabla.Columns.Add("Humedad", typeof(float));
            tabla.Columns.Add("Temperatura", typeof(float));

            foreach (var item in lista)
            {
                tabla.Rows.Add(item.Id, item.Fecha, item.Humedad, item.Temperatura);
            }

            grilla.DataSource = tabla;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.ReadOnly = true;
        }

    }
}
