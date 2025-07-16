using Ferreteria.CapaDominio;
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

namespace Ferreteria.CapaPresentacion.VistaVenta
{
    public partial class FrmAgregarVenta : Form
    {
        public Usuario _Usuario;

        private CN_Metodos CN_Metodos = new CN_Metodos();
        public int Cantidad { get; private set; } = 0;
        public bool PermiteDecimales = true;
        public FrmAgregarVenta()
        {
            InitializeComponent();
            Text = "Gestion Historial de  Ingresos";
        }
        public FrmAgregarVenta(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;

            CargarCboComprobante();
            CargarCboMetodoPago();
            string tipo = cbo_comprobante.SelectedItem?.ToString(); 
            CargarTextBox(tipo);
        }

        private void CargarCboComprobante()
        {

            cbo_comprobante.Items.Add("TICKET");
            cbo_comprobante.Items.Add("BOLETA");
      



            cbo_comprobante.SelectedIndex = 0;

            cbo_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarCboMetodoPago()
        {
            cbo_metodoPago.Items.Add("EFECTIVO");
            cbo_metodoPago.Items.Add("TARJETA DE DÉBITO");
            cbo_metodoPago.Items.Add("TARJETA DE CRÉDITO");
            cbo_metodoPago.Items.Add("TRANSFERENCIA BANCARIA");
            cbo_metodoPago.Items.Add("MERCADO PAGO");
            cbo_metodoPago.Items.Add("CUENTA CORRIENTE");

            cbo_metodoPago.SelectedIndex = 0;
            cbo_metodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void CargarTextBox(string tipoDocumento)
        {
            CN_Metodos metodos = new CN_Metodos();

            try
            {
                string tipo = cbo_comprobante.SelectedItem.ToString();


                var (serie, correlativo) = metodos.GenerarSerieYCorrelativo("Ventas", tipo);


                if (tipo == "TICKET")
                {
                    lbl_encabezado.Text = "TICKET DE VENTA";
                }
                else
                {

                    lbl_encabezado.Text = "BOLETA DE VENTA";
                }

                lbl_serie.Text = serie;
                lbl_correlativo.Text = correlativo;


                lbl_serie_correlativo.Text = $"Comprobante N°: {serie}-{correlativo}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar comprobante: " + ex.Message);
            }
        }
        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbo_comprobante.SelectedItem?.ToString();

            CargarTextBox(tipo);
        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
       
            MostrarTabla();
        }
        private void MostrarTabla()
        {
            // Limpiar columnas si es necesario
            dgv_detalles_ingresos.Columns.Clear();

            // Agregar columnas
            dgv_detalles_ingresos.Columns.Add("Id_Producto", "Id_Producto");
            dgv_detalles_ingresos.Columns.Add("Producto", "Producto");
            dgv_detalles_ingresos.Columns.Add("Cantidad", "Cantidad");
            dgv_detalles_ingresos.Columns.Add("PrecioVenta", "PrecioVenta");
            dgv_detalles_ingresos.Columns.Add("SubTotal", "SubTotal");
            // Autoajustar columnas 

            dgv_detalles_ingresos.Columns["Id_Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["PrecioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
   

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_detalles_ingresos.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ingresos.Columns["SubTotal"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_detalles_ingresos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ingresos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;



        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_fila_Click(object sender, EventArgs e)
        {

        }

        private void Btn_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoIngresoSeleccionado += (Id_Producto, Nombre, RequiereVencimiento, ActualizarPrecioAutomaticamente, PermiteDecimales) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_producto.Text = Nombre;
                this.PermiteDecimales = PermiteDecimales;

            };

            frmSeleccionar.ShowDialog();
        }

        private void txt_codigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarYAsignarProductoPorCodigo(txt_codigoBarra.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BuscarYAsignarProductoPorCodigo(string codigo)
        {
            CN_Producto cN_Producto = new CN_Producto();
            var producto = cN_Producto.BuscarProductoPorCodigoEnIngresos(codigo);

            if (producto != null)
            {
                txt_id_producto.Text = producto.Id_Producto.ToString();
                txt_producto.Text = producto.Nombre;
                this.PermiteDecimales = producto.PermiteDecimales;
            }
            else
            {
                MessageBox.Show($"No se encontró ningún producto con el código: {codigo}. Verifique e intente nuevamente.",
               "Producto no encontrado",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                txt_id_producto.Clear();
                txt_producto.Clear();
            }
            // Limpiar el campo del código de barras después de procesar
            txt_codigoBarra.Clear();
            txt_codigoBarra.Focus();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MostrarResumenIngreso(DataGridView dgv)
        {
            int cantidadProductos = dgv.Rows.Count;
            decimal totalUnidades = 0;
            decimal totalFinal = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null && fila.Cells["PrecioVenta"].Value != null)
                {
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);

                    totalUnidades += cantidad;
                    totalFinal += cantidad * precio; // subtotal acumulado
                }
            }

            lbl_cantidadProductos.Text = $"Productos: {cantidadProductos.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalUnidades.Text = $"Unidades: {totalUnidades.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalFinal.Text = $"Total: ${totalFinal.ToString("N2", new CultureInfo("es-AR"))}";
        }
        private void dgv_detalles_ingresos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MostrarResumenIngreso(dgv_detalles_ingresos);
        }

        private void dgv_detalles_ingresos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MostrarResumenIngreso(dgv_detalles_ingresos);

        }
    }
}
