namespace pryCafeteriaEscolar.Productos
{
    partial class FrmProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreProve = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.txtBuscarProvee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefono:";
            // 
            // txtNombreProve
            // 
            this.txtNombreProve.Location = new System.Drawing.Point(27, 149);
            this.txtNombreProve.Name = "txtNombreProve";
            this.txtNombreProve.Size = new System.Drawing.Size(291, 34);
            this.txtNombreProve.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(27, 75);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(291, 34);
            this.txtRFC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "RFC:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCiudad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNombreProve);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 280);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del proveedor";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(22, 125);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 62;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.Size = new System.Drawing.Size(1027, 221);
            this.dgvProveedores.TabIndex = 6;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI Variable Text", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(942, 49);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(107, 27);
            this.btnEliminarProveedor.TabIndex = 5;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarProveedor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Segoe UI Variable Text", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEditarProveedor.Location = new System.Drawing.Point(817, 49);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(107, 27);
            this.btnEditarProveedor.TabIndex = 4;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.Orange;
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(643, 49);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(150, 27);
            this.btnNuevoProveedor.TabIndex = 3;
            this.btnNuevoProveedor.Text = "+ Nuevo Proveedor";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // txtBuscarProvee
            // 
            this.txtBuscarProvee.Location = new System.Drawing.Point(91, 93);
            this.txtBuscarProvee.Name = "txtBuscarProvee";
            this.txtBuscarProvee.Size = new System.Drawing.Size(350, 26);
            this.txtBuscarProvee.TabIndex = 2;
            this.txtBuscarProvee.TextChanged += new System.EventHandler(this.txtBuscarProvee_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvProveedores);
            this.panel1.Controls.Add(this.btnEliminarProveedor);
            this.panel1.Controls.Add(this.btnEditarProveedor);
            this.panel1.Controls.Add(this.btnNuevoProveedor);
            this.panel1.Controls.Add(this.txtBuscarProvee);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 644);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(27, 216);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(291, 34);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(394, 78);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(291, 34);
            this.txtTelefono.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(394, 145);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(291, 34);
            this.txtCalle.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Colonia:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(394, 216);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(291, 34);
            this.txtColonia.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ciudad:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(753, 78);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(225, 34);
            this.txtCiudad.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(748, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "CP:";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(753, 145);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(225, 34);
            this.txtCp.TabIndex = 20;
            // 
            // FrmProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProveedores";
            this.Load += new System.EventHandler(this.FrmProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreProve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.TextBox txtBuscarProvee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label10;
    }
}