using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaTicket
{
    public partial class FrmCrearTicketVenta : Form
    {
        public FrmCrearTicketVenta()
        {
            InitializeComponent();
        }

        private void FrmCrearTicketVenta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_crearTicket_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    //Creamos una instancia d ela clase CrearTicket
            //    CrearTicket ticket = new CrearTicket();


            //    //Ya podemos usar todos sus metodos
            //    ticket.AbreCajon();//Para abrir el cajon de dinero.
            //                       //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            //                       //Datos de la cabecera del Ticket.

            //    ticket.TextoCentro("FERRETERIA Sa¿AN MIGUEL");
            //    ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            //    ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            //    ticket.TextoIzquierda("TELEF: 4530000");
            //    ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            //    ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            //    ticket.TextoIzquierda("");
            //    ticket.TextoExtremos("Caja # 1", "Ticket # 002-");
            //    ticket.lineasAsteriscos();

            //    //Sub cabecera.
            //    ticket.TextoIzquierda("");
            //    ticket.TextoIzquierda("ATENDIO: " + "VENDEDOR");
            //    ticket.TextoIzquierda("CLIENTE:" + "CONSUMIDOR FINAL");
            //    ticket.TextoIzquierda("");
            //    ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortDateString());
            //    ticket.lineasAsteriscos();



            //    //Articulos a vender.
            //    ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            //    ticket.lineasAsteriscos();
            //    foreach (DataGridViewRow fila    dgvLista.Rows)
            //    { 
            //        ticket.AgregaArticulo(fila.Cells[2].Value.ToString()), int.Parse(fila.Cells[5].Value.ToString());
    
            //        decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString());
            //    }


            //    ticket.AgregaArticulo("Articulo A", 2, 20);
            //    ticket.AgregaArticulo("Articulo B", 1, 10);
            //    ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan ",3,4);

            //    ticket.lineasIgual();

            //    //Resumen de la venta.

            //    ticket.AgregarTotales(" SUBTOTAL... $", 100);
            //    ticket.AgregarTotales("TOTAL... $", 1000);
            //    ticket.TextoIzquierda("");
            //    ticket.AgregarTotales("EFECTIVO... $", 1000);
            //    ticket.AgregarTotales("CAMBIO", 300);
                

            //    //Texto final del Ticket.
            //    ticket.TextoIzquierda("");
            //    ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: " + detalles.Count);
            //    ticket.TextoIzquierda("");
            //    ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            //    ticket.CortaTicket();


            //    ticket.ImprimirTicket("POS-58");
            //}
            //catch (Exception eeee) { }
        }
    }
}
