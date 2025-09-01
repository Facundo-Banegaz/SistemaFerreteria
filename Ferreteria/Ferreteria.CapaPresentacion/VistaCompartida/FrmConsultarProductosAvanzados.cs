using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaProducto;
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
    public partial class FrmConsultarProductosAvanzados : Form
    {

        private List<ProductoAvanzadoDto> ListarProducto;
        public FrmConsultarProductosAvanzados()
        {
            InitializeComponent();
            Text = "Consultar Producto";
        }

        private void FrmConsultarProductosAvanzados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_productos);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto();
                txt_buscar.Clear();     // limpia el campo
                txt_buscar.Focus();     // focus
            }
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
                dgv_productos.DataSource = producto.ConsultaBuscarProductoAvanzado(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_productos.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }


        private void CargarGrilla()
        {
            //logica del dataGridView

            CN_Producto _Producto = new CN_Producto();

            ListarProducto = _Producto.ConsultaMostrarProductosAvanzado();

            dgv_productos.DataSource = ListarProducto;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_productos.Rows.Count);
            lbl_resultado.Text = "";

        }


        private void ArregloDataGridView(DataGridView dgv_productos)
        {
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_Producto"].Visible = false;
            dgv_productos.Columns["Codigo"].Width = 150;
            dgv_productos.Columns["Marca"].Width = 400;
            dgv_productos.Columns["Categoria"].Width = 400;
            dgv_productos.Columns["Subcategoria"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 500;
            dgv_productos.Columns["UnidadMedida"].Width = 200;
            dgv_productos.Columns["Stock"].Width = 150;
            dgv_productos.Columns["StockMinimo"].Width = 200;
            dgv_productos.Columns["Estado"].Width = 200;
            dgv_productos.Columns["Precio"].Width = 150;
            // Fuente para celdas
            dgv_productos.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Fuente para encabezados
            dgv_productos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgv_productos.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Formatear columnas decimales con cultura argentina
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Precio"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["Stock"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Stock"].DefaultCellStyle.FormatProvider = culturaAR;

            foreach (DataGridViewColumn col in dgv_productos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_productos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            _Metodos.AlternarColor(dgv_productos);

            dgv_productos.ClearSelection();
            dgv_productos.CurrentCell = null;
        }


        private void dgv_productos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;

  

            // Primero verificar que la columna sea la de Stock (o el índice o nombre que uses)
            if (dgv.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal stock))
                {
                    // Obtener el valor de StockMinimo de la misma fila
                    var stockMinimoObj = dgv.Rows[e.RowIndex].Cells["StockMinimo"].Value;
                    if (stockMinimoObj != null && decimal.TryParse(stockMinimoObj.ToString(), out decimal stockMinimo))
                    {
                        if (stock < stockMinimo)
                        {
                            e.CellStyle.ForeColor = Color.White;
                            e.CellStyle.BackColor = Color.Red;  // Más grave: rojo fuerte
                        }
                        else if (stock == stockMinimo)
                        {
                            e.CellStyle.ForeColor = Color.Black;
                            e.CellStyle.BackColor = Color.Orange;  // Igual: naranja
                        }
                        else
                        {
                            e.CellStyle.ForeColor = Color.Black;
                            e.CellStyle.BackColor = Color.LightGreen;
                        }
                    }

                 
                }
            }
        }

        private void btn_ver_detalle_Click(object sender, EventArgs e)
        {
            ProductoAvanzadoDto seleccionado = null;
            if (dgv_productos.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Ver el detalle este Producto?", "Detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (ProductoAvanzadoDto)dgv_productos.CurrentRow.DataBoundItem;

                    FrmDetalleConsultarPoductosAvanzados frmDetalle = new FrmDetalleConsultarPoductosAvanzados(seleccionado);
                    frmDetalle.ShowDialog();
                }
            }
        }
    }
}
