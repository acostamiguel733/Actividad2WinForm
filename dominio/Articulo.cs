using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string CodArt { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }               
        public decimal Precio { get; set; }   
        public bool Estado { get; set; } 
        public string ImagenUrl { get; set; }
        [DisplayName("Marca")]
        public Marca Brand { get; set; }
        [DisplayName("Categoría")]
        public Categoria Cate { get; set; }    


    }
}
