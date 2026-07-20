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
    public partial class FrmNuevoproducto : Form
    {
        public bool ProductoEdit =  false;
        public string CodOriginal = "";
        public FrmNuevoproducto()
        {
            InitializeComponent();
        }
        public void CargaD(string codigo, int categoria, string descripcion, decimal precio, int stock)
        {
            txtcodigo.Text = codigo;
            cbcategoria.SelectedValue = categoria;
            txtdescripcion.Text = descripcion;
            nudprecio.Value = precio;
            nudstock.Value = stock;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargaCate()
        {
            try
            {
                DataAcces data = new DataAcces();
                using (MySqlConnection connection = data.Dataacces())
                {
                    string Sql = @"SELECT id_categoria,nombre FROM Categoria";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(Sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cbcategoria.DataSource = table;
                    cbcategoria.DisplayMember = "nombre";
                    cbcategoria.ValueMember = "id_categoria";
                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNuevoproducto_Load(object sender, EventArgs e)
        {
            CargaCate();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataAcces data = new DataAcces();
                using (MySqlConnection connection = data.Dataacces())
                {
                    string Sql;
                    if (ProductoEdit)
                    {
                        Sql = @"UPDATE Producto SET codigo_barra = @codigo,id_categoria=@categoria,descripcion=@descripcion,
                        precio_venta=@precio,stock=@stock WHERE codigo_barra=@original";
                    }
                    else
                    {
                        Sql = @"INSERT INTO producto(codigo_barra,id_categoria,descripcion,precio_venta,stock)
                        VALUES (@codigo,@categoria,@descripcion,@precio,@stock)";
                    }

                    MySqlCommand command = new MySqlCommand(Sql, connection);

                    command.Parameters.AddWithValue("@codigo", txtcodigo.Text.Trim());
                    command.Parameters.AddWithValue("@categoria", cbcategoria.SelectedValue);
                    command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text.Trim());
                    command.Parameters.AddWithValue("@precio", nudprecio.Value);
                    command.Parameters.AddWithValue("@stock", nudstock.Value);
                    if (ProductoEdit)
                    {
                        command.Parameters.AddWithValue("@original", CodOriginal);
                    }
                    command.ExecuteNonQuery();
                }
                if (ProductoEdit)
                {
                    MessageBox.Show("Producto Actualizado Correctamente");
                }
                else
                {
                    MessageBox.Show("Producto registrado correctamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
