using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Cliente { get; set; }
        public decimal Total { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string Estado { get; set; }
        public List<DetallePresupuesto> Detalles { get; set; }
    }
}
