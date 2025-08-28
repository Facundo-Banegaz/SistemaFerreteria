using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.DTOs
{
    public class ProductoAvanzadoDto
    {

        public int Id_Producto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public decimal Stock { get; set; }
        [DisplayName("Stock Minimo")]
        public decimal StockMinimo { get; set; }


        public string Marca { get; set; }

        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        
        [DisplayName("Unidad Medida")]
        public string UnidadMedida { get; set; }
        public bool Estado { get; set; }

    }
}
