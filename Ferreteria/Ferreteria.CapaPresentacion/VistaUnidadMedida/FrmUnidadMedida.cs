using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCategoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaUnidadMedida
{
    public partial class FrmUnidadMedida : Form
    {
        private List<UnidadMedida> listaUnidadMedida;
        public FrmUnidadMedida()
        {
            InitializeComponent();
            Text = "Gestion Unidad Medida:";
        }

        private void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_unidadMedida);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarUnidadMedida();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarUnidadMedida frmAgregar = new FrmAgregarEditarUnidadMedida();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            UnidadMedida seleccionado = null;
            if (dgv_unidadMedida.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Unidad de medida?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (UnidadMedida)dgv_unidadMedida.CurrentRow.DataBoundItem;
                    FrmAgregarEditarUnidadMedida frmEditar = new FrmAgregarEditarUnidadMedida(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_UnidadMedida _UnidadMedida = new CN_UnidadMedida();
            UnidadMedida seleccionado = null;


            try
            {
                if (dgv_unidadMedida.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Unidad de Medida?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (UnidadMedida)dgv_unidadMedida.CurrentRow.DataBoundItem;
                        _UnidadMedida.EliminarUnidadMedida(seleccionado.Id_UnidadMedida);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_UnidadMedida"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto


            dgv_productos.Columns["Id_UnidadMedida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




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

    }
}
