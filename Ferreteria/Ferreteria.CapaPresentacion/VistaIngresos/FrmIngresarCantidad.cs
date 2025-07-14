using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmIngresarCantidad : Form
    {
        public int Cantidad { get; private set; } = 0;

        public FrmIngresarCantidad()
        {
            InitializeComponent();
        }

        private void FrmIngresarCantidad_Load(object sender, EventArgs e)
        {

        }
    

     

    

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txt_Cantidad.Text.Trim(), out int cantidad) && cantidad > 0)
            {
                Cantidad = cantidad;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cantidad.Focus();
            }
        }
    }
}
