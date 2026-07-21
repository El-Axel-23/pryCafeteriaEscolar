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

                string Sql = @"SELECT nombreCafe, direccionCafe, telefonoCafe, correoCafe FROM Empresa LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(Sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["nombreCafe"].ToString();
                    txtDireccion.Text = reader["direccionCafe"].ToString();
                    txtTelefono.Text = reader["telefonoCafe"].ToString();
                    txtCorreo.Text = reader["correoCafe"].ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de la empresa: " + ex.Message);
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
                ConfigGlobal.ColorFondo = Color.White;
                ConfigGlobal.ColorTexto = Color.Black;
            }
            else
            {
                ConfigGlobal.ColorFondo = Color.Black;
                ConfigGlobal.ColorTexto = Color.White;
            }

            if (cmbbxFuente.SelectedItem != null && float.TryParse(cmbbxFuente.SelectedItem.ToString(), out float nuevoTamanio))
            {
                ConfigGlobal.TamanioFuente = nuevoTamanio;
            }

            ConfigGlobal.ActualizarVentanasAbiertas();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHoraSistema.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}