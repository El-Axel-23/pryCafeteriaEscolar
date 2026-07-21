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
                    if (conexion == null)
                    {
                        MessageBox.Show(
                            "No se pudo conectar con la base de datos.",
                            "Error de conexión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }

                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    string query =
                        "SELECT rol FROM Usuario " +
                        "WHERE usuario = @usuario " +
                        "AND contrasena = @contrasena";

                    using (MySqlCommand comando =
                           new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@usuario",
                            txtUser.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@contrasena",
                            txtPassw.Text
                        );

                        object resultado = comando.ExecuteScalar();

                        if (resultado == null)
                        {
                            MessageBox.Show(
                                "Usuario o contraseña incorrectos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            return;
                        }

                        string rolUsuario =
                            resultado.ToString().Trim();

                        if (rolUsuario.Equals(
                            "Administrador",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "¡Bienvenido al sistema!",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            FrmAdministrador administrador =
                                new FrmAdministrador();

                            administrador.Show();
                            this.Hide();
                        }
                        else if (rolUsuario.Equals(
                            "Empleado",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "¡Bienvenido al sistema!",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            FrmEmpleado empleado =
                                new FrmEmpleado();

                            empleado.Show();
                            this.Hide();
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
                    "Error con la base de datos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
