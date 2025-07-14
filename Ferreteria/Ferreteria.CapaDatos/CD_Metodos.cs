using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Ferreteria.CapaDatos
{
    public class CD_Metodos
    {
        private CD_Conexion Conexion;

        // Metodo para alternar los colores en las filas de un data grid
        public void AlternarColor(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        public (string Serie, string Correlativo) GenerarSerieYCorrelativo(string tabla, string tipoDocumento)
        {
            string serie;

            switch (tipoDocumento)
            {
                
                case "TICKET":
                    serie = "T001";
                    break;
                case "BOLETA":
                    serie = "B001";
                    break;
                default:
                    serie = "S001";
                    break;
            }

            Conexion = new CD_Conexion();
            Conexion.SetConsulta($"SELECT COUNT(*) AS Total FROM {tabla}");
            Conexion.EjecutarLectura();

            long total = 0;
            if (Conexion.Lector.Read())
                total = Convert.ToInt64(Conexion.Lector["Total"]) + 1;

            Conexion.CerrarConexion();

            string correlativo = total.ToString().PadLeft(8, '0');
            return (serie, correlativo);
        }


        //Metodo de moneda
        public void FormatoMoneda(TextBox xTextBox)
        {
            if (string.IsNullOrWhiteSpace(xTextBox.Text))
                return;

            if (decimal.TryParse(xTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal monto))
            {
                xTextBox.Text = monto.ToString("N2", CultureInfo.CreateSpecificCulture("es-AR"));
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                xTextBox.Focus();
                xTextBox.SelectAll();
            }
        }

    }
}
