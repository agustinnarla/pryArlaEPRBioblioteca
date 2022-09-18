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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Distribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grlLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // grlLibros
            // 
            this.grlLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre_Libro,
            this.Codigo_Editorial,
            this.Codigo_Autor,
            this.Codigo_Distribuidor});
            this.grlLibros.Location = new System.Drawing.Point(12, 12);
            this.grlLibros.Name = "grlLibros";
            this.grlLibros.Size = new System.Drawing.Size(663, 85);
            this.grlLibros.TabIndex = 0;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(294, 103);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdAtras
            // 
            this.cmdAtras.Location = new System.Drawing.Point(50, 103);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAtras.TabIndex = 2;
            this.cmdAtras.Text = "<<";
            this.cmdAtras.UseVisualStyleBackColor = true;
            // 
            // cmdAdelante
            // 
            this.cmdAdelante.Location = new System.Drawing.Point(538, 103);
            this.cmdAdelante.Name = "cmdAdelante";
            this.cmdAdelante.Size = new System.Drawing.Size(75, 23);
            this.cmdAdelante.TabIndex = 3;
            this.cmdAdelante.Text = " >  > ";
            this.cmdAdelante.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nombre_Libro
            // 
            this.Nombre_Libro.HeaderText = "Nombre Libro";
            this.Nombre_Libro.Name = "Nombre_Libro";
            this.Nombre_Libro.Width = 250;
            // 
            // Codigo_Editorial
            // 
            this.Codigo_Editorial.HeaderText = "Codigo Editorial";
            this.Codigo_Editorial.Name = "Codigo_Editorial";
            // 
            // Codigo_Autor
            // 
            this.Codigo_Autor.HeaderText = "Codigo Autor";
            this.Codigo_Autor.Name = "Codigo_Autor";
            // 
            // Codigo_Distribuidor
            // 
            this.Codigo_Distribuidor.HeaderText = "Codigo Distribuidor";
            this.Codigo_Distribuidor.Name = "Codigo_Distribuidor";
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 150);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Distribuidor;
    }
}

