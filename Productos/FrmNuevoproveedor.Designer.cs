namespace pryCafeteriaEscolar.Productos
{
    partial class FrmNuevoproveedor
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
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelarp = new System.Windows.Forms.Button();
            this.btnguardarp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtcpP = new System.Windows.Forms.Label();
            this.txtciudadp = new System.Windows.Forms.TextBox();
            this.lblci = new System.Windows.Forms.Label();
            this.txtcoloniap = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.txtcallep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttelefonop = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorreop = new System.Windows.Forms.TextBox();
            this.lblp = new System.Windows.Forms.Label();
            this.txtnombrep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.rfc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.Font = new System.Drawing.Font("Segoe UI Variable Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.Lbltitulo.Location = new System.Drawing.Point(40, 25);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(367, 48);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "NUEVO PROVEEDOR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancelarp);
            this.panel1.Controls.Add(this.btnguardarp);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtcpP);
            this.panel1.Controls.Add(this.txtciudadp);
            this.panel1.Controls.Add(this.lblci);
            this.panel1.Controls.Add(this.txtcoloniap);
            this.panel1.Controls.Add(this.lblc);
            this.panel1.Controls.Add(this.txtcallep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttelefonop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcorreop);
            this.panel1.Controls.Add(this.lblp);
            this.panel1.Controls.Add(this.txtnombrep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtrfc);
            this.panel1.Controls.Add(this.rfc);
            this.panel1.Controls.Add(this.Lbltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(951, 762);
            this.panel1.TabIndex = 1;
            // 
            // btncancelarp
            // 
            this.btncancelarp.BackColor = System.Drawing.Color.Firebrick;
            this.btncancelarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelarp.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarp.ForeColor = System.Drawing.Color.White;
            this.btncancelarp.Location = new System.Drawing.Point(506, 662);
            this.btncancelarp.Name = "btncancelarp";
            this.btncancelarp.Size = new System.Drawing.Size(140, 45);
            this.btncancelarp.TabIndex = 18;
            this.btncancelarp.Text = "Cancelar";
            this.btncancelarp.UseVisualStyleBackColor = false;
            this.btncancelarp.Click += new System.EventHandler(this.btncancelarp_Click);
            // 
            // btnguardarp
            // 
            this.btnguardarp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnguardarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarp.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarp.ForeColor = System.Drawing.Color.White;
            this.btnguardarp.Location = new System.Drawing.Point(267, 662);
            this.btnguardarp.Name = "btnguardarp";
            this.btnguardarp.Size = new System.Drawing.Size(140, 45);
            this.btnguardarp.TabIndex = 17;
            this.btnguardarp.Text = "Guardar";
            this.btnguardarp.UseVisualStyleBackColor = false;
            this.btnguardarp.Click += new System.EventHandler(this.btnguardarp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 592);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 34);
            this.textBox1.TabIndex = 16;
            // 
            // txtcpP
            // 
            this.txtcpP.AutoSize = true;
            this.txtcpP.Location = new System.Drawing.Point(48, 561);
            this.txtcpP.Name = "txtcpP";
            this.txtcpP.Size = new System.Drawing.Size(140, 28);
            this.txtcpP.TabIndex = 15;
            this.txtcpP.Text = "Codigo postal:";
            // 
            // txtciudadp
            // 
            this.txtciudadp.Location = new System.Drawing.Point(426, 503);
            this.txtciudadp.MaxLength = 100;
            this.txtciudadp.Name = "txtciudadp";
            this.txtciudadp.Size = new System.Drawing.Size(220, 34);
            this.txtciudadp.TabIndex = 14;
            // 
            // lblci
            // 
            this.lblci.AutoSize = true;
            this.lblci.Location = new System.Drawing.Point(421, 472);
            this.lblci.Name = "lblci";
            this.lblci.Size = new System.Drawing.Size(78, 28);
            this.lblci.TabIndex = 13;
            this.lblci.Text = "Ciudad:";
            // 
            // txtcoloniap
            // 
            this.txtcoloniap.Location = new System.Drawing.Point(48, 503);
            this.txtcoloniap.MaxLength = 100;
            this.txtcoloniap.Name = "txtcoloniap";
            this.txtcoloniap.Size = new System.Drawing.Size(250, 34);
            this.txtcoloniap.TabIndex = 12;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(48, 472);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(83, 28);
            this.lblc.TabIndex = 11;
            this.lblc.Text = "Colonia:";
            // 
            // txtcallep
            // 
            this.txtcallep.Location = new System.Drawing.Point(48, 423);
            this.txtcallep.MaxLength = 100;
            this.txtcallep.Name = "txtcallep";
            this.txtcallep.Size = new System.Drawing.Size(420, 34);
            this.txtcallep.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calle:";
            // 
            // txttelefonop
            // 
            this.txttelefonop.Location = new System.Drawing.Point(48, 346);
            this.txttelefonop.Mask = "0000000000";
            this.txttelefonop.Name = "txttelefonop";
            this.txttelefonop.Size = new System.Drawing.Size(180, 34);
            this.txttelefonop.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefono:";
            // 
            // txtcorreop
            // 
            this.txtcorreop.Location = new System.Drawing.Point(48, 278);
            this.txtcorreop.MaxLength = 100;
            this.txtcorreop.Name = "txtcorreop";
            this.txtcorreop.Size = new System.Drawing.Size(420, 34);
            this.txtcorreop.TabIndex = 6;
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(48, 247);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(76, 28);
            this.lblp.TabIndex = 5;
            this.lblp.Text = "Correo:";
            // 
            // txtnombrep
            // 
            this.txtnombrep.Location = new System.Drawing.Point(48, 210);
            this.txtnombrep.MaxLength = 100;
            this.txtnombrep.Name = "txtnombrep";
            this.txtnombrep.Size = new System.Drawing.Size(420, 34);
            this.txtnombrep.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(48, 129);
            this.txtrfc.MaxLength = 13;
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(300, 34);
            this.txtrfc.TabIndex = 2;
            // 
            // rfc
            // 
            this.rfc.AutoSize = true;
            this.rfc.Location = new System.Drawing.Point(48, 98);
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(50, 28);
            this.rfc.TabIndex = 1;
            this.rfc.Text = "RFC:";
            // 
            // FrmNuevoproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 762);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoproveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Proveedor";
            this.Load += new System.EventHandler(this.FrmNuevoproveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnombrep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Label rfc;
        private System.Windows.Forms.MaskedTextBox txttelefonop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorreop;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox txtciudadp;
        private System.Windows.Forms.Label lblci;
        private System.Windows.Forms.TextBox txtcoloniap;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtcallep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardarp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtcpP;
        private System.Windows.Forms.Button btncancelarp;
    }
}