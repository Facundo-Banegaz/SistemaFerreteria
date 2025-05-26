using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Boleta
    {
        public int Id { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public string NombreCliente { get; set; }
        public string Domicilio { get; set; }
        public string CUIT_CUIL { get; set; }
    }
}
