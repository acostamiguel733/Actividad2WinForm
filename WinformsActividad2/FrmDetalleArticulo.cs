using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WinformsActividad2
{
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo art = null;

        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        public FrmDetalleArticulo(Articulo art)
        {
            InitializeComponent();
            this.art = art;
            Text = "Detalle Articulo";

        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {

            try
            {
                txtId.Text = art.Id.ToString();
                txtCodigo.Text = art.CodArt.ToString();
                txtNombre.Text = art.Nombre.ToString();
                txtDesc.Text = art.Descripcion.ToString();
                txtIdMarca.Text = art.Brand.id.ToString();
                txtDescMarca.Text = art.Brand.Descripcion.ToString();
                txtIdCat.Text = art.Cate.id.ToString();
                txtDescCat.Text = art.Cate.Descripcion.ToString();
                txtPrecio.Text = art.Precio.ToString();
                cargarImagen(art.ImagenUrl.ToString());
      
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDetalle.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDetalle.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
  
    }
}
