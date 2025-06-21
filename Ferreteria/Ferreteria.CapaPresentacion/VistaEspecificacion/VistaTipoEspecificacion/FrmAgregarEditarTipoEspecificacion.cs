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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaTipoEspecificacion
{
    public partial class FrmAgregarEditarTipoEspecificacion : Form
    {
        private TipoEspecificacion _TipoEspecificacion = null;
        public FrmAgregarEditarTipoEspecificacion()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarTipoEspecificacion(TipoEspecificacion tipoEspecificacion)
        {
            InitializeComponent();
            Text = "Agregar Tipo Especificacion";
            this._TipoEspecificacion = tipoEspecificacion;
        }

        private void FormAgregarEditarTipoEspecificacion_Load(object sender, EventArgs e)
        {
            if (_TipoEspecificacion != null)
            {
                MostrarDatos();
            }
        }

     
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarTipoEspecificacion();
        }

        private void GuardarTipoEspecificacion()
        {
            CN_TipoEspecificacion logicaTipoEspecificacion = new CN_TipoEspecificacion();
            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_TipoEspecificacion == null)
                        _TipoEspecificacion = new TipoEspecificacion();

                    _TipoEspecificacion.Nombre = txt_nombre_TiposEspecificacion.Text.Trim().ToUpper();

                    if (_TipoEspecificacion.Id_TipoEspecificacion != 0)
                    {
                     
                        logicaTipoEspecificacion.EditarTipoEspecificacion(_TipoEspecificacion);
                        MessageBox.Show("¡El Tipo Especificacion fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaTipoEspecificacion.InsertarTipoEspecificacion(_TipoEspecificacion);
                        MessageBox.Show("¡El Tipo Especificacion fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Mostrar mensaje amigable si es un error de duplicado
                errorIcono.SetError(txt_nombre_TiposEspecificacion, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_tipoEspecificacion.Text = _TipoEspecificacion.Id_TipoEspecificacion.ToString();
            txt_nombre_TiposEspecificacion.Text = _TipoEspecificacion.Nombre;

        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_TiposEspecificacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_TiposEspecificacion, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            else
            {
                errorIcono.Clear();
            }

            return error;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

