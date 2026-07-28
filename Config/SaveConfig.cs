using System.Drawing;
using System.Windows.Forms;

namespace pryCafeteriaEscolar.Configuracion
{
    public static class ConfigGlobal
    {
        public static Color ColorFondo { get; set; } = Color.NavajoWhite;
        public static Color ColorTexto { get; set; } = Color.Black;
        public static float TamanioFuente { get; set; } = 8f;

        public static void AplicarEstilo(Form formulario)
        {
            formulario.BackColor = ColorFondo;
            AplicarEstiloControles(formulario.Controls);
        }

        private static void AplicarEstiloControles(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;

                    if (ColorFondo == Color.FromArgb(64, 0, 0))
                    {
                        btn.BackColor = Color.FromArgb(60, 20, 15);
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = Color.FromArgb(120, 60, 40);
                    }
                    else
                    {
                        btn.BackColor = Color.Ivory;
                        btn.ForeColor = Color.Black;
                        btn.FlatAppearance.BorderColor = Color.Gray;
                    }
                }
                else if (c is TextBox txt)
                {
                    if (ColorFondo == Color.FromArgb(64, 0, 0))
                    {
                        txt.BackColor = Color.FromArgb(64, 0, 0);
                        txt.ForeColor = Color.White;
                    }
                    else
                    {
                        txt.BackColor = Color.NavajoWhite;
                        txt.ForeColor = Color.Black;
                    }
                }
                else if (c is DataGridView dgv)
                {
                    if (ColorFondo == Color.FromArgb(64, 0, 0))
                    {
                        dgv.BackgroundColor = Color.FromArgb(40, 25, 20);
                        dgv.DefaultCellStyle.BackColor = Color.FromArgb(55, 35, 28);
                        dgv.DefaultCellStyle.ForeColor = Color.White;
                        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 70, 35);
                        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 45, 35);
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(50, 30, 22);
                        dgv.EnableHeadersVisualStyles = false;
                    }
                    else
                    {
                        dgv.BackgroundColor = Color.BlanchedAlmond;
                        dgv.DefaultCellStyle.BackColor = Color.Moccasin;
                        dgv.DefaultCellStyle.ForeColor = Color.SaddleBrown;
                        dgv.DefaultCellStyle.SelectionBackColor = Color.Peru;
                        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 25, 10);
                        dgv.RowsDefaultCellStyle.BackColor = Color.NavajoWhite;
                        dgv.EnableHeadersVisualStyles = false;
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