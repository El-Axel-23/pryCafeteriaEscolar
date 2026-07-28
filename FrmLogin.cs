using MySql.Data.MySqlClient;
using pryCafeteriaEscolar.Base_de_datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
       string.IsNullOrWhiteSpace(txtPassw.Text))
            {
                MessageBox.Show(
                    "Por favor, llene todos los campos.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUser.Focus();
                return;
            }

            DataAcces conBD = new DataAcces();

            try
            {
                using (MySqlConnection conexion = conBD.Dataacces())
                {
                    string query = @"
                SELECT rol
                FROM Usuario
                WHERE usuario = @usuario
                AND contrasena = @contrasena
                AND activo = 1
                LIMIT 1;";

                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@usuario",
                            txtUser.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@contrasena",
                            txtPassw.Text.Trim()
                        );

                        object resultado = comando.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show(
                                "Usuario o contraseña incorrectos.",
                                "Acceso denegado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtPassw.Clear();
                            txtPassw.Focus();
                            return;
                        }

                        string rolUsuario = resultado.ToString().Trim();

                        MessageBox.Show(
                            "¡Bienvenido al sistema!",
                            "Inicio de sesión correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        if (rolUsuario.Equals(
                            "Administrador",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            FrmAdministrador administrador =
                                new FrmAdministrador();

                            administrador.Show();
                            this.Hide();
                        }
                        else if (rolUsuario.Equals(
                            "Empleado",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            FrmEmpleado empleado = new FrmEmpleado();

                            empleado.Show();
                            this.Hide();
                        }
                        else if (rolUsuario.Equals(
                            "Supervisor",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "El rol Supervisor todavía no tiene un formulario asignado.",
                                "Rol sin formulario",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Rol no reconocido: " + rolUsuario,
                                "Error de rol",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Error con la base de datos:\n" + ex.Message,
                    "Error de MySQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}