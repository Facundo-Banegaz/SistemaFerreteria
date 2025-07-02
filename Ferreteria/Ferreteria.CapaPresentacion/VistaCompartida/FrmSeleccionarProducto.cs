using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaEspecificacion;
using Ferreteria.CapaPresentacion.VistaIngresos;
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
    public partial class FrmSeleccionarProducto : Form
    {

        private List<Producto> ListarProducto;
        // Definís un delegado y un evento para pasar datos
        public delegate void ProductoSeleccionadoHandler(string Id_Producto, string Nombre);
        public event ProductoSeleccionadoHandler ProductoSeleccionado;
        public FrmSeleccionarProducto()
        {
            InitializeComponent();
            Text = "Seleccionar Producto";
        }

 
       
    

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Producto = Convert.ToString(this.dgv_productos.CurrentRow.Cells["Id_Producto"].Value);
            string Nombre = Convert.ToString(this.dgv_productos.CurrentRow.Cells["Nombre"].Value);

            // Invocás el evento si hay algún método suscripto
            ProductoSeleccionado?.Invoke(Id_Producto, Nombre);

            this.Close();

        }

        private void FrmSeleccionarProducto_Load(object sender, EventArgs e)
        {
        
            CargarGrilla();
            ArregloDataGridView(dgv_productos);
        }

     



        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();



            //dgv_productos.Columns["Id_Producto"].Visible = false;
            dgv_productos.Columns["Id_Producto"].Width = 120;
            dgv_productos.Columns["Codigo"].Width = 300;
            dgv_productos.Columns["Nombre"].Width = 400;
            dgv_productos.Columns["Precio"].Width = 200;
            dgv_productos.Columns["Stock"].Width = 100;
            dgv_productos.Columns["StockMinimo"].Width = 120;
            dgv_productos.Columns["Descripcion"].Width = 600;
            dgv_productos.Columns["FechaUltimaActualizacionPrecio"].Width = 300;
     
            dgv_productos.Columns["Subcategoria"].Width = 300;

            dgv_productos.Columns["Marca"].Width = 250;
            dgv_productos.Columns["UnidadMedida"].Width = 200;


            dgv_productos.Columns["Id_Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["StockMinimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Subcategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
     
            dgv_productos.Columns["Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["UnidadMedida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["FechaUltimaActualizacionPrecio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
           
            CN_Producto _Producto = new CN_Producto();

            ListarProducto = _Producto.ListaProductos();

            dgv_productos.DataSource = ListarProducto;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_productos.Rows.Count);
            lbl_resultado.Text = "";

        }


        private void BuscarProducto()
        {
            CN_Producto producto = new CN_Producto();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
                CargarGrilla();
            }
            else
            {
                dgv_productos.DataSource = producto.BuscarProducto(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_productos.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto();
                txt_buscar.Clear();     // limpia el campo
                txt_buscar.Focus();     // focus
            }
        }

    

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            BuscarProducto();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {

            txt_buscar.Clear();
            CargarGrilla();
        }


    }
}
