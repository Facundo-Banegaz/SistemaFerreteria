using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_TipoMovimiento
    {
        //inicializa
        private CD_Conexion Conexion;
        private TipoMovimiento tipoMovimiento;
        private List<TipoMovimiento> listaTipoMovimiento;


        public List<TipoMovimiento> ListarTipoMovimiento()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaTipoMovimiento = new List<TipoMovimiento>();

            try
            {

                Conexion.SetConsulta("select Id_TipoMovimiento, Nombre, Descripcion, Movimiento from TiposMovimiento where Id_TipoMovimiento>2;");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    tipoMovimiento = new TipoMovimiento();


                    tipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimiento"];
                    tipoMovimiento.Nombre = (string)Conexion.Lector["Nombre"];
                    tipoMovimiento.Descripcion = (string)Conexion.Lector["Descripcion"];
                    tipoMovimiento.Movimiento = (char)Conexion.Lector["Movimiento"];

                    listaTipoMovimiento.Add(tipoMovimiento);
                }

                return listaTipoMovimiento;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexion.CerrarConexion();
            }

        }

    }
}
