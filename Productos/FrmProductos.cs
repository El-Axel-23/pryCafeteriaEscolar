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
    public partial class FrmProductos : Form
    {
        string CodigoOriginal = "";
        bool EditProduct = false;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProduct();
            CargarCategoriascmb();

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtcodigo.Focus();
        }

        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT p.codigo_barra,p.id_categoria,c.nombre AS categoria,p.descripcion,p.precio_venta,p.stock FROM Producto p INNER JOIN Categoria c ON p.id_categoria = c.id_categoria WHERE p.codigo_barra LIKE @buscar OR p.descripcion LIKE @buscar OR c.nombre LIKE @buscar";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBuscarProduct.Text.Trim() + "%");

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProductos.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarProduct()
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT p.codigo_barra,p.id_categoria,c.nombre AS categoria,p.descripcion,p.precio_venta,p.stock FROM Producto p INNER JOIN Categoria c ON p.id_categoria = c.id_categoria";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvProductos.DataSource = table;

                    dgvProductos.Columns["id_categoria"].Visible = false;
                    dgvProductos.Columns["categoria"].HeaderText = "Categoria";
                    dgvProductos.Columns["descripcion"].HeaderText = "Descripcion";
                    dgvProductos.Columns["precio_venta"].HeaderText = "Precio";
                    dgvProductos.Columns["stock"].HeaderText = "Stock";

                    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvProductos.AllowUserToAddRows = false;
                    dgvProductos.RowHeadersVisible = false;
                    dgvProductos.MultiSelect = false;
                    dgvProductos.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CargarCategoriascmb()
        {
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"SELECT id_categoria,nombre FROM Categoria ORDER BY nombre";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    cmbCatego.DataSource = table;
                    cmbCatego.DisplayMember = "nombre";
                    cmbCatego.ValueMember = "id_categoria";
                    cmbCatego.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void limpiarProduct()
        {
            txtcodigo.Clear();
            txtDescripcion.Clear();
            nudprecio.Value = 0;
            nudStock.Value = 0;
            cmbCatego.SelectedIndex = -1;
            CodigoOriginal = "";
            EditProduct = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtcodigo.Focus();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtcodigo.Text = fila.Cells["codigo_barra"].Value.ToString();
                txtDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
                nudprecio.Value = Convert.ToDecimal(fila.Cells["precio_venta"].Value);
                nudStock.Value = Convert.ToDecimal(fila.Cells["stock"].Value);

                cmbCatego.Text = fila.Cells["categoria"].Value.ToString();
                CodigoOriginal = txtcodigo.Text;
                EditProduct = true;
                btnEditar .Enabled = true;
                btnEliminar .Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Trim() == "")
            {
                MessageBox.Show("ingrese el codigo de barras.");
                txtcodigo.Focus();
                return;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("ingrese la descripcion del producto.");
                txtDescripcion.Focus();
                return;
            }
            if (cmbCatego.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoria.");
                cmbCatego.Focus();
                return;
            }
            if (!EditProduct)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"INSERT INTO Producto(codigo_barra,id_categoria,descripcion,precio_venta,stock) VALUES(@codigo,@categoria,@descripcion,@precio,@stock)";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim());
                        command.Parameters.AddWithValue("@categoria", cmbCatego.SelectedValue);
                        command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                        command.Parameters.AddWithValue("@precio", nudprecio.Value);
                        command.Parameters.AddWithValue("@stock", nudStock.Value);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto guardado correctamente");
                    CargarProduct();
                    limpiarProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta editando un producto. Por favor use el boton editar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!EditProduct)
            {
                MessageBox.Show("Seleccione un producto para editar.");
                return;
            }
            if (txtcodigo.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || cmbCatego.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }
            try
            {
                DataAcces data = new DataAcces();

                using (MySqlConnection connection = data.Dataacces())
                {
                    string sql = @"UPDATE Producto SET codigo_barra = @codigo,id_categoria = @categoria,descripcion = @descripcion,precio_venta = @precio,stock = @stock WHERE codigo_barra = @codigoOriginal";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim());
                    command.Parameters.AddWithValue("@categoria", cmbCatego.SelectedValue);
                    command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                    command.Parameters.AddWithValue("@precio", nudprecio.Value);
                    command.Parameters.AddWithValue("@stock", nudStock.Value);
                    command.Parameters.AddWithValue("@codigoOriginal", CodigoOriginal);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Producto actualizado correctamente");
                CargarProduct();
                limpiarProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!EditProduct)
            {
                MessageBox.Show("Seleccione una producto para eleminar.");
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    DataAcces data = new DataAcces();

                    using (MySqlConnection connection = data.Dataacces())
                    {
                        string sql = @"DELETE FROM Producto WHERE codigo_barra = @codigo";

                        MySqlCommand command = new MySqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@codigo", CodigoOriginal);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto eliminado correctamente");
                    CargarProduct();
                    limpiarProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
