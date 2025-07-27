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

namespace Ferreteria.CapaPresentacion.VistaPresupuesto
{
    public partial class FrmAgregarPresupuesto : Form
    {
        public Usuario _Usuario;

        public CN_Metodos cN_Metodos = new CN_Metodos();
        public int Cantidad { get; private set; } = 0;
        public bool PermiteDecimales = true;


        public FrmAgregarPresupuesto()
        {
            InitializeComponent();
            Text = "Generar Presupuesto";
        }
        public FrmAgregarPresupuesto(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
            CargarCboComprobante();
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

        private void CargarTextBox(string tipoDocumento)
        {
            CN_Metodos metodos = new CN_Metodos();

            try
            {
                string tipo = cbo_comprobante.SelectedItem.ToString();


                var (serie, correlativo) = metodos.GenerarSerieYCorrelativo("Presupuestos", tipo);


                if (tipo == "TICKET")
                {
                    lbl_encabezado.Text = "TICKET DE PRESUPUESTO";
                }
                else
                {

                    lbl_encabezado.Text = "BOLETA DE PRESUPUESTO";
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
        private void FrmAgregarPresupuesto_Load(object sender, EventArgs e)
        {
            txt_cliente.Text = "Consumidor final";
            txt_cliente.Enabled = false;
            MostrarUsuario();
            MostrarTabla();
        }
        private void MostrarUsuario()
        {
            txt_nombre_usuario.Text = _Usuario.Nombre + ' ' + _Usuario.Apellido;
            txt_id_usuario.Text = _Usuario.Id_Usuario.ToString();
            txt_acceso.Text = _Usuario.Acceso;
        }
        private void chk_EditarNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_EditarNombre.Checked)
            {
                txt_cliente.Enabled = true;
                txt_cliente.Select(); // Pone el foco para que empiece a escribir
            }
            else
            {
                txt_cliente.Text = "Consumidor final";
                txt_cliente.Enabled = false;
            }
        }

        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cbo_comprobante.SelectedItem?.ToString();

            CargarTextBox(tipo);
        }

        private void FrmAgregarPresupuesto_Shown(object sender, EventArgs e)
        {
            txt_codigoBarra.Focus();
        }


        private void MostrarTabla()
        {
            dgv_detalles_ventas.Columns.Clear();

            // Agregar columnas
            dgv_detalles_ventas.Columns.Add("Id_Producto", "Id_Producto");
            dgv_detalles_ventas.Columns.Add("Producto", "Producto");
            dgv_detalles_ventas.Columns.Add("Cantidad", "Cantidad");
            dgv_detalles_ventas.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgv_detalles_ventas.Columns.Add("SubTotal", "SubTotal");
        

            // Ajustes de ancho
            dgv_detalles_ventas.Columns["Id_Producto"].Width = 150;
            dgv_detalles_ventas.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ventas.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Formato numérico argentino
            CultureInfo culturaAR = new CultureInfo("es-AR");
            dgv_detalles_ventas.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["PrecioUnitario"].DefaultCellStyle.FormatProvider = culturaAR;
            dgv_detalles_ventas.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["SubTotal"].DefaultCellStyle.FormatProvider = culturaAR;
            dgv_detalles_ventas.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ventas.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

           
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
            GuardarPresupuesto();
        }

        private void GuardarPresupuesto()
        {
            CN_Presupuesto CN_Presupuesto = new CN_Presupuesto();

            // Limpiar errores anteriores
            errorIcono.Clear();

            try
            {
                if (string.IsNullOrWhiteSpace(txt_cliente.Text))
                {
                    errorIcono.SetError(txt_cliente, "Debe completar el cliente.");
                    txt_cliente.Focus();
                    return;
                }

                if (dgv_detalles_ventas.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto al presupuesto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto Presupuesto
                Presupuesto _Presupuesto = new Presupuesto
                {
                    Fecha = dtp_fecha.Value,
                    Cliente = txt_cliente.Text.Trim(),
                    Serie = lbl_serie.Text,
                    Correlativo = lbl_correlativo.Text,
                    Estado = "Activo",
                    Usuario = new Usuario { Id_Usuario = _Usuario.Id_Usuario }
                };

                List<DetallePresupuesto> _Detalle_Presupuesto = new List<DetallePresupuesto>();

                foreach (DataGridViewRow fila in dgv_detalles_ventas.Rows)
                {
                    if (fila.IsNewRow) continue;

                    int idProducto = Convert.ToInt32(fila.Cells["Id_Producto"].Value);
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal PrecioUnitario = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);

                    if (cantidad <= 0 || PrecioUnitario <= 0)
                    {
                        MessageBox.Show($"Fila {fila.Index + 1}: cantidad o precio inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DetallePresupuesto detalle = new DetallePresupuesto
                    {
                        Producto = new Producto { Id_Producto = idProducto },
                        Cantidad = cantidad,
                        PrecioUnitario = PrecioUnitario
                    };

                    _Detalle_Presupuesto.Add(detalle);
                }

                CN_Presupuesto.InsertarPresupuesto(_Presupuesto, _Detalle_Presupuesto);

                MessageBox.Show("¡El Presupuesto se generó exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            var celdaPrecio = fila.Cells["PrecioUnitario"];
            var celdaTotal = fila.Cells["Subtotal"];

            if (celdaCantidad != null &&
                decimal.TryParse(celdaCantidad.Value?.ToString(), out decimal cantidadActual))
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
                MessageBox.Show("Error al leer la cantidad del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        // Obtenemos el precio unitario
                        decimal precioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value.ToString(), CultureInfo.CreateSpecificCulture("es-AR"));
                        decimal nuevoSubtotal = nuevaCantidad * precioUnitario;

                        fila.Cells["Cantidad"].Value = nuevaCantidad;
                        fila.Cells["SubTotal"].Value = nuevoSubtotal.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));

                        MessageBox.Show("La cantidad fue modificada correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }



        }

        private void btn_editar_Click_1(object sender, EventArgs e)
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

          

                        decimal precioUnitario = decimal.Parse(fila.Cells["PrecioUnitario"].Value.ToString(), CultureInfo.CreateSpecificCulture("es-AR"));
                        decimal nuevoSubtotal = nuevaCantidad * precioUnitario;

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

            var producto = cN_Producto.BuscarProductoPorCodigoEnVentas(codigo);

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
                MostrarResumenVenta(dgv_detalles_ventas);
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
            foreach (DataGridViewRow fila in dgv_detalles_ventas.Rows)
            {
                if (fila.Cells["Id_Producto"].Value.ToString() == producto.Id_Producto.ToString())
                {
                    decimal cantidadActual = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal nuevaCantidad = cantidadActual + 1;

                    fila.Cells["Cantidad"].Value = nuevaCantidad;

                    decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);
                    fila.Cells["SubTotal"].Value = Math.Round(nuevaCantidad * precio, 2);

                    MessageBox.Show("Cantidad actualizada.", "Producto existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            
            dgv_detalles_ventas.Rows.Add(
                producto.Id_Producto,
                producto.Nombre,
                1m,
                producto.Precio,
                Math.Round(producto.Precio, 2)
            );

        }

        private void MostrarResumenVenta(DataGridView dgv)
        {
            int cantidadProductos = dgv.Rows.Count;
            decimal totalUnidades = 0;
            decimal totalFinal = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null && fila.Cells["PrecioUnitario"].Value != null)
                {
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);

                    totalUnidades += cantidad;
                    totalFinal += cantidad * precio; // subtotal acumulado
                }
            }

            lbl_cantidadProductos.Text = $"Productos: {cantidadProductos.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalUnidades.Text = $"Unidades: {totalUnidades.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalFinal.Text = $"Total: ${totalFinal.ToString("N2", new CultureInfo("es-AR"))}";
        }

        private void dgv_detalles_ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MostrarResumenVenta(dgv_detalles_ventas);

        }

        private void dgv_detalles_ventas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MostrarResumenVenta(dgv_detalles_ventas);

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
