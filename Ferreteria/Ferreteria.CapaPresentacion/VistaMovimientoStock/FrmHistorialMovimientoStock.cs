using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaProducto;
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
    public partial class FrmHistorialMovimientoStock : Form
    {
        public Usuario _Usuario;
        private List<MovimientoStock> listaMovimientoStock;
        public FrmHistorialMovimientoStock()
        {
            InitializeComponent();
            Text = "Gestion Movimientos de Stock";
        }
        public FrmHistorialMovimientoStock(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
        }
        private void FrmMovimientoStock_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_movimientoStock);
        }

    

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmMovimientoStockManual stockManual = new FrmMovimientoStockManual(_Usuario);
            stockManual.ShowDialog();
            CargarGrilla();
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            MovimientoStock seleccionado = null;
            if (dgv_movimientoStock.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle de este Movimiento?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (MovimientoStock)dgv_movimientoStock.CurrentRow.DataBoundItem;

                    FrmMovimientoStockDetalle frmDetalle = new FrmMovimientoStockDetalle(seleccionado);
                    frmDetalle.ShowDialog();
                }
            }
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
           CN_MovimientoStock _MovimientoStock = new CN_MovimientoStock();

            listaMovimientoStock = _MovimientoStock.ListaMovimientoStockManual();

            dgv_movimientoStock.DataSource = listaMovimientoStock;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_movimientoStock.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void ArregloDataGridView(DataGridView dgv_movimientoStock)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_movimientoStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_movimientoStock.Columns["Id_MovimientoStock"].FillWeight = 15;
            dgv_movimientoStock.Columns["Fecha"].FillWeight = 15;
            dgv_movimientoStock.Columns["TipoMovimiento"].FillWeight = 20;
            dgv_movimientoStock.Columns["Usuario"].FillWeight = 30;
            dgv_movimientoStock.Columns["Observacion"].FillWeight = 20;

            dgv_movimientoStock.Columns["Id_MovimientoStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_movimientoStock.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_movimientoStock.Columns["TipoMovimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_movimientoStock.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_movimientoStock.Columns["Observacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_movimientoStock);
        }

    //    private void ArregloDataGridView(DataGridView dgv_movimientoStock)
    //    {

    //        //logica del dataGridView
    //        CN_Metodos _Metodos = new CN_Metodos();


    //        dgv_movimientoStock.Columns["Id_MovimientoStock"].Width = 200;
    //        dgv_movimientoStock.Columns["Fecha"].Width = 200;

    //        dgv_movimientoStock.Columns["TipoMovimiento"].Width = 200;
     
    //        dgv_movimientoStock.Columns["Usuario"].Width = 300;
    //        dgv_movimientoStock.Columns["Observacion"].Width = 100;
          
    //        //Lo usare en detalle
    //        //// Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
    //        //CultureInfo culturaAR = new CultureInfo("es-AR");

    //        //dgv_movimientoStock.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
    //        //dgv_movimientoStock.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

    //        //dgv_movimientoStock.Columns["StockAnterior"].DefaultCellStyle.Format = "N2";
    //        //dgv_movimientoStock.Columns["StockAnterior"].DefaultCellStyle.FormatProvider = culturaAR;

    //        //// Si Stock también es decimal:
    //        //dgv_movimientoStock.Columns["StockNuevo"].DefaultCellStyle.Format = "N2";
    //        //dgv_movimientoStock.Columns["StockNuevo"].DefaultCellStyle.FormatProvider = culturaAR;


    //        dgv_movimientoStock.Columns["Id_MovimientoStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    //        dgv_movimientoStock.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

    //        dgv_movimientoStock.Columns["TipoMovimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    //        dgv_movimientoStock.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    //        dgv_movimientoStock.Columns["Observacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          



    //        _Metodos.AlternarColor(dgv_movimientoStock);
    //    }
    }
}
