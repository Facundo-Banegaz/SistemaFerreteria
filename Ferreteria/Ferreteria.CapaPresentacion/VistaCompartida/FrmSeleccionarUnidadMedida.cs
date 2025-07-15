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
    public partial class FrmSeleccionarUnidadMedida : Form
    {
        private List<UnidadMedida> listaUnidadMedida;
        // Definís un delegado y un evento para pasar datos
        public delegate void UnidadMedidaSeleccionadoHandler(string Id_UnidadMedida, string Nombre, bool PermiteDecimales);
        public event UnidadMedidaSeleccionadoHandler UnidadMedidaSeleccionada;
        public FrmSeleccionarUnidadMedida()
        {
            InitializeComponent();
            Text = "Seleccionar Unidad Medida:";
        }

        private void FrmSeleccionarUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_unidadMedida);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarUnidadMedida();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_UnidadMedida"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto
            dgv_productos.Columns["Abreviacion"].Width = 800;// nombre_producto
            dgv_productos.Columns["PermiteDecimales"].Width = 800;// nombre_producto

            dgv_productos.Columns["Id_UnidadMedida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dgv_productos.Columns["Abreviacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PermiteDecimales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_UnidadMedida _UnidadMedida = new CN_UnidadMedida();

            listaUnidadMedida = _UnidadMedida.ListaUnidadMedida();

            dgv_unidadMedida.DataSource = listaUnidadMedida;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_unidadMedida.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarUnidadMedida()
        {
            CN_UnidadMedida _UnidadMedida = new CN_UnidadMedida();


            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_unidadMedida.DataSource = _UnidadMedida.UnidadMedidaBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_unidadMedida.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void dgv_unidadMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_UnidadMedida = Convert.ToString(this.dgv_unidadMedida.CurrentRow.Cells["Id_UnidadMedida"].Value);
            string Nombre = Convert.ToString(this.dgv_unidadMedida.CurrentRow.Cells["Nombre"].Value);
            bool PermiteDecimales = Convert.ToBoolean(this.dgv_unidadMedida.CurrentRow.Cells["PermiteDecimales"].Value);
            // Invocás el evento si hay algún método suscripto
            UnidadMedidaSeleccionada?.Invoke(Id_UnidadMedida,  Nombre,  PermiteDecimales);

            this.Close();
        }
    }
}
