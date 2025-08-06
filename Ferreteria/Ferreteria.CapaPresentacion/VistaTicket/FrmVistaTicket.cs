using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaMarca;
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
    public partial class FrmVistaTicket : Form
    {


        public FrmVistaTicket()
        {
            InitializeComponent();
            Text = "Gestion Configuración de Ticket:";
        }
  


        private void FrmVistaTicket_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_ticket);
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ConfigurarTicket seleccionado = null;

            if (dgv_ticket.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Configurar Ticket ?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (ConfigurarTicket)dgv_ticket.CurrentRow.DataBoundItem;
                    FrmEditarTicket frmEditar = new FrmEditarTicket(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }
        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_ticket)
        {
            // Lógica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_ticket.Columns["Id_ConfiguracionTicket"].Width = 200;
            dgv_ticket.Columns["NombreNegocio"].Width = 250;
            dgv_ticket.Columns["Ciudad"].Width = 250;
            dgv_ticket.Columns["Direccion"].Width = 250;
            dgv_ticket.Columns["Telefono"].Width = 250;
            dgv_ticket.Columns["CUIT"].Width = 150;
            dgv_ticket.Columns["Email"].Width = 250;
            dgv_ticket.Columns["TextoVenta"].Width = 300;
            dgv_ticket.Columns["TextoPresupuesto"].Width = 300;
            dgv_ticket.Columns["TextoNoFactura"].Width = 300;
            dgv_ticket.Columns["FraseDespedidaPresupuesto"].Width = 300;
            dgv_ticket.Columns["FraseDespedidaVenta"].Width = 300;
            dgv_ticket.Columns["NombreImpresoraTermica"].Width = 280;

            // Alineación centrada para todas las columnas
            foreach (DataGridViewColumn col in dgv_ticket.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            _Metodos.AlternarColor(dgv_ticket);
        }

        private void CargarGrilla()
        {
            //logica del dataGridView
             CN_ConfigurarTicket _CN_Configuracion = new CN_ConfigurarTicket();
             ConfigurarTicket config = _CN_Configuracion.ObtenerConfiguracion();



            dgv_ticket.DataSource = new List<ConfigurarTicket> { config };

        }

    }
}
