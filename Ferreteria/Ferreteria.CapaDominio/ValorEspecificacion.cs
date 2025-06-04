using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class ValorEspecificacion
    {
        public int Id_ValorEspecificacion { get; set; }
        public string Valor { get; set; }

        public List<Especificacion> Especificaciones { get; set; }
    }
}
