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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion
{
    public partial class FrmAgregarEditarEspecificacion : Form
    {
        private Especificacion _Especificacion;
        public FrmAgregarEditarEspecificacion()
        {
            InitializeComponent();
            Text = "Agregar Especificación";
        }
        public FrmAgregarEditarEspecificacion(Especificacion especificacion)
        {
            InitializeComponent();
            this._Especificacion = especificacion;
            Text = "Editar Especificación";
        }
        private void FrmAgregarEditarEspecificacion_Load(object sender, EventArgs e)
        {
            if (_Especificacion != null)
            {
                MostrarDatos();
            }
        }

        private void MostrarDatos()
        {
            lbl_id_especificacion.Text =_Especificacion.Id_Especificacion.ToString();
            //relaciones
            txt_id_producto.Text = _Especificacion.Producto.Id_Producto.ToString();
            txt_nombre_producto.Text = _Especificacion.Producto.Nombre;

            txt_id_TipoEspecificacion.Text = _Especificacion.TipoEspecificacion.Id_TipoEspecificacion.ToString();
            txt_nombre_TipoEspecificacion.Text = _Especificacion.TipoEspecificacion.Nombre;

            txt_id_valorEspecificacion.Text = _Especificacion.ValorEspecificacion.Id_ValorEspecificacion.ToString();
            txt_valorEspecificacion.Text = _Especificacion.ValorEspecificacion.Valor;

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
            FrmSeleccionarTipoEspecificacion frmSeleccionar = new FrmSeleccionarTipoEspecificacion();

            // Suscribís al evento
            frmSeleccionar.TipoEspecificacioneleccionado += (Id_TipoEspecificacion, Nombre) =>
            {
                txt_id_TipoEspecificacion.Text = Id_TipoEspecificacion;
                txt_nombre_TipoEspecificacion.Text = Nombre;
            };

            frmSeleccionar.ShowDialog();
        }

        private void btn_valor_especificacion_Click(object sender, EventArgs e)
        {
            FrmSeleccionarValorEspecificacion frmSeleccionar = new FrmSeleccionarValorEspecificacion();

            // Suscribís al evento
            frmSeleccionar.ValorEspecificacionSeleccionado += (Id_ValorEspecificacion, Valor) =>
            {
                txt_id_valorEspecificacion.Text = Id_ValorEspecificacion;
                txt_valorEspecificacion.Text = Valor;
            };

            frmSeleccionar.ShowDialog();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarEspecificacion();
        }


        private void GuardarEspecificacion()
        {
           CN_Especificacion n_Especificacion = new CN_Especificacion();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Especificacion == null)
                        _Especificacion = new Especificacion();

                    _Especificacion.Producto = new Producto();

                    _Especificacion.Producto.Id_Producto = Convert.ToInt32(txt_id_producto.Text);

                    _Especificacion.TipoEspecificacion = new TipoEspecificacion();

                    _Especificacion.TipoEspecificacion.Id_TipoEspecificacion = Convert.ToInt32(txt_id_TipoEspecificacion.Text);

                    _Especificacion.ValorEspecificacion = new ValorEspecificacion();

                    _Especificacion.ValorEspecificacion.Id_ValorEspecificacion = Convert.ToInt32(txt_id_valorEspecificacion.Text);

                    if (_Especificacion.Id_Especificacion != 0)
                    {

                        n_Especificacion.EditarEspecificacion(_Especificacion);
                        MessageBox.Show("¡La Especificación fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        n_Especificacion.InsertarEspecificacion(_Especificacion);
                        MessageBox.Show("¡La Especificación fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Suponiendo que usás comboBoxTipo y comboBoxValor
                errorIcono.SetError(txt_nombre_TipoEspecificacion, ex.Message);
                errorIcono.SetError(txt_valorEspecificacion, ex.Message);

                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_producto.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_producto, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            if (txt_nombre_TipoEspecificacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_TipoEspecificacion, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            if (txt_valorEspecificacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_valorEspecificacion, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }

            else
            {
                errorIcono.Clear();
            }

            return error;
        }
    }
}
