using Ferreteria.CapaNegocio;
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
    public partial class FrmSeleccionarFechaVentas : Form
    {
        public FrmSeleccionarFechaVentas()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (dtp_fecha_inicio.Value.Date > dtp_fecha_fin.Value.Date)
            {
                dtp_fecha_inicio.Value=  DateTime.Today;
                dtp_fecha_fin.Value= DateTime.Today;
                MessageBox.Show("La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.", "ADVERTENCIA");
                return;

            }
            else
            {
                FrmReporteDeVenta frmReporte = new FrmReporteDeVenta(dtp_fecha_inicio.Value, dtp_fecha_fin.Value);
                frmReporte.ShowDialog();
            }
        }


        private void FrmSeleccionarFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
