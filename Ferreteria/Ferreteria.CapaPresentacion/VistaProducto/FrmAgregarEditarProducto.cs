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

namespace Ferreteria.CapaPresentacion.VistaProducto
{
    public partial class FrmAgregarEditarProducto : Form
    {
        private Producto producto = null;
        public FrmAgregarEditarProducto()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }
        private void FrmAgregarEditarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
