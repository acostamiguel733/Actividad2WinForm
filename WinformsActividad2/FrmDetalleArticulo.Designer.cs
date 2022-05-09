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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblDescMarca = new System.Windows.Forms.Label();
            this.lblIdCat = new System.Windows.Forms.Label();
            this.lblDescCat = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 59);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 202);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.txtId.Size = new System.Drawing.Size(117, 20);
            this.txtId.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 314);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(166, 242);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(166, 209);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(117, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(166, 278);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(117, 20);
            this.textBox8.TabIndex = 21;
            // 
            // FrmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 377);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescCat);
            this.Controls.Add(this.lblIdCat);
            this.Controls.Add(this.lblDescMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmDetalleArticulo";
            this.Text = "FrmDetalleArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescMarca;
        private System.Windows.Forms.Label lblIdCat;
        private System.Windows.Forms.Label lblDescCat;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
    }
}