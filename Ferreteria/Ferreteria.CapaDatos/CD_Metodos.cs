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
        public void AlternarColor(DataGridView dgv)
        {
            // Color alternado para filas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255); // Celeste claro

            // Color de fondo para filas normales
            dgv.DefaultCellStyle.BackColor = Color.White;

            // Color del texto
            dgv.DefaultCellStyle.ForeColor = Color.Black;

            // Color de selección
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255); // Azul fuerte
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Color de cabecera
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204); // Azul cabecera
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false; // Para aplicar color de cabecera
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
        public void FormatoMoneda(TextBox xTextBox)
        {
            if (string.IsNullOrWhiteSpace(xTextBox.Text))
                return;

            // Intentar convertir respetando coma decimal
            if (decimal.TryParse(xTextBox.Text, NumberStyles.Any, new CultureInfo("es-AR"), out decimal monto))
            {
                xTextBox.Text = monto.ToString("N2", new CultureInfo("es-AR"));
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
