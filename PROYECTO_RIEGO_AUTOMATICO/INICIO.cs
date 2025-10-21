using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_RIEGO_AUTOMATICO
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form iniciar = new INICIAR();
            iniciar.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form iniciar = new INVITADO();
            iniciar.Show();
            this.Hide();

        }

        private void INICIO_Load(object sender, EventArgs e)
        {

        }
    }
}
