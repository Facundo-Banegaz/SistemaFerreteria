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

namespace Ferreteria.CapaPresentacion.VistaProveedor
{
    public partial class FrmAgregarEditarProveedor : Form
    {
        private Proveedor _Proveedor = null;

        public FrmAgregarEditarProveedor()
        {
            InitializeComponent();
            Text = "Agregar Proveedor";
        }
        public FrmAgregarEditarProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            Text = "Editar Proveedor";
            this._Proveedor = proveedor;    
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
        }

        private void FrmAgregarEditarProveedor_Load(object sender, EventArgs e)
        {
            if (_Proveedor != null)
            {
                MostrarDatos();
            }


        }
        private void GuardarProveedor()
        {
            CN_Proveedor logicaProveedor = new CN_Proveedor();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Proveedor == null)
                        _Proveedor = new Proveedor();

                    _Proveedor.Nombre = txt_nombre_proveedor.Text.Trim().ToUpper();
                    _Proveedor.SectorComercial = txt_proveddor_sectorComercial.Text.Trim().ToUpper();

                    if (_Proveedor.Id_Proveedor != 0)
                    {
                        _Proveedor.Id_Proveedor = int.Parse(lbl_proveedor.Text.Trim());
                        logicaProveedor.EditarProveedor(_Proveedor);
                        MessageBox.Show("¡El Proveedor fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaProveedor.InsertarProveedor(_Proveedor);
                        MessageBox.Show("¡El Proveedor fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre_proveedor, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_proveedor.Text = _Proveedor.Id_Proveedor.ToString();
            txt_nombre_proveedor.Text = _Proveedor.Nombre;
            txt_proveddor_sectorComercial.Text = _Proveedor.SectorComercial;

        }

        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_proveedor.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_proveedor, "El campo  es obligatorio, ingrese el Nombre ");


                error = false;
            }
            if (txt_proveddor_sectorComercial.Text == string.Empty)
            {
                errorIcono.SetError(txt_proveddor_sectorComercial, "El campo  es obligatorio, ingrese el Nombre ");


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
