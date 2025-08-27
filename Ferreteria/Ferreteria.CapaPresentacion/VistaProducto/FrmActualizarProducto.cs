using Ferreteria.CapaDominio;
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

namespace Ferreteria.CapaPresentacion.VistaProducto
{
    public partial class FrmActualizarPrecio: Form
    {
        private Producto producto = null;
        private int Id_Producto;
        private decimal Precio;
        private CN_Metodos CN_Metodos = new CN_Metodos();
        public FrmActualizarPrecio()
        {
            InitializeComponent();
            Text = "Actualizar Precio";
        }
        public FrmActualizarPrecio(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Actualizar Precio";
        }
        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            if (producto != null)
            {
                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
            lbl_codigo.Text ="Codigo:   "+ producto.Codigo;
            lbl_nombre.Text ="Nombre:   "+ producto.Nombre;
            lbl_descripcion.Text ="Descripción: "+ producto.Descripcion;
            lbl_fecha.Text= "Fecha de la Ultima Actualización del Precio:  "+ producto.FechaUltimaActualizacionPrecio;
            lbl_precio.Text = "Nuevo Precio :  "+ producto.Precio.ToString("N2", new CultureInfo("es-AR"));
            lbl_precio_anterior.Text = "Precio Actual:  " + producto.Precio.ToString("N2", new CultureInfo("es-AR"));
            lbl_stock.Text = "Stock Actual: "+producto.Stock.ToString("N2", new CultureInfo("es-AR"));
            lbl_subcategoria.Text = "Subcategoria:  " + producto.Subcategoria.Nombre;
            lbl_stock_minimo.Text = "Stock Minimo:  " + producto.StockMinimo.ToString("N2", new CultureInfo("es-AR"));
            lbl_marca.Text = "Marca:    " + producto.Marca.Nombre;
            lbl_Id.Text = producto.Id_Producto.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txt_nuevo_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir control (backspace, delete)
            if (char.IsControl(e.KeyChar))
                return;

            // Solo permitir dígitos y coma/punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Reemplazar punto por coma (opcional, según cultura)
            //if (e.KeyChar == '.')
            //    e.KeyChar = ',';

            // Evitar más de una coma
            if ((e.KeyChar == ',' || e.KeyChar == '.') && txt.Text.Contains(','))
            {
                e.Handled = true;
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarActualizacion();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarActualizacion()
        {
            CN_Producto logicaProducto = new CN_Producto();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

               

                    if (producto.Id_Producto != 0)
                    {
                        Id_Producto = Convert.ToInt32(lbl_Id.Text);
                        Precio = Convert.ToDecimal(txt_nuevo_precio.Text.Trim(), new CultureInfo("es-AR"));

                        logicaProducto.ActualizarPrecio(Id_Producto,Precio);

                        MessageBox.Show("¡El Precio del Producto fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                  
                }
                else
                {
                    MessageBox.Show("¡Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje amigable si es un error 
                errorIcono.SetError(txt_nuevo_precio, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nuevo_precio.Text == string.Empty)
            {
                errorIcono.SetError(txt_nuevo_precio, "El campo  es obligatorio, ingrese el Precio ");


                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void txt_nuevo_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nuevo_precio_Leave(object sender, EventArgs e)
        {
            CN_Metodos.FormatoMoneda((TextBox)sender);
        }
    }
}
