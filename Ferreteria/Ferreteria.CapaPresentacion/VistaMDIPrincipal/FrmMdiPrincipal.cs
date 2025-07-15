using Ferreteria.CapaDominio;
using Ferreteria.CapaPresentacion.VistaCategoria;
using Ferreteria.CapaPresentacion.VistaEspecificacion;
using Ferreteria.CapaPresentacion.VistaIngresos;
using Ferreteria.CapaPresentacion.VistaMarca;
using Ferreteria.CapaPresentacion.VistaMovimientoStock;
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

        private Usuario _Usuario;
        private static Form formularioActivo = null;
        public FrmMdiPrincipal()
        { 
        }
        public FrmMdiPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;


            Text = $"¡¡Bienvenido al Sistema  {_Usuario.Nombre} {_Usuario.Apellido}!! Nombre de  Usuario: ''{_Usuario.UsuarioNombre}'' | Acceso: ''{_Usuario.Acceso}''.";
        }


        private void FrmMdiPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            lbl_usuario.Text = $"¡¡Bienvenido al Sistema  {_Usuario.Nombre}   {_Usuario.Apellido}!! Nombre de  Usuario: ''{_Usuario.UsuarioNombre}'' | Acceso: ''{_Usuario.Acceso}''.";
        }

        private void GestionUsuario()
        {
            if (_Usuario.Acceso == "Administrador")
            {
                this.Menu_gestion_mantenimientos.Enabled = true;
                this.Menu_gestion_compras.Enabled = true;
                this.Menu_gestion_analisis.Enabled = true;
                this.Menu_gestion_reportes.Enabled = true;


                this.Menu_gestion_ventas.Enabled = false;
                this.Menu_gestion_presupuestos.Enabled = false;
                this.Menu_gestion_consultas.Enabled = false;

            }

            else if (_Usuario.Acceso == "Vendedor")
            {
                this.Menu_gestion_mantenimientos.Enabled = false;
                this.Menu_gestion_compras.Enabled = false;
                this.Menu_gestion_analisis.Enabled = false;
                this.Menu_gestion_reportes.Enabled = false;


                this.Menu_gestion_ventas.Enabled = true;
                this.Menu_gestion_presupuestos.Enabled =true;
                this.Menu_gestion_consultas.Enabled = true;

            }


            else
            {
                this.Menu_gestion_mantenimientos.Enabled = false;
                this.Menu_gestion_compras.Enabled = false;
                this.Menu_gestion_analisis.Enabled = false;
                this.Menu_gestion_analisis.Enabled = false;
                this.Menu_gestion_ventas.Enabled = false;
                this.Menu_gestion_presupuestos.Enabled = false;
                this.Menu_gestion_consultas.Enabled = false;

            }
        }
        private void abrirForm(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            // Configuración del formulario hijo
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill; // Asegura que ocupe todo el espacio sin errores
            formulario.WindowState = FormWindowState.Maximized;

            formulario.Show();
        }

        private void Menu_item_salir_Click(object sender, EventArgs e)
        {
            // Verificamos si hay formularios hijos abiertos
            bool hayFormulariosAbiertos = this.MdiChildren.Any();

            if (hayFormulariosAbiertos)
            {
                MessageBox.Show("Primero debe cerrar todas las ventanas abiertas antes de salir del sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult respuesta = MessageBox.Show(
                $"¿Desea salir del sistema?\n\n" +
                $"Usuario: {_Usuario.Nombre} {_Usuario.Apellido}\n" +
                $"Nombre de usuario: {_Usuario.UsuarioNombre}\n" +
                $"Acceso: {_Usuario.Acceso}",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                // Desuscribir el evento de FormClosing para permitir el cierre real
                this.FormClosing -= FrmMdiPrincipal_FormClosing;
                Application.Exit();
            }
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
            abrirForm(new FrmIngreso(_Usuario));

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

  
  

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void Menu_gestion_consultas_Click(object sender, EventArgs e)
        {

        }

        private void Menu_gestion_ventas_Click(object sender, EventArgs e)
        {

        }

        private void Menu_item_proveedores_Click_1(object sender, EventArgs e)
        {
            abrirForm(new FrmProveedor());
        }

        private void Menu_item_movientoStock_Click(object sender, EventArgs e)
        {
            abrirForm(new FrmMovimientoStockManual());
        }

        private void FrmMdiPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancelar el cierre por la X u otras formas no permitidas
            e.Cancel = true;

            MessageBox.Show(
                "Para salir del sistema, usá el botón 'Salir' del menú.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
