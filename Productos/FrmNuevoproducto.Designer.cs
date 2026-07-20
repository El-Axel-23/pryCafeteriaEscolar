namespace pryCafeteriaEscolar.Productos
{
    partial class FrmNuevoproducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCODIGOb = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.labelcatego = new System.Windows.Forms.Label();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudprecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudstock = new System.Windows.Forms.NumericUpDown();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstock)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO PRODUCTO";
            // 
            // labelCODIGOb
            // 
            this.labelCODIGOb.AutoSize = true;
            this.labelCODIGOb.Location = new System.Drawing.Point(46, 96);
            this.labelCODIGOb.Name = "labelCODIGOb";
            this.labelCODIGOb.Size = new System.Drawing.Size(167, 28);
            this.labelCODIGOb.TabIndex = 1;
            this.labelCODIGOb.Text = "Codigo de barras:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(51, 136);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(300, 34);
            this.txtcodigo.TabIndex = 2;
            // 
            // labelcatego
            // 
            this.labelcatego.AutoSize = true;
            this.labelcatego.Location = new System.Drawing.Point(46, 196);
            this.labelcatego.Name = "labelcatego";
            this.labelcatego.Size = new System.Drawing.Size(101, 28);
            this.labelcatego.TabIndex = 3;
            this.labelcatego.Text = "Categoria:";
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(51, 227);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(300, 36);
            this.cbcategoria.TabIndex = 4;
            this.cbcategoria.SelectedIndexChanged += new System.EventHandler(this.cbcategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(51, 336);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(450, 34);
            this.txtdescripcion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudprecio
            // 
            this.nudprecio.DecimalPlaces = 2;
            this.nudprecio.Location = new System.Drawing.Point(51, 444);
            this.nudprecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudprecio.Name = "nudprecio";
            this.nudprecio.Size = new System.Drawing.Size(150, 34);
            this.nudprecio.TabIndex = 8;
            this.nudprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock:";
            // 
            // nudstock
            // 
            this.nudstock.DecimalPlaces = 2;
            this.nudstock.Location = new System.Drawing.Point(272, 444);
            this.nudstock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudstock.Name = "nudstock";
            this.nudstock.Size = new System.Drawing.Size(150, 34);
            this.nudstock.TabIndex = 10;
            this.nudstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(93, 542);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(120, 40);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(272, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(487, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelCODIGOb);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.txtcodigo);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.labelcatego);
            this.panel2.Controls.Add(this.nudprecio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nudstock);
            this.panel2.Controls.Add(this.cbcategoria);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtdescripcion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(576, 622);
            this.panel2.TabIndex = 14;
            // 
            // FrmNuevoproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoproducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.FrmNuevoproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudstock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCODIGOb;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label labelcatego;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudstock;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}