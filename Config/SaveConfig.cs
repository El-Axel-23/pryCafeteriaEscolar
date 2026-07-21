using System.Drawing;
using System.Windows.Forms;

namespace pryCafeteriaEscolar.Configuracion
{
    public static class ConfigGlobal
    {
        public static Color ColorFondo { get; set; } = Color.White;
        public static Color ColorTexto { get; set; } = Color.Black;
        public static float TamanioFuente { get; set; } = 9f;

        public static void AplicarEstilo(Form formulario)
        {
            formulario.BackColor = ColorFondo;

            AplicarEstiloControles(formulario.Controls);
        }

        private static void AplicarEstiloControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {

                if (c is TextBox txt)
                {
                    if (ColorFondo == Color.Black)
                    {
                        txt.BackColor = Color.FromArgb(45, 45, 48);
                        txt.ForeColor = Color.White;
                    }
                    else
                    {
                        txt.BackColor = Color.White;
                        txt.ForeColor = Color.Black;
                    }
                }
                else if (c is DataGridView dgv)
                {
                    if (ColorFondo == Color.Black)
                    {
                        dgv.BackgroundColor = Color.FromArgb(30, 30, 30);
                        dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                        dgv.DefaultCellStyle.ForeColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgv.EnableHeadersVisualStyles = false;
                    }
                    else
                    {
                        dgv.BackgroundColor = SystemColors.AppWorkspace;
                        dgv.DefaultCellStyle.BackColor = Color.White;
                        dgv.DefaultCellStyle.ForeColor = Color.Black;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                        dgv.EnableHeadersVisualStyles = true;
                    }
                }
                else if (c is Panel || c is GroupBox)
                {
                    c.BackColor = ColorFondo;
                    c.ForeColor = ColorTexto;
                }
                else
                {
                    c.ForeColor = ColorTexto;
                }
                c.Font = new Font(c.Font.FontFamily, TamanioFuente, c.Font.Style);

                if (c.HasChildren)
                {
                    AplicarEstiloControles(c.Controls);
                }
            }
        }

        public static void ActualizarVentanasAbiertas()
        {
            foreach (Form frm in Application.OpenForms)
            {
                AplicarEstilo(frm);
                frm.Refresh();
            }
        }
    }
}