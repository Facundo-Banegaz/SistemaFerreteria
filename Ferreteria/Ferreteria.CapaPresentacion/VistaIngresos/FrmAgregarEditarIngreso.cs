using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using System;
using System.Collections;
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
    public partial class FrmAgregarEditarIngreso : Form
    {
        public int Cantidad { get; private set; } = 0;
      


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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool requiereVencimiento = lbl_fechaFabricacion.Visible;
            bool actualizarPrecio = lbl_porcentaje.Visible;

            if (!ValidarCamposObligatorios(requiereVencimiento, actualizarPrecio))
                return;

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
            frmSeleccionar.ProductoIngresoSeleccionado += (Id_Producto, Nombre, RequiereVencimiento,ActualizarPrecioAutomaticamente) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_producto.Text = Nombre;


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

        private bool ValidarCamposObligatorios(bool requiereVencimiento, bool actualizarPrecio)
        {
            bool esValido = true;
            errorIcono.Clear(); // Limpiar errores anteriores

            if (requiereVencimiento)
            {
                if (dtp_fechaFabricacion.Value == DateTime.MinValue)
                {
                    errorIcono.SetError(dtp_fechaFabricacion, "Ingrese la fecha de fabricación.");
                    esValido = false;
                }

                if (dtp_fechaVencimiento.Value == DateTime.MinValue)
                {
                    errorIcono.SetError(dtp_fechaVencimiento, "Ingrese la fecha de vencimiento.");
                    esValido = false;
                }

                // Validar que vencimiento sea posterior a fabricación
                if (dtp_fechaVencimiento.Value <= dtp_fechaFabricacion.Value)
                {
                    errorIcono.SetError(dtp_fechaVencimiento, "La fecha de vencimiento debe ser mayor a la de fabricación.");
                    esValido = false;
                }
            }

            if (actualizarPrecio)
            {
                if (string.IsNullOrWhiteSpace(txt_porcentaje.Text))
                {
                    errorIcono.SetError(txt_porcentaje, "Ingrese el porcentaje de actualización.");
                    esValido = false;
                }
                else
                {
                    // Validar que sea un número válido
                    if (!decimal.TryParse(txt_porcentaje.Text, out decimal porcentaje) || porcentaje < 0)
                    {
                        errorIcono.SetError(txt_porcentaje, "Ingrese un porcentaje válido mayor  0.");
                        esValido = false;
                    }
                }
            }

            return esValido;
        }

        //Logica de la Grilla
        //Crea la tabla de Detalle 


        private void MostrarTabla()
        {
            // Limpiar columnas si es necesario
            dgv_ingresos.Columns.Clear();

            // Agregar columnas
            dgv_ingresos.Columns.Add("Id_Producto", "Id_Producto");
            dgv_ingresos.Columns.Add("Producto", "Producto");
            dgv_ingresos.Columns.Add("Fecha Fabricación", "Fecha Fabricación");
            dgv_ingresos.Columns.Add("Fecha Vencimiento", "Fecha Vencimiento");
            dgv_ingresos.Columns.Add("Precio Compra", "Precio Compra");
            dgv_ingresos.Columns.Add("Porcentaje Ganancia", "Porcentaje Ganancia");
            dgv_ingresos.Columns.Add("Cantidad", "Cantidad");
            dgv_ingresos.Columns.Add("SubTotal", "SubTotal");
            // Autoajustar columnas 
            dgv_ingresos.Columns["Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Id_Producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Precio Compra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Cantidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Fecha Fabricación"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Fecha Vencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ingresos.Columns["Porcentaje Ganancia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
        }
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dgv_ingresos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este producto del detalle?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                dgv_ingresos.Rows.Remove(dgv_ingresos.CurrentRow);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgv_ingresos.CurrentRow == null)
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

                        DataGridViewRow fila = dgv_ingresos.CurrentRow;
                        decimal precioCompra = decimal.Parse(fila.Cells["Precio Compra"].Value.ToString(), CultureInfo.CurrentCulture);
                        decimal nuevoSubtotal = nuevaCantidad * precioCompra;

                        fila.Cells["Cantidad"].Value = nuevaCantidad;
                        fila.Cells["SubTotal"].Value = nuevoSubtotal.ToString("N2", CultureInfo.CurrentCulture);

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
                    return;

                int idProducto = Convert.ToInt32(txt_id_producto.Text);
                string nombreProducto = txt_producto.Text;

                // Verificar si el producto ya está en la grilla
                foreach (DataGridViewRow row in dgv_ingresos.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Id_Producto"].Value) == idProducto)
                    {
                        MessageBox.Show("Este producto ya fue agregado.\nUse el botón de 'Modificar cantidad'.", "Producto duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCamposDetalle();
                        return;
                    }
                }

                decimal precioCompra = decimal.Parse(txt_precioCompra.Text, CultureInfo.InvariantCulture);
                int cantidad = int.Parse(txt_productoCantidad.Text);

                string fechaFabricacion = dtp_fechaFabricacion.Visible ? dtp_fechaFabricacion.Value.ToString("yyyy-MM-dd") : "--";
                string fechaVencimiento = dtp_fechaVencimiento.Visible ? dtp_fechaVencimiento.Value.ToString("yyyy-MM-dd") : "--";
                decimal porcentajeGanancia = txt_porcentaje.Visible && !string.IsNullOrWhiteSpace(txt_porcentaje.Text)? decimal.Parse(txt_porcentaje.Text, CultureInfo.CreateSpecificCulture("es-AR"))      : 0;


                decimal subtotal = precioCompra * cantidad;

                dgv_ingresos.Rows.Add(
                    idProducto,
                    nombreProducto,
                    fechaFabricacion,
                    fechaVencimiento,
                    precioCompra.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR")),
                    porcentajeGanancia.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR")),
                    cantidad,
                    subtotal.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"))
                );

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

            if (!decimal.TryParse(txt_precioCompra.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal precio) || precio <= 0)
            {
                errorIcono.SetError(txt_precioCompra, "Precio inválido.");
                MessageBox.Show("Ingrese un precio válido mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_precioCompra.Focus();
                return false;
            }

            if (!int.TryParse(txt_productoCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                errorIcono.SetError(txt_productoCantidad, "Cantidad inválida.");
                MessageBox.Show("Ingrese una cantidad válida mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_productoCantidad.Focus();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números enteros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Solo se permiten números y punto decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Solo se permiten números y punto decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
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
    }
}
