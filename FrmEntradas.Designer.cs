namespace pryCafeteriaEscolar
{
    partial class FrmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.lbcontadorP = new System.Windows.Forms.Label();
            this.lbcontadorE = new System.Windows.Forms.Label();
            this.lbcontadorproveedores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de productos que entraron en la cafeteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label4.Location = new System.Drawing.Point(41, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Productos hoy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label5.Location = new System.Drawing.Point(60, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entradas hoy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Proveedores activos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label8.Location = new System.Drawing.Point(40, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Proveedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbcontadorP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(68, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 130);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbcontadorE);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(346, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 130);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbcontadorproveedores);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(618, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 130);
            this.panel3.TabIndex = 11;
            // 
            // dtgTabla
            // 
            this.dtgTabla.AllowUserToAddRows = false;
            this.dtgTabla.AllowUserToDeleteRows = false;
            this.dtgTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTabla.BackgroundColor = System.Drawing.Color.White;
            this.dtgTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgTabla.Location = new System.Drawing.Point(68, 390);
            this.dtgTabla.MultiSelect = false;
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.ReadOnly = true;
            this.dtgTabla.RowHeadersVisible = false;
            this.dtgTabla.RowHeadersWidth = 62;
            this.dtgTabla.RowTemplate.Height = 28;
            this.dtgTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTabla.Size = new System.Drawing.Size(767, 183);
            this.dtgTabla.TabIndex = 12;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(289, 138);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 30);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.Text = "Buscar producto";
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.btnEntradas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.White;
            this.btnEntradas.Location = new System.Drawing.Point(68, 132);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(184, 46);
            this.btnEntradas.TabIndex = 14;
            this.btnEntradas.Text = "Nueva entrada";
            this.btnEntradas.UseVisualStyleBackColor = false;
            // 
            // lbcontadorP
            // 
            this.lbcontadorP.AutoSize = true;
            this.lbcontadorP.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontadorP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.lbcontadorP.Location = new System.Drawing.Point(123, 51);
            this.lbcontadorP.Name = "lbcontadorP";
            this.lbcontadorP.Size = new System.Drawing.Size(42, 46);
            this.lbcontadorP.TabIndex = 10;
            this.lbcontadorP.Text = "0";
            this.lbcontadorP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcontadorE
            // 
            this.lbcontadorE.AutoSize = true;
            this.lbcontadorE.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontadorE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.lbcontadorE.Location = new System.Drawing.Point(145, 57);
            this.lbcontadorE.Name = "lbcontadorE";
            this.lbcontadorE.Size = new System.Drawing.Size(42, 46);
            this.lbcontadorE.TabIndex = 11;
            this.lbcontadorE.Text = "0";
            this.lbcontadorE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcontadorproveedores
            // 
            this.lbcontadorproveedores.AutoSize = true;
            this.lbcontadorproveedores.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcontadorproveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(156)))), ((int)(((byte)(61)))));
            this.lbcontadorproveedores.Location = new System.Drawing.Point(140, 57);
            this.lbcontadorproveedores.Name = "lbcontadorproveedores";
            this.lbcontadorproveedores.Size = new System.Drawing.Size(42, 46);
            this.lbcontadorproveedores.TabIndex = 15;
            this.lbcontadorproveedores.Text = "0";
            this.lbcontadorproveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(44, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(64, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label6.Location = new System.Drawing.Point(60, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Entradas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.label3.Location = new System.Drawing.Point(41, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipos diferentes";
            // 
            // FrmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1056, 596);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgTabla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "FrmEntradas";
            this.Text = "FrmEntradas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgTabla;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Label lbcontadorP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbcontadorE;
        private System.Windows.Forms.Label lbcontadorproveedores;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}