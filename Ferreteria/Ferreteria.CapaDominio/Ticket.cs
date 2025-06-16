using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Ticket
    {
        public int Id_Ticket { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }
        public Venta Venta { get; set; }

        public DateTime FechaEmision { get; set; } = DateTime.Now;
    }
}
