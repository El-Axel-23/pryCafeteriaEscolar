using pryCafeteriaEscolar.Configuracion;
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
            // Si quieres que abra Configuración al iniciar, descomenta:
            // btnConfiguracion_Click(sender, e);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            FrmConfig configuracion = new FrmConfig();

            configuracion.TopLevel = false;
            configuracion.FormBorderStyle = FormBorderStyle.None;
            configuracion.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(configuracion);
            configuracion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CargarVistaEnPanel(UserControl nuevaVista)
        {
            splitContainer1.Panel2.Controls.Clear();

            nuevaVista.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(nuevaVista);

            nuevaVista.BringToFront();
        }
    }
}