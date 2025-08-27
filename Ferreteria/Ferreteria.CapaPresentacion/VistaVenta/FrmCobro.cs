using Ferreteria.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaVenta
{
    public partial class FrmCobro : Form
    {
        public decimal TotalVenta { get; set; }
        public decimal MontoPagado { get; private set; }
        public decimal Vuelto { get; private set; }
        public bool Cobrado { get; private set; }
        private CN_Metodos CN_Metodos = new CN_Metodos();
        public FrmCobro(decimal total)
        {
            InitializeComponent();
            TotalVenta = total;
        }



        private void FrmCobro_Load(object sender, EventArgs e)
        {
            txt_monto_final.Text = TotalVenta.ToString("C", new CultureInfo("es-AR"));
            txt_paga_con.Focus();
        }



        private void txt_paga_con_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_paga_con.Text, out decimal pagaCon))
            {
                MontoPagado = pagaCon;
                Vuelto = MontoPagado - TotalVenta;

                txt_vuelto.Text = Vuelto >= 0
                    ? Vuelto.ToString("C", new CultureInfo("es-AR"))
                    : "Monto insuficiente";
            }
            else
            {
                txt_vuelto.Text = "";
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Cobrado = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {



            if (MontoPagado < TotalVenta)
            {
                MessageBox.Show("El monto ingresado es insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cobrado = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt_paga_con_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (backspace, delete, flechas, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Solo permitir dígitos y coma/punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // bloquea cualquier otro carácter
                return;
            }

            //// Reemplazar punto por coma
            //if (e.KeyChar == '.')
            //    e.KeyChar = ',';

            // Evitar más de una coma
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txt_paga_con_Leave(object sender, EventArgs e)
        {
            CN_Metodos.FormatoMoneda((TextBox)sender);
        }
    }
}
