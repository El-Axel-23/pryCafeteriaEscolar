using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class FrmConfiguracion : UserControl
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void configuracion_Load(object sender, EventArgs e)
        {
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
            if (trackTemas != null && trackTemas.Value == 0)
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
                c.Font = new Font(c.Font.FontFamily, tamaño, c.Font.Style);

                if (c.HasChildren)
                {
                    CambiarFuente(c, tamaño);
                }
            }
        }
    }
}
