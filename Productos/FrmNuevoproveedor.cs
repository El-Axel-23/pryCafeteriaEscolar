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
                        Sql = @"UPDATE Proveedor SET  RFC=@rfc,nombre=@nombre,correo=@correo,telefono=@telefono,calle=@calle,colonia=@colonia,ciudad=@ciudad,cp=@cp WHERE RFC=@original";
                    }
                    else
                    {
                        Sql = @"INSER INTO Proveedor (RFC,nombre,correo,telefono,calle,colonia,ciudad,cp) VALUES(@rfc,@nombre,@correo,@telefono,@calle,@colonia,@ciudad,@cp)";
                    }
                    MySqlCommand command = new MySqlCommand(Sql, connection);

                    command.Parameters.AddWithValue("@rfc", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@nombre", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@correo", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@telefono", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@calle", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@colonia", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@ciudad", txtrfc.Text.Trim());
                    command.Parameters.AddWithValue("@cp", txtrfc.Text.Trim());

                    if (proveedorEd)
                    {
                        MessageBox.Show("Proveedor actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Proveedor registrado correctamente.");
                        this.Close();
                    }
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
    }
}
