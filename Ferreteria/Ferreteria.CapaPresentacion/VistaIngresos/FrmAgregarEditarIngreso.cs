using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
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
    public partial class FrmAgregarEditarIngreso : Form
    {
        private decimal precioCompra = 0;

        private decimal totalCompra = 0;

     
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
                txt_id_proveedor.Text = Id_Producto;
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
            lbl_precioDeVenta.Visible = actualizarPrecio;

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

        private void txt_codigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {

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

                txt_id_proveedor.Clear();
                    txt_producto.Clear();
                }
            // Limpiar el campo del código de barras después de procesar
            txt_codigoBarra.Clear();
            txt_codigoBarra.Focus();

        }
    }
}
