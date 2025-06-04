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

namespace Ferreteria.CapaPresentacion.VistaMarca
{
    public partial class FrmAgregarEditarMarca : Form
    {

        private Marca _Marca = null;
        public FrmAgregarEditarMarca()
        {
            InitializeComponent();
            Text = "Agregar Marca";
        }

        public FrmAgregarEditarMarca(Marca marca)
        {
            InitializeComponent();
            this._Marca = marca;
            Text = "Editar Marca";
        }
        private void FrmAgregarEditarMarca_Load(object sender, EventArgs e)
        {
            if (_Marca != null)
            {
                MostrarDatos();
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarMarca();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GuardarMarca()
        {
            CN_Marca logicaMarca = new CN_Marca();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Marca == null)
                        _Marca = new Marca();

                    _Marca.Nombre = txt_nombre_marca.Text.Trim().ToUpper();

                    if (_Marca.Id_Marca != 0)
                    {
                        _Marca.Id_Marca = int.Parse(lbl_marca.Text.Trim());
                        logicaMarca.EditarMarca(_Marca);
                        MessageBox.Show("¡La Marca fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaMarca.InsertarMarca(_Marca);
                        MessageBox.Show("¡La Marca fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre_marca, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_marca.Text = _Marca.Id_Marca.ToString();
            txt_nombre_marca.Text = _Marca.Nombre;

        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_marca.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_marca, "El campo  es obligatorio, ingrese el Nombre ");


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
