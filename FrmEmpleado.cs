
using System;


using pryCafeteriaEscolar.Configuracion;
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

        private void CargarVistaEnPanel(UserControl nuevaVista)
        {


            FrmConfig configuracion = new FrmConfig();
            // Si quieres que abra Configuración al iniciar, descomenta:
            // btnConfiguracion_Click(sender, e);
            // 1. Limpiamos cualquier control que esté visible actualmente en Panel2

            splitContainer1.Panel2.Controls.Clear();

            nuevaVista.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(nuevaVista);

            nuevaVista.BringToFront();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            FrmConfig configuracion = new FrmConfig();

            configuracion.TopLevel = false;
            configuracion.FormBorderStyle = FormBorderStyle.None;
            configuracion.Dock = DockStyle.Fill;


            splitContainer1.Panel2.Controls.Add(configuracion);
            configuracion.Show();

            FrmConfig config = new FrmConfig();
            config.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(config);
            config.Show();


        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            FrmProductos productos = new FrmProductos();

            productos.TopLevel = false;
            productos.FormBorderStyle = FormBorderStyle.None;
            productos.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(productos);
            productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            // Pasamos una instancia del UserControl correspondiente

            CargarVistaEnPanel(new Ventas());
        }
    }
}