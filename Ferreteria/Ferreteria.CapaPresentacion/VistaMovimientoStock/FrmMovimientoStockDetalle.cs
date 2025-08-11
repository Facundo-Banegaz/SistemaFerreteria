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


        public FrmMovimientoStockDetalle()
        {

            InitializeComponent();
            Text = "Detalle del Movimiento de Stock:";
        }
        public FrmMovimientoStockDetalle(MovimientoStock movimientoStock)
        {
            InitializeComponent();
            this._Movimiento = movimientoStock;
        }

     

        private void FrmMovimientoStockDetalle_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }
        private void MostrarDetalles()
        {

            CN_MovimientoDetalleStock _MovimientoDetalleStock = new CN_MovimientoDetalleStock();

            dgv_detalles.DataSource = _MovimientoDetalleStock.ListaDetalleMovimientoStock(_Movimiento.Id_MovimientoStock);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_DetalleMovimientoStock"].Visible = false;

            dgv_productos.Columns["MovimientoStock"].Visible = false;





            dgv_productos.Columns["Producto"].Width = 450;// nombre_producto
            dgv_productos.Columns["Cantidad"].Width = 300;// Categoria
            dgv_productos.Columns["StockAnterior"].Width = 300;// Presentacion
            dgv_productos.Columns["StockNuevo"].Width = 300;// nombre_producto
            dgv_productos.Columns["ObservacionDetalle"].Width = 300;// Categoria
         

            dgv_productos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["StockAnterior"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_productos.Columns["StockNuevo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ObservacionDetalle"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         

        

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["StockAnterior"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockAnterior"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // Si Stock también es decimal:
            dgv_productos.Columns["StockNuevo"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockNuevo"].DefaultCellStyle.FormatProvider = culturaAR;

            _Metodos.AlternarColor(dgv_productos);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
