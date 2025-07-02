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
    public partial class FrmSeleccionarTipoEspecificacion : Form
    {
        private List<TipoEspecificacion> ListaTipoEspecificacion;
        // Definís un delegado y un evento para pasar datos
        public delegate void TipoEspecificacionSeleccionadoHandler(string Id_TipoEspecificacion, string Nombre);
        public event TipoEspecificacionSeleccionadoHandler TipoEspecificacioneleccionado;

        public FrmSeleccionarTipoEspecificacion()
        {
            InitializeComponent();
            Text = "Seleccionar Tipo Especificacion";
        }

        private void dgv_TipoEspecificacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_TipoEspecificacion = Convert.ToString(this.dgv_TipoEspecificacion.CurrentRow.Cells["Id_TipoEspecificacion"].Value);
            string Nombre = Convert.ToString(this.dgv_TipoEspecificacion.CurrentRow.Cells["Nombre"].Value);

            // Invocás el evento si hay algún método suscripto
            TipoEspecificacioneleccionado?.Invoke(Id_TipoEspecificacion, Nombre);

            this.Close();
        }

        private void FrmSeleccionarTipoEspecificacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_TipoEspecificacion);
        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_TipoEspecificacion"].Visible = false;

            dgv_productos.Columns["Id_TipoEspecificacion"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 1000;// nombre_producto


            dgv_productos.Columns["Id_TipoEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_TipoEspecificacion _logicaTipoEspecificacion = new CN_TipoEspecificacion();

            ListaTipoEspecificacion = _logicaTipoEspecificacion.ListaTipoEspecificacion();

            dgv_TipoEspecificacion.DataSource = ListaTipoEspecificacion;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_TipoEspecificacion.Rows.Count);
            lbl_resultado.Text = "";

        }
    }
}
