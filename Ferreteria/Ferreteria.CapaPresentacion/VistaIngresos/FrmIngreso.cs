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

namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmIngreso : Form
    {

        private List<Ingreso> Listaingresos;
        public Usuario _Usuario;
        public FrmIngreso()
        {
            InitializeComponent();
            Text = "Gestion Historial de  Ingresos";
        }
        public FrmIngreso(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
        }
        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_ingresos);
     
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Ingreso _Ingreso = new CN_Ingreso();

            Listaingresos = _Ingreso.ListaIngreso();

            dgv_ingresos.DataSource = Listaingresos;
            int anulados = 0;
            int emitidos = 0;

            foreach (DataGridViewRow fila in dgv_ingresos.Rows)
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

            lbl_total.Text = "Total de Ingresos: " + Convert.ToString(dgv_ingresos.Rows.Count);
            lbl_anulados.Text = "Ingresos Anulados: " + Convert.ToString(anulados);
            lbl_emitidos.Text = "Ingresos Emitidos: " + Convert.ToString(emitidos);

        }

  

        private void ArregloDataGridView(DataGridView dgv_ingresos)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


          

            dgv_ingresos.Columns["Id_ingreso"].Width = 300;
            dgv_ingresos.Columns["Usuario"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Proveedor"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Fecha"].Width = 350;
            dgv_ingresos.Columns["Tipo_comprobante"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Serie"].Width = 400; // descripcion_producto 
            dgv_ingresos.Columns["Correlativo"].Width = 400;
       
            dgv_ingresos.Columns["Estado"].Width = 400; // nombre_producto
            dgv_ingresos.Columns["Total"].Width = 500; // descripcion_producto 


         

            dgv_ingresos.Columns["Id_ingreso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Tipo_comprobante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Serie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Correlativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_ingresos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N0";

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_ingresos.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgv_ingresos.Columns["Total"].DefaultCellStyle.FormatProvider = culturaAR;

            _Metodos.AlternarColor(dgv_ingresos);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            BuscarFechas();
        }

        private void BuscarFechas()
        {
            CN_Ingreso _Ingreso = new CN_Ingreso();


            if (dtp_fecha_inicio.Value.Date > dtp_fecha_fin.Value.Date)
            {
                MessageBox.Show("La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.", "ADVERTENCIA");
                lbl_resultado.Text = "La fecha de 'Inicio' no puede ser mayor que la fecha de 'Fin'.";
                return;
            }


            try
            {
                dgv_ingresos.DataSource = _Ingreso.IngresoBuscarFecha(dtp_fecha_inicio.Value, dtp_fecha_fin.Value);

                // Limpiar conteos
                int anulados = 0;
                int emitidos = 0;

                foreach (DataGridViewRow fila in dgv_ingresos.Rows)
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

                lbl_total.Text = $"Total de Registros Encontrados: {dgv_ingresos.Rows.Count}";
                lbl_anulados.Text = $"Ingresos Anulados: {anulados}";
                lbl_emitidos.Text = $"Ingresos Emitidos: {emitidos}";
                lbl_resultado.Text = "Para volver a ver el listado completo, 'Limpiar' el campo.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar ingresos: " + ex.Message, "ERROR");
                lbl_resultado.Text = "Error al buscar ingresos.";
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            // Establecer la fecha actual como valor por defecto
            dtp_fecha_inicio.Value = DateTime.Today;
            dtp_fecha_fin.Value = DateTime.Today;



            CargarGrilla();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarIngreso frmAgregar = new FrmAgregarEditarIngreso(_Usuario);
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            Ingreso seleccionado = null;

            if (dgv_ingresos.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle este Ingreso?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Ingreso)dgv_ingresos.CurrentRow.DataBoundItem;

                    FrmDetalleIngreso frmDetalle = new FrmDetalleIngreso(seleccionado);
                    frmDetalle.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_ingresos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un ingreso de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var seleccionado = (Ingreso)dgv_ingresos.CurrentRow.DataBoundItem;

                if (!ConfirmarCambioEstado(seleccionado)) return;

                var ingresoService = new CN_Ingreso();
                ingresoService.CambiarEstadoIngreso(seleccionado.Id_Ingreso);

                CargarGrilla();

                MostrarMensajeExito(seleccionado.Estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ConfirmarCambioEstado(Ingreso ingreso)
        {
            string accion = ingreso.Estado == "ANULADO" ? "reactivar" : "anular";
            string titulo = ingreso.Estado == "ANULADO" ? "Reactivar Ingreso" : "Anular Ingreso";

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea {accion} este ingreso?",
                titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return respuesta == DialogResult.Yes;
        }

        private void MostrarMensajeExito(string estadoAnterior)
        {
            string mensaje = estadoAnterior == "ANULADO"
                ? "Ingreso reactivado correctamente."
                : "Ingreso anulado correctamente.";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgv_ingresos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var fila = dgv_ingresos.Rows[e.RowIndex];

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
