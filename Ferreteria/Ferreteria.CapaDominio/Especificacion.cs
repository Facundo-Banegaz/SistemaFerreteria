using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Especificacion
    {
        public int Id_Especificacion { get; set; }

      
        public Producto Producto { get; set; }

       
        public TipoEspecificacion TipoEspecificacion { get; set; }

       
        public ValorEspecificacion ValorEspecificacion { get; set; }
    }
}
