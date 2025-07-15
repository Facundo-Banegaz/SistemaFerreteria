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

namespace Ferreteria.CapaPresentacion.VistaUnidadMedida
{
    public partial class FrmAgregarEditarUnidadMedida : Form
    {
        private UnidadMedida _UnidadMedida = null;
        public FrmAgregarEditarUnidadMedida()
        {
            InitializeComponent();
            Text = "Agregar UnidadMedida:";
        }

        public FrmAgregarEditarUnidadMedida( UnidadMedida unidadMedida)
        {
            InitializeComponent();
            Text = "Editar UnidadMedida:";
            this._UnidadMedida = unidadMedida;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            GuardarUnidadMedida();
        }

        private void FrmAgregarEditarUnidadMedida_Load(object sender, EventArgs e)
        {
            if (_UnidadMedida != null)
            {
                MostrarDatos();
            }
        }

        private void GuardarUnidadMedida()
        {
           CN_UnidadMedida _logicaUnidadMedida =new CN_UnidadMedida();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_UnidadMedida == null)
                        _UnidadMedida = new UnidadMedida();

                    _UnidadMedida.Nombre = txt_nombre.Text.Trim().ToUpper();
                    _UnidadMedida.Abreviacion = txt_abreviacion.Text.Trim().ToUpper();
                    _UnidadMedida.PermiteDecimales = Chk_PermiteDecimales.Checked;

                    if (_UnidadMedida.Id_UnidadMedida != 0)
                    {
                       
                        _logicaUnidadMedida.EditarUnidadMedida(_UnidadMedida);
                        MessageBox.Show("¡La Unidad de Medida fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        _logicaUnidadMedida.InsertarUnidadMedida(_UnidadMedida);
                        MessageBox.Show("¡La Unidad de Medida fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_categoria.Text = _UnidadMedida.Id_UnidadMedida.ToString();
            txt_nombre.Text = _UnidadMedida.Nombre;
            txt_abreviacion.Text = _UnidadMedida.Abreviacion;
            Chk_PermiteDecimales.Checked = _UnidadMedida.PermiteDecimales;
        }



        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            if (txt_abreviacion.Text == string.Empty)
            {
                errorIcono.SetError(txt_abreviacion, "El campo  es obligatorio, ingrese el Nombre ");


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
