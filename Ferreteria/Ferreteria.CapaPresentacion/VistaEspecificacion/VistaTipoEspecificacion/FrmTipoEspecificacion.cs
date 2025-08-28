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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaTipoEspecificacion
{
    public partial class FrmTipoEspecificacion : Form
    {
        private List<TipoEspecificacion> listaTipoEspecificacion;

        public FrmTipoEspecificacion()
        {
            InitializeComponent();
            Text = "Gestion Tipo  Especificaión:";
        }

        private void FrmTipoEspecificacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_tipo_especificacion);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarTipoEspecificacion();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           CN_TipoEspecificacion _TipoEspecificacion = new CN_TipoEspecificacion();
            TipoEspecificacion seleccionado = null;


            try
            {
                if (dgv_tipo_especificacion.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (TipoEspecificacion)dgv_tipo_especificacion.CurrentRow.DataBoundItem;
                        _TipoEspecificacion.EliminarTipoEspecificacion(seleccionado.Id_TipoEspecificacion);

                        CargarGrilla();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    FrmAgregarEditarTipoEspecificacion frmEditar = new FrmAgregarEditarTipoEspecificacion(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarTipoEspecificacion frmAgregar = new FrmAgregarEditarTipoEspecificacion();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();
            dgv_productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_productos.Columns["Id_TipoEspecificacion"].Visible = false;

            dgv_productos.Columns["Id_TipoEspecificacion"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 1000;// nombre_producto


            dgv_productos.Columns["Id_TipoEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_TipoEspecificacion _logicaTipoEspecificacion = new CN_TipoEspecificacion();

            listaTipoEspecificacion = _logicaTipoEspecificacion.ListaTipoEspecificacion();

            dgv_tipo_especificacion.DataSource = listaTipoEspecificacion;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_tipo_especificacion.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarTipoEspecificacion()
        {

            CN_TipoEspecificacion _TipoEspecificacion = new CN_TipoEspecificacion();

       

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_tipo_especificacion.DataSource = _TipoEspecificacion.TipoEspecificacionBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_tipo_especificacion.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

    }
}
