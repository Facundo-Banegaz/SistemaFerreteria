using Ferreteria.CapaDominio.DTOs;
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
    public partial class FrmReporteProductoVencimiento : Form
    {

        private string filtrarEstado {get; set;}
        
        public FrmReporteProductoVencimiento(string filtroEstado)
        {
            InitializeComponent();
            this.filtrarEstado = filtroEstado;
        }

        private void FrmReporteProductoVencimiento_Load(object sender, EventArgs e)
        {

            try
            {
           
                this.sp_ProductosVencimientoTableAdapter.Fill(this.dsPrincipal.Sp_ProductosVencimiento,filtrarEstado);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                this.reportViewer1.RefreshReport();
            }


        }
    }
}
