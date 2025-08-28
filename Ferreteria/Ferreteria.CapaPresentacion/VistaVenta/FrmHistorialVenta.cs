using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaIngresos;
using Ferreteria.CapaPresentacion.VistaReporte;
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
        private CN_DetalleVenta _CNDetalleVenta = new CN_DetalleVenta();

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

        private void ArregloDataGridView(DataGridView dgv_ventas)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_ventas.Columns["Presupuesto"].Visible = false;
       

            dgv_ventas.Columns["Id_Venta"].Width = 300;
            dgv_ventas.Columns["Usuario"].Width = 400; 
            dgv_ventas.Columns["Fecha"].Width = 350;
            dgv_ventas.Columns["Tipo_Comprobante"].Width = 400; // nombre_producto
            dgv_ventas.Columns["Serie"].Width = 400; // descripcion_producto 
            dgv_ventas.Columns["Correlativo"].Width = 400;
            dgv_ventas.Columns["Cliente"].Width = 400;
            dgv_ventas.Columns["Estado"].Width = 400; // nombre_producto
            dgv_ventas.Columns["MetodoPago"].Width = 500; // descripcion_producto 
            dgv_ventas.Columns["Total"].Width = 500; // descripcion_producto 




            foreach (DataGridViewColumn col in dgv_ventas.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_ventas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
   
            dgv_ventas.Columns["Total"].DefaultCellStyle.Format = "N0";

            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_ventas.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgv_ventas.Columns["Total"].DefaultCellStyle.FormatProvider = culturaAR;

            _Metodos.AlternarColor(dgv_ventas);
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

            Venta seleccionado = null;

            if (dgv_ventas.CurrentRow != null)
            {
                // Primera confirmación general
                DialogResult confirmar = MessageBox.Show(
                    "¿Desea imprimir el comprobante de venta con sus datos y el detalle completo?",
                    "Confirmar impresión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;

                    // Segunda confirmación: tipo de comprobante
                    DialogResult tipo = MessageBox.Show(
                        "Selecciona el tipo de impresión:\nSí: Ticket\nNo: Boleta normal\nCancelar",
                        "Tipo de Comprobante",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);

                    if (tipo == DialogResult.Yes)
                    {
                        // Imprimir Ticket
                        ImprimirTicketVenta(seleccionado);
                    }
                    else if (tipo == DialogResult.No)
                    {
                        // Imprimir Boleta normal
                        ImprimirBoletaVenta(seleccionado);
             
                    }
           
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void ImprimirBoletaVenta(Venta venta)
        {
            FrmReporteFacturaVenta frmReporte = new FrmReporteFacturaVenta(venta);
            frmReporte.ShowDialog();
        }

        private void ImprimirTicketVenta(Venta seleccionado)
        {
            CrearTicket ticket = new CrearTicket();


            // Encabezado
            CN_ConfigurarTicket cnConfiguracion = new CN_ConfigurarTicket();
            ConfigurarTicket config = cnConfiguracion.ObtenerConfiguracion();



            // Encabezado

            ticket.TextoCentro(config.NombreNegocio, true);
            ticket.TextoCentro(config.TextoVenta, false);
            ticket.TextoIzquierda("CIUDAD: " + config.Ciudad);
            ticket.TextoIzquierda("DIREC: " + config.Direccion);
            ticket.TextoIzquierda("TELEF: " + config.Telefono);
            ticket.TextoIzquierda("C.U.I.T: " + config.CUIT);
            ticket.TextoIzquierda("EMAIL: " + config.Email);
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("Comprobante N°: " + seleccionado.Serie + "-" + seleccionado.Correlativo);

            ticket.lineasGuion();

            // Datos cliente
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("VENDEDOR: " + seleccionado.Usuario);
            ticket.TextoIzquierda("CLIENTE: " + seleccionado.Cliente);
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + seleccionado.Fecha.ToString("dd/MM/yyyy"), "HORA: " + seleccionado.Fecha.ToString("HH:mm:ss"));
            ticket.lineasGuion();


            // Encabezado de ítems
            ticket.EncabezadoVenta();
            ticket.lineasGuion();

            var detalles = _CNDetalleVenta.ObtenerDetalleVenta(seleccionado.Id_Venta);


            foreach (var item in detalles)
            {
                ticket.AgregaArticulo(item.Producto.Nombre, item.Cantidad, item.PrecioVenta);
            }



            ticket.lineasGuion();
            ticket.TextoCentro("Total:" + seleccionado.Total.ToString("C2", new CultureInfo("es-AR")), true);

            ticket.lineasGuion();

            ticket.TextoCentro("Total de Items: " + detalles.Sum(d => d.Cantidad), false);
            ticket.lineasGuion();


            ticket.TextoCentro(config.TextoNoFactura);
            ticket.TextoIzquierda("");
            ticket.TextoCentro(config.FraseDespedidaVenta);

            ticket.CortaTicket();
            // Imprimir en la impresora POS
            ticket.ImprimirTicket(config.NombreImpresoraTermica);
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

            CN_Venta _Venta= new CN_Venta();
            Venta seleccionado = null;

            try
            {
                if (dgv_ventas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show(
                        "¿Quieres anular esta Venta?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        DialogResult segundaRespuesta = MessageBox.Show(
                            "⚠️ Esta acción es irreversible.\n\n¿Estás completamente seguro de anular la Venta?",
                            "Advertencia Final",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Stop);

                        if (segundaRespuesta == DialogResult.Yes)
                        {
                            seleccionado = (Venta)dgv_ventas.CurrentRow.DataBoundItem;
                            _Venta.AnularVenta(seleccionado.Id_Venta);

                            CargarGrilla();
                            MessageBox.Show(
                                "Venta anulada correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        private bool ConfirmarCambioEstadoVenta(Venta venta)
        {
            string accion = venta.Estado == "ANULADO" ? "reactivar" : "anular";
            string titulo = venta.Estado == "ANULADO" ? "Reactivar Venta" : "Anular Venta";

            DialogResult respuesta = MessageBox.Show(
                $"¿Desea {accion} esta venta?",
                titulo,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return respuesta == DialogResult.Yes;
        }

        private void MostrarMensajeExitoVenta(string estadoAnterior)
        {
            string mensaje = estadoAnterior == "ANULADO"
                ? "Venta reactivada correctamente."
                : "Venta anulada correctamente.";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
