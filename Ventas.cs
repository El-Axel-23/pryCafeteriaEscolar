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
    public partial class Ventas : UserControl
    {
        private decimal totalVenta = 0m;
        public Ventas()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        //1. Botón REGISTRAR: Añade el producto a la lista y suma al total
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCodgProduc.Text) ||
                string.IsNullOrWhiteSpace(txtProduc.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCant.Text))
            {
                MessageBox.Show("Por favor, completa los datos del producto (Código, Nombre, Precio y Cantidad).",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar valores numéricos
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCant.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad válida mayor a cero.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular subtotal de este producto
            decimal subtotal = precio * cantidad;

            // Formatear texto para la ListBox "Venta actual"
            string lineaProducto = $"{txtProduc.Text} x{cantidad} - ${subtotal:F2}";
            listBxListaProduc.Items.Add(lineaProducto);

            // Actualizar acumulador total
            totalVenta += subtotal;
            txtTotalVenta.Text = totalVenta.ToString("F2");

            // Limpiar solo los campos del producto ingresado para vender el siguiente
            txtCodgProduc.Clear();
            txtProduc.Clear();
            txtPrecio.Clear();
            txtCant.Clear();
            txtCodgProduc.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodgProduc.Clear();
            txtProduc.Clear();
            txtPrecio.Clear();
            txtCant.Clear();
            txtRcbClient.Clear();
            txtCambio.Clear();
            txtTotalVenta.Clear();
            listBxListaProduc.Items.Clear();

            totalVenta = 0m;
            txtCodgProduc.Focus();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (totalVenta == 0m)
            {
                MessageBox.Show("No hay productos agregados a la venta actual.", "Venta vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtRcbClient.Text, out decimal recibido) || recibido < totalVenta)
            {
                MessageBox.Show("El dinero recibido es insuficiente o no es un valor válido.",
                                "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular cambio
            decimal cambio = recibido - totalVenta;
            txtCambio.Text = cambio.ToString("F2");

            MessageBox.Show($"¡Venta efectuada con éxito!\nCambio a entregar: ${cambio:F2}",
                            "Cobro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
