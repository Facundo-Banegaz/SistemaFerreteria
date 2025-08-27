using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
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

namespace Ferreteria.CapaPresentacion.VistaMovimientoStock
{
    public partial class FrmMovimientoStockManual : Form
    {
        private int Id_Usuario;
        private MovimientoStockInsertDto _MovimientoStock;
        public FrmMovimientoStockManual()
        {
            InitializeComponent();
            Text = "Gestión Movimientos De Stock";
        }
        public FrmMovimientoStockManual(Usuario usuario)
        {
            InitializeComponent();
            this.Id_Usuario = usuario.Id_Usuario;
        }
        private void FrmMovimientoStockManual_Load(object sender, EventArgs e)
        {
            CargarCbo();
        }
        private void CargarCbo()
        {
            CN_TipoMovimiento _TipoMovimiento = new CN_TipoMovimiento();

            cbo_TipoMovimiento.DataSource = _TipoMovimiento.ListarTipoMovimientoStockManual();
            cbo_TipoMovimiento.ValueMember = "Id_TipoMovimiento";
            cbo_TipoMovimiento.DisplayMember = "Nombre";


        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoSeleccionado += (Id_Producto, Nombre) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_nombre_producto.Text = Nombre;

            };

            frmSeleccionar.ShowDialog();
        }





        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarMovimientoStock();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir teclas de control (Backspace, Delete, flechas)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
                return;

            // Permitir coma decimal (solo una)
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // Convertir punto en coma
                //if (e.KeyChar == '.')
                //    e.KeyChar = ',';

                // Bloquear si ya hay coma
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
                return;
            }

            // Bloquear cualquier otro caracter
            e.Handled = true;
        }


        private void GuardarMovimientoStock()
        {
            CN_MovimientoStock cN_MovimientoStock = new CN_MovimientoStock();

            try
            {


                if (ValidarVacio() && ValidarCantidad())
                {
                    errorIcono.Clear();

                    if (_MovimientoStock == null)
                        _MovimientoStock = new MovimientoStockInsertDto();


                    _MovimientoStock.Id_TipoMovimiento = Convert.ToInt32(cbo_TipoMovimiento.SelectedValue);
                    _MovimientoStock.Id_Usuario = Id_Usuario;
                    _MovimientoStock.Id_Producto = Convert.ToInt32(txt_id_producto.Text.Trim());
                    _MovimientoStock.Cantidad = Convert.ToDecimal(txt_cantidad.Text);
                    _MovimientoStock.ObservacionDetalle = txt_observacion.Text.Trim().ToUpper();




                    cN_MovimientoStock.AjusteManualStock(_MovimientoStock);
                    MessageBox.Show("¡El Movimiento de Stock se hizo exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool ValidarVacio()
        {
            errorIcono.Clear();
            bool error = true;

            if (txt_nombre_producto.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_producto, "El campo  es obligatorio");


                error = false;
            }
            if (txt_id_producto.Text == string.Empty)
            {
                errorIcono.SetError(txt_id_producto, "El campo  es obligatorio");


                error = false;
            }

            if (txt_cantidad.Text == string.Empty)
            {
                errorIcono.SetError(txt_cantidad, "El campo  es obligatorio");


                error = false;
            }


            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

            //ValidarCantidad();
        }

        private bool ValidarCantidad()
        {
            errorIcono.Clear();
            // Validar cantidad > 0
            if (!decimal.TryParse(txt_cantidad.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal cantidad) || cantidad <= 0)
            {
                errorIcono.SetError(txt_cantidad, "Cantidad inválida.");
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cantidad.Clear();
                txt_cantidad.Focus();
                return false;
            }

            return true;
        }

        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            //errorIcono.Clear();
            //if (!decimal.TryParse(txt_cantidad.Text.Trim(), out decimal cantidad) || cantidad <= 0)
            //{
            //    errorIcono.SetError(txt_cantidad, "Cantidad inválida, debe ser mayor a 0.");
            //    txt_cantidad.Focus();
            //}
        }
    }
}
