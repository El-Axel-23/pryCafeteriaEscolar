using MySql.Data.MySqlClient;
using pryCafeteriaEscolar.Base_de_datos;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pryCafeteriaEscolar
{
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();

            txtBuscar.Text = "Buscar producto";
            txtBuscar.ForeColor = Color.Gray;
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar producto";
            txtBuscar.ForeColor = Color.Gray;

            CargarEntradas();
            ActualizarContadores();
        }

        // =====================================================
        // CARGAR DATOS EN LA TABLA
        // =====================================================
        private void CargarEntradas(string busqueda = "")
        {
            try
            {
                DataAcces acceso = new DataAcces();

                using (MySqlConnection conexion = acceso.conexion())
                {
                    string consulta = @"
                        SELECT
                            p.descripcion AS Producto,
                            dc.cantidad AS Cantidad,
                            pr.nombre AS Proveedor,
                            DATE_FORMAT(c.fecha, '%d/%m/%Y %H:%i') AS Fecha
                        FROM Detalle_compra dc
                        INNER JOIN Compra c
                            ON dc.id_compra = c.id_compra
                        INNER JOIN Producto p
                            ON dc.codigo_barra = p.codigo_barra
                        INNER JOIN Proveedor pr
                            ON c.RFC = pr.RFC
                        WHERE p.descripcion LIKE @buscar
                           OR p.codigo_barra LIKE @buscar
                           OR pr.nombre LIKE @buscar
                        ORDER BY c.fecha DESC;";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue( "@buscar", "%" + busqueda + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Evita que aparezcan columnas repetidas
                    dtgTabla.AutoGenerateColumns = false;

                    // Relaciona las columnas del diseñador
                    // con los resultados de la consulta
                    colProducto.DataPropertyName = "Producto";
                    colCantidad.DataPropertyName = "Cantidad";
                    colProveedor.DataPropertyName = "Proveedor";
                    colFecha.DataPropertyName = "Fecha";

                    dtgTabla.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "No se pudieron cargar las entradas.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // BUSCAR PRODUCTO
        // =====================================================
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar producto")
            {
                txtBuscar.Clear();
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar producto";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar producto")
            {
                CargarEntradas();
            }
            else
            {
                CargarEntradas(txtBuscar.Text.Trim());
            }
        }

        // =====================================================
        // ACTUALIZAR CONTADORES
        // =====================================================
        private void ActualizarContadores()
        {
            try
            {
                DataAcces acceso = new DataAcces();

                using (MySqlConnection conexion = acceso.conexion())
                {
                    // Productos diferentes registrados
                    string consultaProductos = @"
                        SELECT COUNT(DISTINCT codigo_barra)
                        FROM Detalle_compra;";

                    MySqlCommand comandoProductos =
                        new MySqlCommand(
                            consultaProductos,
                            conexion
                        );

                    lbcontadorP.Text =
                        comandoProductos.ExecuteScalar().ToString();

                    // Total de entradas registradas
                    string consultaEntradas = @"
                        SELECT COUNT(*)
                        FROM Compra;";

                    MySqlCommand comandoEntradas =
                        new MySqlCommand(
                            consultaEntradas,
                            conexion
                        );

                    lbcontadorE.Text =
                        comandoEntradas.ExecuteScalar().ToString();

                    // Total de proveedores
                    string consultaProveedores = @"
                        SELECT COUNT(*)
                        FROM Proveedor;";

                    MySqlCommand comandoProveedores =
                        new MySqlCommand(
                            consultaProveedores,
                            conexion
                        );

                    lbcontadorproveedores.Text =
                        comandoProveedores.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron actualizar los contadores.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Se deja porque está conectado desde el Designer
        private void dtgTabla_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        // Se deja vacío hasta programar Nueva entrada
        private void btnEntradas_Click(
            object sender,
            EventArgs e)
        {
        }

      
    }
}