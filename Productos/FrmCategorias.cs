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
    public partial class FrmCategorias : Form
    {
        int idCateg = 0;
        bool editCateg = false;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCatego();
            txtID.Enabled = false;
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
        }
        private void CargarCatego()//Metodo para el cargar los datos de la base de datos
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT id_categoria, nombre FROM categoria";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvCategorias.DataSource = table;

                    dgvCategorias.AllowUserToAddRows = false;
                    dgvCategorias.RowHeadersVisible = false;
                    dgvCategorias.Columns["nombre"].HeaderText = "Categoria";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtBuscarCateg_TextChanged(object sender, EventArgs e)//metodo para buscar
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT id_categoria, nombre FROM Categoria WHERE nombre LIKE @buscar";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);

                    adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBuscarCateg.Text.Trim() + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvCategorias.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpiar()//metodo para limpiar
        {
            txtID.Clear();
            txtNombreCategoria.Clear();
            idCateg = 0;
            editCateg = false;
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled=false;
            txtNombreCategoria.Focus();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)//evento para el datagrid
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                txtID.Text = fila.Cells["id_categoria"].Value.ToString();
                txtNombreCategoria.Text = fila.Cells["nombre"].Value.ToString();

                idCateg = Convert.ToInt32(fila.Cells["id_categoria"].Value.ToString());
                editCateg = true;
                btnEditarCategoria.Enabled = true;
                btnEliminarCategoria.Enabled = true;
            }

        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)//boton nuevo
        {
            if (txtNombreCategoria.Text.Trim()=="")
            {
                MessageBox.Show("ingrese el nombre de la categoria");
                txtNombreCategoria.Focus();
                return;
            }
            if (editCateg == false)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"INSERT INTO categoria(nombre) VALUES(@nombre)";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text.Trim());
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Categoria guardada correctamente");
                    CargarCatego();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta editando.Por favor use el boton de editar.");
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)//boton editar
        {
            if (!editCateg)
            {
                MessageBox.Show("ingrese el nombre de la categoria para editar.");
                return;
            }
            if(txtNombreCategoria.Text.Trim() == "")
            {
                MessageBox.Show("ingrese el nombre de la categoria");
                txtNombreCategoria.Focus();
                return;
            }
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"UPDATE Categoria SET nombre = @nombre WHERE id_categoria = @id";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@nombre", txtNombreCategoria.Text.Trim());
                    command.Parameters.AddWithValue("@id", idCateg);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Categoria actualizada correctamente");
                CargarCatego();
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if(!editCateg)
            {
                MessageBox.Show("Seleccione una categoria para eleminar.");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Desea eliminar esta categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"DELETE FROM Categoria WHERE id_categoria = @id";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@id", idCateg);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Categoria eliminada correctamente");
                    CargarCatego();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
