using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaReporte
{
    public partial class FrmReporteInventario : Form
    {
        public FrmReporteInventario()
        {
            InitializeComponent();
            Text = "Reporte De Invenatrio";    
        }

        private void FrmReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.Sp_ProductosInventarioBajo' Puede moverla o quitarla según sea necesario.
            this.sp_ProductosInventarioBajoTableAdapter.Fill(this.dsPrincipal.Sp_ProductosInventarioBajo);

            this.reportViewer1.RefreshReport();
        }
    }
}
