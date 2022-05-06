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
                datos.setearConsulta("SELECT Nombre, Codigo,a.Descripcion,Precio, ImagenUrl,a.IdMarca,m.Descripcion Marca ,a.IdCategoria, c.Descripcion Categoria, a.Id FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE m.Id = a.IdMarca and c.Id = a.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.CodArt = (string)datos.Lector["Codigo"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Brand = new Marca();
                    aux.Brand.id = (int)datos.Lector["IdMarca"];
                    aux.Brand.Descripcion = (string)datos.Lector["Marca"];
                    aux.Cate = new Categoria();
                    aux.Cate.id = (int)datos.Lector["IdCategoria"];
                    aux.Cate.Descripcion = (string)datos.Lector["Categoria"];


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
                datos.setearConsulta("insert into Articulos (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                datos.setearParametros("@Codigo", nuevo.CodArt);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion",nuevo.Descripcion);
                datos.setearParametros("@IdMarca", nuevo.Brand.id);
                datos.setearParametros("@IdCategoria", nuevo.Cate.id);
                datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);
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

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @desc, IdMarca = @IdMarca, IdCategoria = @IdCat , ImagenUrl = @img , Precio = @precio WHERE Id = @Id");
                datos.setearParametros("@codigo", art.CodArt);
                datos.setearParametros("@nombre", art.Nombre);
                datos.setearParametros("@desc", art.Descripcion);
                datos.setearParametros("@IdMarca", art.Brand.id);
                datos.setearParametros("@IdCat", art.Cate.id);
                datos.setearParametros("@img", art.ImagenUrl);
                datos.setearParametros("@precio", art.Precio);
                datos.setearParametros("@Id", art.Id);
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
        public void Eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 










    }
}
