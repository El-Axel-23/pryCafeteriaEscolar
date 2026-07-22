using pryCafeteriaEscolar.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pryCafeteriaEscolar
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }


        private void CargarVistaEnPanel(Control nuevaVista)
        {
            // 1. Limpiamos cualquier control que esté visible actualmente en Panel2
            splitContainer1.Panel2.Controls.Clear();

            // 2. Hacemos que la vista se acople y ocupe todo el panel
            nuevaVista.Dock = DockStyle.Fill;

            // 3. Añadimos la vista al panel
            splitContainer1.Panel2.Controls.Add(nuevaVista);

            // Si la vista es un Formulario, es necesario llamar a .Show()
            if (nuevaVista is Form frm)
            {
                frm.Show();
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            FrmConfig frm = new FrmConfig();
            frm.TopLevel = false; // Permite metelo en un contenedor/panel
            frm.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de la ventana

            CargarVistaEnPanel(frm);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Pasamos una instancia del UserControl correspondiente
            CargarVistaEnPanel(new Ventas());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();

            // 2. Instanciamos FrmProductos
            FrmProductos productos = new FrmProductos();

            // 3. Le quitamos los bordes de ventana independiente y adaptamos el tamaño
            productos.TopLevel = false;
            productos.FormBorderStyle = FormBorderStyle.None;
            productos.Dock = DockStyle.Fill;

            // 4. Lo agregamos al panel y lo mostramos
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(productos);
            productos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos el panel derecho para quitar la vista anterior
    splitContainer1.Panel2.Controls.Clear();

    // 2. Instanciamos FrmEntradas
    FrmEntradas entradas = new FrmEntradas();

    // 3. Quitamos el comportamiento de ventana externa y ajustamos al panel
    entradas.TopLevel = false;
    entradas.FormBorderStyle = FormBorderStyle.None;
    entradas.Dock = DockStyle.Fill;

    // 4. Lo agregamos a Panel2 y lo mostramos
    splitContainer1.Panel2.Controls.Add(entradas);
    entradas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
