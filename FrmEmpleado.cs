using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            configuracion configuracion = new configuracion();

            configuracion.Dock = DockStyle.Fill;

            this.Controls.Add(configuracion);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Clear();

            configuracion config = new configuracion();
            config.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(config);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void CargarVistaEnPanel(UserControl nuevaVista)
        {
            //1. Limpiamos cualquier control que esté visible actualmente en Panel2
        }

    }
}
