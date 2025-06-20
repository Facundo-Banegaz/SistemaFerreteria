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

namespace Ferreteria.CapaPresentacion.VistaUsuario
{
    public partial class FrmActualizarContrasenia : Form
    {
        private Usuario usuario = null;
        private int Id_Usuario;
        private  string Clave;
        public FrmActualizarContrasenia(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            Text = "Cambiar Contraseña:"; 
        }

        private void FrmActualizarContrasenia_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
          
            lbl_nombre.Text = "Nombre:   " + usuario.Nombre;
            lbl_apellido.Text = "Apellido:  " + usuario.Apellido;
            lbl_usuario.Text = "Nombre de Usuario: " + usuario.UsuarioNombre;
            lbl_acceso.Text = "Tipo de Rol: " + usuario.Acceso;
            check_estado.Checked = usuario.Estado;
            
            lbl_dni.Text = "Numero de Documento: " + usuario.Dni;
        
            lbl_Id.Text = usuario.Id_Usuario.ToString();
        }

        private void GuardarActualizacion()
        {
            CN_Usuario _Usuario = new CN_Usuario();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();



                    if (usuario.Id_Usuario != 0)
                    {
                        Id_Usuario = Convert.ToInt32(lbl_Id.Text);
                        Clave = txt_contrasenia.Text;

                        _Usuario.ActualizarContrasenia(Id_Usuario, Clave);

                        MessageBox.Show("¡La contraseña del Usuario fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("¡Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje amigable si es un error 
                errorIcono.SetError(txt_contrasenia, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_contrasenia.Text == string.Empty)
            {
                errorIcono.SetError(txt_contrasenia, "El campo  es obligatorio ");
                txt_contrasenia.Focus();

                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarActualizacion();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
