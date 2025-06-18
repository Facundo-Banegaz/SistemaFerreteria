using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaMDIPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }




        private void btn_acceder_Click(object sender, EventArgs e)
        {
           CN_Usuario _Usuario = new CN_Usuario();

            Usuario usuario = _Usuario.Login(txt_usuario.Text, txt_clave.Text);

            if (usuario != null)
            {

                
                //para que me muestre un mensaje en la ventana 
                Text = $"Inicio de sesión exitoso. ¡Bienvenido al Sistema  {usuario.Nombre}  {usuario.Apellido}!";

                // Usuario válido, realizar acciones correspondientes (por ejemplo, mostrar el formulario principal)
                string mensaje = $"Inicio de sesión exitoso. ¡Bienvenido al Sistema, {usuario.Nombre}  {usuario.Apellido} | Nombre de Usuario: {txt_usuario.Text} | Accediste como: {usuario.Acceso}!";
                MessageBox.Show(mensaje, "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmMdiPrincipal principal = new FrmMdiPrincipal(usuario);

              
                principal.Show();

                this.Hide();

            }
            else
            {
                // Usuario no válido, mostrar mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos, intentar de nuevo.", " No tiene Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_clave.Clear();
                txt_usuario.Clear();

            }
        }


        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Quieres Salir del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
