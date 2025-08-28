using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaEspecificacion.VistaTipoEspecificacion;
using Ferreteria.CapaPresentacion.VistaEspecificacion.VistaValorEspecificacion;
using Ferreteria.CapaPresentacion.VistaSubcategoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaEspecificacion
{
    public partial class FrmEspecificacion : Form
    {
        private List<Especificacion> listaEspecificacion;
        public FrmEspecificacion()
        {
            InitializeComponent();
            Text = "Gestion Especificación:";
        }

        private void FrmEspecificacion_Load(object sender, EventArgs e)
        {

            CargarGrilla();

            ArregloDataGridView(dgv_especificacion);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarEspecificacion();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarEspecificacion frmAgregar = new FrmAgregarEditarEspecificacion();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Especificacion seleccionado = null;
            if (dgv_especificacion.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Especificación?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Especificacion)dgv_especificacion.CurrentRow.DataBoundItem;
                    FrmAgregarEditarEspecificacion frmEditar = new FrmAgregarEditarEspecificacion(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Especificacion _Subcategoria = new CN_Especificacion();
            Especificacion seleccionado = null;


            try
            {
                if (dgv_especificacion.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Especificación?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Especificacion)dgv_especificacion.CurrentRow.DataBoundItem;
                        _Subcategoria.EliminarEspecificacion(seleccionado.Id_Especificacion);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Especificacion _Especificacion = new CN_Especificacion();

            listaEspecificacion = _Especificacion.ListaEspecificacion();

            dgv_especificacion.DataSource = listaEspecificacion;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_especificacion.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productos.Columns["Id_Especificacion"].Visible = false;


            dgv_productos.Columns["Id_Especificacion"].Width = 300;
            dgv_productos.Columns["Producto"].Width = 600;// nombre_producto

        
            dgv_productos.Columns["TipoEspecificacion"].Width = 500;// nombre_producto
            dgv_productos.Columns["ValorEspecificacion"].Width = 500;// nombre_producto



            dgv_productos.Columns["Id_Especificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          
            dgv_productos.Columns["TipoEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["ValorEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            _Metodos.AlternarColor(dgv_productos);
        }
        private void BuscarEspecificacion()
        {
            CN_Especificacion Especificacion = new CN_Especificacion();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_especificacion.DataSource = Especificacion.EspecificacionBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_especificacion.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEspecificacion();
                txt_buscar.Clear();     // limpia el campo
                txt_buscar.Focus();     // focus
            }
        }

        private void btn_tipo_Click(object sender, EventArgs e)
        {
            FrmTipoEspecificacion frmTipo = new FrmTipoEspecificacion();
            frmTipo.ShowDialog();
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            FrmValorEspecificacion frmValor = new FrmValorEspecificacion();
            frmValor.ShowDialog();
        }
    }
}
