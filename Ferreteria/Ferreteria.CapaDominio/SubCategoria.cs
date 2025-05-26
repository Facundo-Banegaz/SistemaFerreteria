using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
