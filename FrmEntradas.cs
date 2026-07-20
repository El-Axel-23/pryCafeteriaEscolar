using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
              /*/
                Conexion conexion = new Conexion();

                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql = @"SELECT producto_id, codigo, descripcion, precio, stock  FROM productos WHERE codigo LIKE @buscar OR descripcion LIKE @buscar";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, cn);
                    da.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txtBusqueda.Text.Trim() + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProductos.DataSource = dt;
                
                /*/
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            /*/
             string codigo = txtCodigo.Text.Trim();
            string descripcion = txtNombre.Text.Trim();

            if (codigo == "" || descripcion == "")
            {
                MessageBox.Show("Código y descripción son obligatorios.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser numérico.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser numérico.");
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (MySqlConnection cn = conexion.ObtenerConexion())
                {
                    string sql = @"INSERT INTO productos  (codigo, descripcion, precio, stock) VALUES (@codigo, @descripcion, @precio, @stock)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@stock", stock);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto guardado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }/*/
        }

        private void dtgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
