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

namespace Ferreteria.CapaPresentacion.VistaCategoria
{
    public partial class FrmAgregarEditarCategoria : Form
    {
        private Categoria _Categoria = null;
        public FrmAgregarEditarCategoria()
        {
            InitializeComponent();
            Text = "Agregar Categoria";
        }
        public FrmAgregarEditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this._Categoria = categoria;
            Text = "Editar Categoria";
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void FrmAgregarEditarCategoria_Load(object sender, EventArgs e)
        {
            if (_Categoria != null)
            {
                MostrarDatos();
            }
        }

        private void GuardarCategoria()
        {
            CN_Categoria logicaCategoria = new CN_Categoria();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Categoria == null)
                        _Categoria = new Categoria();

                    _Categoria.Nombre = txt_nombre_categoria.Text.Trim().ToUpper();

                    if (_Categoria.Id_Categoria != 0)
                    {
                        _Categoria.Id_Categoria = int.Parse(lbl_categoria.Text.Trim());
                        logicaCategoria.EditarCategoria(_Categoria);
                        MessageBox.Show("¡La Categoría fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaCategoria.InsertarCategoria(_Categoria);
                        MessageBox.Show("¡La Categoría fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre_categoria, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            lbl_categoria.Text = _Categoria.Id_Categoria.ToString();
            txt_nombre_categoria.Text = _Categoria.Nombre;
        
        }

        private bool ValidarVacio()
        {
            errorIcono.Clear();
            bool error = true;

            if (txt_nombre_categoria.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_categoria, "El campo  es obligatorio, ingrese el Nombre ");


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
