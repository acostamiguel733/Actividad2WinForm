namespace WinformsActividad2
{
    partial class frmConsultas
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
            this.dgvArticulos1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos1
            // 
            this.dgvArticulos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos1.Location = new System.Drawing.Point(61, 65);
            this.dgvArticulos1.Name = "dgvArticulos1";
            this.dgvArticulos1.Size = new System.Drawing.Size(855, 328);
            this.dgvArticulos1.TabIndex = 0;
            // 
            // frmConsultas
            // 
            this.ClientSize = new System.Drawing.Size(959, 451);
            this.Controls.Add(this.dgvArticulos1);
            this.Name = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.PictureBox pbListar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvArticulos1;
    }
}

