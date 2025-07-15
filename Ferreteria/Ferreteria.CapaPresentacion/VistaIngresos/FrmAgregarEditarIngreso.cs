using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmAgregarEditarIngreso : Form
    {
        public int Cantidad { get; private set; } = 0;
        bool PermiteDecimales = true;

        private CN_Metodos CN_Metodos = new CN_Metodos();
        public Usuario _Usuario;
        public FrmAgregarEditarIngreso()
        {
            InitializeComponent();
            Text = "Agregar Ingreso";
        }
        public FrmAgregarEditarIngreso(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
         
            CargarCboComprobante();
            string tipo = cbo_comprobante.SelectedItem?.ToString(); // ✅ correcto
            CargarTextBox(tipo);
        }

        private void CargarCboComprobante()
        {


            cbo_comprobante.Items.Add("BOLETA");
            //cbo_comprobante.Items.Add("TICKET");
       
       

            cbo_comprobante.SelectedIndex = 0;

            cbo_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void CargarTextBox(string tipoDocumento)
        {
            CN_Metodos metodos = new CN_Metodos();

            try
            {
                string tipo = cbo_comprobante.SelectedItem.ToString();


                var (serie, correlativo) = metodos.GenerarSerieYCorrelativo("Ingresos", tipo);


                if (tipo == "TICKET")
                {
                    lbl_encabezado.Text = "TICKET DE COMPRA";
                } else
                {

                    lbl_encabezado.Text = "BOLETA DE COMPRA";
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


  
        private void FrmAgregarEditarIngreso_Load(object sender, EventArgs e)
        {
            MostrarOcultarControles(false, false);
            MostrarTabla();
        }

 

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string tipo = cbo_comprobante.SelectedItem?.ToString();
         
            CargarTextBox(tipo);
        }



        private void Btn_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoIngresoSeleccionado += (Id_Producto, Nombre, RequiereVencimiento,ActualizarPrecioAutomaticamente,PermiteDecimales) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_producto.Text = Nombre;
                this.PermiteDecimales = PermiteDecimales;


                MostrarOcultarControles( RequiereVencimiento, ActualizarPrecioAutomaticamente);


            };

            frmSeleccionar.ShowDialog();
        }
        private void MostrarOcultarControles(bool requiereVencimiento, bool actualizarPrecio)
        {
            // VENCIMIENTO
            lbl_fechaFabricacion.Visible = requiereVencimiento;
            dtp_fechaFabricacion.Visible = requiereVencimiento;
            lbl_fechaVencimiento.Visible = requiereVencimiento;
            dtp_fechaVencimiento.Visible = requiereVencimiento;

            // Siempre limpiar errores previos, aunque se sigan usando
            errorIcono.SetError(dtp_fechaFabricacion, "");
            errorIcono.SetError(dtp_fechaVencimiento, "");

            if (requiereVencimiento)
            {
                dtp_fechaFabricacion.Value = DateTime.Now;
                dtp_fechaVencimiento.Value = DateTime.Now;
            }

            // ACTUALIZACIÓN DE PRECIO
            lbl_porcentaje.Visible = actualizarPrecio;
            txt_porcentaje.Visible = actualizarPrecio;
            lbl_precioVenta.Visible = actualizarPrecio;
            lbl_precioVentaCalculado.Visible = actualizarPrecio;

            // Siempre limpiar errores previos
            errorIcono.SetError(txt_porcentaje, "");

            if (actualizarPrecio)
            {
                txt_porcentaje.Clear();
            }
        }

        private void Btn_proveedor_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProveedor frmSeleccionar = new FrmSeleccionarProveedor();

            //Suscribís al evento
            frmSeleccionar.ProveedorSeleccionado += (Id_Proveedor, Nombre, SectorComercial) =>
            {
                txt_id_proveedor.Text = Id_Proveedor;
                txt_nombre_proveedor.Text = Nombre;
                txt_sectorComercial.Text = SectorComercial;
            };

            frmSeleccionar.ShowDialog();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {

            GuardarIngreso();
        }
        private void GuardarIngreso()
        {
            CN_Ingreso _CN_Ingreso = new CN_Ingreso();

            try
            {
                // Verificar si el DataGridView está vacío
                if (dgv_detalles_ingresos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un detalle de ingreso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos generales
                if (!ValidarVacio())
                {
                    MessageBox.Show("Debe completar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                errorIcono.Clear();

                // Crear objeto Ingreso
                Ingreso _Ingreso = new Ingreso
                {
                    Usuario = new Usuario { Id_Usuario = _Usuario.Id_Usuario },
                    Proveedor = new Proveedor { Id_Proveedor = Convert.ToInt32(txt_id_proveedor.Text) },
                    Fecha = dtp_fecha.Value,
                    Tipo_Comprobante = cbo_comprobante.SelectedItem?.ToString(),
                    Serie = lbl_serie.Text,
                    Correlativo = lbl_correlativo.Text,
                    Estado = "EMITIDO"
                };

                List<DetalleIngreso> _Detalle_Ingreso = new List<DetalleIngreso>();

                // Nombres de columnas centralizados
                const string COL_ID = "Id_Producto";
                const string COL_NOMBRE = "Producto";
                const string COL_PRECIO = "PrecioCompra";
                const string COL_CANTIDAD = "Cantidad";
                const string COL_FECHA_FAB = "FechaFabricacion";
                const string COL_FECHA_VENC = "FechaVencimiento";
                const string COL_GANANCIA = "PorcentajeGanancia";

                // Recorrer el DataGridView
                foreach (DataGridViewRow fila in dgv_detalles_ingresos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    DetalleIngreso detalle = new DetalleIngreso
                    {
                        Producto = new Producto
                        {
                            Id_Producto = Convert.ToInt32(fila.Cells[COL_ID].Value),
                            Nombre = fila.Cells[COL_NOMBRE].Value?.ToString()
                        },
                        PrecioCompra = decimal.TryParse(fila.Cells[COL_PRECIO].Value?.ToString(), NumberStyles.Any, CultureInfo.CreateSpecificCulture("es-AR"), out decimal precioCompra) ? precioCompra : 0,
                        Cantidad = decimal.TryParse(fila.Cells[COL_CANTIDAD].Value?.ToString(), NumberStyles.Any, CultureInfo.CreateSpecificCulture("es-AR"), out decimal cantidad) ? cantidad : 0,
                        PorcentajeGanancia = decimal.TryParse(fila.Cells[COL_GANANCIA].Value?.ToString(), NumberStyles.Any, CultureInfo.CreateSpecificCulture("es-AR"), out decimal ganancia) ? ganancia : 0,
                        FechaFabricacion = DateTime.TryParse(fila.Cells[COL_FECHA_FAB].Value?.ToString(), out DateTime fab)
                    && fab >= SqlDateTime.MinValue.Value ? fab : (DateTime?)null,

                        FechaVencimiento = DateTime.TryParse(fila.Cells[COL_FECHA_VENC].Value?.ToString(), out DateTime venc)
                    && venc >= SqlDateTime.MinValue.Value ? venc : (DateTime?)null,

                    };

                    // Validar campos críticos
                    if (detalle.PrecioCompra <= 0 || detalle.Cantidad <= 0)
                    {
                        MessageBox.Show($"La fila {fila.Index + 1} contiene datos inválidos (precio o cantidad).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _Detalle_Ingreso.Add(detalle);
                }

                // Guardar en la base de datos
                _CN_Ingreso.InsertarIngreso(_Ingreso, _Detalle_Ingreso);

                // Mostrar resumen y cerrar
                MessageBox.Show("¡El ingreso fue agregado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarResumenIngreso(_Detalle_Ingreso);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResumenIngreso(List<DetalleIngreso> detalles)
        {
            StringBuilder resumen = new StringBuilder();
            decimal total = 0;

            resumen.AppendLine("Resumen del Ingreso:");
            resumen.AppendLine("--------------------------------------------------");

            foreach (var item in detalles)
            {
                decimal subtotal = item.PrecioCompra * item.Cantidad;
                total += subtotal;

                resumen.AppendLine($"Producto: {item.Producto.Nombre}");
                resumen.AppendLine($"Cantidad: {item.Cantidad}");
                resumen.AppendLine($"Precio Compra: ${item.PrecioCompra:N2}");
                resumen.AppendLine($"Subtotal: ${subtotal:N2}");
                resumen.AppendLine("--------------------------------------------------");
            }

            resumen.AppendLine($"TOTAL: ${total:N2}");

            MessageBox.Show(resumen.ToString(), "Resumen del Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool ValidarVacio()
        {
            bool error = true;

            if (txt_id_proveedor.Text == string.Empty)
            {
                errorIcono.SetError(txt_id_proveedor, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            else  if (txt_nombre_proveedor.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_proveedor, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }
    
        //Logica de la Grilla
        //Crea la tabla de Detalle 


        private void MostrarTabla()
        {
            // Limpiar columnas si es necesario
            dgv_detalles_ingresos.Columns.Clear();

            // Agregar columnas
            dgv_detalles_ingresos.Columns.Add("Id_Producto", "Id_Producto");
            dgv_detalles_ingresos.Columns.Add("Producto", "Producto");
            dgv_detalles_ingresos.Columns.Add("FechaFabricacion", "FechaFabricacion");
            dgv_detalles_ingresos.Columns.Add("FechaVencimiento", "FechaVencimiento");
            dgv_detalles_ingresos.Columns.Add("PrecioCompra", "PrecioCompra");
            dgv_detalles_ingresos.Columns.Add("PorcentajeGanancia", "PorcentajeGanancia");
            dgv_detalles_ingresos.Columns.Add("Cantidad", "Cantidad");
            dgv_detalles_ingresos.Columns.Add("SubTotal", "SubTotal");
            // Autoajustar columnas 
            dgv_detalles_ingresos.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["Id_Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["PrecioCompra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["FechaFabricacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["FechaVencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_detalles_ingresos.Columns["PorcentajeGanancia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_detalles_ingresos.Columns["SubTotal"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ingresos.Columns["SubTotal"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_detalles_ingresos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ingresos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // Si Stock también es decimal:
            dgv_detalles_ingresos.Columns["PorcentajeGanancia"].DefaultCellStyle.Format = "N2";
            dgv_detalles_ingresos.Columns["PorcentajeGanancia"].DefaultCellStyle.FormatProvider = culturaAR;

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
                   this.PermiteDecimales= producto.PermiteDecimales;
                    MostrarOcultarControles(producto.RequiereVencimiento, producto.ActualizarPrecioAutomaticamente);
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
        //Logica de agregar fila

   
    
        private void btn_agregar_fila_Click(object sender, EventArgs e)
        {
            AgregarFilaIngreso();
            MostrarResumenIngreso(dgv_detalles_ingresos);
        }
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ingresos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este producto del detalle?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                dgv_detalles_ingresos.Rows.Remove(dgv_detalles_ingresos.CurrentRow);
             
            }
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_detalles_ingresos.CurrentRow == null)
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
                using (var formCantidad = new FrmIngresarCantidad())
                {
                    if (formCantidad.ShowDialog() == DialogResult.OK)
                    {
                        int nuevaCantidad = formCantidad.Cantidad;

                        DataGridViewRow fila = dgv_detalles_ingresos.CurrentRow;
                        decimal precioCompra = decimal.Parse(fila.Cells["PrecioCompra"].Value.ToString(), CultureInfo.CreateSpecificCulture("es-AR"));
                        decimal nuevoSubtotal = nuevaCantidad * precioCompra;

                        fila.Cells["Cantidad"].Value = nuevaCantidad;
                        fila.Cells["SubTotal"].Value = nuevoSubtotal.ToString("N2",CultureInfo.CreateSpecificCulture("es-AR"));

                        MessageBox.Show("La cantidad fue modificada correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    }
                }
            }
          
        }

        private void AgregarFilaIngreso()
        {
            try
            {
                if (!ValidarCamposDetalle())
                {
                    MessageBox.Show("Debe completar todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProducto = Convert.ToInt32(txt_id_producto.Text);
                string nombreProducto = txt_producto.Text;

                // Verificar si el producto ya está presente en la grilla
                foreach (DataGridViewRow row in dgv_detalles_ingresos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Id_Producto"].Value) == idProducto)
                    {
                        MessageBox.Show("Este producto ya fue agregado.\nUse el botón de 'Modificar cantidad'.", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCamposDetalle();
                        return;
                    }
                }

                // Conversión de campos con validación regional
                decimal precioCompra = decimal.Parse(txt_precioCompra.Text, CultureInfo.CreateSpecificCulture("es-AR"));
                decimal cantidad = decimal.Parse(txt_productoCantidad.Text, CultureInfo.CreateSpecificCulture("es-AR"));
                decimal porcentajeGanancia = txt_porcentaje.Visible && !string.IsNullOrWhiteSpace(txt_porcentaje.Text)
                    ? decimal.Parse(txt_porcentaje.Text, CultureInfo.CreateSpecificCulture("es-AR"))
                    : 0;

                object fechaFabricacion = dtp_fechaFabricacion.Visible ? (object)dtp_fechaFabricacion.Value.Date : DBNull.Value;
                object fechaVencimiento = dtp_fechaVencimiento.Visible ? (object)dtp_fechaVencimiento.Value.Date : DBNull.Value;


                decimal subtotal = precioCompra * cantidad;

                // Crear y asignar los valores de la fila
                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.CreateCells(dgv_detalles_ingresos);

                nuevaFila.Cells[0].Value = idProducto;
                nuevaFila.Cells[1].Value = nombreProducto;
                nuevaFila.Cells[2].Value = fechaFabricacion;
                nuevaFila.Cells[3].Value = fechaVencimiento;
                nuevaFila.Cells[4].Value = precioCompra.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));
                nuevaFila.Cells[5].Value = porcentajeGanancia.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));
                nuevaFila.Cells[6].Value = cantidad;
                nuevaFila.Cells[7].Value = subtotal.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));

                dgv_detalles_ingresos.Rows.Add(nuevaFila);

                // Limpiar los campos
                LimpiarCamposDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarCamposDetalle()
        {
            txt_id_producto.Clear();
            txt_producto.Clear();
            txt_precioCompra.Clear();
            txt_porcentaje.Clear();
            txt_productoCantidad.Clear();

            dtp_fechaFabricacion.Value = DateTime.Today;
            dtp_fechaVencimiento.Value = DateTime.Today;

            // Ocultar controles si estaban visibles por el producto anterior
            lbl_fechaFabricacion.Visible = false;
            dtp_fechaFabricacion.Visible = false;
            lbl_fechaVencimiento.Visible = false;
            dtp_fechaVencimiento.Visible = false;

            lbl_porcentaje.Visible = false;
            txt_porcentaje.Visible = false;

            // Dejar enfocado el primer campo si querés
            txt_id_producto.Focus();
        }

        private bool ValidarCamposDetalle()
        {
            errorIcono.Clear();

            if (string.IsNullOrWhiteSpace(txt_id_producto.Text))
            {
                errorIcono.SetError(txt_id_producto, "Debe seleccionar un producto.");
                MessageBox.Show("Debe seleccionar un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id_producto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_producto.Text))
            {
                errorIcono.SetError(txt_producto, "Debe seleccionar un producto.");
                MessageBox.Show("Debe seleccionar un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_producto.Focus();
                return false;
            }

        


            if (dtp_fechaFabricacion.Visible || dtp_fechaVencimiento.Visible)
            {
                if (dtp_fechaVencimiento.Value <= dtp_fechaFabricacion.Value)
                {
                    errorIcono.SetError(dtp_fechaVencimiento, "La fecha de vencimiento debe ser mayor a la de fabricación.");
                    MessageBox.Show("La fecha de vencimiento debe ser mayor a la de fabricación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtp_fechaVencimiento.Focus();
                    return false;
                }
            }

            if (txt_porcentaje.Visible)
            {
                if (!decimal.TryParse(txt_porcentaje.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal porcentaje) || porcentaje < 0)
                {
                    errorIcono.SetError(txt_porcentaje, "Porcentaje inválido.");
                    MessageBox.Show("Ingrese un porcentaje válido mayor o igual a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_porcentaje.Focus();
                    return false;
                }
            }

            return true;
        }


        //validar con eventos


        private void txt_producto_cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            // Evitar más de una coma
            if ((e.KeyChar == ',' || e.KeyChar == '.') && txt.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == '.')
                e.KeyChar = ',';

            // Evitar más de una coma
            if ((e.KeyChar == ',' || e.KeyChar == '.') && txt.Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        private void CalcularPrecioVenta()
        {
            lbl_precioVentaCalculado.ForeColor = Color.Black; // Color por defecto

            string textoCompra = txt_precioCompra.Text.Trim();
            string textoPorcentaje = txt_porcentaje.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoCompra) && string.IsNullOrWhiteSpace(textoPorcentaje))
            {
                lbl_precioVentaCalculado.Text = "Ingrese el precio de compra y porcentaje.";
                lbl_precioVentaCalculado.ForeColor = Color.DarkOrange;
                return;
            }

            if (string.IsNullOrWhiteSpace(textoCompra))
            {
                lbl_precioVentaCalculado.Text = "Ingrese el precio de compra.";
                lbl_precioVentaCalculado.ForeColor = Color.DarkOrange;
                return;
            }

            if (string.IsNullOrWhiteSpace(textoPorcentaje))
            {
                lbl_precioVentaCalculado.Text = "Ingrese el porcentaje de ganancia.";
                lbl_precioVentaCalculado.ForeColor = Color.DarkOrange;
                return;
            }

            // Validar y calcular
            if (decimal.TryParse(textoCompra, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal precioCompra) &&
                decimal.TryParse(textoPorcentaje, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal porcentajeGanancia))
            {
                decimal precioVenta = precioCompra + (precioCompra * (porcentajeGanancia / 100));
                lbl_precioVentaCalculado.Text = $"Precio final: {precioVenta.ToString("0.00", CultureInfo.InvariantCulture)}";
                lbl_precioVentaCalculado.ForeColor = Color.Green;
            }
            else
            {
                lbl_precioVentaCalculado.Text = "Verifique los datos ingresados.";
                lbl_precioVentaCalculado.ForeColor = Color.Red;
            }
        }


        private void txt_precioCompra_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        
        }

        private void txt_porcentaje_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

        private void txt_precioCompra_Leave(object sender, EventArgs e)
        {
            CN_Metodos.FormatoMoneda((TextBox)sender);
        }

        private void txt_productoCantidad_Leave(object sender, EventArgs e)
        {
            if (PermiteDecimales)
            {
                CN_Metodos.FormatoMoneda((TextBox)sender);// permite decimales
            }
            else
            {
                // Intentamos formatear como entero
                if (decimal.TryParse(txt_productoCantidad.Text, NumberStyles.Number, new CultureInfo("es-AR"), out decimal valor))
                {
                    if (valor % 1 != 0)
                    {
                        MessageBox.Show("Este tipo de unidad no permite decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_productoCantidad.Focus();
                        txt_productoCantidad.SelectAll();
                    }
                    else
                    {
                        txt_productoCantidad.Text = ((int)valor).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_productoCantidad.Focus();
                    txt_productoCantidad.SelectAll();
                }
            }
        }

        private void txt_porcentaje_Leave(object sender, EventArgs e)
        {
            CN_Metodos.FormatoMoneda((TextBox)sender);
        }

        private void MostrarResumenIngreso(DataGridView dgv)
        {
            int cantidadProductos = dgv.Rows.Count;
            decimal totalUnidades = 0;
            decimal totalFinal = 0;

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null && fila.Cells["PrecioCompra"].Value != null)
                {
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["PrecioCompra"].Value);

                    totalUnidades += cantidad;
                    totalFinal += cantidad * precio; // subtotal acumulado
                }
            }

            lbl_cantidadProductos.Text = $"Productos: {cantidadProductos.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalUnidades.Text = $"Unidades: {totalUnidades.ToString("N2", new CultureInfo("es-AR"))}";
            lbl_totalFinal.Text = $"Total: ${totalFinal.ToString("N2", new CultureInfo("es-AR"))}";
        }

        private void dgv_detalles_ingresos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MostrarResumenIngreso(dgv_detalles_ingresos);
        }

        private void dgv_detalles_ingresos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            MostrarResumenIngreso(dgv_detalles_ingresos);
        }
    }
}
