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

                Conexion.SetConsulta("SELECT Id_TipoMovimiento, Nombre FROM TiposMovimiento");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    tipoMovimiento = new TipoMovimiento();


                    tipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimiento"];
                    tipoMovimiento.Nombre = (string)Conexion.Lector["Nombre"];
   

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

        public List<TipoMovimiento> ListarTipoMovimientoStockManual()
        {

            //instancia

            Conexion = new CD_Conexion();

            listaTipoMovimiento = new List<TipoMovimiento>();

            try
            {

                Conexion.SetConsulta("SELECT Id_TipoMovimiento, Nombre FROM TiposMovimiento WHERE Id_TipoMovimiento IN (3,4,5,6,7,8,9);");

                Conexion.EjecutarLectura();

                while (Conexion.Lector.Read())
                {
                    tipoMovimiento = new TipoMovimiento();


                    tipoMovimiento.Id_TipoMovimiento = (int)Conexion.Lector["Id_TipoMovimiento"];
                    tipoMovimiento.Nombre = (string)Conexion.Lector["Nombre"];


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
