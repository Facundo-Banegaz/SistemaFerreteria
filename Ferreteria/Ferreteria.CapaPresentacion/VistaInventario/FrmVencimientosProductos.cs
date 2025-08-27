using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaReporte;
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

namespace Ferreteria.CapaPresentacion.VistaInventario
{
    public partial class FrmVencimientosProductos : Form
    {
        private List<ProductoConVencimientoDto> listaProductos;
        private Usuario Usuario;
        public FrmVencimientosProductos()
        {
            InitializeComponent();
            Text = "Gestion Inventario Vencimientos";
        }
        public FrmVencimientosProductos(Usuario usuario)
        {
            InitializeComponent();
            Text = "Gestion Inventario Vencimientos";

            this.Usuario = usuario;
        }

        private void FrmVencimientosProductos_Load(object sender, EventArgs e)
        {
            Rb_Todos.Checked = true;
            CargarGrilla();
            ArregloDataGridView(dgv_productos);
        
        }

        private void CargarGrilla()
        {
            CN_Producto _Producto = new CN_Producto();

            // Determinar el valor del filtro según el radio button seleccionado
            string filtroEstado = "";
            if (Rb_Todos.Checked)
                filtroEstado = "TODOS";
            else if (Rb_Por_Vencer.Checked)
                filtroEstado = "PORVENCER";
            else if (Rb_Vencido.Checked)
                filtroEstado = "VENCIDO";

            // Ejecutar la consulta con el filtro y sin filtro de producto
            listaProductos = _Producto.ListaProductosConVencimiento(filtroEstado);

            dgv_productos.DataSource = listaProductos;
            lbl_total.Text = "Total de Productos:  " + dgv_productos.Rows.Count.ToString();
            lbl_resultado.Text = "";
        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_Producto"].Visible = false;
            dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");



            // Si Stock también es decimal:
            dgv_productos.Columns["Stock"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Stock"].DefaultCellStyle.FormatProvider = culturaAR;




            foreach (DataGridViewColumn col in dgv_productos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            _Metodos.AlternarColor(dgv_productos);
            // Quitar selección al cargar
            dgv_productos.ClearSelection();
            dgv_productos.CurrentCell = null;
        }

        private void Rb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Todos.Checked) CargarGrilla();
        }
        

        private void Rb_Por_Vencer_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Por_Vencer.Checked) CargarGrilla();
        }
    

        private void Rb_Vencido_CheckedChanged(object sender, EventArgs e)
        {
             if (Rb_Vencido.Checked) CargarGrilla();

        }

        private void dgv_productos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;

            // Solo colorear la columna "Estado"
            if (dgv.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();

                    if (estado == "VENCIDO")
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (estado == "POR VENCER")
                    {
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.CellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
                        e.CellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;
                    }
                }
            }
            // Colorear solo columna FechaVencimiento
            else if (dgv.Columns[e.ColumnIndex].Name == "FechaVencimiento")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime fecha))
                {
                    // Color neutro para la fecha de vencimiento (por ejemplo, un amarillo pastel)
                    e.CellStyle.BackColor = Color.LightGoldenrodYellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    e.CellStyle.BackColor = dgv.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dgv.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();
        }

        private void btn_limpiar(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
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
                string filtroEstado = "";
                if (Rb_Todos.Checked)
                    filtroEstado = "TODOS";
                else if (Rb_Por_Vencer.Checked)
                    filtroEstado = "PORVENCER";
                else if (Rb_Vencido.Checked)
                    filtroEstado = "VENCIDO";


                dgv_productos.DataSource = producto.BuscarProductoConVencimiento(filtroEstado,txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_productos.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            

            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            string filtroEstado = "";
            if (Rb_Todos.Checked)
                filtroEstado = "TODOS";
            else if (Rb_Por_Vencer.Checked)
                filtroEstado = "PORVENCER";
            else if (Rb_Vencido.Checked)
                filtroEstado = "VENCIDO";

            DialogResult respuesta = MessageBox.Show(
       "¿Desea imprimir el reporte de vencimiento de productos?",
       "Confirmar impresión",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);


            if (respuesta == DialogResult.Yes)
            {
                
                FrmReporteProductoVencimiento frmReporteProductoVencimiento = new FrmReporteProductoVencimiento(filtroEstado);

                frmReporteProductoVencimiento.ShowDialog();   
            }
          
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Producto _Producto = new CN_Producto();
            ProductoConVencimientoDto seleccionado = null;


            try
            {
                if (dgv_productos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Descontar estos Productos vencidos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (ProductoConVencimientoDto)dgv_productos.CurrentRow.DataBoundItem;
                        _Producto.DescontarProductoVencido( Usuario.Id_Usuario, seleccionado.Id_DetalleIngreso);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
