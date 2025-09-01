using Ferreteria.CapaDominio;
using Ferreteria.CapaDominio.DTOs;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaProducto;
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
    public partial class FrmInventarioBajo : Form
    {

        private List<ProductoInventarioBajoDto> listaProductos;
        public FrmInventarioBajo()
        {
            InitializeComponent();
            Text = "Gestion Inventario";
        }


        private void FrmInventarioBajo_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_productos);
            ActualizarConteoStock();
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Producto _Producto = new CN_Producto();

            listaProductos = _Producto.ListaProductosInventarioBajo();

            dgv_productos.DataSource = listaProductos;
            lbl_total.Text = "Total de Productos:  " + Convert.ToString(dgv_productos.Rows.Count);
            lbl_resultado.Text = "";
            CalcularTotalMercaderia();
        }
        private void CalcularTotalMercaderia()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                if (row.Cells["Stock"].Value != null && row.Cells["Precio"].Value != null)
                {
                    decimal stock = Convert.ToDecimal(row.Cells["Stock"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

                    total += stock * precio;
                }
            }

            // Formato argentino (ej: $ 12.345,67)
            CultureInfo culturaAR = new CultureInfo("es-AR");
            lbl_ValorMercaderia.Text = $"Valor total del Inventario: {total.ToString("C2", culturaAR)}";
        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_Producto"].Visible = false;

     
            dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Formatear columnas decimales con cultura argentina (coma como decimal, punto como miles)
            CultureInfo culturaAR = new CultureInfo("es-AR");

            dgv_productos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["Precio"].DefaultCellStyle.FormatProvider = culturaAR;

            dgv_productos.Columns["StockMinimo"].DefaultCellStyle.Format = "N2";
            dgv_productos.Columns["StockMinimo"].DefaultCellStyle.FormatProvider = culturaAR;

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
        private void ActualizarConteoStock()
        {
            int countOk = 0, countIgual = 0, countCritico = 0;

            foreach (DataGridViewRow row in dgv_productos.Rows)
            {
                if (!row.IsNewRow && row.Visible)  // <-- Solo filas visibles
                {
                    var stockObj = row.Cells["Stock"].Value;
                    var stockMinimoObj = row.Cells["StockMinimo"].Value;

                    if (stockObj != null && stockMinimoObj != null &&
                        decimal.TryParse(stockObj.ToString(), out decimal stock) &&
                        decimal.TryParse(stockMinimoObj.ToString(), out decimal stockMinimo))
                    {
                        if (stock < stockMinimo)
                            countCritico++;
                        else if (stock == stockMinimo)
                            countIgual++;
                        else
                            countOk++;
                    }
                }
            }

            lbl_Stock_Critico.Text = $"Productos en stock crítico: {countCritico}";
            lbl_Stock_Igual.Text = $"Productos en límite de stock: {countIgual}";
            lbl_Stock_Ok.Text = $"Productos con stock suficiente: {countOk}";
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
            ActualizarConteoStock();
        }
        private void BuscarProducto()
        {
            CN_Producto producto = new CN_Producto();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
                CargarGrilla();
                ActualizarConteoStock();
            }
            else
            {
                dgv_productos.DataSource = producto.BuscarProductosInventarioBajo(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_productos.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
                ActualizarConteoStock();

            }
        }
        private void btn_imprimir_Click(object sender, EventArgs e)
        {

            FrmReporteInventario frmReporte = new FrmReporteInventario();
            frmReporte.ShowDialog();
        }

        private void dgv_productos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //ActualizarConteoStock(dgv_productos);
        }

        private void dgv_productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //ActualizarConteoStock(dgv_productos);
        }
    }
}