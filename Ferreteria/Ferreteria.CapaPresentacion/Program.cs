using Ferreteria.CapaPresentacion.VistaCategoria;
using Ferreteria.CapaPresentacion.VistaMarca;
using Ferreteria.CapaPresentacion.VistaPrincipalMDI;
using Ferreteria.CapaPresentacion.VistaProducto;
using Ferreteria.CapaPresentacion.VistaSubcategoria;
using Ferreteria.CapaPresentacion.VistaUnidadMedida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmProducto());
        }
    }
}
