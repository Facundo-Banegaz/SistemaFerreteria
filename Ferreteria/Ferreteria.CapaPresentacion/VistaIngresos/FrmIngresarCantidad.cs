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

namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmIngresarCantidad : Form
    {
        public decimal Cantidad { get; private set; } = 0;
        bool PermiteDecimales = true;
        private CN_Metodos CN_Metodos = new CN_Metodos();
        public FrmIngresarCantidad(bool permiteDecimales)
        {
            InitializeComponent();
            this.PermiteDecimales = permiteDecimales;
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
            string input = txt_Cantidad.Text.Trim();

            if (decimal.TryParse(input, NumberStyles.Number, new CultureInfo("es-AR"), out decimal cantidadDecimal) && cantidadDecimal > 0)
            {
                if (!PermiteDecimales && cantidadDecimal % 1 != 0)
                {
                    MessageBox.Show("Este producto no permite cantidades decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cantidad.Focus();
                    txt_Cantidad.SelectAll();
                    return;
                }

                Cantidad = cantidadDecimal;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cantidad.Focus();
            }
        }



        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir teclas de control (Backspace, Delete, etc)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos siempre
            if (!char.IsDigit(e.KeyChar))
            {
                // Si NO permite decimales, bloqueamos cualquier otro caracter no numérico
                if (!PermiteDecimales)
                {
                    e.Handled = true;
                    return;
                }

                // Si permite decimales, solo permitimos coma (o punto) una sola vez
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    // Reemplazamos punto por coma para estandarizar
                    e.KeyChar = ',';

                    // Si ya existe una coma en el texto, bloqueamos
                    if (txt.Text.Contains(","))
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    // Cualquier otro caracter no permitido
                    e.Handled = true;
                }
            }
        }

        private void txt_Cantidad_Leave(object sender, EventArgs e)
        {

            if (PermiteDecimales)
            {
                CN_Metodos.FormatoMoneda((TextBox)sender);// permite decimales
            }
            else
            {
                // Intentamos formatear como entero
                if (decimal.TryParse(txt_Cantidad.Text, NumberStyles.Number, new CultureInfo("es-AR"), out decimal valor))
                {
                    if (valor % 1 != 0)
                    {
                        MessageBox.Show("Este tipo de unidad no permite decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Cantidad.Focus();
                        txt_Cantidad.SelectAll();
                    }
                    else
                    {
                        txt_Cantidad.Text = ((int)valor).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Cantidad.Focus();
                    txt_Cantidad.SelectAll();
                }
            }
        }
    }
}
