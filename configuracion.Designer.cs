namespace pryCafeteriaEscolar
{
    partial class configuracion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackTemas = new System.Windows.Forms.TrackBar();
            this.cmbbxFuente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxCor = new System.Windows.Forms.TextBox();
            this.txtbxTel = new System.Windows.Forms.TextBox();
            this.txtbxDir = new System.Windows.Forms.TextBox();
            this.txtbxNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbxImp = new System.Windows.Forms.TextBox();
            this.txtbxHora = new System.Windows.Forms.TextBox();
            this.txtbxZona = new System.Windows.Forms.TextBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTemas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(580, 474);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttnGuardar.TabIndex = 11;
            this.bttnGuardar.Text = "GUARDAR CAMBIOS";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Location = new System.Drawing.Point(567, 395);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(94, 38);
            this.bttnCerrar.TabIndex = 10;
            this.bttnCerrar.Text = "CERRAR SESION";
            this.bttnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.dateFecha);
            this.groupBox2.Controls.Add(this.txtbxZona);
            this.groupBox2.Controls.Add(this.txtbxHora);
            this.groupBox2.Controls.Add(this.txtbxImp);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(445, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 192);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.trackTemas);
            this.groupBox3.Controls.Add(this.cmbbxFuente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(72, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 186);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";

            // 
            // trackTemas
            // 
            this.trackTemas.LargeChange = 1;
            this.trackTemas.Location = new System.Drawing.Point(200, 44);
            this.trackTemas.Maximum = 1;
            this.trackTemas.Name = "trackTemas";
            this.trackTemas.Size = new System.Drawing.Size(110, 45);
            this.trackTemas.TabIndex = 12;
            this.trackTemas.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackTemas.Scroll += new System.EventHandler(this.trackTemas_Scroll);
            // 
            // cmbbxFuente
            // 
            this.cmbbxFuente.FormattingEnabled = true;
            this.cmbbxFuente.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.cmbbxFuente.Location = new System.Drawing.Point(200, 123);
            this.cmbbxFuente.Name = "cmbbxFuente";
            this.cmbbxFuente.Size = new System.Drawing.Size(121, 21);
            this.cmbbxFuente.TabIndex = 17;
            this.cmbbxFuente.SelectedIndexChanged += new System.EventHandler(this.cmbbxFuente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tamaño de fuente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraste";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Accesibilidad";

            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.txtbxCor);
            this.groupBox1.Controls.Add(this.txtbxTel);
            this.groupBox1.Controls.Add(this.txtbxDir);
            this.groupBox1.Controls.Add(this.txtbxNom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(72, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtbxCor
            // 
            this.txtbxCor.Location = new System.Drawing.Point(142, 150);
            this.txtbxCor.Name = "txtbxCor";
            this.txtbxCor.Size = new System.Drawing.Size(100, 20);
            this.txtbxCor.TabIndex = 20;
            // 
            // txtbxTel
            // 
            this.txtbxTel.Location = new System.Drawing.Point(142, 112);
            this.txtbxTel.Name = "txtbxTel";
            this.txtbxTel.Size = new System.Drawing.Size(100, 20);
            this.txtbxTel.TabIndex = 19;
            // 
            // txtbxDir
            // 
            this.txtbxDir.Location = new System.Drawing.Point(142, 77);
            this.txtbxDir.Name = "txtbxDir";
            this.txtbxDir.Size = new System.Drawing.Size(100, 20);
            this.txtbxDir.TabIndex = 18;
            // 
            // txtbxNom
            // 
            this.txtbxNom.Location = new System.Drawing.Point(142, 43);
            this.txtbxNom.Name = "txtbxNom";
            this.txtbxNom.Size = new System.Drawing.Size(100, 20);
            this.txtbxNom.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Direccion";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Informacion de  la cafeteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONFIGURACION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Configuracion del sistema";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Impuesto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Fecha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Hora del sistema";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Zona horaria";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "%";
            // 
            // txtbxImp
            // 
            this.txtbxImp.Location = new System.Drawing.Point(122, 50);
            this.txtbxImp.Name = "txtbxImp";
            this.txtbxImp.Size = new System.Drawing.Size(100, 20);
            this.txtbxImp.TabIndex = 18;
            // 
            // txtbxHora
            // 
            this.txtbxHora.Location = new System.Drawing.Point(122, 119);
            this.txtbxHora.Name = "txtbxHora";
            this.txtbxHora.Size = new System.Drawing.Size(100, 20);
            this.txtbxHora.TabIndex = 20;
            // 
            // txtbxZona
            // 
            this.txtbxZona.Location = new System.Drawing.Point(122, 157);
            this.txtbxZona.Name = "txtbxZona";
            this.txtbxZona.Size = new System.Drawing.Size(100, 20);
            this.txtbxZona.TabIndex = 21;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(122, 84);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(196, 20);
            this.dateFecha.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(197, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Claro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Oscuro";
            // 
            // configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "configuracion";
            this.Size = new System.Drawing.Size(834, 573);
            this.Load += new System.EventHandler(this.configuracion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTemas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxCor;
        private System.Windows.Forms.TextBox txtbxTel;
        private System.Windows.Forms.TextBox txtbxDir;
        private System.Windows.Forms.TextBox txtbxNom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbxFuente;
        private System.Windows.Forms.TrackBar trackTemas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.TextBox txtbxZona;
        private System.Windows.Forms.TextBox txtbxHora;
        private System.Windows.Forms.TextBox txtbxImp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}
