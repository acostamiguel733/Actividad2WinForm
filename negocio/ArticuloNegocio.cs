using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;


namespace negocio
{
    public  class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List <Articulo> list = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
             
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; datebase=CATALOGO_DB; integrated security=true" ;
                   return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
