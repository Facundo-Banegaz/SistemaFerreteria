using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class TipoEspecificacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
    }
}
