using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ferreteria.CapaPresentacion.VistaProducto
{
    public partial class FrmDetalleProducto : Form
    {
        private Producto _Producto;
        private List<Especificacion> listaEspecificacion;
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
            CargarGrilla();

            ArregloDataGridView(dgv_caracteristicas);

        }

        private void MostrarDatos()
        {
            lbl_codigo.Text = "Codigo:   " + _Producto.Codigo;
            lbl_nombre.Text = "Nombre:   " + _Producto.Nombre;
            txt_descripcion_producto.Text =  _Producto.Descripcion;
            lbl_fecha.Text = "Fecha de la Ultima Actualización:  " + _Producto.FechaUltimaActualizacionPrecio;
            lbl_precio.Text = "Precio Actual:  " + _Producto.Precio.ToString("N2", new CultureInfo("es-AR")); ;
            lbl_stock.Text = "Stock Actual: " + _Producto.Stock.ToString("N2", new CultureInfo("es-AR"));
            lbl_subcategoria.Text = "Subcategoria:  " + _Producto.Subcategoria.Nombre;
            lbl_stock_minimo.Text = "Stock Minimo:  " + _Producto.StockMinimo.ToString("N2", new CultureInfo("es-AR"));
            Chk_estado.Checked = _Producto.Estado;
            Chk_actualizarPrecioAutomaticamente.Checked = _Producto.ActualizarPrecioAutomaticamente;
            Chk_requiereVencimiento.Checked = _Producto.RequiereVencimiento;
            lbl_marca.Text = "Marca:    " + _Producto.Marca.Nombre;
            lbl_Id.Text = _Producto.Id_Producto.ToString();
            lbl_unidad.Text = "Unidad de Medida:    " + _Producto.UnidadMedida.Nombre;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_Especificacion"].Visible = false;
            dgv_productos.Columns["Producto"].Visible = false;


            dgv_productos.Columns["TipoEspecificacion"].Width = 520;
            dgv_productos.Columns["ValorEspecificacion"].Width = 520;
           


            dgv_productos.Columns["TipoEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ValorEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Especificacion n_Especificacion = new CN_Especificacion();

            //int Id_Producto = _Producto.Id_Producto;
            listaEspecificacion = n_Especificacion.MostrarDetalleEspecificacionesPorProducto(_Producto.Id_Producto);

            dgv_caracteristicas.DataSource = listaEspecificacion;
          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
