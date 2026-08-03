using pryCafeteriaEscolar.Base_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace pryCafeteriaEscolar
{
    public partial class Ventas : UserControl
    {
        // Lista temporal para almacenar las filas agregadas a la tabla
        private List<DetalleVentaItem> listaDetalle = new List<DetalleVentaItem>();

        private readonly CultureInfo cultureMx = new CultureInfo("es-MX");

        public Ventas()
        {
            InitializeComponent();

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarMetodosPago();
            ConfigurarAutocompletadoProducto();
        }
        // --- Cargar ComboBox desde la BD ---
        private void CargarMetodosPago()
        {
            try
            {
                DataAcces db = new DataAcces();
                using (MySqlConnection conn = db.Dataacces())
                {
                    string query = "SELECT id_metodopago, nombre FROM Metodo_pago";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "nombre";
                    comboBox1.ValueMember = "id_metodopago";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar métodos de pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- AUTOCOMPLETADO EN EL TEXTBOX DE PRODUCTO ---
        private void ConfigurarAutocompletadoProducto()
        {
            try
            {
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                DataAcces db = new DataAcces();

                using (MySqlConnection conn = db.Dataacces())
                {
                    // Asume que la tabla de productos se llama Producto y la columna nombre
                    string query = "SELECT descripcion FROM Producto";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coleccion.Add(reader["descripcion"].ToString());
                        }
                    }
                }

                // Configurar propiedades de autocompletado en txtProduc
                txtProduc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProduc.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProduc.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception ex)
            {
                // Si la tabla aún no tiene datos o varía el nombre, no interrumpe el programa
                Console.WriteLine("Info Autocompletado: " + ex.Message);
            }
        }
        // --- BÚSQUEDA AUTOMÁTICA AL SELECCIONAR O PERDER EL FOCO EN PRODUCTO ---
        private void txtProduc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduc.Text)) return;

            try
            {
                DataAcces db = new DataAcces();
                using (MySqlConnection conn = db.Dataacces())
                {
                    string query = "SELECT codigo_barra, precio_venta FROM Producto WHERE descripcion = @descripcion LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@descripcion", "%" + txtProduc.Text.Trim() + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCodgProduc.Text = reader["codigo_barra"].ToString();
                            decimal precio = Convert.ToDecimal(reader["precio_venta"]);
                            txtPrecio.Text = precio.ToString("F2");
                        }
                        else
                        {
                            txtCodgProduc.Clear();
                            txtPrecio.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar datos del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // --- BOTÓN REGISTRAR (Agregar a DataGridView) ---
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduc.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor selecciona un producto válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            int.TryParse(txtCant.Text, out int cantidad);
            if (cantidad <= 0) cantidad = 0;

            decimal.TryParse(txtPrecio.Text, out decimal precioProd);

            DetalleVentaItem item = new DetalleVentaItem
            {
                codigo_Barra = txtCodgProduc.Text.Trim(),
                Producto = txtProduc.Text,
                Cantidad = cantidad,
                Precio = precioProd
            };

            listaDetalle.Add(item);
            ActualizarTabla();

            // Limpiar campos de entrada de producto
            txtProduc.Clear();
            txtCodgProduc.Clear();
            txtPrecio.Clear();
            txtCant.Text = "";
            txtProduc.Focus();
        }

        private void ActualizarTabla()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDetalle;

            decimal total = listaDetalle.Sum(x => x.Subtotal);
            txtTotalVenta.Text = total.ToString("C2", cultureMx);
        }
        // --- CALCULAR CAMBIO AL INGRESAR LO QUE RECIBE DEL CLIENTE ---
        private void txtRcbClient_TextChanged(object sender, EventArgs e)
        {
            decimal total = listaDetalle.Sum(x => x.Subtotal);
            

            if (decimal.TryParse(txtRcbClient.Text, out decimal recibido))
            {
                decimal cambio = recibido - total;
                txtCambio.Text = (cambio >= 0) ? cambio.ToString("C2", cultureMx) : "$0.00";
            }
            else
            {
                txtCambio.Text = "$0.00";
            }
        }

        // --- BOTÓN BORRAR / LIMPIAR ---
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            listaDetalle.Clear();
            ActualizarTabla();
            txtProduc.Clear();
            txtCodgProduc.Clear();
            txtPrecio.Clear();
            txtCant.Text = "";
            txtRcbClient.Clear();
            txtCambio.Clear();
            txtTotalVenta.Clear();
        }
        // --- BOTÓN COBRAR (INSERTAR EN MYSQL) ---
        private void btnCobrar_Click_1(object sender, EventArgs e)
        {
            decimal totalVenta = listaDetalle.Sum(x => x.Subtotal);

            if (listaDetalle.Count == 0)
            {
                MessageBox.Show("No hay productos cargados en la venta.");
                return;
            }
            // Validar la cantidad ingresada
            if(decimal.TryParse(txtRcbClient.Text,out decimal recibido))
            {
                if(recibido < totalVenta)
                {
                    MessageBox.Show($"El dinero recibido (${recibido.ToString("C2", cultureMx)}) es menor al total de la venta(${totalVenta.ToString("C2", cultureMx)}).", "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                   
                }
                //Calcular el cambio y mostrarlo en la casilla
                decimal cambio = recibido - totalVenta;

                txtCambio.Text = cambio.ToString("C2", cultureMx);

                try
                {
                    DataAcces db = new DataAcces();
                    using (MySqlConnection conn = db.Dataacces())
                    {
                        MySqlTransaction trans = conn.BeginTransaction();

                        try
                        {
                            int idEmpleado = 1; // Ajustar según el usuario logueado
                            int idMetodoPago = Convert.ToInt32(comboBox1.SelectedValue);
                            int idCliente = 1;
                            decimal total = listaDetalle.Sum(x => x.Subtotal);

                            // 1. Insert en tabla Venta
                            string qVenta = @"INSERT INTO Venta (id_empleado, id_metodopago, id_cliente, fecha, total) 
                                          VALUES (@emp, @metodo, @cli, NOW(), @tot);
                                          SELECT LAST_INSERT_ID();";

                            MySqlCommand cmdVenta = new MySqlCommand(qVenta, conn, trans);
                            cmdVenta.Parameters.AddWithValue("@emp", idEmpleado);
                            cmdVenta.Parameters.AddWithValue("@metodo", idMetodoPago);
                            cmdVenta.Parameters.AddWithValue("@cli", idCliente);
                            cmdVenta.Parameters.AddWithValue("@tot", totalVenta);

                            int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                            // 2. Insert en tabla Detalle_venta
                            foreach (var item in listaDetalle)
                            {
                                string qDetalle = @"INSERT INTO Detalle_venta (id_venta, codigo_barra, cantidad, precio_unitario, subtotal) 
                                                VALUES (@idV, @codBarra, @cant, @prec, @sub);";

                                MySqlCommand cmdDetalle = new MySqlCommand(qDetalle, conn, trans);
                                cmdDetalle.Parameters.AddWithValue("@idV", idVenta);
                                cmdDetalle.Parameters.AddWithValue("@codBarra", item.codigo_Barra);
                                cmdDetalle.Parameters.AddWithValue("@cant", item.Cantidad);
                                cmdDetalle.Parameters.AddWithValue("@prec", item.Precio);
                                cmdDetalle.Parameters.AddWithValue("@sub", item.Subtotal);

                                cmdDetalle.ExecuteNonQuery();
                            }

                            trans.Commit();
                            MessageBox.Show($"¡Venta cobrada e insertada con éxito!\nCambio a entregar: {cambio.ToString("C2", cultureMx)}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string cambioFinal = cambio.ToString("C2", cultureMx);
                            txtCambio.Text = cambioFinal;
                        }
                        catch (Exception exInner)
                        {
                            trans.Rollback();
                            MessageBox.Show("Error en la transacción: " + exInner.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la BD: " + ex.Message);
                }

                MessageBox.Show($"¡Venta registrada correctamente!\nCambio: {cambio.ToString("C2", cultureMx)}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor ingresa una cantidad válida en el campo de dinero  recibido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }

    public class DetalleVentaItem
    {
        public string codigo_Barra { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal => Cantidad * Precio;
    }
}
