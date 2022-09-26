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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.cmdAtras = new System.Windows.Forms.Button();
            this.cmdAdelante = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre_Libro = new System.Windows.Forms.Label();
            this.lblCodigo_Autor = new System.Windows.Forms.Label();
            this.lblNombre_Editorial = new System.Windows.Forms.Label();
            this.lblNombre_Distribuidor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtNombreEdit = new System.Windows.Forms.TextBox();
            this.txtNombreDistribuidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(149, 174);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 2;
            this.cmdAtras.Text = "<<";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // cmdAdelante
            // 
            this.cmdAdelante.Location = new System.Drawing.Point(235, 174);
            this.cmdAdelante.Name = "cmdAdelante";
            this.cmdAdelante.Size = new System.Drawing.Size(75, 23);
            this.cmdAdelante.TabIndex = 3;
            this.cmdAdelante.Text = " >  > ";
            this.cmdAdelante.UseVisualStyleBackColor = true;
            this.cmdAdelante.Click += new System.EventHandler(this.cmdAdelante_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código ";
            // 
            // lblNombre_Libro
            // 
            this.lblNombre_Libro.AutoSize = true;
            this.lblNombre_Libro.Location = new System.Drawing.Point(9, 51);
            this.lblNombre_Libro.Name = "lblNombre_Libro";
            this.lblNombre_Libro.Size = new System.Drawing.Size(87, 13);
            this.lblNombre_Libro.TabIndex = 5;
            this.lblNombre_Libro.Text = "Nombre del Libro";
            // 
            // lblCodigo_Autor
            // 
            this.lblCodigo_Autor.AutoSize = true;
            this.lblCodigo_Autor.Location = new System.Drawing.Point(9, 80);
            this.lblCodigo_Autor.Name = "lblCodigo_Autor";
            this.lblCodigo_Autor.Size = new System.Drawing.Size(85, 13);
            this.lblCodigo_Autor.TabIndex = 6;
            this.lblCodigo_Autor.Text = "Código del Autor";
            // 
            // lblNombre_Editorial
            // 
            this.lblNombre_Editorial.AutoSize = true;
            this.lblNombre_Editorial.Location = new System.Drawing.Point(9, 109);
            this.lblNombre_Editorial.Name = "lblNombre_Editorial";
            this.lblNombre_Editorial.Size = new System.Drawing.Size(110, 13);
            this.lblNombre_Editorial.TabIndex = 7;
            this.lblNombre_Editorial.Text = "Nombre de la Editorial";
            // 
            // lblNombre_Distribuidor
            // 
            this.lblNombre_Distribuidor.AutoSize = true;
            this.lblNombre_Distribuidor.Location = new System.Drawing.Point(9, 138);
            this.lblNombre_Distribuidor.Name = "lblNombre_Distribuidor";
            this.lblNombre_Distribuidor.Size = new System.Drawing.Size(116, 13);
            this.lblNombre_Distribuidor.TabIndex = 8;
            this.lblNombre_Distribuidor.Text = "Nombre del Distribuidor";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(149, 45);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(161, 20);
            this.txtNombreLibro.TabIndex = 10;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Location = new System.Drawing.Point(149, 75);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.ReadOnly = true;
            this.txtCodigoAutor.Size = new System.Drawing.Size(74, 20);
            this.txtCodigoAutor.TabIndex = 11;
            // 
            // txtNombreEdit
            // 
            this.txtNombreEdit.Location = new System.Drawing.Point(149, 105);
            this.txtNombreEdit.Name = "txtNombreEdit";
            this.txtNombreEdit.ReadOnly = true;
            this.txtNombreEdit.Size = new System.Drawing.Size(161, 20);
            this.txtNombreEdit.TabIndex = 12;
            // 
            // txtNombreDistribuidor
            // 
            this.txtNombreDistribuidor.Location = new System.Drawing.Point(149, 135);
            this.txtNombreDistribuidor.Name = "txtNombreDistribuidor";
            this.txtNombreDistribuidor.ReadOnly = true;
            this.txtNombreDistribuidor.Size = new System.Drawing.Size(161, 20);
            this.txtNombreDistribuidor.TabIndex = 13;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 204);
            this.Controls.Add(this.txtNombreDistribuidor);
            this.Controls.Add(this.txtNombreEdit);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre_Distribuidor);
            this.Controls.Add(this.lblNombre_Editorial);
            this.Controls.Add(this.lblCodigo_Autor);
            this.Controls.Add(this.lblNombre_Libro);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cmdAdelante);
            this.Controls.Add(this.cmdAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.Button cmdAdelante;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre_Libro;
        private System.Windows.Forms.Label lblCodigo_Autor;
        private System.Windows.Forms.Label lblNombre_Editorial;
        private System.Windows.Forms.Label lblNombre_Distribuidor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtNombreEdit;
        private System.Windows.Forms.TextBox txtNombreDistribuidor;
    }
}

