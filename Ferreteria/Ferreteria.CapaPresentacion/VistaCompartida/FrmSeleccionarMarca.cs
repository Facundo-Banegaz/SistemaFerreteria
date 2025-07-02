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

namespace Ferreteria.CapaPresentacion.VistaCompartida
{

    public partial class FrmSeleccionarMarca : Form
    {
        private List<Marca> listaMarcas;
        // Definís un delegado y un evento para pasar datos
        public delegate void MarcaSeleccionadoHandler(string Id_Marca, string Nombre);
        public event MarcaSeleccionadoHandler MarcaSeleccionada;
        public FrmSeleccionarMarca()
        {
            InitializeComponent();
            Text = "Seleccionar Marca:";
        }

        private void dgv_marcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSeleccionarMarca_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            ArregloDataGridView(dgv_marcas);
        }


        ///Funciones propias
        private void ArregloDataGridView(DataGridView dgv_productos)
        {

            //logica del dataGridView
            CN_Metodos _Metodos = new CN_Metodos();


            dgv_productos.Columns["Id_Marca"].Width = 400;
            dgv_productos.Columns["Nombre"].Width = 800;// nombre_producto


            dgv_productos.Columns["Id_Marca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_productos.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            _Metodos.AlternarColor(dgv_productos);
        }
        private void CargarGrilla()
        {
            //logica del dataGridView
            CN_Marca _Marca = new CN_Marca();

            listaMarcas = _Marca.ListaMarca();

            dgv_marcas.DataSource = listaMarcas;
            lbl_total.Text = "Total de Registros:  " + Convert.ToString(dgv_marcas.Rows.Count);
            lbl_resultado.Text = "";

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            BuscarMarca();
            txt_buscar.Clear();     // limpia el campo
            txt_buscar.Focus();     // focus
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            txt_buscar.Clear();
            CargarGrilla();
        }
          
        private void BuscarMarca()
        {
            CN_Marca marca = new CN_Marca();

            if (txt_buscar.Text == string.Empty)
            {
                MessageBox.Show("El CAMPO NO PUEDE QUEDAR VACIO!!", "ADVERTENCIA");

                lbl_resultado.Text = "No escribio nada en el campo  'Buscador'.";
            }
            else
            {
                dgv_marcas.DataSource = marca.MarcaBuscar(txt_buscar.Text);

                lbl_total.Text = "Total de Registros Encontrados:" + " " + Convert.ToString(dgv_marcas.Rows.Count);
                lbl_resultado.Text = "Para volver a ver el listado completo 'Limpiar' el campo!!.";
            }
        }

        private void dgv_marcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Marca = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["Id_Marca"].Value);
            string Nombre = Convert.ToString(this.dgv_marcas.CurrentRow.Cells["Nombre"].Value);

            // Invocás el evento si hay algún método suscripto
            MarcaSeleccionada?.Invoke(Id_Marca, Nombre);

            this.Close();
        }
    }
}
