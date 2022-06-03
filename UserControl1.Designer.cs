
namespace ControlUsuario
{
    partial class UserControl1
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
            this.pcbForm = new System.Windows.Forms.PictureBox();
            this.btnPulsar = new System.Windows.Forms.Button();
            this.txtNombreForm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbForm
            // 
            this.pcbForm.Location = new System.Drawing.Point(13, 16);
            this.pcbForm.Name = "pcbForm";
            this.pcbForm.Size = new System.Drawing.Size(207, 168);
            this.pcbForm.TabIndex = 0;
            this.pcbForm.TabStop = false;
            // 
            // btnPulsar
            // 
            this.btnPulsar.Location = new System.Drawing.Point(171, 203);
            this.btnPulsar.Name = "btnPulsar";
            this.btnPulsar.Size = new System.Drawing.Size(49, 23);
            this.btnPulsar.TabIndex = 1;
            this.btnPulsar.Text = "Pulsar";
            this.btnPulsar.UseVisualStyleBackColor = true;
            // 
            // txtNombreForm
            // 
            this.txtNombreForm.Location = new System.Drawing.Point(13, 203);
            this.txtNombreForm.Name = "txtNombreForm";
            this.txtNombreForm.Size = new System.Drawing.Size(152, 20);
            this.txtNombreForm.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNombreForm);
            this.Controls.Add(this.btnPulsar);
            this.Controls.Add(this.pcbForm);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(239, 252);
            ((System.ComponentModel.ISupportInitialize)(this.pcbForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pcbForm;
        public System.Windows.Forms.Button btnPulsar;
        public System.Windows.Forms.TextBox txtNombreForm;
    }
}
