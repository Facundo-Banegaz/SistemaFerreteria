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

namespace Ferreteria.CapaPresentacion.VistaVenta
{
    public partial class FrmDetalleVenta : Form
    {
        private Venta _Venta;

        public FrmDetalleVenta()
        {
            InitializeComponent();
            Text = "Detalles de Venta:";
        }
        public FrmDetalleVenta(Venta venta)
        {
            InitializeComponent();
            this._Venta = venta;
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }
        private void MostrarDetalles()
        {

            CN_DetalleVenta _Detalle_Venta = new CN_DetalleVenta();

            dgv_detalles.DataSource = _Detalle_Venta.ListaDetalleVenta(_Venta.Id_Venta);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_detalleVenta"].Visible = false;

            dgv_productos.Columns["Venta"].Visible = false;




            dgv_productos.Columns["Producto"].Width = 350;// nombre_producto
            dgv_productos.Columns["Cantidad"].Width = 300;// Categoria
            dgv_productos.Columns["PrecioVenta"].Width = 300;// Categoria
            dgv_productos.Columns["Subtotal"].Width = 300;// Presentacion

            dgv_productos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N0";


            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["PrecioVenta"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // Si Stock también es decimal:
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.FormatProvider = culturaAR;

            _Metodos.AlternarColor(dgv_productos);
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
