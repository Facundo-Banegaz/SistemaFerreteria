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

namespace Ferreteria.CapaPresentacion.VistaUsuario
{
    public partial class FrmUsuario : Form
    {
        private List<Usuario> listaUsuarios;
        public FrmUsuario()
        {
            InitializeComponent();
            Text = "Gestion Usuario:";
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            ArregloDataGridView(dgv_usuarios);
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
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
            FrmAgregarEditarUsuario frmAgregar = new FrmAgregarEditarUsuario();
            frmAgregar.ShowDialog();
            CargarGrilla();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Usuario seleccionado = null;

            if (dgv_usuarios.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Editar este Usuario?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Usuario)dgv_usuarios.CurrentRow.DataBoundItem;
                    FrmAgregarEditarUsuario frmEditar = new FrmAgregarEditarUsuario(seleccionado);
                    frmEditar.ShowDialog();
                    CargarGrilla();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            CN_Usuario _Usuario = new CN_Usuario();
            Usuario seleccionado = null;


            try
            {
                if (dgv_usuarios.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Quieres Eliminar este Usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Usuario)dgv_usuarios.CurrentRow.DataBoundItem;
                        _Usuario.EliminarUsuario(seleccionado.Id_Usuario);

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

        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_Usuario"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 500;
            dgv_productos.Columns["Apellido"].Width = 500;
            dgv_productos.Columns["Dni"].Width = 500;
            dgv_productos.Columns["UsuarioNombre"].Width = 500;
            dgv_productos.Columns["Clave"].Width = 500;
            dgv_productos.Columns["Estado"].Width = 500;
            dgv_productos.Columns["Acceso"].Width = 500;
            dgv_productos.Columns["Id_Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Apellido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Dni"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["UsuarioNombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Clave"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Acceso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Usuario _Usuario = new CN_Usuario();
            listaUsuarios = _Usuario.ListaUsuario();

            dgv_usuarios.DataSource = listaUsuarios;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_usuarios.Rows.Count);
            lbl_resultado.Text = "";

        }
        private void BuscarUsuario()
        {
            CN_Usuario _Usuario = new CN_Usuario();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_usuarios.DataSource = _Usuario.UsuarioBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_usuarios.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Usuario seleccionado = null;

            if (dgv_usuarios.CurrentRow != null)
            {
                DialogResult respuesta = MessageBox.Show("¿Quieres Actualizar la contraseña de este Usuario?", "Actualizar Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Usuario)dgv_usuarios.CurrentRow.DataBoundItem;
                    FrmActualizarContrasenia frmActualizar = new FrmActualizarContrasenia(seleccionado);
                    frmActualizar.ShowDialog();
                    CargarGrilla();
                }
            }
        }
    }
}
