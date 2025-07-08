using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCompartida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    public partial class FrmAgregarEditarIngreso : Form
    {
        public Usuario _Usuario;
        public FrmAgregarEditarIngreso()
        {
            InitializeComponent();
            Text = "Agregar Ingreso";
        }
        public FrmAgregarEditarIngreso(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
            CargarCboComprobante();
            string tipo = cbo_comprobante.SelectedItem?.ToString(); // ✅ correcto
            CargarTextBox(tipo);
        }

        private void CargarCboComprobante()
        {


            cbo_comprobante.Items.Add("TICKET");
           
            cbo_comprobante.Items.Add("BOLETA");
       

            cbo_comprobante.SelectedIndex = 0;

            cbo_comprobante.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void CargarTextBox(string tipoDocumento)
        {
            CN_Metodos metodos = new CN_Metodos();

            try
            {
                string tipo = cbo_comprobante.SelectedItem.ToString();


                var (serie, correlativo) = metodos.GenerarSerieYCorrelativo("Ingresos", tipo);


                if (tipo == "TICKET")
                {
                    lbl_encabezado.Text = "TICKET DE COMPRA";
                } else
                {

                    lbl_encabezado.Text = "BOLETA DE COMPRA";
                }
                   
                lbl_serie_correlativo.Text = $"Comprobante N°: {serie}-{correlativo}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar comprobante: " + ex.Message);
            }
        }


  
        private void FrmAgregarEditarIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_comprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string tipo = cbo_comprobante.SelectedItem?.ToString();
         
            CargarTextBox(tipo);
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoSeleccionado += (Id_Producto, Nombre) =>
            {
                txt_id_proveedor.Text = Id_Producto;
                txt_producto.Text = Nombre;
            };

            frmSeleccionar.ShowDialog();
        }

        private void Btn_proveedor_Click(object sender, EventArgs e)
        {
            //FrmSeleccionarProveedor frmSeleccionar = new FrmSeleccionarProveedor();

            // Suscribís al evento
            ////frmSeleccionar.ProveedorSeleccionado += (Id_Proveedor, Nombre, SectorComercial) =>
            ////{
            ////    txt_id_proveedor.Text = Id_Proveedor;
            ////    txt_nombre_proveedor.Text = Nombre;
            ////   txt_sectorComercial.Text = SectorComercial;
            ////};

            ////frmSeleccionar.ShowDialog();
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
