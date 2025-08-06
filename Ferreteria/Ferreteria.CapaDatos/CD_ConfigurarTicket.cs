using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_ConfigurarTicket
    {

        //inicializa
        private CD_Conexion Conexion;
        private ConfigurarTicket Config;
       
        public ConfigurarTicket ObtenerConfiguracion()
        {
            Conexion = new CD_Conexion();
            

            try
            {
                Conexion.SetConsultaProcedure("sp_MostrarConfiguracionTicket");
                Conexion.EjecutarLectura();

                if (Conexion.Lector.Read())
                {
                    Config = new ConfigurarTicket();

                    Config.Id_ConfiguracionTicket = (int)Conexion.Lector["Id_ConfiguracionTicket"];
                    Config.NombreNegocio = (string)Conexion.Lector["NombreNegocio"];
                    Config.Ciudad = (string)Conexion.Lector["Ciudad"];
                    Config.Direccion = (string)Conexion.Lector["Direccion"];
                    Config.Telefono = (string)Conexion.Lector["Telefono"];
                    Config.CUIT = (string)Conexion.Lector["CUIT"];
                    Config.Email = (string)Conexion.Lector["Email"];
                    Config.TextoNoFactura = (string)Conexion.Lector["TextoNoFactura"];
                    Config.TextoVenta = (string)Conexion.Lector["TextoVenta"];
                    Config.TextoPresupuesto = (string)Conexion.Lector["TextoPresupuesto"];
                    Config.FraseDespedidaPresupuesto = (string)Conexion.Lector["FraseDespedidaPresupuesto"];
                    Config.FraseDespedidaVenta = (string)Conexion.Lector["FraseDespedidaVenta"];
                    Config.NombreImpresoraTermica = (string)Conexion.Lector["NombreImpresoraTermica"];
                }

                return Config;
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

        public void EditarConfiguracion(ConfigurarTicket Config)
        {
            Conexion = new CD_Conexion();

            try
            {
                Conexion.SetConsultaProcedure("Sp_ActualizarConfiguracionTicket");

                Conexion.SetearParametro("@Id_ConfiguracionTicket", Config.Id_ConfiguracionTicket);
                Conexion.SetearParametro("@NombreNegocio", Config.NombreNegocio);
                Conexion.SetearParametro("@Ciudad", Config.Ciudad);
                Conexion.SetearParametro("@Direccion", Config.Direccion);
                Conexion.SetearParametro("@Telefono", Config.Telefono);
                Conexion.SetearParametro("@CUIT", Config.CUIT);
                Conexion.SetearParametro("@Email", Config.Email);
          
                Conexion.SetearParametro("@FraseDespedidaPresupuesto", Config.FraseDespedidaPresupuesto);
                Conexion.SetearParametro("@FraseDespedidaVenta", Config.FraseDespedidaVenta);
                Conexion.SetearParametro("@NombreImpresoraTermica", Config.NombreImpresoraTermica);
                Conexion.EjecutarAccion();
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
