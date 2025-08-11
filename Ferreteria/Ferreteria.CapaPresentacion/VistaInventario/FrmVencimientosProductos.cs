using Ferreteria.CapaDominio.DTOs;
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

namespace Ferreteria.CapaPresentacion.VistaInventario
{
    public partial class FrmVencimientosProductos : Form
    {
        private List<ProductoConVencimientoDto> listaProductos;
        public FrmVencimientosProductos()
        {
            InitializeComponent();
            Text = "Gestion Inventario Vencimientos";
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
            listaProductos = _Producto.ListaProductosConVencimientoDto(filtroEstado);

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
    }
}
