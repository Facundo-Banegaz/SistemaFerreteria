using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaIngresos;
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
    public partial class FrmHistorialVenta : Form
    {

        private List<Venta> ListaVentas;
        public Usuario _Usuario;
        public FrmHistorialVenta()
        {
            InitializeComponent();
            Text = "Gestion Historial Ventas";
        }

        public FrmHistorialVenta(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
        }



        private void FrmHistorialVenta_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_ventas);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Venta cN_Venta = new CN_Venta();

            ListaVentas = cN_Venta.ListaVenta();

            dgv_ventas.DataSource = ListaVentas;
            int anulados = 0;
            int emitidos = 0;

            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                if (fila.Cells["Estado"].Value != null)
                {
                    string estado = fila.Cells["Estado"].Value.ToString();

                    if (estado.Equals("Anulado", StringComparison.OrdinalIgnoreCase))
                    {
                        anulados++;

                    }
                    else if (estado.Equals("Emitido", StringComparison.OrdinalIgnoreCase))
                    {
                        emitidos++;
                    }
                }
            }

            lbl_total.Text = "Total de Ingresos: " + Convert.ToString(dgv_ventas.Rows.Count);
            lbl_anulados.Text = "Ingresos Anulados: " + Convert.ToString(anulados);
            lbl_emitidos.Text = "Ingresos Emitidos: " + Convert.ToString(emitidos);

        }

        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_ingresos.Columns["Presupuesto"].Visible = false;
       

            dgv_ingresos.Columns["Id_Venta"].Width = 300;
            dgv_ingresos.Columns["Usuario"].Width = 400; 
            dgv_ingresos.Columns["Fecha"].Width = 350;
            dgv_ingresos.Columns["Tipo_Comprobante"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Serie"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Correlativo"].Width = 400;

            dgv_ingresos.Columns["Estado"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["MetodoPago"].Width = 500; // descripcion_producto 
            dgv_ingresos.Columns["Total"].Width = 500; // descripcion_producto 

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgv_ingresos.Columns["Total"].DefaultCellStyle.FormatProvider = culturaAR;



            dgv_ingresos.Columns["Id_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Tipo_comprobante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Correlativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_ingresos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["MetodoPago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_ingresos);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarFechas();
        }
        private void BuscarFechas()
        {
            
            CN_Venta cN_Venta = new CN_Venta();


            if (dtp_fecha_inicio.Value.Date > dtp_fecha_fin.Value.Date)
            {
                MessageBox.Show("La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.", "ADVERTENCIA");
                lbl_resultado.Text = "La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.";
                return;
            }


            try
            {
                dgv_ventas.DataSource = cN_Venta.VentaBuscarFecha(dtp_fecha_inicio.Value, dtp_fecha_fin.Value);

                // Limpiar conteos
                int anulados = 0;
                int emitidos = 0;

                foreach (DataGridViewRow fila in dgv_ventas.Rows)
                {
                    if (fila.Cells["Estado"].Value != null)
                    {
                        string estado = fila.Cells["Estado"].Value.ToString();

                        if (estado.Equals("Anulado", StringComparison.OrdinalIgnoreCase))
                            anulados++;
                        else if (estado.Equals("Emitido", StringComparison.OrdinalIgnoreCase))
                            emitidos++;
                    }
                }

                lbl_total.Text = $"Total de Registros Encontrados: {dgv_ventas.Rows.Count}";
                lbl_anulados.Text = $"Ingresos Anulados: {anulados}";
                lbl_emitidos.Text = $"Ingresos Emitidos: {emitidos}";
                lbl_resultado.Text = "Para volver a ver el listado completo, 'Limpiar' el campo.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Ventas: " + ex.Message, "ERROR");
                lbl_resultado.Text = "Error al buscar Ventas.";
            }
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Establecer la fecha actual como valor por defecto
            dtp_fecha_inicio.Value = DateTime.Today;
            dtp_fecha_fin.Value = DateTime.Today;



            CargarGrilla();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            Venta seleccionado = null;

            if (dgv_ventas.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle esta Venta?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;

                    FrmDetalleVenta frmDetalle = new FrmDetalleVenta(seleccionado);
                    frmDetalle.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarVenta frmAgregar = new FrmAgregarVenta(_Usuario);
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            CN_Venta cN_Venta = new CN_Venta();

            Venta seleccionado = null;


            try
            {
                if (dgv_ventas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Anular esta Venta?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;
                        cN_Venta.AnularVenta(seleccionado.Id_Venta);

                        CargarGrilla();
                        MessageBox.Show("Venta Anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_ventas_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var fila = dgv_ventas.Rows[e.RowIndex];

            if (fila.Cells["Estado"].Value != null)
            {
                string estado = fila.Cells["Estado"].Value.ToString();

                if (estado.Equals("Anulado", StringComparison.OrdinalIgnoreCase))
                {
                    fila.DefaultCellStyle.BackColor = Color.DarkRed;
                    fila.DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }
    }
}
