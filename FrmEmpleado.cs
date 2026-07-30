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
            // 1. Limpiamos cualquier control que esté visible actualmente en Panel2
            splitContainer1.Panel2.Controls.Clear();

            // 2. Hacemos que la vista se acople y ocupe todo el panel
            nuevaVista.Dock = DockStyle.Fill;

            // 3. Añadimos la vista al panel
            splitContainer1.Panel2.Controls.Add(nuevaVista);
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

            // 2. Instanciamos FrmProductos
            FrmProductos productos = new FrmProductos();

            // 3. Le quitamos los bordes de ventana independiente y adaptamos el tamaño
            productos.TopLevel = false;
            productos.FormBorderStyle = FormBorderStyle.None;
            productos.Dock = DockStyle.Fill;

            // 4. Lo agregamos al panel y lo mostramos
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

        
    }
}
