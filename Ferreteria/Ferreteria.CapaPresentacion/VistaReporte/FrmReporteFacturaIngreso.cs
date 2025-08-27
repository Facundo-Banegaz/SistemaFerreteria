using Ferreteria.CapaDominio;
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
    public partial class FrmReporteFacturaIngreso : Form
    {

        private int Id_Ingreso { get; set; }
        public FrmReporteFacturaIngreso(Ingreso ingreso)
        {
            InitializeComponent();
            this.Id_Ingreso= ingreso.Id_Ingreso;
        }

        private void FrmReporteFacturaIngreso_Load(object sender, EventArgs e)
        {
            this.spReporte_factura_IngresoTableAdapter.Fill(this.dsPrincipal.SpReporte_factura_Ingreso, Id_Ingreso);
            this.reportViewer1.RefreshReport();
        }
    }
}
