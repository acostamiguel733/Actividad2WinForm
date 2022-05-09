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

            cargar();

                
        }

        private void dgvArticulos1_SelectionChanged(object sender, EventArgs e)
        {

            Articulo selec = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem; 
            cargarImagen(selec.ImagenUrl);

        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvArticulos1.DataSource = listaArticulos;
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
        private void ocultarColumnas()
        {
            dgvArticulos1.Columns["ImagenUrl"].Visible = false;
            dgvArticulos1.Columns["Descripcion"].Visible = false;
            dgvArticulos1.Columns["Estado"].Visible = false;
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
            DataGridViewRow row = dgvArticulos1.CurrentRow;
            if(row != null)
            {
            Articulo seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);

            modificar.ShowDialog();

            cargar();
            }
        }
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvArticulos1.CurrentRow;
            if( row != null) 
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                Articulo seleccionado;
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;
                        articulo.Eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> Listafiltrada;
            string filtro = txtFiltro.Text;

            if(filtro.Length >= 3)
            { 
            Listafiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Brand.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CodArt.ToUpper().Contains(filtro.ToUpper()) || x.Cate.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                Listafiltrada = listaArticulos;
            }
            dgvArticulos1.DataSource = null;
            dgvArticulos1.DataSource = Listafiltrada;
            ocultarColumnas();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvArticulos1.CurrentRow;
            if (row != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;

                FrmDetalleArticulo detalle = new FrmDetalleArticulo(seleccionado);
                detalle.ShowDialog();

            }


        }
    }

}



