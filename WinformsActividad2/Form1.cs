﻿using dominio;
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
            dgvArticulos1.Columns["ImagenUrl"].Visible = false;
            dgvArticulos1.Columns["Descripcion"].Visible = false;
            dgvArticulos1.Columns["Estado"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);

                
        }

        private void dgvArticulos1_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos1.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);

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


    }

}



