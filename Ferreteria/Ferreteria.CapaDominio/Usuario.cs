using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UsuarioNombre { get; set; }
        public string Acceso { get; set; }
        public string Dni { get; set; }
        public string Clave { get; set; }
        public byte Estado { get; set; }

        public List<Ingreso> Ingresos { get; set; }
        public List<Venta> Ventas { get; set; }
        public List<Presupuesto> Presupuestos { get; set; }
    }
}
