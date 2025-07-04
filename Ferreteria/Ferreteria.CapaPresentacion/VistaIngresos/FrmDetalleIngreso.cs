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

namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmDetalleIngreso : Form
    {
        private Ingreso _Ingreso;
        public FrmDetalleIngreso()
        {
        
            InitializeComponent();
            Text = "Detalles de Ingreso:";
        }
        public FrmDetalleIngreso( Ingreso ingreso)
        {

            InitializeComponent();
            this._Ingreso = ingreso;    
        }

        private void FrmDetalleIngreso_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }

        private void MostrarDetalles()
        {

            CN_DetalleIngreso _Detalle_Ingreso = new CN_DetalleIngreso();

            dgv_detalles.DataSource = _Detalle_Ingreso.ListaDetalleIngreso(_Ingreso.Id_Ingreso);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_detalleIngreso"].Visible = false;
      
            dgv_productos.Columns["Ingreso"].Visible = false;




            dgv_productos.Columns["Producto"].Width = 450;// nombre_producto
            dgv_productos.Columns["PrecioCompra"].Width = 300;// nombre_producto
            dgv_productos.Columns["Cantidad"].Width = 300;// Categoria
            dgv_productos.Columns["Subtotal"].Width = 300;// Presentacion


            dgv_productos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PrecioCompra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N0";

            _Metodos.AlternarColor(dgv_productos);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
