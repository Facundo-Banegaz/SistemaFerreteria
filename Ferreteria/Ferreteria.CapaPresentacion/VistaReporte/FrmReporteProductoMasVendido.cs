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
    public partial class FrmReporteProductoMasVendido : Form
    {
        private DateTime FechaInicio { get; set; }

        private DateTime FechaFin { get; set; }
        public FrmReporteProductoMasVendido(DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
        }


    
        private void FrmReporteProductoMasVendido_Load(object sender, EventArgs e)
        {

            this.sp_ProductosMasVendidosTableAdapter.Fill(this.dsPrincipal.Sp_ProductosMasVendidos, FechaInicio, FechaFin);
            this.reportViewer1.RefreshReport();
        }
    }
}
