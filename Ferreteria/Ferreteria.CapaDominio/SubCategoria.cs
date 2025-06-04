using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Subcategoria
    {
        public int Id_Subcategoria { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
        public Categoria Categoria { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
