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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaValorEspecificacion
{
    public partial class FrmAgregarEditarValorEspecificacion : Form
    {
        private ValorEspecificacion _ValorEspecificacion;

        public FrmAgregarEditarValorEspecificacion()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarValorEspecificacion(ValorEspecificacion valorEspecificacion)
        {
            InitializeComponent();
            this._ValorEspecificacion = valorEspecificacion;
            Text = "Agregar Valor Especificacion";
        }
        private void FrmAgregarEditarValorEspecificacion_Load(object sender, EventArgs e)
        {
            if (_ValorEspecificacion != null)
            {
                MostrarDatos();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarValorEspecificacion();
        }
        private void GuardarValorEspecificacion()
        {
            CN_ValorEspecificacion logicaValorEspecificacion = new CN_ValorEspecificacion();
            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_ValorEspecificacion == null)
                        _ValorEspecificacion = new ValorEspecificacion();

                    _ValorEspecificacion.Valor = txt_nombre_ValorEspecificacion.Text.Trim().ToUpper();

                    if (_ValorEspecificacion.Id_ValorEspecificacion != 0)
                    {

                        logicaValorEspecificacion.EditarValorEspecificacion(_ValorEspecificacion);
                        MessageBox.Show("¡El Valor Especificacion fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaValorEspecificacion.InsertarValorEspecificacion(_ValorEspecificacion);
                        MessageBox.Show("¡El Valor Especificacion fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre_ValorEspecificacion, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_IdvalorEspecificacion.Text = _ValorEspecificacion.Id_ValorEspecificacion.ToString();
            txt_nombre_ValorEspecificacion.Text = _ValorEspecificacion.Valor;

        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_ValorEspecificacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_ValorEspecificacion, "El campo  es obligatorio, ingrese el Nombre ");


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
