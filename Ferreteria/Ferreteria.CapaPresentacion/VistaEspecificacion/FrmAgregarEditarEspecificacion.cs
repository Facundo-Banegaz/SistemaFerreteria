using Ferreteria.CapaDominio;
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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion
{
    public partial class FrmAgregarEditarEspecificacion : Form
    {
        private Especificacion Especificacion;
        public FrmAgregarEditarEspecificacion()
        {
            InitializeComponent();
            Text = "Agregar Especificación";
        }
        public FrmAgregarEditarEspecificacion(Especificacion especificacion)
        {
            InitializeComponent();
            this.Especificacion = especificacion;
            Text = "Editar Especificación";
        }
        private void FrmAgregarEditarEspecificacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProducto frmSeleccionar = new FrmSeleccionarProducto();

            // Suscribís al evento
            frmSeleccionar.ProductoSeleccionado += (Id_Producto, Nombre) =>
            {
                txt_id_producto.Text = Id_Producto;
                txt_nombre_producto.Text = Nombre;
            };

            frmSeleccionar.ShowDialog();
        }

  

        private void btn_tipo_especificacion_Click(object sender, EventArgs e)
        {

        }
        private void setTipoEspecificacion(string Id_TipoEspecificaion, string Nombre)
        {
            txt_id_TipoEspecificacion.Text = Id_TipoEspecificaion;
            txt_nombre_TipoEspecificacion.Text= Nombre;
        }
        private void btn_valor_especificacion_Click(object sender, EventArgs e)
        {

        }

        private void setValorEspecificacion(string Id_ValorEspecificaion, string Valor)
        {
            txt_id_valorEspecificacion.Text = Id_ValorEspecificaion;
            txt_valorEspecificacion.Text = Valor;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
