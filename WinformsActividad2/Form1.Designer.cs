﻿namespace WinformsActividad2
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
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos1
            // 
            this.dgvArticulos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos1.Location = new System.Drawing.Point(429, 43);
            this.dgvArticulos1.Name = "dgvArticulos1";
            this.dgvArticulos1.Size = new System.Drawing.Size(651, 364);
            this.dgvArticulos1.TabIndex = 0;
            this.dgvArticulos1.SelectionChanged += new System.EventHandler(this.dgvArticulos1_SelectionChanged);
            // 
            // pbArticulos
            // 
            this.pbArticulos.Location = new System.Drawing.Point(49, 67);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(204, 252);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            // 
            // frmConsultas
            // 
            this.ClientSize = new System.Drawing.Size(1205, 484);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgvArticulos1);
            this.Name = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.PictureBox pbListar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvArticulos1;
        private System.Windows.Forms.PictureBox pbArticulos;
    }
}

