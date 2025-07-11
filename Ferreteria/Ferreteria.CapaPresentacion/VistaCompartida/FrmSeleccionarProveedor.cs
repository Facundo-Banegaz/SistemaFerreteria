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
    public partial class FrmSeleccionarProveedor : Form
    {
        private List<Proveedor> listaProveedores;

        // Definís un delegado y un evento para pasar datos
        public delegate void ProveedorSeleccionadoHandler(string Id_Proveedor, string Nombre, string SectorComercial);
        public event ProveedorSeleccionadoHandler ProveedorSeleccionado;
        public FrmSeleccionarProveedor()
        {
            InitializeComponent();
            Text = "Seleccionar Proveedor:";
        }

        private void FrmSeleccionarProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_proveedor);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarMarca();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_Proveedor"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto
            dgv_productos.Columns["SectorComercial"].Width = 800;// nombre_producto

            dgv_productos.Columns["Id_Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["SectorComercial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;





            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView

            CN_Proveedor _Proveedor = new CN_Proveedor();

            listaProveedores = _Proveedor.ListaProveedor();

            dgv_proveedor.DataSource = listaProveedores;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_proveedor.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarMarca()
        {
            CN_Proveedor _Proveedor = new CN_Proveedor();


            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_proveedor.DataSource = _Proveedor.ProveedorBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_proveedor.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void dgv_proveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Proveedor = Convert.ToString(this.dgv_proveedor.CurrentRow.Cells["Id_Proveedor"].Value);
            string Nombre = Convert.ToString(this.dgv_proveedor.CurrentRow.Cells["Nombre"].Value);
            string SectorComercial = Convert.ToString(this.dgv_proveedor.CurrentRow.Cells["SectorComercial"].Value);
            // Invocás el evento si hay algún método suscripto
            ProveedorSeleccionado?.Invoke(Id_Proveedor, Nombre, SectorComercial);
            this.Close();
        }
    }
}
