using pryCafeteriaEscolar.Configuracion;
using System;
﻿using System;
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
            // Si quieres que abra Configuración al iniciar, descomenta:
            // btnConfiguracion_Click(sender, e);
            // 1. Limpiamos cualquier control que esté visible actualmente en Panel2
            splitContainer1.Panel2.Controls.Clear();

            // 2. Hacemos que la vista se acople y ocupe todo el panel
            nuevaVista.Dock = DockStyle.Fill;

            // 3. Añadimos la vista al panel
            splitContainer1.Panel2.Controls.Add(nuevaVista);
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
            splitContainer1.Panel2.Controls.Clear();

            nuevaVista.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(nuevaVista);

            nuevaVista.BringToFront();
            // Pasamos una instancia del UserControl correspondiente
            CargarVistaEnPanel(new Ventas());
        }
    }
}