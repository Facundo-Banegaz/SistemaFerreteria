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
    public partial class FrmReporteFacturaVenta : Form
    {
        private int Id_venta { get; set; }
        public FrmReporteFacturaVenta(Venta venta)
        {
            InitializeComponent();
            this.Id_venta = venta.Id_Venta;
        }

        private void FrmReporteFacturaVenta_Load(object sender, EventArgs e)
        {
            this.spReporte_factura_VentaTableAdapter.Fill(this.dsPrincipal.SpReporte_factura_Venta, Id_venta);
           
            this.reportViewer1.RefreshReport();
        }
    }
}
