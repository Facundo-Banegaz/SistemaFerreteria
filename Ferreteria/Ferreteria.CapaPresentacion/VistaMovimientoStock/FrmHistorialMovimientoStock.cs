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
        
        private List<MovimientoStock> listaMovimientoStock;

        public FrmHistorialMovimientoStock()
        {
            InitializeComponent();
            Text = "Gestion Movimientos de Stock";
        }

        private void FrmMovimientoStock_Load(object sender, EventArgs e)
        {

            CargarCbo();

            CargarGrilla();
   

            ArregloDataGridView(dgv_movimientoStock);
        }


        private void CargarCbo()
        { 
            CN_TipoMovimiento _TipoMovimiento = new CN_TipoMovimiento();

            cbo_TipoMovimiento.DataSource = _TipoMovimiento.ListaTipoMovimiento();
            cbo_TipoMovimiento.ValueMember = "Id_TipoMovimiento";
            cbo_TipoMovimiento.DisplayMember = "Nombre";


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

            // Capturar el ID seleccionado del ComboBox
            int Id = Convert.ToInt32(cbo_TipoMovimiento.SelectedValue);

            listaMovimientoStock = _MovimientoStock.ListaMovimientoStock(Id);

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



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarFechas();
        }

    
        private void BuscarFechas()
        {

            CN_MovimientoStock _MovimientoStock = new CN_MovimientoStock();


            if (dtp_fecha_inicio.Value.Date > dtp_fecha_fin.Value.Date)
            {
                MessageBox.Show("La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.", "ADVERTENCIA");
                lbl_resultado.Text = "La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.";
                return;
            }


            try
            {

                // Capturar el ID seleccionado del ComboBox
                int Id = Convert.ToInt32(cbo_TipoMovimiento.SelectedValue);
                dgv_movimientoStock.DataSource = _MovimientoStock.BuscarMovimientoStock(dtp_fecha_inicio.Value, dtp_fecha_fin.Value,Id);


                lbl_total.Text = $"Total de Movimientos: {dgv_movimientoStock.Rows.Count}";
                lbl_resultado.Text = "Para volver a ver el listado completo, 'Limpiar' el campo.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Presupuestos: " + ex.Message, "ERROR");
                lbl_resultado.Text = "Error al buscar Presupuestos.";
            }
        }

        private void cbo_TipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoMovimiento.SelectedValue != null && cbo_TipoMovimiento.SelectedValue is int)
            {
                CargarGrilla();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
