using BLL;
using ENTITY;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class MENUPRINCIPAL : Form
    {
        ServiciosPlanta serviciosPlanta;
        List<Cultivo> listaPlantas;

        public MENUPRINCIPAL()
        {
            serviciosPlanta = new ServiciosPlanta();
            List<Cultivo> listaPlantas;
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
                    lbTemp.Text = $"TEMPERATURA: {weatherInfo.main.temp} °C";
                    lbHum.Text = $"HUMEDAD: {weatherInfo.main.humidity} %";
                    lbVie.Text = $"VELOCIDAD DEL VIENTO: {weatherInfo.wind.speed} M/S";
                    lbDes.Text = $"DESCRIPCION: {weatherInfo.weather[0].description.ToUpper()}";
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Error al obtener datos del clima: {e.Message}");
                }
            }
        }
        private void cargarPlantas()
        {
            var lista = serviciosPlanta.MostrarTodos();
            cbPlantas.Items.Clear();
            foreach (var cultivo in lista)
            {
                cbPlantas.Items.Add(cultivo);
            }

        }
        private void BuscarPlanta()
        {
            if (cbPlantas.SelectedItem is Cultivo cultivo)
            {
                MId.Text = cultivo.IdPlanta.ToString();
                Mnombre.Text = cultivo.Nombre;
                MDescripcion.Text = cultivo.Descripcion;
                Mhumedad.Text = cultivo.nivel_optimo_humedad.ToString("0.00")+"%";
                Mtemperatura.Text = cultivo.nivel_optimo_temperatura.ToString("0.00")+"C°";
                Mluz.Text = cultivo.nivel_optimo_luz.ToString("0.00")+"%";
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
    }
}
