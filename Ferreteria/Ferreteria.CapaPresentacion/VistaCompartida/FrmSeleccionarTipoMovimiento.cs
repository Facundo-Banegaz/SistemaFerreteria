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
    public partial class FrmSeleccionarTipoMovimiento : Form
    {
        private List<TipoMovimiento> ListarTipoMovimiento;

        public FrmSeleccionarTipoMovimiento()
        {
            InitializeComponent();
            Text = "Seleccionar TipoMovimiento";

        }

        private void dgv_marcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSeleccionarTipoMovimiento_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_TipoMovimiento);
        }
        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            //dgv_productos.Columns["Id_Producto"].Visible = false;
            dgv_productos.Columns["Id_TipoMovimiento"].Width = 120;
            dgv_productos.Columns["Movimiento"].Width = 300;
            dgv_productos.Columns["Nombre"].Width = 400;
            dgv_productos.Columns["Descripcion"].Width = 600;
    



            dgv_productos.Columns["Id_TipoMovimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Movimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
  


            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView

            CN_TipoMovimiento  _TipoMovimiento = new CN_TipoMovimiento();

           ListarTipoMovimiento  = _TipoMovimiento.ListarTodosLosTipoMovimiento();

            dgv_TipoMovimiento.DataSource = ListarTipoMovimiento;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_TipoMovimiento.Rows.Count);
      

        }

    }
}
