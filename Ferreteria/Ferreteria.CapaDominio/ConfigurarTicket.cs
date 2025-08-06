using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class ConfigurarTicket
    {
        public int Id_ConfiguracionTicket { get; set; }
        public string NombreNegocio { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string TextoNoFactura { get; set; }
        public string TextoVenta { get; set; }
        public string TextoPresupuesto { get; set; }
        public string FraseDespedidaPresupuesto { get; set; }
        public string FraseDespedidaVenta { get; set; }

        public string NombreImpresoraTermica { get; set; }
    }
}
