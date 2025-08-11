using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class DetalleMovimientoStock
    {

        public int Id_DetalleMovimientoStock { get; set; }

        public MovimientoStock MovimientoStock { get; set; }
        public Producto Producto { get; set; }

   

        public decimal Cantidad { get; set; }
        public decimal StockAnterior { get; set; } = 0;

        [DisplayName("Stock Nuevo")]
        public decimal StockNuevo { get; set; } = 0;


        public string ObservacionDetalle { get; set; }
    }
}
