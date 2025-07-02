using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaEspecificacion.VistaValorEspecificacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaValorEspecificacion
{
    public partial class FrmValorEspecificacion : Form
    {
        private List<ValorEspecificacion> listaValorEspecificacion;

        public FrmValorEspecificacion()
        {
            InitializeComponent();

            Text = "Gestion Valor  Especificaión:";
        }
        private void FrmValorEspecificacion_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_valor_especificacion);
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarValorEspecificacion frmAgregar = new FrmAgregarEditarValorEspecificacion();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ValorEspecificacion seleccionado = null;

            if (dgv_valor_especificacion.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Tipo de Especificación?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (ValorEspecificacion)dgv_valor_especificacion.CurrentRow.DataBoundItem;
                    FrmAgregarEditarValorEspecificacion frmEditar = new FrmAgregarEditarValorEspecificacion(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_ValorEspecificacion _ValorEspecificacion = new CN_ValorEspecificacion();
            ValorEspecificacion seleccionado = null;


            try
            {
                if (dgv_valor_especificacion.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar esta Categoria?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (ValorEspecificacion)dgv_valor_especificacion.CurrentRow.DataBoundItem;
                        _ValorEspecificacion.EliminarValorEspecificacion(seleccionado.Id_ValorEspecificacion);

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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarValorEspecificacion();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_buscar.Clear();
            CargarGrilla();
        }
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();

            dgv_productos.Columns["Id_ValorEspecificacion"].Visible = false;

            dgv_productos.Columns["Id_ValorEspecificacion"].Width = 400;
            dgv_productos.Columns["Valor"].Width = 1000;// nombre_producto


            dgv_productos.Columns["Id_ValorEspecificacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_ValorEspecificacion _logicaValorEspecificacion = new CN_ValorEspecificacion();

            listaValorEspecificacion = _logicaValorEspecificacion.listaValorEspecificacion();

            dgv_valor_especificacion.DataSource = listaValorEspecificacion;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_valor_especificacion.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarValorEspecificacion()
        {

            CN_ValorEspecificacion _ValorEspecificacion = new CN_ValorEspecificacion();



            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_valor_especificacion.DataSource = _ValorEspecificacion.ValorEspecificacionBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_valor_especificacion.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }


    }
}
