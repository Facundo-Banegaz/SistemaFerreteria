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
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            txt_id_producto.Text = _Producto.Id_Producto.ToString();
            txt_codigo_producto.Text = _Producto.Codigo.ToString();
            txt_nombre_producto.Text = _Producto.Nombre;
            txt_descripcion_producto.Text = _Producto.Descripcion;
            txt_fecha.Text = _Producto.FechaUltimaActualizacionPrecio.ToString();
            txt_marca.Text = _Producto.Marca.Nombre.ToString();
            txt_subcategoria.Text = _Producto.Subcategoria.Nombre.ToString();
            txt_unidadMedida.Text = _Producto.UnidadMedida.Nombre.ToString();
            txt_stock.Text = _Producto.Stock.ToString();
            txt_stockminimo.Text = _Producto.StockMinimo.ToString();
            txt_url_Precio.Text = _Producto.Precio.ToString();
            chek_estado.Checked = _Producto.Estado;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
