using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Marca
    {
        public int Id_Marca { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
        public List<Producto> Productos { get; set; }
    }
}
