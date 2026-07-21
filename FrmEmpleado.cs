using pryCafeteriaEscolar.Configuracion;
using System;
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
            CargarVistaEnPanel(new Ventas());
        }
    }
}