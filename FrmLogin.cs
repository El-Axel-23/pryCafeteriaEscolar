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

namespace pryCafeteriaEscolar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                DataAcces con = new DataAcces();
                con.conexion();
                MessageBox.Show("coneccion ecitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassw.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos (Usuario y Contraseña).", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUser.Focus();

                return;
            }
            MessageBox.Show("Campos validados correctamente. Buscando en la base de datos...");

            Conexion conBD = new Conexion();

            using (MySqlConnection conexion = conBD.obtenerConexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        string query = "SELECT COUNT(*) FROM usuarios WHERE username = @username AND PASSWORD = @PASSWORD";

                        MySqlCommand comando = new MySqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@username", txtUser.Text);
                        comando.Parameters.AddWithValue("@PASSWORD", txtPassw.Text);

                        object resultado = comando.ExecuteScalar();

                        // Validamos que no sea nulo y convertimos de forma segura
                        if (resultado != null && Convert.ToInt32(resultado) > 0)
                        {
                            // ¡Aquí pones tu código de acceso exitoso!
                            MessageBox.Show("¡Bienvenido al sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (txtUser == "AdminEmpleado")
                            {
                                FrmEmpleado pantallaPrincipal = new FrmEmpleado();
                                pantallaPrincipal.Show();
                                this.Hide();
                            }
                            else if(txtUser == "AdminEncargado")
                            {
                                FrmAdministrador pantallaPrincipal = new FrmAdministrador();
                                pantallaPrincipal.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al buscar el usuario: " + ex.Message, "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    }
}
