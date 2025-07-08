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
        public string Tipo_Comprobante { get; set; }
        public string Serie { get; set; }
        public string Correlativo { get; set; }

        public string Estado { get; set; }

        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public decimal Total { get; set; }

 

        public List<DetalleIngreso> Detalles { get; set; }

    }
}
