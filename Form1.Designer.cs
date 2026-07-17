namespace pryCafeteriaEscolar
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(888, 581);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(455, 611);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguracion.TabIndex = 1;
            this.btnConfiguracion.Text = "button1";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 648);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.panelContenedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}

