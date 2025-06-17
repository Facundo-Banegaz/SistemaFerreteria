using Ferreteria.CapaDominio;
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
    public partial class FrmDetalleProducto : Form
    {
        private Producto _Producto;
        public FrmDetalleProducto(Producto producto)
        {
            InitializeComponent();
            Text = "Detalle del Producto:";
            this._Producto = producto;
        }

        private void FrmDetalleProducto_Load(object sender, EventArgs e)
        {
            if (_Producto != null)
            {
                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
            lbl_codigo.Text = "Codigo:   " + _Producto.Codigo;
            lbl_nombre.Text = "Nombre:   " + _Producto.Nombre;
            txt_descripcion_producto.Text =  _Producto.Descripcion;
            lbl_fecha.Text = "Fecha de la Ultima Actualización:  " + _Producto.FechaUltimaActualizacionPrecio;
            lbl_precio.Text = "Precio Actual:  " + _Producto.Precio;
            lbl_stock.Text = "Stock Actual: " + _Producto.Stock;
            lbl_subcategoria.Text = "Subcategoria:  " + _Producto.Subcategoria.Nombre;
            lbl_stock_minimo.Text = "Stock Minimo:  " + _Producto.StockMinimo;
            chek_estado.Checked = _Producto.Estado;
            lbl_marca.Text = "Marca:    " + _Producto.Marca.Nombre;
            lbl_Id.Text = _Producto.Id_Producto.ToString();
            lbl_unidad.Text = "Unidad de Medida:    " + _Producto.UnidadMedida.Nombre;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
