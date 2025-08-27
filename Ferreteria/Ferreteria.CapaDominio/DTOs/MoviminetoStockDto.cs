using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.DTOs
{
    public class MoviminetoStockDto
    {
        public int Id_MovimientoStock { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Tipo Movimiento")]
        public string TipoMovimiento { get; set; }
        public string Usuario { get; set; }
        public string Observacion { get; set; }

        public int Id_DetalleMovimientoStock { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        [DisplayName("Stock Anterior")]
        public decimal StockAnterior { get; set; }
        [DisplayName("Stock Nuevo")]

        public decimal StockNuevo { get; set; }
        [DisplayName("Detalles")]
        public string ObservacionDetalle { get; set; }
    }
}
