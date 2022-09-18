namespace pryArlaEPRBioblioteca
{
    partial class frmBiblioteca
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
            this.grlLibros = new System.Windows.Forms.DataGridView();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdAdelante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // grlLibros
            // 
            this.grlLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlLibros.Location = new System.Drawing.Point(12, 12);
            this.grlLibros.Name = "grlLibros";
            this.grlLibros.Size = new System.Drawing.Size(753, 109);
            this.grlLibros.TabIndex = 0;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(370, 127);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(126, 127);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 2;
            this.cmdAtras.Text = "<<";
            this.cmdAtras.UseVisualStyleBackColor = true;
            // 
            // cmdAdelante
            // 
            this.cmdAdelante.Location = new System.Drawing.Point(614, 127);
            this.cmdAdelante.Name = "cmdAdelante";
            this.cmdAdelante.Size = new System.Drawing.Size(75, 23);
            this.cmdAdelante.TabIndex = 3;
            this.cmdAdelante.Text = " >  > ";
            this.cmdAdelante.UseVisualStyleBackColor = true;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 169);
            this.Controls.Add(this.cmdAdelante);
            this.Controls.Add(this.cmdAtras);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.grlLibros);
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.grlLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlLibros;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdAdelante;
    }
}

