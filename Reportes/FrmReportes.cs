using MySql.Data.MySqlClient;
using pryCafeteriaEscolar.Base_de_datos;
using pryCafeteriaEscolar.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCafeteriaEscolar.Reportes
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            frmReportes_Resize(null, null);
            cmbTipoReporte.Items.Add("Ventas");
            cmbTipoReporte.Items.Add("Productos");
            cmbTipoReporte.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;

            ConfigGlobal.AplicarEstilo(this);
        }

        private void ReporteVentas()
        {
            DataAcces data = new DataAcces();
            using (MySqlConnection conexion = data.Dataacces())
            {
                conexion.Open();
                string sql = @"SELECT v.fecha, v.hora, p.nombre AS Producto, c.nombre AS Categoria, d.cantidad, d.precio * d.cantidad AS Total FROM ventas v INNER JOIN detalle_venta d ON v.id_venta=d.id_venta INNER JOIN productos p ON d.id_producto=p.id_producto INNER JOIN categoria c ON p.id_categoria=c.id_categoria WHERE v.fecha BETWEEN @desde AND @hasta";
                MySqlCommand cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);
                DataTable tabla = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(tabla);
                dgvReporte.DataSource = tabla;
            }
            CalcularDatos();
        }

        private void CalcularDatos()
        {
            decimal ganancias = 0;
            int ventas = dgvReporte.Rows.Count;
            int productos = 0;

            foreach (DataGridViewRow fila in dgvReporte.Rows)
            {
                ganancias += Convert.ToDecimal(fila.Cells["Total"].Value);
                productos += Convert.ToInt32(fila.Cells["Cantidad"].Value);
            }

            lblGanancias.Text = "$" + ganancias.ToString("N2");

            lblVentas.Text = ventas.ToString();

            lblProductos.Text = productos.ToString();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cmbTipoReporte.Text == "Ventas")
            {
                ReporteVentas();
            }
        }

        private void frmReportes_Resize(object sender, EventArgs e)
        {
            panelPrincipal.Left = (this.ClientSize.Width - panelPrincipal.Width) / 2;
            panelPrincipal.Top = (this.ClientSize.Height - panelPrincipal.Height) / 2;
        }
    }
}
