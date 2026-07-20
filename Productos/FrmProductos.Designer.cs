namespace pryCafeteriaEscolar
{
    partial class FrmProductos
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
            this.pnlprincipal = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpcategorias = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnuevoproducto = new System.Windows.Forms.Button();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonProve = new System.Windows.Forms.Button();
            this.editarProve = new System.Windows.Forms.Button();
            this.ElimProve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlprincipal.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpcategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlprincipal
            // 
            this.pnlprincipal.Controls.Add(this.button1);
            this.pnlprincipal.Controls.Add(this.ElimProve);
            this.pnlprincipal.Controls.Add(this.editarProve);
            this.pnlprincipal.Controls.Add(this.buttonProve);
            this.pnlprincipal.Controls.Add(this.buttonEliminar);
            this.pnlprincipal.Controls.Add(this.buttonEditar);
            this.pnlprincipal.Controls.Add(this.btnnuevoproducto);
            this.pnlprincipal.Controls.Add(this.txtbuscar);
            this.pnlprincipal.Controls.Add(this.groupBox3);
            this.pnlprincipal.Controls.Add(this.grpcategorias);
            this.pnlprincipal.Controls.Add(this.groupBox1);
            this.pnlprincipal.Controls.Add(this.label2);
            this.pnlprincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlprincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlprincipal.Name = "pnlprincipal";
            this.pnlprincipal.Size = new System.Drawing.Size(1344, 712);
            this.pnlprincipal.TabIndex = 2;
            this.pnlprincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(554, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proveedores";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(594, 169);
            this.dataGridView2.TabIndex = 0;
            // 
            // grpcategorias
            // 
            this.grpcategorias.Controls.Add(this.dataGridView1);
            this.grpcategorias.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpcategorias.Location = new System.Drawing.Point(104, 403);
            this.grpcategorias.Name = "grpcategorias";
            this.grpcategorias.Size = new System.Drawing.Size(420, 202);
            this.grpcategorias.TabIndex = 2;
            this.grpcategorias.TabStop = false;
            this.grpcategorias.Text = "Categorias";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(414, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvproductos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de productos";
            // 
            // btnnuevoproducto
            // 
            this.btnnuevoproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(119)))), ((int)(((byte)(36)))));
            this.btnnuevoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevoproducto.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevoproducto.ForeColor = System.Drawing.Color.White;
            this.btnnuevoproducto.Location = new System.Drawing.Point(746, 62);
            this.btnnuevoproducto.Name = "btnnuevoproducto";
            this.btnnuevoproducto.Size = new System.Drawing.Size(120, 35);
            this.btnnuevoproducto.TabIndex = 3;
            this.btnnuevoproducto.Text = "+ Nuevo producto";
            this.btnnuevoproducto.UseVisualStyleBackColor = false;
            this.btnnuevoproducto.Click += new System.EventHandler(this.btnnuevoproducto_Click);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(3, 30);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 62;
            this.dgvproductos.RowTemplate.Height = 28;
            this.dgvproductos.Size = new System.Drawing.Size(1044, 188);
            this.dgvproductos.TabIndex = 2;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.DimGray;
            this.txtbuscar.Location = new System.Drawing.Point(345, 63);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(381, 34);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.Text = "Buscar:";
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Productos";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(884, 62);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(120, 35);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(1028, 62);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 35);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonProve
            // 
            this.buttonProve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(119)))), ((int)(((byte)(36)))));
            this.buttonProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProve.Font = new System.Drawing.Font("Segoe UI Variable Text", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProve.ForeColor = System.Drawing.Color.White;
            this.buttonProve.Location = new System.Drawing.Point(746, 373);
            this.buttonProve.Name = "buttonProve";
            this.buttonProve.Size = new System.Drawing.Size(120, 35);
            this.buttonProve.TabIndex = 7;
            this.buttonProve.Text = "+ Nuevo proveedor";
            this.buttonProve.UseVisualStyleBackColor = false;
            // 
            // editarProve
            // 
            this.editarProve.BackColor = System.Drawing.Color.SteelBlue;
            this.editarProve.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarProve.ForeColor = System.Drawing.Color.White;
            this.editarProve.Location = new System.Drawing.Point(884, 372);
            this.editarProve.Name = "editarProve";
            this.editarProve.Size = new System.Drawing.Size(120, 35);
            this.editarProve.TabIndex = 8;
            this.editarProve.Text = "Editar";
            this.editarProve.UseVisualStyleBackColor = false;
            // 
            // ElimProve
            // 
            this.ElimProve.BackColor = System.Drawing.Color.Firebrick;
            this.ElimProve.Font = new System.Drawing.Font("Segoe UI Variable Text", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElimProve.ForeColor = System.Drawing.Color.White;
            this.ElimProve.Location = new System.Drawing.Point(1028, 372);
            this.ElimProve.Name = "ElimProve";
            this.ElimProve.Size = new System.Drawing.Size(120, 35);
            this.ElimProve.TabIndex = 9;
            this.ElimProve.Text = "Eliminar";
            this.ElimProve.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(119)))), ((int)(((byte)(36)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Variable Text", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(398, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "+ Nuevo Categoria";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.pnlprincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.pnlprincipal.ResumeLayout(false);
            this.pnlprincipal.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpcategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlprincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btnnuevoproducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpcategorias;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button ElimProve;
        private System.Windows.Forms.Button editarProve;
        private System.Windows.Forms.Button buttonProve;
        private System.Windows.Forms.Button button1;
    }
}