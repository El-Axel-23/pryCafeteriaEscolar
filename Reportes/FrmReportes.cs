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
                string sqlResumen = @"
        SELECT
            IFNULL(SUM(total),0) AS Ganancias,
            COUNT(*) AS Ventas,
            (
                SELECT IFNULL(SUM(dv.cantidad),0)
                FROM Detalle_venta dv
                INNER JOIN Venta v2
                ON dv.id_venta = v2.id_venta
                WHERE DATE(v2.fecha) BETWEEN @desde AND @hasta
            ) AS Productos
        FROM Venta
        WHERE DATE(fecha) BETWEEN @desde AND @hasta";

                MySqlCommand cmd = new MySqlCommand(sqlResumen, conexion);

                cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblGanancias.Text = "$ " +
                        Convert.ToDecimal(dr["Ganancias"]).ToString("N2");

                    lblVentas.Text = dr["Ventas"].ToString();

                    lblProductos.Text = dr["Productos"].ToString();
                }

                dr.Close();

                string sqlDeudores = @"
        SELECT
            c.matricula AS Matricula,
            CONCAT(c.nombre,' ',c.apellido_paterno,' ',IFNULL(c.apellido_materno,'')) AS Cliente,
            c.carrera AS Carrera,
            c.cuatrimestre AS Cuatrimestre,
            c.grupo AS Grupo,
            c.telefono AS Telefono,
            v.saldo_pendiente AS Adeudo
        FROM Cliente c
        INNER JOIN Venta v
            ON c.id_cliente = v.id_cliente
        WHERE v.es_credito = 1
        AND v.saldo_pendiente > 0
        ORDER BY v.saldo_pendiente DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlDeudores, conexion);

                DataTable tabla = new DataTable();

                da.Fill(tabla);

                dgvReporte.DataSource = tabla;
            }
        }

        private void CalcularDatos()
        {
            DataAcces data = new DataAcces();

            using (MySqlConnection conexion = data.Dataacces())
            {

                string sql = @"
        SELECT

        IFNULL(SUM(total),0) AS Ganancias,

        COUNT(*) AS Ventas,

        (
            SELECT IFNULL(SUM(cantidad),0)
            FROM Detalle_venta dv
            INNER JOIN Venta v2
            ON dv.id_venta=v2.id_venta
            WHERE DATE(v2.fecha)
            BETWEEN @desde AND @hasta
        ) AS Productos

        FROM Venta

        WHERE DATE(fecha)
        BETWEEN @desde AND @hasta";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.Date);
                cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.Date);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblGanancias.Text = "$ " +
                        Convert.ToDecimal(dr["Ganancias"]).ToString("N2");

                    lblVentas.Text =
                        dr["Ventas"].ToString();

                    lblProductos.Text =
                        dr["Productos"].ToString();
                }
            }
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

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
