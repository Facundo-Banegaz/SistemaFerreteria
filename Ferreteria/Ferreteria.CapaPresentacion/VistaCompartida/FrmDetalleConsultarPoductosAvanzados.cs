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

namespace Ferreteria.CapaPresentacion.VistaCompartida
{
    public partial class FrmDetalleConsultarPoductosAvanzados : Form
    {
        private ProductoAvanzadoDto _Producto;
        private List<Especificacion> listaEspecificacion;


        public FrmDetalleConsultarPoductosAvanzados(ProductoAvanzadoDto productoAvanzadoDto)
        {
            InitializeComponent();
            Text = "Detalle del Producto:";
            this._Producto = productoAvanzadoDto;
        }

        private void FrmDetalleConsultarroductosAvanzados_Load(object sender, EventArgs e)
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
            lbl_precio.Text = "Precio Actual:  " + _Producto.Precio.ToString("N2", new CultureInfo("es-AR"));
            lbl_stock.Text = "Stock Actual: " + _Producto.Stock.ToString("N2", new CultureInfo("es-AR"));
            lbl_categoria.Text = "Categoria:  " + _Producto.Categoria;
            Chk_estado.Checked = _Producto.Estado;
            lbl_subcategoria.Text = "Subcategoria:  " + _Producto.Subcategoria;
            lbl_stock_minimo.Text = "Stock Minimo:  " + _Producto.StockMinimo.ToString("N2", new CultureInfo("es-AR"));
            lbl_marca.Text = "Marca:    " + _Producto.Marca;
            lbl_Id.Text = _Producto.Id_Producto.ToString();
            lbl_unidad.Text = "Unidad de Medida:    " + _Producto.UnidadMedida;
        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            // Ocultar columnas que no queremos mostrar
            dgv_productos.Columns["Id_Especificacion"].Visible = false;
            dgv_productos.Columns["Producto"].Visible = false;

            // Ajustar columnas visibles para que ocupen todo el ancho del DataGridView
            dgv_productos.Columns["TipoEspecificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_productos.Columns["ValorEspecificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Puedes definir proporciones si quieres que una sea más ancha que la otra
            dgv_productos.Columns["TipoEspecificacion"].FillWeight = 50; // 50% del espacio disponible
            dgv_productos.Columns["ValorEspecificacion"].FillWeight = 50; // 50% del espacio disponible

            // Alinear el contenido de las celdas
            dgv_productos.Columns["TipoEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ValorEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alternar colores de filas (método personalizado)
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
    }
}
