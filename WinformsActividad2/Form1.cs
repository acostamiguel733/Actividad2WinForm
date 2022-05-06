using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformsActividad2
{
    public partial class frmModificar : Form
    {
        
        private List<Articulo> listaArticulos;

        public frmModificar()
        {

            InitializeComponent();

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos1.DataSource = listaArticulos;
                //dgvArticulos1.Columns["Id"].Visible = false;
                dgvArticulos1.Columns["ImagenUrl"].Visible = false;
                dgvArticulos1.Columns["Descripcion"].Visible = false;
                dgvArticulos1.Columns["Estado"].Visible = false;
                cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

                
        }

        private void dgvArticulos1_SelectionChanged(object sender, EventArgs e)
        {

            Articulo selec = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem; 
            cargarImagen(selec.ImagenUrl);

        }

        private void cargarImagen(string imagen)         
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulos.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Articulo seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);

            modificar.ShowDialog();



        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;
                articulo.Eliminar(seleccionado.Id);
                   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }

}



