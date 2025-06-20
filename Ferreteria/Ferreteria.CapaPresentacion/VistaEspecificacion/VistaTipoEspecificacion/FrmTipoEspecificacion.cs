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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaTipoEspecificacion
{
    public partial class FrmTipoEspecificacion : Form
    {
        private List<Especificacion> listaEspecificacion;

        public FrmTipoEspecificacion()
        {
            InitializeComponent();
            Text = "Gestion Especificaión:";
        }

        private void FrmTipoEspecificacion_Load(object sender, EventArgs e)
        {
            //CargarGrilla();

            //ArregloDataGridView(dgv_tipo_especificacion);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Categoria _Categoria = new CN_Categoria();
            Categoria seleccionado = null;


            try
            {
                if (dgv_tipo_especificacion.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        ////seleccionado = (TipoEspecificacion)dgv_tipo_especificacion.CurrentRow.DataBoundItem;
                        ////_Categoria.EliminarCategoria(seleccionado.Id_Categoria);

                        ////CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            TipoEspecificacion seleccionado = null;

            if (dgv_tipo_especificacion.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Tipo de Especificación?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (TipoEspecificacion)dgv_tipo_especificacion.CurrentRow.DataBoundItem;
                    //FormAgregarEditarTipoEspecificacion frmEditar = new FormAgregarEditarTipoEspecificacion(seleccionado);
                    //frmEditar.ShowDialog();
                    //CargarGrilla();
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormAgregarEditarTipoEspecificacion frmAgregar = new FormAgregarEditarTipoEspecificacion();
            frmAgregar.ShowDialog();
            //CargarGrilla();
        }
    }
}
