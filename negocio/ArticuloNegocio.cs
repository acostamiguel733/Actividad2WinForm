using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace negocio
{
    public  class ArticuloNegocio
    {
        //public List<Articulo> Listar()
        //{
        //    List <Articulo> list = new List<Articulo>();
        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    SqlDataReader lector;
        //     
        //    try
        //    {
        //        conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true" ;
        //        comando.CommandType = System.Data.CommandType.Text ;
        //        comando.CommandText = "select a.Nombre , a.Codigo, m.Descripcion as 'Marca', a.Descripcion, c.Descripcion as 'Categoria', precio from articulos a inner join categorias c on a.IdCategoria = c.Id inner join marcas m on a.IdMarca = m.Id";
        //        comando.Connection = conexion ;
        //        conexion.Open();
        //        lector = comando.ExecuteReader();
        //
        //        while (lector.Read())
        //        {
        //            Articulo aux = new Articulo();
        //            aux.Nombre = (string)lector["Nombre"];
        //            aux.CodArt = (string)lector["Codigo"];
        //            aux.Marca = (string)lector["Marca"];
        //            aux.Descripcion = (string)lector["Descripcion"];
        //            aux.Categoria = (string)lector["Categoria"];
        //            aux.Precio = (float)lector["Precio"];
        //            list.Add(aux);
        //        }
        //           return list;
        //    }
        //    catch (Exception ex)
        //    {
        //
        //        throw ex;
        //    }
        //    finally
        //    {
        //           conexion.Close();
        //
        //    }
        //
        //}
        //


        public List <Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("SELECT Nombre, Codigo,Precio, ImagenUrl,m.Descripcion Marca FROM ARTICULOS a,MARCAS m WHERE m.Id = a.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.CodArt = (string)datos.Lector["Codigo"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Brand = new Marca();
                    aux.Brand.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);


                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            
            }      
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into Articulos (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                datos.setearParametros("@Codigo", nuevo.CodArt);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion",nuevo.Descripcion);
                datos.setearParametros("@IdMarca", nuevo.Brand.id);
                datos.setearParametros("@IdCategoria", nuevo.Cate.id);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

            }
        }








    }
}
