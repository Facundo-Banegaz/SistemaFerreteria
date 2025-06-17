
using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaProducto
{
    public partial class FrmAgregarEditarProducto : Form
    {
        private Producto producto = null;
        public FrmAgregarEditarProducto()
        {
            InitializeComponent();
            Text = "Nuevo Producto";
        }
        public FrmAgregarEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            Text = "Editar Producto";
        }
        private void FrmAgregarEditarProducto_Load(object sender, EventArgs e)
        {
            if (producto != null)
            {
                //MostrarDatos();
            }
            CargarCbo();
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
            //txt_codigo.Text =  producto.Codigo;
            //txt_nombre.Text =  producto.Nombre;
            //txt_descripcion.Text =  producto.Descripcion;
            //txt_precio.Text =  producto.Precio.ToString();
            //txt_stock.Text =  producto.Stock.ToString();
            //txt_stock_minimo.Text = producto.StockMinimo.ToString();
            //lbl_id.Text = producto.Id_Producto.ToString();
        }
   

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla backspace u otras teclas de control
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.' && !txt_stock.Text.Contains("."))
            {
                return;
            }

            // Bloquear todo lo demás (letras, símbolos, múltiples puntos)
            e.Handled = true;
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla backspace u otras teclas de control
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir dígitos
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.' && !txt_stock_minimo.Text.Contains("."))
            {
                return;
            }

            // Bloquear todo lo demás (letras, símbolos, múltiples puntos)
            e.Handled = true;
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
    }
}
