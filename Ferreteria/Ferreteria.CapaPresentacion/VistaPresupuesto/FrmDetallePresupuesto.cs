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

namespace Ferreteria.CapaPresentacion.VistaPresupuesto
{
    public partial class FrmDetallePresupuesto : Form
    {

        private Presupuesto _Presupuesto;



        public FrmDetallePresupuesto()
        {
            InitializeComponent();
            Text = "Detalles del Presupuesto:";
        }

        public FrmDetallePresupuesto(Presupuesto presupuesto)
        {
            InitializeComponent();
            this._Presupuesto = presupuesto;
        }

        private void FrmDetallePresupuesto_Load(object sender, EventArgs e)
        {
            MostrarDetalles();
            ArregloDataGridView(dgv_detalles);
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_detalles.Rows.Count);
        }

        private void MostrarDetalles()
        {

            CN_DetallePresupuesto _Detalle_Presupuesto = new CN_DetallePresupuesto();

            dgv_detalles.DataSource = _Detalle_Presupuesto.ListaDetallePresupuesto(_Presupuesto.Id_Presupuesto);

        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.Columns["Id_detallePresupuesto"].Visible = false;

            dgv_productos.Columns["Presupuesto"].Visible = false;




            dgv_productos.Columns["Producto"].Width = 350;// nombre_producto
            dgv_productos.Columns["Cantidad"].Width = 300;// Categoria
            dgv_productos.Columns["PrecioUnitario"].Width = 300;// Categoria
            dgv_productos.Columns["Subtotal"].Width = 300;// Presentacion

            dgv_productos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PrecioUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N0";


            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["PrecioUnitario"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Cantidad"].DefaultCellStyle.FormatProvider = culturaAR;

            // Si Stock también es decimal:
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Subtotal"].DefaultCellStyle.FormatProvider = culturaAR;

            _Metodos.AlternarColor(dgv_productos);
        }
   

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
