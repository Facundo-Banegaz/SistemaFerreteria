using Ferreteria.CapaDominio;
using Ferreteria.CapaPresentacion.VistaCategoria;
using Ferreteria.CapaPresentacion.VistaEspecificacion;
using Ferreteria.CapaPresentacion.VistaIngresos;
using Ferreteria.CapaPresentacion.VistaMarca;
using Ferreteria.CapaPresentacion.VistaProducto;
using Ferreteria.CapaPresentacion.VistaProveedor;
using Ferreteria.CapaPresentacion.VistaSubcategoria;
using Ferreteria.CapaPresentacion.VistaUnidadMedida;
using Ferreteria.CapaPresentacion.VistaUsuario;
using Ferreteria.CapaPresentacion.VistaVenta;
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

namespace Ferreteria.CapaPresentacion.VistaMDIPrincipal
{
    public partial class FrmMdiPrincipal : Form
    {

        private Usuario Usuario;
        private static Form formularioActivo = null;

        public FrmMdiPrincipal()
        {
            InitializeComponent();
            //lbl_usuario.Text  = $"¡¡Bienvenido al Sistema de Ventas {Usuario.Nombre} {Usuario.Apellido}!! Nombre de  Usuario: ''{Usuario.UsuarioNombre}'' | Acceso: ''{Usuario.Acceso}''.";

        }
        private void abrirForm(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            formulario.FormBorderStyle = FormBorderStyle.None;


            formulario.MdiParent = this;
            formulario.BringToFront();
            formulario.Show();
        }
        private void Menu_item_salir_Click(object sender, EventArgs e)
        {
            //DialogResult respuesta = MessageBox.Show($"¿Estás seguro de que deseas salir del sistema {Usuario.Nombre} {Usuario.Apellido}? Nombre de  Usuario: ''{Usuario.UsuarioNombre}'' | Acceso: ''{Usuario.Acceso}''.", "Salir del Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (respuesta == DialogResult.Yes)
            //{
                Application.Exit();
            //}
        }

     

        private void tn_tiempo_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text =     DateTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture);
            lbl_fecha.Text =    DateTime.Now.ToLongDateString();
        }



        private void menu_item_productos_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmProducto());
        }

        private void menu_items_categorias_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmCategoria());  
        }

        private void menu_item_subcategorias_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmSubcategoria());
        }

        private void menu_item_marcas_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmMarca());
        }

        private void Menu_item_UnidadMedida_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmUnidadMedida());
        }

        private void menu_item_especificación_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmEspecificacion());
        }

        private void Menu_item_proveedores_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmProveedor());
        }

        private void Menu_item_ingresos_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmIngreso());

        }

        private void Menu_item_usuarios_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmUsuario());
        }

 

        private void Menu_item_venta_Click(object sender, EventArgs e)
        {
            abrirForm(new  FrmVenta() );
           
        }

        private void Menu_item_historial_vendedor_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmHistorialVenta());
        }

        private void Menu_item_ingresos_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FrmIngreso());
        }

  

        private void Menu_item_usuarios_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FrmUsuario());
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void Menu_item_actualizarPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
