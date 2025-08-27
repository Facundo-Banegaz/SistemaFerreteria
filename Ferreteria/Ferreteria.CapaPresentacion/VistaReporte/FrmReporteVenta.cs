using Ferreteria.CapaDominio.Reportes;
using Ferreteria.CapaNegocio.Reportes;
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
    public partial class FrmReporteVenta : Form
    {
        public FrmReporteVenta()
        {
            InitializeComponent();
        }

        private void FrmReporteVenta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void getSalesReport(DateTime StartDate, DateTime endDate)
        {
            CN_ReporteVenta cN_Reportes = new CN_ReporteVenta();
            cN_Reportes.ListaReporteVenta(StartDate,endDate);

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
