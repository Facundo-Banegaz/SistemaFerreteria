using Ferreteria.CapaDominio;
using Ferreteria.CapaNegocio;
using Ferreteria.CapaPresentacion.VistaCategoria;
using Ferreteria.CapaPresentacion.VistaInventario;
using Ferreteria.CapaPresentacion.VistaMarca;
using Ferreteria.CapaPresentacion.VistaMovimientoStock;
using Ferreteria.CapaPresentacion.VistaProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaKardex
{
    public partial class FrmKardex : Form
    {
        private readonly Dictionary<TabPage, Form> formulariosPorPestaña = new Dictionary<TabPage, Form>();
        public FrmKardex()
        {
            InitializeComponent();

        }


        private void AbrirFormEnTab(TabPage tab, Func<Form> crearFormulario)
        {
            if (!formulariosPorPestaña.TryGetValue(tab, out Form formulario))
            {
                formulario = crearFormulario();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;

                tab.Controls.Add(formulario);
                formulario.Show();

                formulariosPorPestaña[tab] = formulario;
            }
            else
            {
                formulario.Show();
            }

            // Ocultar formularios de otras pestañas
            foreach (var kvp in formulariosPorPestaña)
            {
                kvp.Value.Visible = kvp.Key == tab;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabSeleccionada = tabControl1.SelectedTab;
            if (tabSeleccionada == null) return;

            switch (tabSeleccionada.Name)
            {

                case "Tp_InventarioBajo":
                    AbrirFormEnTab(tabSeleccionada, () => new FrmInventarioBajo());
                    break;
            
                case "Tp_VencimientosProductos":
                    AbrirFormEnTab(tabSeleccionada, () => new FrmVencimientosProductos());
                    break;
                    // Agrega más casos si tenés más pestañas
            }
        }

        private void FrmKardex_Load(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                tabControl1.SelectedIndex = 0; // Selecciona la primer pestaña
                tabControl1_SelectedIndexChanged(tabControl1, EventArgs.Empty); // Forzar cargar formulario
            }
        }
    }
}
