using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public string CodArt { get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }               
        public string Categoria { get; set; } 
        public decimal Precio { get; set; }   
        public bool Estado { get; set; } 
        public string ImagenUrl { get; set; }
        public Marca Brand { get; set; }
         public Categoria Cate { get; set; }    


    }
}
