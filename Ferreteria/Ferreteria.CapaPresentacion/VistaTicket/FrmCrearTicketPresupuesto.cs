using Ferreteria.CapaDominio;
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

namespace Ferreteria.CapaPresentacion.VistaTicket
{
    public partial class FrmCrearTicketPresupuesto : Form
    {
        public FrmCrearTicketPresupuesto()
        {
            InitializeComponent();
        }

        private void Btn_crearTicket_Click(object sender, EventArgs e)
        {
            try
            {

                // Instancia del ticket
                CrearTicket ticket = new CrearTicket();

                // Abrir cajón de dinero (si corresponde)
                ticket.AbreCajon();

                // Datos del local
                ticket.TextoCentro("CORRALON SAN MIGUEL", true);
                ticket.TextoCentro("TICKET DE PRESUPUESTO", false);

                ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
                ticket.TextoIzquierda("DIREC: AV. 24 DE SEPTIEMBRE");
                ticket.TextoIzquierda("TELEF: 3856654232");
                ticket.TextoIzquierda("C.U.I.T: XXXXXXXXX-XX");
                ticket.TextoIzquierda("EMAIL: CorralonSanMiguel@gmail.com");
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("Caja #1", "Ticket #0001");
                ticket.lineasAsteriscos();

                // Datos del cliente y vendedor
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ATENDIO: VENDEDOR");
                ticket.TextoIzquierda("CLIENTE: CONSUMIDOR FINAL");
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("FECHA: " + DateTime.Now.ToString("dd/MM/yyyy"), "HORA: " + DateTime.Now.ToString("HH:mm:ss"));
                ticket.lineasAsteriscos();

                // Encabezado de venta
                ticket.EncabezadoVenta();
                ticket.lineasAsteriscos();

                // --- Agregar artículos desde DataGridView ---
                // Supongo que tienes un DataGridView llamado dgvLista con las columnas correctas.
                // Ejemplo corregido:
                //foreach (DataGridViewRow fila in dgvPresupuesto.Rows)
                //{
                //    if (fila.IsNewRow) continue; // Omitir fila vacía si aplica

                //    string nombreArticulo = fila.Cells[2].Value?.ToString() ?? "";
                //    int cantidad = 0;
                //    decimal precio = 0;

                //    // Validar y parsear cantidad y precio
                //    int.TryParse(fila.Cells[5].Value?.ToString(), out cantidad);
                //    decimal.TryParse(fila.Cells[4].Value?.ToString(), NumberStyles.Any, new CultureInfo("es-AR"), out precio);

                //    ticket.AgregaArticulo(nombreArticulo, cantidad, precio);
                //}

                // Si querés probar sin DataGridView, podés usar esto:
                // ticket.AgregaArticulo("Martillo Philips", 2, 6000);
                // ticket.AgregaArticulo("Disco de Amoladora", 1, 5500);
                // ticket.AgregaArticulo("Pincel N°2", 3, 2500);

                ticket.lineasIgual();

                // Totales (con formato de moneda y separadores de miles)
                ticket.AgregarTotales("SUBTOTAL  $", 14000m);
                ticket.AgregarTotales("TOTAL     $", 14000m);
                ticket.TextoIzquierda("");
                ticket.AgregarTotales("PAGO CON  $", 15000m);
                ticket.AgregarTotales("SU CAMBIO $", 1000m);

                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + 6);
                ticket.TextoIzquierda("");
                ticket.TextoCentro("¡GRACIAS POR SU COMPRA!", true);

                ticket.CortaTicket();

                // Imprimir en la impresora POS-58 (asegurate que el nombre coincida)
                ticket.ImprimirTicket("POS-58");

            }
            catch (Exception eeee) { }
        }

        private void FrmCrearTicketPresupuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
