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

namespace Ferreteria.CapaPresentacion.VistaMovimientoStock
{
    public partial class FrmMovimientoStockDetalle : Form
    {

        private MovimientoStock _Movimiento;

        private List<Especificacion> listaEspecificacion;
        public FrmMovimientoStockDetalle(MovimientoStock movimientoStock)
        {
            InitializeComponent();
            Text = "Detalle del Movimiento de Stock:";
            this._Movimiento = movimientoStock;
        }

     

        private void FrmMovimientoStockDetalle_Load(object sender, EventArgs e)
        {
            if (_Movimiento != null)
            {
                MostrarDatos();
            }
            CargarGrilla();

            //ArregloDataGridView(dgv_caracteristicas);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Especificacion n_Especificacion = new CN_Especificacion();

            //int Id_Producto = _Producto.Id_Producto;
            ////listaEspecificacion = n_Especificacion.MostrarDetalleEspecificacionesPorProducto(_Producto.Id_Producto);

            ////dgv_caracteristicas.DataSource = listaEspecificacion;


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
        private void MostrarDatos()
        {
            //lbl_codigo.Text = "Codigo:   " + _Movimiento.Codigo;
            //lbl_nombre.Text = "Nombre:   " + _Movimiento.Nombre;
            //txt_descripcion_Movimiento.Text = _Movimiento.Descripcion;
            //lbl_fecha.Text = "Fecha de la Ultima Actualización:  " + _Movimiento.FechaUltimaActualizacionPrecio;
            //lbl_precio.Text = "Precio Actual:  " + _Movimiento.Precio.ToString("N2", new CultureInfo("es-AR")); ;
            //lbl_stock.Text = "Stock Actual: " + _Movimiento.Stock.ToString("N2", new CultureInfo("es-AR"));
            //lbl_subcategoria.Text = "Subcategoria:  " + _Movimiento.Subcategoria.Nombre;
            //lbl_stock_minimo.Text = "Stock Minimo:  " + _Movimiento.StockMinimo.ToString("N2", new CultureInfo("es-AR"));
            //Chk_estado.Checked = _Movimiento.Estado;
            //Chk_actualizarPrecioAutomaticamente.Checked = _Movimiento.ActualizarPrecioAutomaticamente;
            //Chk_requiereVencimiento.Checked = _Movimiento.RequiereVencimiento;
            //lbl_marca.Text = "Marca:    " + _Movimiento.Marca.Nombre;
            //lbl_Id.Text = _Movimiento.Id_Movimiento.ToString();
            //lbl_unidad.Text = "Unidad de Medida:    " + _Movimiento.UnidadMedida.Nombre;
        }
    }
}
