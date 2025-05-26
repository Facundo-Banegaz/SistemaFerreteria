using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Especificacion
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int TipoEspecificacionId { get; set; }
        public TipoEspecificacion TipoEspecificacion { get; set; }

        public int ValorEspecificacionId { get; set; }
        public ValorEspecificacion ValorEspecificacion { get; set; }
    }
}
