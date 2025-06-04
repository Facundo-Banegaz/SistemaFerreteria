using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Ingreso
    {
        public int Id_Ingreso { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public List<DetalleIngreso> Detalles { get; set; }
    }
}
