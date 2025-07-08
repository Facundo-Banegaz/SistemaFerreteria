using Ferreteria.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ferreteria.CapaNegocio
{
    public class CN_Metodos
    {
        CD_Metodos objMetodos = new CD_Metodos();

        // Metodo para alternar los colores en las filas de un data grid
        public void AlternarColor(DataGridView Dgv)
        {
            objMetodos.AlternarColor(Dgv);
        }
        public (string Serie, string Correlativo) GenerarSerieYCorrelativo(string tabla, string tipoDocumento)
        {
            return objMetodos.GenerarSerieYCorrelativo(tabla, tipoDocumento);
        }


    }
}
