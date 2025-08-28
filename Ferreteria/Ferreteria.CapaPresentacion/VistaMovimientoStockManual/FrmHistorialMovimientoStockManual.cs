using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using Ferreteria.CapaPresentacion.VistaMovimientoStock;
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

namespace Ferreteria.CapaPresentacion.VistaMovimientoStockManual
{
    public partial class FrmHistorialMovimientoStockManual : Form
    {

        private Usuario usuario;

        private List<MoviminetoStockDto> listaMovimientoStockManual;

        public FrmHistorialMovimientoStockManual()
        {
            InitializeComponent();
            Text = "Gestion Movimientos de Stock Manual";
        }
        public FrmHistorialMovimientoStockManual(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void FrmHistorialMovimientoStockManual_Load(object sender, EventArgs e)
        {

            CargarCbo();

            CargarGrilla();


            ArregloDataGridView(dgv_movimientoStock);
        }


        private void CargarCbo()
        {
            CN_TipoMovimiento _TipoMovimiento = new CN_TipoMovimiento();

            cbo_TipoMovimiento.DataSource = _TipoMovimiento.ListarTipoMovimientoStockManual();
            cbo_TipoMovimiento.ValueMember = "Id_TipoMovimiento";
            cbo_TipoMovimiento.DisplayMember = "Nombre";


        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_MovimientoStock _MovimientoStock = new CN_MovimientoStock();

            // Capturar el ID seleccionado del ComboBox
            int Id = Convert.ToInt32(cbo_TipoMovimiento.SelectedValue);

            listaMovimientoStockManual = _MovimientoStock.ListaMovimientoStockManual(Id);

            dgv_movimientoStock.DataSource = listaMovimientoStockManual;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_movimientoStock.Rows.Count);
            lbl_resultado.Text = "";

        }


        private void ArregloDataGridView(DataGridView dgv_productos)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            // Ocultar columnas innecesarias
            dgv_productos.Columns["Id_MovimientoStock"].Visible = false;
            dgv_productos.Columns["Id_DetalleMovimientoStock"].Visible = false;

            // Asignar ancho fijo a columnas críticas
            dgv_productos.Columns["Fecha"].Width = 250;
            dgv_productos.Columns["TipoMovimiento"].Width = 300;
            dgv_productos.Columns["Usuario"].Width = 250;
            dgv_productos.Columns["Producto"].Width = 350;
            dgv_productos.Columns["Cantidad"].Width = 200;
            dgv_productos.Columns["StockAnterior"].Width = 200;
            dgv_productos.Columns["StockNuevo"].Width = 200;
            dgv_productos.Columns["Observacion"].Width = 380;
            dgv_productos.Columns["ObservacionDetalle"].Width = 380;
            ////// Columnas restantes que pueden llenar el espacio
            ////dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Formatear decimales con cultura argentina
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["StockAnterior"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockAnterior"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["StockNuevo"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockNuevo"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // Alinear todo al centro
            foreach (DataGridViewColumn col in dgv_productos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            _Metodos.AlternarColor(dgv_productos);
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
                dgv_movimientoStock.DataSource = _MovimientoStock.BuscarMovimientosManual(dtp_fecha_inicio.Value, dtp_fecha_fin.Value, Id);


                lbl_total.Text = $"Total de Movimientos: {dgv_movimientoStock.Rows.Count}";
                lbl_resultado.Text = "Para volver a ver el listado completo, 'Limpiar' el campo.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Presupuestos: " + ex.Message, "ERROR");
                lbl_resultado.Text = "Error al buscar Presupuestos.";
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void cbo_TipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoMovimiento.SelectedValue != null && cbo_TipoMovimiento.SelectedValue is int)
            {
                CargarGrilla();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmMovimientoStockManual frmHistorialMovimientoStockManual = new FrmMovimientoStockManual(usuario);

            frmHistorialMovimientoStockManual.ShowDialog();
            CargarGrilla();
        }

        private void Btn_tiposMovimiento_Click(object sender, EventArgs e)
        {
            FrmSeleccionarTipoMovimiento seleccionarTipoMovimiento = new FrmSeleccionarTipoMovimiento();
            seleccionarTipoMovimiento.ShowDialog();
        }
    }
}
