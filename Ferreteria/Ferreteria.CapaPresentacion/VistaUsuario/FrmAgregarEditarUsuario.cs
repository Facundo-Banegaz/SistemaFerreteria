using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
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

namespace Ferreteria.CapaPresentacion.VistaUsuario
{
    public partial class FrmAgregarEditarUsuario : Form
    {
        private Usuario _Usuario = null;
        public FrmAgregarEditarUsuario()
        {
            InitializeComponent();
            Text = "Nuevo Usuario";
        }
        public FrmAgregarEditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            _Usuario = usuario; 
            Text = "Editar Usuario";
        }

        private void FrmAgregarEditarUsuario_Load(object sender, EventArgs e)
        {
            CargarCboAcceso();

            if (_Usuario != null)
            {
                MostrarDatos();

                // Ocultar clave solo si estás editando
                txt_clave.Visible = false;
                lbl_clave.Visible = false; // si tenés una etiqueta para "Clave"
            }
            else
            {
                // Mostrar campo clave si es nuevo usuario
                txt_clave.Visible = true;
                lbl_clave.Visible = true;
            }

        }


        private void CargarCboAcceso()
        {



            cbo_acceso.Items.Add("SELECCIONAR ACCESO");

            cbo_acceso.Items.Add("Vendedor");
            cbo_acceso.Items.Add("Administrador");

            cbo_acceso.SelectedIndex = 0;

            cbo_acceso.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void MostrarDatos()
        {
            try
            {
                if (_Usuario != null)
                {
                    txt_id_usuario.Text =  _Usuario.Id_Usuario.ToString();
                    txt_nombre.Text = _Usuario.Nombre;
                    txt_apellido.Text = _Usuario.Apellido;
                    txt_dni.Text = _Usuario.Dni;
                    txt_nombre_usuario.Text = _Usuario.UsuarioNombre;



                    cbo_acceso.SelectedItem = _Usuario.Acceso;




                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarUsuario()
        {
            CN_Usuario _CN_Usuario = new CN_Usuario();

            try
            {
                bool esNuevo = _Usuario == null || _Usuario.Id_Usuario == 0;

                // Validar: solo validar clave si es nuevo
                if (ValidarVacio(validarClave: esNuevo))
                {
                    errorIcono.Clear();

                    if (_Usuario == null)
                        _Usuario = new Usuario();

                    _Usuario.Nombre = txt_nombre.Text.Trim().ToUpper();
                    _Usuario.Apellido = txt_apellido.Text.Trim().ToUpper();
                    _Usuario.Dni = txt_dni.Text.Trim().ToUpper();
                    _Usuario.UsuarioNombre = txt_nombre_usuario.Text.Trim().ToUpper();
                    _Usuario.Clave = txt_clave.Text.Trim().ToUpper();
                    _Usuario.Acceso = cbo_acceso.SelectedItem.ToString();

                    if (esNuevo)
                    {
                
                        _CN_Usuario.InsertarUsuario(_Usuario);
                        MessageBox.Show("¡El Usuario fue agregado exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // No modificar clave en edición si está oculta
                        _CN_Usuario.EditarUsuario(_Usuario);
                        MessageBox.Show("¡El Usuario fue modificado exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                errorIcono.SetError(txt_dni, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarVacio(bool validarClave = true)
        {

            bool error = true;

            if (txt_apellido.Text == string.Empty)
            {
                errorIcono.SetError(txt_apellido, "El campo  es obligatorio");


                error = false;
            }
            if (txt_nombre.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre, "El campo  es obligatorio");


                error = false;
            }

            if (txt_dni.Text == string.Empty)
            {
                errorIcono.SetError(txt_dni, "El campo  es obligatorio");


                error = false;
            }

            if (validarClave && string.IsNullOrWhiteSpace(txt_clave.Text))
            {
                errorIcono.SetError(txt_clave, "El campo es obligatorio");
                error = false;
            }

            if (txt_nombre_usuario.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_usuario, "El campo  es obligatorio");


                error = false;
            }
            if (cbo_acceso.SelectedIndex == 0)
            {
                errorIcono.SetError(cbo_acceso, "El campo  es obligatorio");


                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

    }
}
