using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class MovimientoStock
    {
        public int Id_MovimientoStock { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;



        // Relación con TipoMovimiento
        public TipoMovimiento TipoMovimiento { get; set; }


        // Relación con Usuario
        public Usuario Usuario { get; set; }

        public string Observacion { get; set; }

        public List<DetalleMovimientoStock> Detalles { get; set; }
    }
}
