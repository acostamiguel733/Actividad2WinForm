using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinformsActividad2
{
    public partial class frmConsultas : Form
    {

        private List<Articulo> listaArticulos;

        public frmConsultas()
        {

            InitializeComponent();

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.Listar();
            dgvArticulos1.DataSource = listaArticulos;


        }   
    }

}



