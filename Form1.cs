using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
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
            panelContenedor.Controls.Clear();

            configuracion config = new configuracion();
            config.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(config);
        }
    }
}
