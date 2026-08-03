using MySql.Data.MySqlClient;
using pryCafeteriaEscolar.Base_de_datos;
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
            frmConfiguracion_Resize(null, null);            
            CargarDatosEmpresa();

            if (cmbbxFuente.SelectedIndex == -1)
            {
                cmbbxFuente.SelectedIndex = 0;
            }
            CambiarTema();
        }

        private void CargarDatosEmpresa()
        {
            try
            {
                DataAcces data = new DataAcces();
                MySqlConnection connection = data.Dataacces();

                string sql = @"SELECT nombre, direccion, telefono, correo FROM InformacionCafeteria LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["nombre"].ToString();
                    txtDireccion.Text = reader["direccion"].ToString();
                    txtTelefono.Text = reader["telefono"].ToString();
                    txtCorreo.Text = reader["correo"].ToString();
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la cafetería: " + ex.Message);
            }
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
                this.BackColor = Color.NavajoWhite;
                CambiarColorControles(this, Color.NavajoWhite, Color.Black);
            }
            else
            {
                this.BackColor = Color.FromArgb(64, 0, 0);
                CambiarColorControles(this, Color.FromArgb(64, 0, 0), Color.White);
            }
        }

        private void trackTemas_Scroll(object sender, EventArgs e)
        {
            CambiarTema();
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
            if (trackTemas.Value == 0)
            {
                ConfigGlobal.ColorFondo = Color.NavajoWhite;
                ConfigGlobal.ColorTexto = Color.Black;
            }
            else
            {
                ConfigGlobal.ColorFondo = Color.FromArgb(64, 0, 0);
                ConfigGlobal.ColorTexto = Color.White;
            }

            if (cmbbxFuente.SelectedItem != null)
            {
                float tamaño;

                if (float.TryParse(cmbbxFuente.SelectedItem.ToString(), out tamaño))
                {
                    ConfigGlobal.TamanioFuente = tamaño;
                }
            }

            ConfigGlobal.ActualizarVentanasAbiertas();

            MessageBox.Show("Cambios guardados correctamente.","Configuración",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHoraSistema.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Application.OpenForms["FrmAdministrador"]?.Close();
            this.Hide();
        }

        private void frmConfiguracion_Resize(object sender, EventArgs e)
        {
            panelPrincipal.Left = (this.ClientSize.Width - panelPrincipal.Width) / 2;
            panelPrincipal.Top = (this.ClientSize.Height - panelPrincipal.Height) / 2;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxFuente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}