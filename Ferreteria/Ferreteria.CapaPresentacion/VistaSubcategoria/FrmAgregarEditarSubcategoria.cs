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

namespace Ferreteria.CapaPresentacion.VistaSubcategoria
{
    public partial class FrmAgregarEditarSubcategoria : Form
    {
        private SubCategoria _Subcategoria = null;
        public FrmAgregarEditarSubcategoria()
        {
            InitializeComponent();
            Text = "Agregar Subcategoria";
        }
        public FrmAgregarEditarSubcategoria(SubCategoria subcategoria)
        {
            InitializeComponent();
            this._Subcategoria = subcategoria;
            Text = "Editar Subcategoria";
        }



        private void FrmAgregarEditarSubcategoria_Load(object sender, EventArgs e)
        {
                MostrarDatos();   
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarSubcategoria();
        }



        private void GuardarSubcategoria()
        {
            CN_SubCategoria logicaSubCategoria = new CN_SubCategoria();

            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    if (_Subcategoria == null)
                        _Subcategoria = new SubCategoria();

                    _Subcategoria.Nombre = txt_nombre_subcategoria.Text.Trim().ToUpper();

                    _Subcategoria.Categoria = (Categoria)cbo_categoria.SelectedItem;

                    if (_Subcategoria.Id != 0)
                    {
                       
                        logicaSubCategoria.EditarSubCategoria(_Subcategoria);
                        MessageBox.Show("¡La Subcategoría fue modificada exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        logicaSubCategoria.InsertarSubCategoria(_Subcategoria);
                        MessageBox.Show("¡La Subcategoría fue agregada exitosamente!", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                errorIcono.SetError(txt_nombre_subcategoria, ex.Message);
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarDatos()
        {
            CN_Categoria _Categoria = new CN_Categoria();

            try
            {
                // Carga del comboBox
                cbo_categoria.DataSource = _Categoria.CargarCbo();
                cbo_categoria.ValueMember = "Id";
                cbo_categoria.DisplayMember = "Nombre";

                // Solo si la subcategoría no es null
                if (_Subcategoria != null)
                {
                    lbl_subcategoria.Text = _Subcategoria.Id.ToString();
                    txt_nombre_subcategoria.Text = _Subcategoria.Nombre;

                    if (_Subcategoria.Categoria != null)
                    {
                        cbo_categoria.SelectedValue = _Subcategoria.Categoria.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos: " + ex.Message);
            }
        }


        private bool ValidarVacio()
        {

            bool error = true;

            if (txt_nombre_subcategoria.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_subcategoria, "El campo  es obligatorio, ingrese el Nombre ");


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
