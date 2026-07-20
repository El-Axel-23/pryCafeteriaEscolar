using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaEscolar.Configuracion
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            if (cmbbxFuente.SelectedIndex == -1)
            {
                cmbbxFuente.SelectedIndex = 0;
            }
            CambiarTema();
        }
        private void CambiarColorControles(Control padre, Color fondo, Color texto)
        {
            foreach (Control c in padre.Controls)
            {
                c.BackColor = fondo;
                c.ForeColor = texto;

                if (c.HasChildren)
                {
                    CambiarColorControles(c, fondo, texto);
                }
            }
        }
        private void CambiarTema()
        {
            if (trackTemas.Value == 0)
            {
                this.BackColor = Color.WhiteSmoke;
                CambiarColorControles(this, Color.WhiteSmoke, Color.Black);
            }
            else
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                CambiarColorControles(this, Color.FromArgb(45, 45, 48), Color.White);
            }
        }
        private void trackTemas_Scroll(object sender, EventArgs e)
        {
            CambiarTema();
        }
        private void cmbbxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(cmbbxFuente.Text, out float tamaño))
            {
                CambiarFuente(this, tamaño);
            }
        }

        private void CambiarFuente(Control padre, float tamaño)
        {
            foreach (Control c in padre.Controls)
            {
                try
                {
                    c.Font = new Font(c.Font.FontFamily, tamaño, c.Font.Style);
                }
                catch { }

                if (c.HasChildren)
                {
                    CambiarFuente(c, tamaño);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Reemplaza 'trackBarTema' por el nombre real de tu control en el diseño
            if (trackTemas.Value == 0) // Modo Claro
            {
                ConfigGlobal.ColorFondo = Color.White;
                ConfigGlobal.ColorTexto = Color.Black;
            }
            else // Modo Oscuro
            {
                ConfigGlobal.ColorFondo = Color.Black;
                ConfigGlobal.ColorTexto = Color.White;
            }

            // Configurar el tamaño de fuente si hay un ComboBox seleccionado
            if (cmbbxFuente.SelectedItem != null &&
                float.TryParse(cmbbxFuente.SelectedItem.ToString(), out float nuevoTamanio))
            {
                ConfigGlobal.TamanioFuente = nuevoTamanio;
            }

            // Aplicar a todas las ventanas abiertas en tiempo real
            ConfigGlobal.ActualizarVentanasAbiertas();
        }

    }
}
