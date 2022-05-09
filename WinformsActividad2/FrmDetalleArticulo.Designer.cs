namespace WinformsActividad2
{
    partial class FrmDetalleArticulo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbxDetalle = new System.Windows.Forms.PictureBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblIdCat = new System.Windows.Forms.Label();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIdCat = new System.Windows.Forms.TextBox();
            this.txtDescMarca = new System.Windows.Forms.TextBox();
            this.txtDescCat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(54, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DETALLE ARTCULO";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(49, 92);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(78, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo Articulo";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(49, 153);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Descripcion";
            // 
            // pbxDetalle
            // 
            this.pbxDetalle.Location = new System.Drawing.Point(317, 53);
            this.pbxDetalle.Name = "pbxDetalle";
            this.pbxDetalle.Size = new System.Drawing.Size(203, 202);
            this.pbxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalle.TabIndex = 5;
            this.pbxDetalle.TabStop = false;
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(49, 181);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(49, 13);
            this.lblIdMarca.TabIndex = 6;
            this.lblIdMarca.Text = "Id Marca";
            // 
            // lblDescMarca
            // 
            this.lblDescMarca.AutoSize = true;
            this.lblDescMarca.Location = new System.Drawing.Point(49, 212);
            this.lblDescMarca.Name = "lblDescMarca";
            this.lblDescMarca.Size = new System.Drawing.Size(96, 13);
            this.lblDescMarca.TabIndex = 7;
            this.lblDescMarca.Text = "Descripcion Marca";
            // 
            // lblIdCat
            // 
            this.lblIdCat.AutoSize = true;
            this.lblIdCat.Location = new System.Drawing.Point(49, 242);
            this.lblIdCat.Name = "lblIdCat";
            this.lblIdCat.Size = new System.Drawing.Size(64, 13);
            this.lblIdCat.TabIndex = 8;
            this.lblIdCat.Text = "Id Categoria";
            // 
            // lblDescCat
            // 
            this.lblDescCat.AutoSize = true;
            this.lblDescCat.Location = new System.Drawing.Point(47, 281);
            this.lblDescCat.Name = "lblDescCat";
            this.lblDescCat.Size = new System.Drawing.Size(111, 13);
            this.lblDescCat.TabIndex = 9;
            this.lblDescCat.Text = "Descripcion Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(49, 321);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 59);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(117, 20);
            this.txtId.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(166, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(117, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 121);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(166, 150);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(117, 20);
            this.txtDesc.TabIndex = 15;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(166, 181);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.ReadOnly = true;
            this.txtIdMarca.Size = new System.Drawing.Size(117, 20);
            this.txtIdMarca.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(166, 314);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(117, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtIdCat
            // 
            this.txtIdCat.Location = new System.Drawing.Point(166, 242);
            this.txtIdCat.Name = "txtIdCat";
            this.txtIdCat.ReadOnly = true;
            this.txtIdCat.Size = new System.Drawing.Size(117, 20);
            this.txtIdCat.TabIndex = 19;
            // 
            // txtDescMarca
            // 
            this.txtDescMarca.Location = new System.Drawing.Point(166, 209);
            this.txtDescMarca.Name = "txtDescMarca";
            this.txtDescMarca.ReadOnly = true;
            this.txtDescMarca.Size = new System.Drawing.Size(117, 20);
            this.txtDescMarca.TabIndex = 20;
            // 
            // txtDescCat
            // 
            this.txtDescCat.Location = new System.Drawing.Point(166, 278);
            this.txtDescCat.Name = "txtDescCat";
            this.txtDescCat.ReadOnly = true;
            this.txtDescCat.Size = new System.Drawing.Size(117, 20);
            this.txtDescCat.TabIndex = 21;
            // 
            // FrmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 358);
            this.Controls.Add(this.txtDescCat);
            this.Controls.Add(this.txtDescMarca);
            this.Controls.Add(this.txtIdCat);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescCat);
            this.Controls.Add(this.lblIdCat);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.pbxDetalle);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmDetalleArticulo";
            this.Text = "FrmDetalleArticulo";
            this.Load += new System.EventHandler(this.FrmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbxDetalle;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblIdCat;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdCat;
        private System.Windows.Forms.TextBox txtDescMarca;
        private System.Windows.Forms.TextBox txtDescCat;
    }
}