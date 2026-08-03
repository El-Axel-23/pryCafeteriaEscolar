
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

        private void RestablecerColorBotones()
        {

            // Cambia SystemColors.Control por el color por defecto original de tus botones
            btnProductos.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;



        }
        private void btnProductos_Click(object sender, EventArgs e)
        {

            RestablecerColorBotones(); // Limpia los colores de los demás botones
            btnProductos.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4A460");

            // 1. Limpiamos el Panel2 (donde se muestra la vista)


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

            RestablecerColorBotones(); // Limpia los colores de los demás botones
            button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#F4A460");



            // Pasamos una instancia del UserControl correspondiente

            CargarVistaEnPanel(new Ventas());
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}