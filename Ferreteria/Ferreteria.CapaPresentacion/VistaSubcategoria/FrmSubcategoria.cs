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

namespace Ferreteria.CapaPresentacion.VistaSubcategoria
{
    public partial class FrmSubcategoria : Form
    {
        private List<Subcategoria> listaSubcategorias;
        public FrmSubcategoria()
        {
            InitializeComponent();
            Text = "Gestion Subcategoria:";
        }

        private void FrmSubcategoria_Load(object sender, EventArgs e)
        {

            CargarGrilla();

            ArregloDataGridView(dgv_subcategorias);
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarSubcategoria();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }

        private void dgv_categorias_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarSubcategoria frmAgregar = new FrmAgregarEditarSubcategoria();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Subcategoria seleccionado = null;
            if (dgv_subcategorias.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Subcateforia?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Subcategoria)dgv_subcategorias.CurrentRow.DataBoundItem;
                    FrmAgregarEditarSubcategoria frmEditar = new FrmAgregarEditarSubcategoria(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_SubCategoria _Subcategoria = new CN_SubCategoria();
            Subcategoria seleccionado = null;


            try
            {
                if (dgv_subcategorias.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Subcategoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Subcategoria)dgv_subcategorias.CurrentRow.DataBoundItem;
                        _Subcategoria.EliminarSubCategoria(seleccionado.Id_Subcategoria);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar solo el mensaje amigable que tiramos en la lógica
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
            CN_SubCategoria _Subcategoria = new CN_SubCategoria();

            listaSubcategorias = _Subcategoria.ListaSubCategoria();

            dgv_subcategorias.DataSource = listaSubcategorias;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_subcategorias.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
     


            dgv_productos.Columns["Id_Subcategoria"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 500;// nombre_producto

            dgv_productos.Columns["Categoria"].Width = 500;// nombre_producto




            dgv_productos.Columns["Id_Subcategoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Categoria"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void BuscarSubcategoria()
        {
            CN_SubCategoria subcategoria = new CN_SubCategoria();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_subcategorias.DataSource = subcategoria.SubCategoriaBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_subcategorias.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

     
    }
}
