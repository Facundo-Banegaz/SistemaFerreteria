using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class TipoMovimiento
    {
        public int Id_TipoMovimiento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public char Movimiento { get; set; } // 'E' para Entrada, 'S' para Salida
    }
}
