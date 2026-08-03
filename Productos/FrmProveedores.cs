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

namespace pryCafeteriaEscolar.Productos
{
    public partial class FrmProveedores : Form
    {
        string rfcOriginal = "";
        bool EditProve = false;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProvee();
            txtRFC.Focus();
            btnEditarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;


        }
        private void CargarProvee()
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT RFC,nombre,correo,telefono,calle,colonia,ciudad,cp FROM Proveedor";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvProveedores.DataSource = table;
                    dgvProveedores.AllowUserToAddRows = false;
                    dgvProveedores.RowHeadersVisible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void limpiarProve()
        {
            txtRFC.Clear();
            txtNombreProve.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtColonia.Clear();
            txtCiudad.Clear();
            txtCp.Clear();

            EditProve = false;
            rfcOriginal = "";
            btnEditarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;
            
            txtRFC.Focus();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtRFC.Text = fila.Cells["RFC"].Value.ToString();
                txtNombreProve.Text = fila.Cells["nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtCalle.Text = fila.Cells["calle"].Value.ToString();
                txtColonia.Text = fila.Cells["colonia"].Value.ToString();
                txtCiudad.Text = fila.Cells["ciudad"].Value.ToString();
                txtCp.Text = fila.Cells["cp"].Value.ToString();

                rfcOriginal = txtRFC.Text;
                EditProve = true;

                btnEditarProveedor.Enabled = true;
                btnEliminarProveedor.Enabled = true;

            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (txtRFC.Text.Trim() == "" || txtNombreProve.Text.Trim() == "")
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }
            if (!EditProve)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"INSERT INTO Proveedor(RFC,nombre,correo,telefono,calle,colonia,ciudad,cp) VALUES(@rfc,@nombre,@correo,@telefono,@calle,@colonia,@ciudad,@cp)";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@rfc", txtRFC.Text.Trim());
                        command.Parameters.AddWithValue("@nombre", txtNombreProve.Text.Trim());
                        command.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        command.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                        command.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                        command.Parameters.AddWithValue("@colonia", txtColonia.Text.Trim());
                        command.Parameters.AddWithValue("@ciudad", txtColonia.Text.Trim());
                        command.Parameters.AddWithValue("@cp", txtCp.Text.Trim());
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Proveedor guardado correctamente");
                    CargarProvee();
                    limpiarProve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta editando un proveedor. Por favor use el boton editar.");
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (!EditProve)
            {
                MessageBox.Show("Seleccione un proveedor para editar.");
                return;
            }
            if (txtRFC.Text.Trim() == "" || txtNombreProve.Text.Trim() == "")
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"UPDATE Proveedor SET RFC = @rfc,nombre = @nombre,correo = @correo,telefono = @telefono,calle = @calle,colonia = @colonia,ciudad = @ciudad,cp = @cp WHERE RFC = @rfcOriginal";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@rfc", txtRFC.Text.Trim());
                    command.Parameters.AddWithValue("@nombre", txtNombreProve.Text.Trim());
                    command.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    command.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    command.Parameters.AddWithValue("@calle", txtCalle.Text.Trim());
                    command.Parameters.AddWithValue("@colonia", txtColonia.Text.Trim());
                    command.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                    command.Parameters.AddWithValue("@cp", txtCp.Text.Trim());
                    command.Parameters.AddWithValue("@rfcOriginal", rfcOriginal);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Proveedor actualizado correctamente");
                CargarProvee();
                limpiarProve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (!EditProve)
            {
                MessageBox.Show("Seleccione una proveedor para eleminar.");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Desea eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"DELETE FROM Proveedor WHERE RFC = @rfc";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@rfc", rfcOriginal);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Proveedor eliminado correctamente");
                    CargarProvee();
                    limpiarProve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtBuscarProvee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT RFC,nombre,correo,telefono,calle,colonia,ciudad,cp FROM Proveedor WHERE RFC LIKE @buscar OR nombre LIKE @buscar OR correo LIKE @buscar OR telefono LIKE @buscar";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBuscarProvee.Text.Trim() + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProveedores.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
