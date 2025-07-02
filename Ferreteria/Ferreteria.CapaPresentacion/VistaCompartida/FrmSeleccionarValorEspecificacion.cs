using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaCompartida
{
    public partial class FrmSeleccionarValorEspecificacion : Form
    {
        private List<ValorEspecificacion> ListaValorEspecificacion;
        // Definís un delegado y un evento para pasar datos
        public delegate void ValorEspecificacionSeleccionadoHandler(string Id_ValorEspecificacion, string Valor);
        public event ValorEspecificacionSeleccionadoHandler ValorEspecificacionSeleccionado;
        public FrmSeleccionarValorEspecificacion()
        {
            InitializeComponent();
            Text = "Selecciona Valor  Especificaión:";
        }

        private void FrmSeleccionarValorEspecificacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_valorEspecificacion);
        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_ValorEspecificacion"].Visible = false;

            dgv_productos.Columns["Id_ValorEspecificacion"].Width = 400;
            dgv_productos.Columns["Valor"].Width = 1000;// nombre_producto


            dgv_productos.Columns["Id_ValorEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_ValorEspecificacion _logicaValorEspecificacion = new CN_ValorEspecificacion();

            ListaValorEspecificacion = _logicaValorEspecificacion.listaValorEspecificacion();

            dgv_valorEspecificacion.DataSource = ListaValorEspecificacion;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_valorEspecificacion.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void dgv_valorEspecificacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_ValorEspecificacion = Convert.ToString(this.dgv_valorEspecificacion.CurrentRow.Cells["Id_ValorEspecificacion"].Value);
            string Valor = Convert.ToString(this.dgv_valorEspecificacion.CurrentRow.Cells["Valor"].Value);

            // Invocás el evento si hay algún método suscripto
            ValorEspecificacionSeleccionado?.Invoke(Id_ValorEspecificacion, Valor);

            this.Close();

        }
    }
}
