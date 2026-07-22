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
    public partial class FrmNuevoproveedor : Form
    {
        public bool proveedorEd = false;
        public string RFCOriginal= "";
        public FrmNuevoproveedor()
        {
            InitializeComponent();
        }

        private void FrmNuevoproveedor_Load(object sender, EventArgs e)
        {

        }
        public void CargarDp(string rfc,string nombre,string correo,string telefono,string calle,string colonia,string ciudad,string cp)
        {
            txtrfc.Text = rfc;
            txtnombrep.Text = nombre;
            txtcorreop.Text = correo;
            txttelefonop.Text = telefono;
            txtcallep.Text = calle;
            txtcoloniap.Text = colonia;
            txtciudadp.Text = ciudad;
            txtcpP.Text = cp;
        }

        private void btnguardarp_Click(object sender, EventArgs e)
        {
            try
            {
                DataAcces data = new DataAcces();

                using(MySqlConnection connection = data.Dataacces())
                {
                    string Sql;
                    if(proveedorEd)
                    {
                        Sql = @"UPDATE Proveedor SET RFC=@rfc,nombre=@nombre,correo=@correo,telefono=@telefono,calle=@calle,colonia=@colonia,ciudad=@ciudad,cp=@cp WHERE RFC=@original";
                    }
                    else
                    {
                        Sql = @"INSERT INTO Proveedor(RFC,nombre,correo,telefono,calle,colonia,ciudad,cp) VALUES(@rfc,@nombre,@correo,@telefono,@calle,@colonia,@ciudad,@cp)";
                    }
                    MySqlCommand command = new MySqlCommand(Sql, connection);


                    command.Parameters.AddWithValue("@rfc", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@nombre", txtnombrep.Text.Trim());
                    command.Parameters.AddWithValue("@correo", txtcorreop.Text.Trim());
                    command.Parameters.AddWithValue("@telefono", txttelefonop.Text.Trim());
                    command.Parameters.AddWithValue("@calle", txtcallep.Text.Trim());
                    command.Parameters.AddWithValue("@colonia", txtcoloniap.Text.Trim());
                    command.Parameters.AddWithValue("@ciudad", txtciudadp.Text.Trim());
                    command.Parameters.AddWithValue("@cp", txtcpP.Text.Trim());
                    
                    if (proveedorEd)
                    {
                        command.Parameters.AddWithValue("@original", RFCOriginal);
                    }
                    command.ExecuteNonQuery();

                    if (proveedorEd)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor registrado correctamente.");
                        
                    }
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncancelarp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
