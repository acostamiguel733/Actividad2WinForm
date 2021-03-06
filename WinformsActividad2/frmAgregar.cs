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
    public partial class frmAgregar : Form
    {
        private Articulo art = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo art)
        {
            InitializeComponent();
            this.art = art;
            Text = "Modificar Articulo";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private bool ValidarIngresoDeDatos()
        {
            if (string.IsNullOrEmpty(textCodigo.Text))
            {
                MessageBox.Show("Por favor completa el Codigo del Articulo.");
                return true;
            }
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                MessageBox.Show("Por favor completa el Nombre del Articulo.");
                return true;
            }
            if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                MessageBox.Show("Por favor completa la Descripcion del Articulo.");
                return true;
            }
            if (string.IsNullOrEmpty(textPrecio.Text))
            {
                MessageBox.Show("Por favor completa el Precio del Articulo.");
                return true;
            }
            if (!(soloNumeros(textPrecio.Text)))
            {
                MessageBox.Show("Por favor solo ingrese numeros para el  campo Precio");
                return true;
            }
            return false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio negocio = new ArticuloNegocio();
            
 
            try
            {
                if (art == null)
                    art = new Articulo();
                if (ValidarIngresoDeDatos())
                    return;

                art.CodArt = textCodigo.Text;
                art.Nombre = textNombre.Text;
                art.Descripcion = textDescripcion.Text;
                art.ImagenUrl = cbxUrlImagen.Text;
                art.Brand = (Marca)cbxMarca.SelectedItem; 
                art.Brand = (Marca)cbxMarca.SelectedItem;
                art.Cate = (Categoria)cbxCategoria.SelectedItem;
                art.Precio = decimal.Parse(textPrecio.Text);


               if(art.Id != 0)
                {
                    negocio.modificar(art);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(art);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = marcaNegocio.Listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if ( art != null)
                {
                    textCodigo.Text = art.CodArt;
                    textNombre.Text = art.Nombre;
                    textDescripcion.Text = art.Descripcion;
                    cbxUrlImagen.Text = art.ImagenUrl;
                    cargarImagen(art.ImagenUrl);
                    textPrecio.Text = art.Precio.ToString();
                    cbxMarca.SelectedValue = art.Brand.id;
                    cbxCategoria.SelectedValue = art.Cate.id;
                      
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbxUrlImagen_Leave(object sender, EventArgs e)
        {

            cargarImagen(cbxUrlImagen.Text);                  


        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

    }
}
