using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaMarca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaProveedor
{
    public partial class FrmProveedor : Form
    {
        private List<Proveedor> listaProveedores;
        public FrmProveedor()
        {
            InitializeComponent();
            Text = "Gestion Proveedor:";
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_proveedor);
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

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEditarProveedor frmAgregar = new FrmAgregarEditarProveedor();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Proveedor seleccionado = null;

            if (dgv_proveedor.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Proveedor?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Proveedor)dgv_proveedor.CurrentRow.DataBoundItem;
                    FrmAgregarEditarProveedor frmEditar = new FrmAgregarEditarProveedor(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Proveedor _Proveedor = new CN_Proveedor();
            Proveedor seleccionado = null;


            try
            {
                if (dgv_proveedor.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Proveedor)dgv_proveedor.CurrentRow.DataBoundItem;
                        _Proveedor.EliminarProveedor(seleccionado.Id_Proveedor);

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


            dgv_productos.Columns["Id_Proveedor"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto


            dgv_productos.Columns["Id_Proveedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView

            CN_Proveedor _Proveedor = new CN_Proveedor();

            listaProveedores = _Proveedor.ListaProveedor();

            dgv_proveedor.DataSource = listaProveedores;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_proveedor.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarMarca()
        {
            CN_Proveedor _Proveedor = new CN_Proveedor();


            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_proveedor.DataSource = _Proveedor.ProveedorBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_proveedor.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }
    }
}
