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
    public partial class FrmReporteFacturaPresupuesto : Form
    {

        private int Id_Presupuesto {  get; set; }
        public FrmReporteFacturaPresupuesto(Presupuesto presupuesto)
        {
            InitializeComponent();
            this.Id_Presupuesto = presupuesto.Id_Presupuesto;
        }

        private void FrmReporteFacturaPresupuesto_Load(object sender, EventArgs e)
        {

            this.spReporte_factura_PresupuestoTableAdapter.Fill(this.dsPrincipal.SpReporte_factura_Presupuesto, Id_Presupuesto);

            this.reportViewer1.RefreshReport();
        }
    }
}
