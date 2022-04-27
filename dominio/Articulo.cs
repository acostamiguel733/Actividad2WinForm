using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace dominio
{
    public class Articulo
    {
        public int CodArt { get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; } 
        public string Marca { get; set; }   
        public string Categoria { get; set; } 
        public float Precio { get; set; }   
        public bool Estado { get; set; }    

    }
}
