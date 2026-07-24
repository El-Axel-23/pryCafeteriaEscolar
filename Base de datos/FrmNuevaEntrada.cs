using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace pryCafeteriaEscolar.Base_de_datos
{
    public partial class FrmNuevaEntrada : Form
    {
        private string codigoProductoSeleccionado = "";

        public FrmNuevaEntrada()
        {
            InitializeComponent();
        }

        private void FrmNuevaEntrada_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarProveedores();
        }

        private void ConfigurarControles()
        {
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 10000;
            nudCantidad.Value = 1;

            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Value = DateTime.Now;

            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

            txtProducto.Clear();
            txtPreciocompra.Clear();
            rbtObservaciones.Clear();
        }

        // =====================================================
        // CARGAR PROVEEDORES
        // =====================================================
        private void CargarProveedores()
        {
            try
            {
                DataAcces acceso = new DataAcces();

                using (MySqlConnection conexion = acceso.Dataacces())
                {
                    string consulta = @"
                        SELECT RFC, nombre
                        FROM Proveedor
                        ORDER BY nombre;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbProveedor.DataSource = tabla;
                    cmbProveedor.DisplayMember = "nombre";
                    cmbProveedor.ValueMember = "RFC";
                    cmbProveedor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los proveedores.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // BUSCAR PRODUCTO
        // =====================================================
        private void btnBuscarproducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show(
                    "Escribe el código de barras o el nombre del producto.",
                    "Buscar producto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProducto.Focus();
                return;
            }

            try
            {
                DataAcces acceso = new DataAcces();

                using (MySqlConnection conexion = acceso.Dataacces())
                {
                    string consulta = @"
                SELECT codigo_barra, descripcion
                FROM Producto
                WHERE codigo_barra = @codigo
                   OR descripcion LIKE @descripcion
                LIMIT 1;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@codigo",
                            txtProducto.Text.Trim()
                        );

                        comando.Parameters.AddWithValue(
                            "@descripcion",
                            "%" + txtProducto.Text.Trim() + "%"
                        );

                        using (MySqlDataReader lector =
                               comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                codigoProductoSeleccionado =
                                    lector["codigo_barra"].ToString();

                                string descripcion =
                                    lector["descripcion"].ToString();

                                txtProducto.Text =
                                    codigoProductoSeleccionado +
                                    " - " +
                                    descripcion;

                                nudCantidad.Focus();
                            }
                            else
                            {
                                codigoProductoSeleccionado = "";

                                MessageBox.Show(
                                    "No se encontró el producto.",
                                    "Producto no encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                txtProducto.SelectAll();
                                txtProducto.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo buscar el producto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        // =====================================================
        // GUARDAR ENTRADA
        // =====================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            decimal precioCompra;

            string textoPrecio = txtPreciocompra.Text
                .Replace("$", "")
                .Trim();

            bool precioValido = decimal.TryParse(
                textoPrecio,
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out precioCompra
            );

            if (!precioValido)
            {
                precioValido = decimal.TryParse(
                    textoPrecio.Replace(",", "."),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out precioCompra
                );
            }

            if (!precioValido || precioCompra <= 0)
            {
                MessageBox.Show(
                    "Escribe un precio de compra válido.",
                    "Precio incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPreciocompra.Focus();
                return;
            }

            int cantidad = Convert.ToInt32(nudCantidad.Value);

            decimal subtotal = cantidad * precioCompra;
            decimal total = subtotal;

            string rfcProveedor =
                cmbProveedor.SelectedValue.ToString();

            DataAcces acceso = new DataAcces();

            using (MySqlConnection conexion = acceso.Dataacces())
            using (MySqlTransaction transaccion =
                   conexion.BeginTransaction())
            {
                try
                {
                    // Registrar la compra
                    string insertarCompra = @"
                        INSERT INTO Compra
                            (RFC, fecha, total)
                        VALUES
                            (@RFC, @fecha, @total);";

                    long idCompra;

                    using (MySqlCommand comandoCompra =
                           new MySqlCommand(
                               insertarCompra,
                               conexion,
                               transaccion))
                    {
                        comandoCompra.Parameters.AddWithValue(
                            "@RFC",
                            rfcProveedor
                        );

                        comandoCompra.Parameters.AddWithValue(
                            "@fecha",
                            dtpFecha.Value
                        );

                        comandoCompra.Parameters.AddWithValue(
                            "@total",
                            total
                        );

                        comandoCompra.ExecuteNonQuery();

                        idCompra = comandoCompra.LastInsertedId;
                    }

                    // Registrar detalle de compra
                    string insertarDetalle = @"
                        INSERT INTO Detalle_compra
                            (
                                id_compra,
                                codigo_barra,
                                cantidad,
                                precio_compra,
                                subtotal
                            )
                        VALUES
                            (
                                @idCompra,
                                @codigoBarra,
                                @cantidad,
                                @precioCompra,
                                @subtotal
                            );";

                    using (MySqlCommand comandoDetalle =
                           new MySqlCommand(
                               insertarDetalle,
                               conexion,
                               transaccion))
                    {
                        comandoDetalle.Parameters.AddWithValue(
                            "@idCompra",
                            idCompra
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@codigoBarra",
                            codigoProductoSeleccionado
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@cantidad",
                            cantidad
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@precioCompra",
                            precioCompra
                        );

                        comandoDetalle.Parameters.AddWithValue(
                            "@subtotal",
                            subtotal
                        );

                        comandoDetalle.ExecuteNonQuery();
                    }

                    // Actualizar stock
                    string actualizarStock = @"
                        UPDATE Producto
                        SET stock = stock + @cantidad
                        WHERE codigo_barra = @codigoBarra;";

                    using (MySqlCommand comandoStock =
                           new MySqlCommand(
                               actualizarStock,
                               conexion,
                               transaccion))
                    {
                        comandoStock.Parameters.AddWithValue(
                            "@cantidad",
                            cantidad
                        );

                        comandoStock.Parameters.AddWithValue(
                            "@codigoBarra",
                            codigoProductoSeleccionado
                        );

                        comandoStock.ExecuteNonQuery();
                    }

                    transaccion.Commit();

                    MessageBox.Show(
                        "La entrada se guardó correctamente.\n\n" +
                        "Subtotal: $" + subtotal.ToString("N2"),
                        "Entrada registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();

                    MessageBox.Show(
                        "No se pudo guardar la entrada.\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // =====================================================
        // VALIDAR CAMPOS
        // =====================================================
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show(
                    "Escribe un producto.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProducto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(codigoProductoSeleccionado))
            {
                MessageBox.Show(
                    "Busca y selecciona el producto antes de guardar.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProducto.Focus();
                return false;
            }

            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecciona un proveedor.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbProveedor.Focus();
                return false;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Cantidad incorrecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudCantidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPreciocompra.Text))
            {
                MessageBox.Show(
                    "Escribe el precio de compra.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPreciocompra.Focus();
                return false;
            }

            return true;
        }

        // =====================================================
        // CANCELAR
        // =====================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas cancelar el registro de la entrada?",
                "Cancelar entrada",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(codigoProductoSeleccionado))
            {
                string textoEsperado =
                    codigoProductoSeleccionado + " - ";

                if (!txtProducto.Text.StartsWith(textoEsperado))
                {
                    codigoProductoSeleccionado = "";
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}