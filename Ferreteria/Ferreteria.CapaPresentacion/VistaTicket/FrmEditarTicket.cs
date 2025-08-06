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

namespace Ferreteria.CapaPresentacion.VistaTicket
{
    public partial class FrmEditarTicket : Form
    {

        private ConfigurarTicket _ConfigurarTicket = null;

        public FrmEditarTicket()
        {
            InitializeComponent();
            Text = "Editar Configuración de Ticket";
        }
        public FrmEditarTicket(ConfigurarTicket configurarTicket)
        {
            InitializeComponent();
            this._ConfigurarTicket = configurarTicket;
        }





        private void FrmEditarTicket_Load(object sender, EventArgs e)
        {
            if (_ConfigurarTicket != null)
            {
                MostrarDatos();
            }
        }

     
        private void MostrarDatos()
        {
            lbl_Id_ConfigurarTicket.Text =_ConfigurarTicket.Id_ConfiguracionTicket.ToString();
            txt_nombre_negocio.Text =_ConfigurarTicket.NombreNegocio;
            txt_ciudad.Text = _ConfigurarTicket.Ciudad;
            txt_direccion.Text = _ConfigurarTicket.Direccion;
            txt_telefono.Text = _ConfigurarTicket.Telefono;
            txt_cuit.Text = _ConfigurarTicket.CUIT;
            txt_email.Text = _ConfigurarTicket.Email;
            txt_frasePresupuesto.Text = _ConfigurarTicket.FraseDespedidaPresupuesto;
            txt_fraseVenta.Text = _ConfigurarTicket.FraseDespedidaVenta;
            txt_impresoraTermica.Text = _ConfigurarTicket.NombreImpresoraTermica;

        }



        private bool ValidarVacio()
        {
            bool esValido = true;

            if (txt_nombre_negocio.Text == string.Empty)
            {
                errorIcono.SetError(txt_nombre_negocio, "El campo es obligatorio, ingrese el Nombre");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_nombre_negocio, "");
            }

            if (txt_ciudad.Text == string.Empty)
            {
                errorIcono.SetError(txt_ciudad, "El campo es obligatorio, ingrese la Ciudad");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_ciudad, "");
            }

            if (txt_direccion.Text == string.Empty)
            {
                errorIcono.SetError(txt_direccion, "El campo es obligatorio, ingrese la Dirección");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_direccion, "");
            }

            if (txt_telefono.Text == string.Empty)
            {
                errorIcono.SetError(txt_telefono, "El campo es obligatorio, ingrese el Teléfono");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_telefono, "");
            }

            if (txt_cuit.Text == string.Empty)
            {
                errorIcono.SetError(txt_cuit, "El campo es obligatorio, ingrese el CUIT");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_cuit, "");
            }

       

            if (txt_frasePresupuesto.Text == string.Empty)
            {
                errorIcono.SetError(txt_frasePresupuesto, "Ingrese una frase de despedida para el presupuesto");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_frasePresupuesto, "");
            }

            if (txt_fraseVenta.Text == string.Empty)
            {
                errorIcono.SetError(txt_fraseVenta, "Ingrese una frase de despedida para la venta");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_fraseVenta, "");
            }

            if (txt_impresoraTermica.Text == string.Empty)
            {
                errorIcono.SetError(txt_impresoraTermica, "Ingrese el nombre de la impresora térmica");
                esValido = false;
            }
            else
            {
                errorIcono.SetError(txt_impresoraTermica, "");
            }


            return esValido;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }


        private void GuardarConfiguracion()
        {
            try
            {
                if (ValidarVacio())
                {
                    errorIcono.Clear();

                    // Obtener los datos actuales del formulario
                    ConfigurarTicket config = new ConfigurarTicket();

                    config.Id_ConfiguracionTicket = Convert.ToInt32(lbl_Id_ConfigurarTicket.Text); 
                    config.NombreNegocio = txt_nombre_negocio.Text.Trim();
                    config.Ciudad = txt_ciudad.Text.Trim(); 
                    config.Direccion = txt_direccion.Text.Trim();
                    config.Telefono = txt_telefono.Text.Trim();
                    config.CUIT = txt_cuit.Text.Trim();
                    config.Email = txt_email.Text.Trim();
                    config.FraseDespedidaPresupuesto = txt_frasePresupuesto.Text.Trim();
                    config.FraseDespedidaVenta = txt_fraseVenta.Text.Trim();
                    config.NombreImpresoraTermica = txt_impresoraTermica.Text.Trim();
                    

                    CN_ConfigurarTicket _CN_ConfigurarTicket = new CN_ConfigurarTicket();
                    _CN_ConfigurarTicket.EditarConfiguracionTicket(config);


                    MessageBox.Show("¡El Ticket fue modificado exitosamente!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la configuración:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
