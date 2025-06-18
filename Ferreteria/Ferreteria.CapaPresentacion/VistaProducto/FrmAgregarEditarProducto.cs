
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
    public partial class FrmAgregarEditarProducto : Form
    {
        private Producto producto = null;
        private bool mensajeMostrado = false;
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
            CN_Marca _Marca = new CN_Marca();
            CN_UnidadMedida _UnidadMedida = new CN_UnidadMedida();
 
            try
            {

                cbo_categoria.DataSource =_Categoria.CargarCbo();
                cbo_categoria.ValueMember = "Id_categoria";
                cbo_categoria.DisplayMember = "Nombre";

               

                cbo_marca.DataSource = _Marca.CargarCbo();
                cbo_marca.ValueMember = "Id_Marca";
                cbo_marca.DisplayMember = "Nombre";

                cbo_unidadMedida.DataSource = _UnidadMedida.CargarCbo();
                cbo_unidadMedida.ValueMember = "Id_UnidadMedida";
                cbo_unidadMedida.DisplayMember = "Nombre";

   
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
                    //txt_precio.Text = producto.Precio.ToString();
                    txt_precio.Text = producto.Precio.ToString("F2",CultureInfo.InvariantCulture);
                    txt_stock.Text = producto.Stock.ToString();
                    txt_stock_minimo.Text = producto.StockMinimo.ToString();
                    lbl_id.Text = producto.Id_Producto.ToString();
                    lbl_fecha.Visible = true;
                    lbl_fecha.Text = "Ultima actualización:      "+producto.FechaUltimaActualizacionPrecio.ToString();

                    cbo_subcategoria.SelectedValue = producto.Subcategoria.Id_Subcategoria;

                    cbo_categoria.SelectedValue = producto.Subcategoria.Categoria.Id_Categoria;

                    cbo_marca.SelectedValue = producto.Marca.Id_Marca;
                    cbo_unidadMedida.SelectedValue = producto.UnidadMedida.Id_UnidadMedida;

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

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {


            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

  

            // Bloquear todo lo demás (letras, símbolos, múltiples puntos)
            e.Handled = true;
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

       
            // Bloquear todo lo demás (letras, símbolos, múltiples puntos)
            e.Handled = true;
        }


        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite teclas de control como Backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permite números (0–9)
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permite un solo punto (.)
            if (e.KeyChar == '.' && !txt_precio.Text.Contains("."))
            {
                return;
            }
     
            // Si no es número, ni control, ni punto válido: se bloquea
            e.Handled = true;
            if (!mensajeMostrado)
            {
                MessageBox.Show("Solo se permiten números y un único punto decimal.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mensajeMostrado = true;
            }
        }
        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt_nombre.Focus();     // focus
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
                    producto.Precio = Convert.ToDecimal(txt_precio.Text.Trim());
                    producto.Stock =Convert.ToInt32( txt_stock.Text.Trim());
                    producto.StockMinimo = Convert.ToInt32(txt_stock_minimo.Text.Trim());


                    producto.Subcategoria = (Subcategoria)cbo_subcategoria.SelectedItem;
                    producto.Marca = (Marca)cbo_marca.SelectedItem;
                    producto.UnidadMedida = (UnidadMedida)cbo_unidadMedida.SelectedItem;


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
            else if (txt_stock.Text == string.Empty)
            {
                errorIcono.SetError(txt_stock, "El campo  es obligatorio, ingrese el Stock ");


                error = false;
            }
            else if (txt_stock_minimo.Text == string.Empty)
            {
                errorIcono.SetError(txt_stock_minimo, "El campo  es obligatorio, ingrese el Stock Minimo ");


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




    }
}
