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

namespace Ferreteria.CapaPresentacion.VistaEspecificacion
{
    public partial class FrmAgregarEditarEspecificacion : Form
    {
        private Especificacion Especificacion;
        public FrmAgregarEditarEspecificacion()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarEspecificacion(Especificacion especificacion)
        {
            InitializeComponent();
            this.Especificacion = especificacion;
        }
        private void FrmAgregarEditarEspecificacion_Load(object sender, EventArgs e)
        {

        }
    }
}
