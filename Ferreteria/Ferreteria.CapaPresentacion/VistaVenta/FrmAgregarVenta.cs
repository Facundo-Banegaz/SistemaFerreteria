using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using Ferreteria.CapaPresentacion.VistaIngresos;
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

        public CN_Metodos cN_Metodos = new CN_Metodos();
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
            MostrarUsuario();
            MostrarTabla();
        }
        private void FrmAgregarVenta_Shown(object sender, EventArgs e)
        {
            txt_codigoBarra.Focus();
   
        }
        private  void MostrarUsuario()
        {
            txt_nombre_usuario.Text = _Usuario.Nombre + ' ' + _Usuario.Apellido;
            txt_id_usuario.Text = _Usuario.Id_Usuario.ToString();
            txt_acceso.Text = _Usuario.Acceso;
        }


        private void MostrarTabla()
        {
            dgv_detalles_ventas.Columns.Clear();

            // Agregar columnas
            dgv_detalles_ventas.Columns.Add("Id_Producto", "Id_Producto");
            dgv_detalles_ventas.Columns.Add("Producto", "Producto");
            dgv_detalles_ventas.Columns.Add("Cantidad", "Cantidad");
            dgv_detalles_ventas.Columns.Add("PrecioVenta", "Precio Venta");
            dgv_detalles_ventas.Columns.Add("SubTotal", "SubTotal");
            dgv_detalles_ventas.Columns.Add("Stock", "Stock");
            dgv_detalles_ventas.Columns["Stock"].Visible = false;

            // Ajustes de ancho
            dgv_detalles_ventas.Columns["Id_Producto"].Width = 150;
            dgv_detalles_ventas.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["PrecioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Formato numérico argentino
            CultureInfo culturaAR = new CultureInfo("es-AR");
            dgv_detalles_ventas.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["PrecioVenta"].DefaultCellStyle.FormatProvider = culturaAR;
            dgv_detalles_ventas.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["SubTotal"].DefaultCellStyle.FormatProvider = culturaAR;
            dgv_detalles_ventas.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // 👉 Estilo visual
            dgv_detalles_ventas.EnableHeadersVisualStyles = false;
            dgv_detalles_ventas.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv_detalles_ventas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_detalles_ventas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv_detalles_ventas.DefaultCellStyle.BackColor = Color.White;
            dgv_detalles_ventas.DefaultCellStyle.ForeColor = Color.Black;
            dgv_detalles_ventas.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dgv_detalles_ventas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_detalles_ventas.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgv_detalles_ventas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ventas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para incrementar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Desea agregar una unidad del producto seleccionado?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            var fila = dgv_detalles_ventas.CurrentRow;
            var celdaCantidad = fila.Cells["Cantidad"];
            var celdaStock = fila.Cells["Stock"];
            var celdaPrecio = fila.Cells["PrecioVenta"];
            var celdaTotal = fila.Cells["Subtotal"];

            if (celdaCantidad != null && celdaStock != null &&
                decimal.TryParse(celdaCantidad.Value?.ToString(), out decimal cantidadActual) &&
                decimal.TryParse(celdaStock.Value?.ToString(), out decimal stockDisponible))
            {
                if (cantidadActual < stockDisponible)
                {
                    cantidadActual++;
                    celdaCantidad.Value = cantidadActual;

                    // Recalcular total
                    if (celdaPrecio != null && decimal.TryParse(celdaPrecio.Value?.ToString(), out decimal precio))
                    {
                        celdaTotal.Value = cantidadActual * precio;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede agregar más unidades. Se alcanzó el stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error al leer la cantidad o el stock del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ventas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Desea quitar una unidad del producto seleccionado?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                // Usamos el nombre de la columna "Cantidad"
                var celdaCantidad = dgv_detalles_ventas.CurrentRow.Cells["Cantidad"];

                if (celdaCantidad != null && decimal.TryParse(celdaCantidad.Value?.ToString(), out decimal cantidadActual))
                {
                    if (cantidadActual > 1)
                    {
                        celdaCantidad.Value = cantidadActual - 1;
                    }
                    else
                    {
                        dgv_detalles_ventas.Rows.Remove(dgv_detalles_ventas.CurrentRow);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo leer la cantidad del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ventas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este producto del detalle?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                dgv_detalles_ventas.Rows.Remove(dgv_detalles_ventas.CurrentRow);

            }
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ventas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para modificar la cantidad.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea modificar la cantidad de este producto?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                using (var formCantidad = new FrmIngresarCantidad(PermiteDecimales))
                {
                    if (formCantidad.ShowDialog() == DialogResult.OK)
                    {
                        decimal nuevaCantidad = formCantidad.Cantidad;

                        if (nuevaCantidad <= 0)
                        {
                            MessageBox.Show("La cantidad debe ser mayor que cero.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DataGridViewRow fila = dgv_detalles_ventas.CurrentRow;

                        // Obtener el stock actual
                        decimal stockDisponible = Convert.ToDecimal(fila.Cells["Stock"].Value);

                        if (nuevaCantidad > stockDisponible)
                        {
                            MessageBox.Show($"No hay suficiente stock. Stock disponible: {stockDisponible}", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        decimal precioVenta = decimal.Parse(fila.Cells["PrecioVenta"].Value.ToString(), CultureInfo.CreateSpecificCulture("es-AR"));
                        decimal nuevoSubtotal = nuevaCantidad * precioVenta;

                        fila.Cells["Cantidad"].Value = nuevaCantidad;
                        fila.Cells["SubTotal"].Value = nuevoSubtotal.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));

                        MessageBox.Show("La cantidad fue modificada correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void Btn_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoVentaSeleccionado += (Id_Producto, Nombre, Precio, Stock, Codigo, PermiteDecimales) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_producto.Text = Nombre;
                this.PermiteDecimales = PermiteDecimales;
                txt_stock.Text = Stock.ToString();
                txt_precioVenta.Text = Precio.ToString();
                txt_codigoBarra.Text = Codigo.ToString();
                BuscarYAsignarProductoPorCodigo(Codigo);
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

        private void LimpiarCampos()
        {

            txt_id_producto.Clear();
            txt_producto.Clear();
            txt_precioVenta.Clear();
            txt_stock.Clear();
            txt_codigoBarra.Clear();
            txt_id_producto.Clear();
        }


        private void BuscarYAsignarProductoPorCodigo(string codigo)
        {
            CN_Producto cN_Producto = new CN_Producto();

            var producto = cN_Producto.BuscarProductoPorCodigoEnVentas( codigo);

            if (producto != null)
            {
                txt_id_producto.Text = producto.Id_Producto.ToString();
                txt_producto.Text = producto.Nombre;
                this.PermiteDecimales = producto.PermiteDecimales;
                txt_precioVenta.Text = producto.Precio.ToString();
                cN_Metodos.FormatoMoneda(txt_precioVenta);
                txt_stock.Text = producto.Stock.ToString();
                cN_Metodos.FormatoMoneda(txt_stock);

                AgregarProductoAGrilla(producto);
            }
            else
            {
                MessageBox.Show($"No se encontró ningún producto con el código: {codigo}. Verifique e intente nuevamente.",
               "Producto no encontrado",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                LimpiarCampos();
            }
            // Limpiar el campo del código de barras después de procesar
            txt_codigoBarra.Clear();
            txt_codigoBarra.Focus();

        }
        private void AgregarProductoAGrilla(Producto producto)
        {
            bool productoExistente = false;

            foreach (DataGridViewRow fila in dgv_detalles_ventas.Rows)
            {
                if (fila.Cells["Id_Producto"].Value.ToString() == producto.Id_Producto.ToString())
                {
                    // Ya está en la grilla, intentar sumar 1
                    decimal cantidadActual = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal nuevaCantidad = cantidadActual + 1;

                    if (nuevaCantidad > producto.Stock)
                    {
                        MessageBox.Show("La cantidad supera el stock disponible.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    fila.Cells["Cantidad"].Value = nuevaCantidad;

                    decimal precio = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);
                    fila.Cells["SubTotal"].Value = Math.Round(nuevaCantidad * precio, 2);

                    productoExistente = true;
                    break;
                }
            }

            if (!productoExistente)
            {
                if (producto.Stock < 1)
                {
                    MessageBox.Show("No hay stock disponible para este producto.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal cantidad = 1m;
                decimal precio = producto.Precio;
                decimal subtotal = Math.Round(cantidad * precio, 2);
                decimal stock = producto.Stock;

                dgv_detalles_ventas.Rows.Add(
                    producto.Id_Producto,
                    producto.Nombre,
                    cantidad,
                    precio,
                    subtotal,
                    stock
                );
            }
        }


        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        private void MostrarResumenVenta(DataGridView dgv)
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
            MostrarResumenVenta(dgv_detalles_ventas);
        }

        private void dgv_detalles_ingresos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           MostrarResumenVenta(dgv_detalles_ventas);

        }

        private void dgv_detalles_ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
