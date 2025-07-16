using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaVenta
{
    public partial class FrmAgregarVenta : Form
    {
        public Usuario _Usuario;
        public FrmAgregarVenta()
        {
            InitializeComponent();
            Text = "Gestion Historial de  Ingresos";
        }
        public FrmAgregarVenta(Usuario usuario)
        {
            InitializeComponent();
            this._Usuario = usuario;
        }
        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
