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

namespace Ferreteria.CapaPresentacion.VistaMarca
{
    public partial class FrmMarca : Form
    {
        private List<Marca> listaMarcas;
        public FrmMarca()
        {
            InitializeComponent();
            Text = "Gestion Marca:";
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_marcas);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarMarca frmAgregar = new FrmAgregarEditarMarca();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Marca seleccionado = null;

            if (dgv_marcas.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar esta Marca?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgv_marcas.CurrentRow.DataBoundItem;
                    FrmAgregarEditarMarca frmEditar = new FrmAgregarEditarMarca(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Marca _Marca = new CN_Marca();
            Marca seleccionado = null;

            try
            {
                if (dgv_marcas.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres eliminar esta marca?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Marca)dgv_marcas.CurrentRow.DataBoundItem;
                        _Marca.EliminarMarca(seleccionado.Id_Marca);

                        CargarGrilla();

                        MessageBox.Show("Marca eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar solo el mensaje amigable que tiramos en la lógica
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarMarca();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
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
            dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_productos.Columns["Id_Marca"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto


            dgv_productos.Columns["Id_Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Marca _Marca = new CN_Marca();

            listaMarcas = _Marca.ListaMarca();

            dgv_marcas.DataSource = listaMarcas;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_marcas.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarMarca()
        {
            CN_Marca marca = new CN_Marca();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_marcas.DataSource = marca.MarcaBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_marcas.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

    }
}
