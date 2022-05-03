﻿using System;
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
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            
 
            try
            {

                nuevo.CodArt = textCodigo.Text;
                nuevo.Nombre = textNombre.Text;
                nuevo.Descripcion = textDescripcion.Text;
<<<<<<< HEAD
                nuevo.ImagenUrl = cbxUrlImagen.Text;
                nuevo.Brand = (Marca)cbxMarca.SelectedItem; 
=======
                nuevo.Brand = (Marca)cbxMarca.SelectedItem;
>>>>>>> d27c160f98e8d49b5462cec6e133933e0eb18b22
                nuevo.Cate = (Categoria)cbxCategoria.SelectedItem;
                nuevo.Precio = decimal.Parse(textPrecio.Text);
                negocio.agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
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
                cbxCategoria.DataSource = categoriaNegocio.Listar();

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
