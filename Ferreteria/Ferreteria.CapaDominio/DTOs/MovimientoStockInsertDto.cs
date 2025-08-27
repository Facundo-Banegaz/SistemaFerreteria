using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.DTOs
{
    public class MovimientoStockInsertDto
    {
        public int Id_TipoMovimiento { get; set; }
        public int Id_Usuario { get; set; }

        public int Id_Producto { get; set; }
        public decimal Cantidad { get; set; }

        public string ObservacionDetalle { get; set; }

    }
}
