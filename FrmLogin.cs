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

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassw.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos (Usuario y Contraseña).", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUser.Focus();

                return;
            }
            MessageBox.Show("Campos validados correctamente. Buscando en la base de datos...");

            DataAcces conBD = new DataAcces();

            using (MySqlConnection conexion = conBD.conexion())
            {
                if (conexion != null)
                {
                    try
                    {
                        string query = "SELECT rol FROM Usuario WHERE usuario = @usuario AND contrasena = @contrasena";

                        MySqlCommand comando = new MySqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@usuario", txtUser.Text);
                        comando.Parameters.AddWithValue("@contrasena", txtPassw.Text);

                        object resultado = comando.ExecuteScalar();

                        // Validamos que no sea nulov(si es nulo, significa que el usuario o contraseña no existen)
                        if (resultado != null)
                        {
                            //Convertimos lo que devolvió la base de datos a texto limpio (el rol)
                            string rolUsuario = resultado.ToString();

                            //1. Si el rol que guardó tu compañero en la BD es "Administrador"
                            if (rolUsuario == "Administrador")
                            {
                                MessageBox.Show("¡Bienvenido al sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmAdministrador pantallaPrincipalAdministrador = new FrmAdministrador();
                                pantallaPrincipalAdministrador.Show();
                                this.Hide();
                            }
                            //2. Si el rol que guardó tu compañero en la BD es "Empleado"
                            else if (rolUsuario == "Empleado")
                            {
                                MessageBox.Show("¡Bienvenido al sistema!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FrmEmpleado pantallaPrincipalEmpleado = new FrmEmpleado();
                                pantallaPrincipalEmpleado.Show();
                                this.Hide();
                            }
                            //Por si acaso hay algún error de dedo en la base de datos (ej. "empleado" en minúscula)
                            else
                            {
                                MessageBox.Show("Rol de usuario no reconocido (" + rolUsuario + ").", "Error de Rol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // Si la base de datos devolvió null, las credenciales están mal
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
