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

namespace Ferreteria.CapaPresentacion.VistaProducto
{
    public partial class FrmProducto : Form
    {

        private List<Producto> listaProductos;
        public FrmProducto()
        {
            InitializeComponent();
            Text = "Gestion Productos";
        }



        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_producto);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarProducto frmAgregar = new FrmAgregarEditarProducto();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Producto seleccionado = null;

            if (dgv_producto.CurrentRow != null)
            {


                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Producto?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgv_producto.CurrentRow.DataBoundItem;
                    FrmAgregarEditarProducto frmEditar = new FrmAgregarEditarProducto(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }


            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            CN_Producto _Producto = new CN_Producto();
            Producto seleccionado = null;


            try
            {
                if (dgv_producto.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Producto)dgv_producto.CurrentRow.DataBoundItem;
                        _Producto.EliminarProducto(seleccionado.Id_Producto);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Producto seleccionado= null;
            if (dgv_producto.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Producto?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgv_producto.CurrentRow.DataBoundItem;
                    FrmActualizarPrecio frmEditar = new FrmActualizarPrecio(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            Producto seleccionado= null;
            if (dgv_producto.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle este Producto?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Producto)dgv_producto.CurrentRow.DataBoundItem;

                    FrmDetalleProducto frmDetalle = new FrmDetalleProducto(seleccionado);
                    frmDetalle.ShowDialog();
                }
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

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

            dgv_productos.Columns["RequiereVencimiento"].Width = 250;
            dgv_productos.Columns["ActualizarPrecioAutomaticamente"].Width = 300;
            dgv_productos.Columns["EnPromocion"].Width = 200;
            dgv_productos.Columns["PorcentajeDescuentoPromocion"].Width = 300;


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

            dgv_productos.Columns["RequiereVencimiento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ActualizarPrecioAutomaticamente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["EnPromocion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["PorcentajeDescuentoPromocion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Producto _Producto = new CN_Producto();

            listaProductos = _Producto.ListaProductos();

            dgv_producto.DataSource = listaProductos;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_producto.Rows.Count);
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
                dgv_producto.DataSource = producto.BuscarProducto(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_producto.Rows.Count);
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

     
    }
}
