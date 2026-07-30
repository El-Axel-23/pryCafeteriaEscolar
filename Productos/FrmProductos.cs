using MySql.Data.MySqlClient;
using pryCafeteriaEscolar.Base_de_datos;
using pryCafeteriaEscolar.Productos;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        private void CargandoP()
        {
            try
            {
                DataAcces data = new DataAcces();
                MySqlConnection connection = data.Dataacces();

                string Sql = @"SELECT p.codigo_barra,p.id_categoria,c.nombre AS Categoria,p.descripcion,p.precio_venta,p.stock
                FROM Producto p INNER JOIN Categoria c ON p.id_categoria = c.id_categoria";

                MySqlDataAdapter adapter = new MySqlDataAdapter(Sql, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvproductos.DataSource = table;
                dgvproductos.Columns["id_categoria"].Visible = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargandoProve()
        {

            DataAcces data = new DataAcces();
            MySqlConnection connection = data.Dataacces();

            string Sql = @"SELECT * FROM Proveedor";

            MySqlDataAdapter adapter = new MySqlDataAdapter(Sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView2.DataSource = table;
            connection.Close();


        }
        private void CargandoCatego()
        {


            DataAcces data = new DataAcces();
            MySqlConnection connection = data.Dataacces();

            string Sql = @"SELECT * FROM Categoria";

            MySqlDataAdapter adapter = new MySqlDataAdapter(Sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close();


        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargandoP();
            CargandoProve();
            CargandoCatego();

            dgvproductos.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnventas_Click(object sender, EventArgs e)
        {

        }

        private void btncaja_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAcces data = new DataAcces();
                MySqlConnection connection = data.Dataacces();

                string Sql =
                @"SELECT p.codigo_barra,c.nombre AS Categoria,p.descripcion,
                p.precio_venta,p.stock FROM Producto p INNER JOIN Categoria c ON p.id_categoria = c.id_categoria WHERE p.descripcion
                LIKE @buscar OR p.codigo_barra LIKE @buscar OR c.nombre LIKE @buscar";

                MySqlDataAdapter adapter = new MySqlDataAdapter(Sql, connection);
                DataTable table = new DataTable();
                adapter.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtbuscar.Text.Trim() + "%");
                adapter.Fill(table);

                dgvproductos.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnuevoproducto_Click(object sender, EventArgs e)
        {
           FrmNuevoproducto frm = new FrmNuevoproducto();
           frm.ShowDialog();
           CargandoP();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dgvproductos.CurrentRow == null)
            {
                MessageBox.Show("seleccione un producto.");
                return;
            }
            FrmNuevoproducto frm = new FrmNuevoproducto();
            frm.ProductoEdit = true;
            frm.CodOriginal = dgvproductos.CurrentRow.Cells["codigo_barra"].Value.ToString();
            frm.CargaD(dgvproductos.CurrentRow.Cells["codigo_barra"].Value.ToString(),
                Convert.ToInt32(dgvproductos.CurrentRow.Cells["id_categoria"].Value),
                dgvproductos.CurrentRow.Cells["descripcion"].Value.ToString(),
                Convert.ToDecimal(dgvproductos.CurrentRow.Cells["precio_venta"].Value),
                Convert.ToInt32(dgvproductos.CurrentRow.Cells["stock"].Value)
            );
            frm.ShowDialog();
            CargandoP();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dgvproductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            DialogResult result = MessageBox.Show("Esta seguro de eliminar este producto?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                try
                {
                    DataAcces data = new DataAcces();
                    using (MySqlConnection conn = data.Dataacces())
                    {
                        string Sql = "DELETE FROM Producto WHERE codigo_barra=@codigo";
                        MySqlCommand command = new MySqlCommand(Sql, conn);
                        command.Parameters.AddWithValue("@codigo", dgvproductos.CurrentRow.Cells["codigo_barra"].Value.ToString());
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto eliminado correctamente");
                    CargandoP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonProve_Click(object sender, EventArgs e)
        {
            FrmNuevoproveedor frn = new FrmNuevoproveedor();

            frn.ShowDialog();
            CargandoProve();
        }

        private void editarProve_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }
            FrmNuevoproveedor frm = new FrmNuevoproveedor();
            frm.proveedorEd = true;
            frm.RFCOriginal = dataGridView2.CurrentRow.Cells["RFC"].Value.ToString();

            frm.CargarDp(dataGridView2.CurrentRow.Cells["RFC"].Value.ToString(), dataGridView2.CurrentRow.Cells["nombre"].Value.ToString(), dataGridView2.CurrentRow.Cells["correo"].Value.ToString(),
                dataGridView2.CurrentRow.Cells["telefono"].Value.ToString(), dataGridView2.CurrentRow.Cells["calle"].Value.ToString(), dataGridView2.CurrentRow.Cells["colonia"].Value.ToString(),
                dataGridView2.CurrentRow.Cells["ciudad"].Value.ToString(), dataGridView2.CurrentRow.Cells["cp"].Value.ToString()
            );
            frm.ShowDialog();
            CargandoProve();
        }

        private void ElimProve_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow.Cells == null)
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }
            DialogResult result = MessageBox.Show("Desea eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataAcces data = new DataAcces();
                    using(MySqlConnection connection = data.Dataacces())
                    {
                        string Sql = "DELETE FROM Proveedor WHERE RFC=@rfc";
                        MySqlCommand command = new MySqlCommand(Sql, connection);

                        command.Parameters.AddWithValue("@rfc", dataGridView2.CurrentRow.Cells["RFC"].Value.ToString());
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Proveedor eliminado correctamente.");
                    CargandoProve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
