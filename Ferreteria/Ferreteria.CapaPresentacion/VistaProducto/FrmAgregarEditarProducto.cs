
using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using Ferreteria.CapaPresentacion.VistaEspecificacion.VistaTipoEspecificacion;
using Ferreteria.CapaPresentacion.VistaMarca;
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
    public partial class FrmAgregarEditarProducto : Form
    {
        private Producto producto = null;
        private bool mensajeMostrado = false;
        bool PermiteDecimales = true; 

        private CN_Metodos CN_Metodos = new CN_Metodos();
        public FrmAgregarEditarProducto()
        {
            InitializeComponent();
            Text = "Nuevo Producto";
            lbl_fecha.Visible = false;
        }
        public FrmAgregarEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Editar Producto";
          

        }
        private void FrmAgregarEditarProducto_Load(object sender, EventArgs e)
        {
            CargarCbo();

            if (producto != null)
            {
                MostrarDatos();
            }
        }


        private void CargarCbo()
        {

            CN_Categoria _Categoria = new CN_Categoria();
            //CN_Marca _Marca = new CN_Marca();
            ////CN_UnidadMedida _UnidadMedida = new CN_UnidadMedida();

            try
            {

                cbo_categoria.DataSource = _Categoria.CargarCbo();
                cbo_categoria.ValueMember = "Id_categoria";
                cbo_categoria.DisplayMember = "Nombre";



                ////cbo_marca.DataSource = _Marca.CargarCbo();
                ////cbo_marca.ValueMember = "Id_Marca";
                ////cbo_marca.DisplayMember = "Nombre";

                //cbo_unidadMedida.DataSource = _UnidadMedida.CargarCbo();
                //cbo_unidadMedida.ValueMember = "Id_UnidadMedida";
                //cbo_unidadMedida.DisplayMember = "Nombre";


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }
        private void MostrarDatos()
        {
            try
            {
                if(producto != null)
                {
                    txt_codigo.Text = producto.Codigo;
                    txt_nombre.Text = producto.Nombre;
                    txt_descripcion.Text = producto.Descripcion;
                    txt_precio.Text = producto.Precio.ToString("N2", new CultureInfo("es-AR"));

                    txt_stock_minimo.Text = producto.StockMinimo.ToString("N2", new CultureInfo("es-AR"));


                    Chk_RequiereVencimiento.Checked = producto.RequiereVencimiento;

                    Chk_actualizarPrecioAutomaticamente.Checked = producto.ActualizarPrecioAutomaticamente;


                    lbl_id.Text = producto.Id_Producto.ToString();
                    lbl_fecha.Visible = true;
                    lbl_fecha.Text = "Ultima actualización:      "+producto.FechaUltimaActualizacionPrecio.ToString();

                    cbo_subcategoria.SelectedValue = producto.Subcategoria.Id_Subcategoria;

                    cbo_categoria.SelectedValue = producto.Subcategoria.Categoria.Id_Categoria;
                    txt_nombre_marca.Text = producto.Marca.Nombre;
                    txt_id_marca.Text = producto.Marca.Id_Marca.ToString();

                    txt_unidadMedida.Text = producto.UnidadMedida.Nombre;
                    txt_id_unidadMedida.Text = producto.UnidadMedida.Id_UnidadMedida.ToString();

                    //cbo_marca.SelectedValue = producto.Marca.Id_Marca;
                    //cbo_unidadMedida.SelectedValue = producto.UnidadMedida.Id_UnidadMedida;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }



        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el CheckBox está marcado, permitir cualquier entrada
            if (Chk_CambiarEstado.Checked)
            {
                return; // No hacemos validaciones
            }

            // ---- Validación original ----

            // Permitir teclas de control (backspace, delete, flechas...)
            if (char.IsControl(e.KeyChar))
            {
                mensajeMostrado = false; // Resetea el mensaje
                return;
            }

            // Permitir solo números
            if (char.IsDigit(e.KeyChar))
            {
                // Solo permitir si no supera los 13 caracteres
                if (txt_codigo.Text.Length >= 13)
                {
                    e.Handled = true; // Bloquear más escritura

                    if (!mensajeMostrado)
                    {
                        MessageBox.Show("El código de barras no puede tener más de 13 números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mensajeMostrado = true;
                    }
                }
                else
                {
                    mensajeMostrado = false; // Resetea mensaje si no excede
                }

                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
            if (!mensajeMostrado)
            {
                MessageBox.Show("Solo se permiten números.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mensajeMostrado = true;
            }
        }


        private void cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_SubCategoria _Subcategoria = new CN_SubCategoria();
            try
            {
                Categoria categoriaSeleccionada = (Categoria)cbo_categoria.SelectedItem;
                int Id_Categoria = categoriaSeleccionada.Id_Categoria;


                cbo_subcategoria.DataSource = _Subcategoria.CargarCbo(Id_Categoria);
                cbo_subcategoria.ValueMember = "Id_Subcategoria";
                cbo_subcategoria.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar subcategorías: " + ex.Message);
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            mensajeMostrado = false;
        }

        private void GuardarProducto()
        {
          CN_Producto _CN_Producto = new CN_Producto();

            try
            {

                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (producto == null)

                        producto = new Producto();

                    producto.Codigo = txt_codigo.Text.Trim().ToUpper();
                    producto.Nombre = txt_nombre.Text.Trim().ToUpper();
                    producto.Descripcion = txt_descripcion.Text.Trim();
                    producto.Precio = Convert.ToDecimal(txt_precio.Text.Trim(), new CultureInfo("es-AR"));
                    producto.StockMinimo = Convert.ToDecimal(txt_stock_minimo.Text.Trim(), new CultureInfo("es-AR"));


                    producto.RequiereVencimiento = Chk_RequiereVencimiento.Checked;

                    producto.ActualizarPrecioAutomaticamente = Chk_actualizarPrecioAutomaticamente.Checked;


                    producto.Marca = new Marca();

                    producto.Marca.Id_Marca = Convert.ToInt32(txt_id_marca.Text.Trim());


                    producto.UnidadMedida = new UnidadMedida();

                    producto.UnidadMedida.Id_UnidadMedida = Convert.ToInt32(txt_id_unidadMedida.Text.Trim());

                    producto.Subcategoria = (Subcategoria)cbo_subcategoria.SelectedItem;
                    ////producto.Marca = (Marca)cbo_marca.SelectedItem;
                   
                    //producto.UnidadMedida = (UnidadMedida)cbo_unidadMedida.SelectedItem;




                    if (producto.Id_Producto != 0)
                    {
                        _CN_Producto.EditarProducto(producto);
                        MessageBox.Show("El Producto Fue Modificada Exitosamente!!", "Modificado");
                        this.Close();
                    }
                    else
                    {


                        _CN_Producto.InsertarProducto(producto);
                        MessageBox.Show("El Producto Fue Agregada Exitosamente!!", "Agregado");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Completar Todos los Campos!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                // Mostrar mensaje amigable si es un error de duplicado
                errorIcono.SetError(txt_codigo, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia Código duplicado detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
                txt_codigo.Clear();
                txt_codigo.Focus();

            }


        }

        private bool ValidarVacio()
        {
            errorIcono.Clear();
            bool error = true;

            if (txt_codigo.Text == string.Empty)
            {
                errorIcono.SetError(txt_codigo, "El campo  es obligatorio, ingrese el Codigo ");


                error = false;
            }
            else if (txt_nombre.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            else if (txt_precio.Text == string.Empty)
            {
                errorIcono.SetError(txt_precio, "El campo  es obligatorio, ingrese el Precio ");


                error = false;
            }
     
            else if (txt_stock_minimo.Text == string.Empty)
            {
                errorIcono.SetError(txt_stock_minimo, "El campo  es obligatorio, ingrese el Stock Minimo ");


                error = false;
            }
            else if (txt_nombre_marca.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_marca, "El campo  es obligatorio, ingrese la Marca ");


                error = false;
            }
            else if (cbo_subcategoria.SelectedIndex == -1)
            {
                errorIcono.SetError(cbo_subcategoria, "El campo  es obligatorio, ingrese la Subcategoria ");
                MessageBox.Show("La categoría seleccionada no tiene subcategorías disponibles.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            if (Chk_CambiarEstado.Checked)
                return; // No validar en modo libre

            string codigo = txt_codigo.Text;

            if (codigo.Length == 13)
            {
                if (codigo.Distinct().Count() == 1)
                {
                    MessageBox.Show("El código de barras no puede tener todos los números iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_codigo.Focus();
                    txt_codigo.SelectAll();
                    return;
                }

                txt_nombre.Focus();
            }
        }

        private void txt_stock_minimo_TextChanged(object sender, EventArgs e)
        {
            mensajeMostrado = false;
        }


        private void btn_marca_Click(object sender, EventArgs e)
        {
            FrmSeleccionarMarca frmSeleccionar = new FrmSeleccionarMarca();

            // Suscribís al evento
            frmSeleccionar.MarcaSeleccionada += (Id_Marca, Nombre) =>
            {
                txt_id_marca.Text = Id_Marca;
                txt_nombre_marca.Text = Nombre;
            };

            frmSeleccionar.ShowDialog();
        }


   
    



        private void btn_unidadMedida_Click(object sender, EventArgs e)
        {
            FrmSeleccionarUnidadMedida frmSeleccionar = new FrmSeleccionarUnidadMedida();

            // Suscribís al evento
            frmSeleccionar.UnidadMedidaSeleccionada += (Id_UnidadMedida, Nombre, PermiteDecimales) =>
            {
                txt_id_unidadMedida.Text = Id_UnidadMedida;
                txt_unidadMedida.Text = Nombre;
                this.PermiteDecimales = PermiteDecimales;

            };

            frmSeleccionar.ShowDialog();
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir teclas de control (backspace, delete, flechas, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Solo permitir dígitos y coma/punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            //// Reemplazar punto por coma
            //if (e.KeyChar == '.')
            //    e.KeyChar = ',';

            // Evitar más de una coma
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
                return;
            }

            // Opcional: limitar a 2 decimales
            if (char.IsDigit(e.KeyChar) && txt.Text.Contains(","))
            {
                int index = txt.Text.IndexOf(",");
                string decimales = txt.Text.Substring(index + 1);

                if (decimales.Length >= 2) // máximo 2 decimales
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_precio_Leave(object sender, EventArgs e)
        {
           CN_Metodos.FormatoMoneda((TextBox)sender);
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar == '.')
                    e.KeyChar = ',';

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
        



        private void txt_stock_minimo_Leave(object sender, EventArgs e)
        {
            if (PermiteDecimales)
            {
                CN_Metodos.FormatoMoneda((TextBox)sender);// permite decimales
            }
            else
            {
                // Intentamos formatear como entero
                if (decimal.TryParse(txt_stock_minimo.Text, NumberStyles.Number, new CultureInfo("es-AR"), out decimal valor))
                {
                    if (valor % 1 != 0)
                    {
                        MessageBox.Show("Este tipo de unidad no permite decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_stock_minimo.Focus();
                        txt_stock_minimo.SelectAll();
                    }
                    else
                    {
                        txt_stock_minimo.Text = ((int)valor).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_stock_minimo.Focus();
                    txt_stock_minimo.SelectAll();
                }
            }
        }

        private void Chk_CambiarEstado_CheckedChanged(object sender, EventArgs e)
        {
            txt_codigo.Clear(); // Vaciar el TextBox

            if (Chk_CambiarEstado.Checked)
            {
                toolTip.SetToolTip(txt_codigo, "Puede ingresar letras, números o símbolos");
            }
            else
            {
                
                toolTip.SetToolTip(txt_codigo, "Solo números y hasta 13 dígitos");
            }
        }
    }
}
