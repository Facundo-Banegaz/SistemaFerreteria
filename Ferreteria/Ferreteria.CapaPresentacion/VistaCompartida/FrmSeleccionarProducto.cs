using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaEspecificacion;
using Ferreteria.CapaPresentacion.VistaIngresos;
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

namespace Ferreteria.CapaPresentacion.VistaCompartida
{
    public partial class FrmSeleccionarProducto : Form
    {

        private List<Producto> ListarProducto;
        // Definís un delegado y un evento para pasar datos
        public delegate void ProductoSeleccionadoHandler(string Id_Producto, string Nombre);
        public event ProductoSeleccionadoHandler ProductoSeleccionado;

        public delegate void ProductoIngresoSeleccionadoHandler(string Id_Producto, string Nombre,bool RequiereVencimiento,bool ActualizarPrecioAutomaticamente,bool PermiteDecimales  );
        public event ProductoIngresoSeleccionadoHandler ProductoIngresoSeleccionado;

        public delegate void ProductoVentaSeleccionadoHandler(string Id_Producto, string Nombre, decimal Precio, decimal Stock, string Codigo, bool PermiteDecimales);
        public event ProductoVentaSeleccionadoHandler ProductoVentaSeleccionado;
        public FrmSeleccionarProducto()
        {
            InitializeComponent();
            Text = "Seleccionar Producto";
        }

 
       
    

        private void dgv_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Producto = Convert.ToString(this.dgv_productos.CurrentRow.Cells["Id_Producto"].Value);
            string Nombre = Convert.ToString(this.dgv_productos.CurrentRow.Cells["Nombre"].Value);
            string Codigo = Convert.ToString(this.dgv_productos.CurrentRow.Cells["Codigo"].Value);
            bool RequiereVencimiento = Convert.ToBoolean(this.dgv_productos.CurrentRow.Cells["RequiereVencimiento"].Value);
            bool ActualizarPrecioAutomaticamente = Convert.ToBoolean(this.dgv_productos.CurrentRow.Cells["ActualizarPrecioAutomaticamente"].Value);
            bool PermiteDecimales = Convert.ToBoolean(this.dgv_productos.CurrentRow.Cells["PermiteDecimales"].Value);
            decimal Precio = Convert.ToDecimal(this.dgv_productos.CurrentRow.Cells["Precio"].Value);
            decimal Stock = Convert.ToDecimal(this.dgv_productos.CurrentRow.Cells["Stock"].Value);

            // Invocás el evento si hay algún método suscripto
            ProductoSeleccionado?.Invoke(Id_Producto, Nombre);
            ProductoIngresoSeleccionado?.Invoke(Id_Producto, Nombre,RequiereVencimiento,ActualizarPrecioAutomaticamente,PermiteDecimales);
            ProductoVentaSeleccionado?.Invoke(Id_Producto,  Nombre,  Precio, Stock, Codigo,  PermiteDecimales);
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

            dgv_productos.Columns["Id_Producto"].Visible = false;
            dgv_productos.Columns["Id_Producto"].Width = 120;
            dgv_productos.Columns["Codigo"].Width = 200;
            dgv_productos.Columns["Nombre"].Width = 400;
            dgv_productos.Columns["Precio"].Width = 200;
            dgv_productos.Columns["Stock"].Width = 100;
            dgv_productos.Columns["StockMinimo"].Width = 120;
            dgv_productos.Columns["Descripcion"].Width = 600;
            dgv_productos.Columns["FechaUltimaActualizacionPrecio"].Width = 300;
            dgv_productos.Columns["Estado"].Width = 100;
            dgv_productos.Columns["Subcategoria"].Width = 200;
            dgv_productos.Columns["Marca"].Width = 200;
            dgv_productos.Columns["UnidadMedida"].Width = 200;
            dgv_productos.Columns["PermiteDecimales"].Width = 200;
            dgv_productos.Columns["RequiereVencimiento"].Width = 250;
            dgv_productos.Columns["ActualizarPrecioAutomaticamente"].Width = 300;
            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Precio"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["StockMinimo"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockMinimo"].DefaultCellStyle.FormatProvider = culturaAR;

            // Si Stock también es decimal:
            dgv_productos.Columns["Stock"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Stock"].DefaultCellStyle.FormatProvider = culturaAR;



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
            dgv_productos.Columns["PermiteDecimales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["FechaUltimaActualizacionPrecio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_productos.Columns["RequiereVencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ActualizarPrecioAutomaticamente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
   



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
