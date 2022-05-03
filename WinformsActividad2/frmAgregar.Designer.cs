namespace WinformsActividad2
{
    partial class frmAgregar
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
            this.lAgregar1 = new System.Windows.Forms.Label();
            this.lAgregar2 = new System.Windows.Forms.Label();
            this.lAgregar3 = new System.Windows.Forms.Label();
            this.lAgregar4 = new System.Windows.Forms.Label();
            this.lAgregar5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lAgregarz = new System.Windows.Forms.Label();
            this.lUrlImagen = new System.Windows.Forms.Label();
            this.cbxUrlImagen = new System.Windows.Forms.ComboBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lAgregar1
            // 
            this.lAgregar1.AutoSize = true;
            this.lAgregar1.Location = new System.Drawing.Point(26, 68);
            this.lAgregar1.Name = "lAgregar1";
            this.lAgregar1.Size = new System.Drawing.Size(40, 13);
            this.lAgregar1.TabIndex = 0;
            this.lAgregar1.Text = "Codigo";
            this.lAgregar1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lAgregar2
            // 
            this.lAgregar2.AutoSize = true;
            this.lAgregar2.Location = new System.Drawing.Point(26, 98);
            this.lAgregar2.Name = "lAgregar2";
            this.lAgregar2.Size = new System.Drawing.Size(44, 13);
            this.lAgregar2.TabIndex = 1;
            this.lAgregar2.Text = "Nombre";
            // 
            // lAgregar3
            // 
            this.lAgregar3.AutoSize = true;
            this.lAgregar3.Location = new System.Drawing.Point(26, 130);
            this.lAgregar3.Name = "lAgregar3";
            this.lAgregar3.Size = new System.Drawing.Size(63, 13);
            this.lAgregar3.TabIndex = 2;
            this.lAgregar3.Text = "Descripcion";
            // 
            // lAgregar4
            // 
            this.lAgregar4.AutoSize = true;
            this.lAgregar4.Location = new System.Drawing.Point(26, 236);
            this.lAgregar4.Name = "lAgregar4";
            this.lAgregar4.Size = new System.Drawing.Size(37, 13);
            this.lAgregar4.TabIndex = 3;
            this.lAgregar4.Text = "Marca";
            // 
            // lAgregar5
            // 
            this.lAgregar5.AutoSize = true;
            this.lAgregar5.Location = new System.Drawing.Point(26, 268);
            this.lAgregar5.Name = "lAgregar5";
            this.lAgregar5.Size = new System.Drawing.Size(52, 13);
            this.lAgregar5.TabIndex = 4;
            this.lAgregar5.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(165, 233);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(165, 265);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 6;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(165, 68);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(121, 20);
            this.textCodigo.TabIndex = 0;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(165, 98);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(121, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(165, 127);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textDescripcion.TabIndex = 2;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(165, 158);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(121, 20);
            this.textPrecio.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(108, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lAgregarz
            // 
            this.lAgregarz.AutoSize = true;
            this.lAgregarz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAgregarz.Location = new System.Drawing.Point(42, 26);
            this.lAgregarz.Name = "lAgregarz";
            this.lAgregarz.Size = new System.Drawing.Size(166, 20);
            this.lAgregarz.TabIndex = 14;
            this.lAgregarz.Text = "Agregue un articulo";
            this.lAgregarz.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lUrlImagen
            // 
            this.lUrlImagen.AutoSize = true;
            this.lUrlImagen.Location = new System.Drawing.Point(26, 195);
            this.lUrlImagen.Name = "lUrlImagen";
            this.lUrlImagen.Size = new System.Drawing.Size(55, 13);
            this.lUrlImagen.TabIndex = 15;
            this.lUrlImagen.Text = "UrlImagen";
            // 
            // cbxUrlImagen
            // 
            this.cbxUrlImagen.FormattingEnabled = true;
            this.cbxUrlImagen.Location = new System.Drawing.Point(165, 192);
            this.cbxUrlImagen.Name = "cbxUrlImagen";
            this.cbxUrlImagen.Size = new System.Drawing.Size(121, 21);
            this.cbxUrlImagen.TabIndex = 4;
            this.cbxUrlImagen.Leave += new System.EventHandler(this.cbxUrlImagen_Leave);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(341, 68);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(253, 226);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 17;
            this.pbxArticulo.TabStop = false;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 435);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.cbxUrlImagen);
            this.Controls.Add(this.lUrlImagen);
            this.Controls.Add(this.lAgregarz);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lAgregar5);
            this.Controls.Add(this.lAgregar4);
            this.Controls.Add(this.lAgregar3);
            this.Controls.Add(this.lAgregar2);
            this.Controls.Add(this.lAgregar1);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAgregar1;
        private System.Windows.Forms.Label lAgregar2;
        private System.Windows.Forms.Label lAgregar3;
        private System.Windows.Forms.Label lAgregar4;
        private System.Windows.Forms.Label lAgregar5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lAgregarz;
        private System.Windows.Forms.Label lUrlImagen;
        private System.Windows.Forms.ComboBox cbxUrlImagen;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}