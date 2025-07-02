using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaMovimientoStock
{
    public partial class FrmHistorialMovimientoStock : Form
    {
        public FrmHistorialMovimientoStock()
        {
            InitializeComponent();
            Text = "Movimientos de Stock";
        }

        private void FrmMovimientoStock_Load(object sender, EventArgs e)
        {

        }

        private void btn_anular_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
