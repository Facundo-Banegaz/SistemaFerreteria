using Ferreteria.CapaDatos;
using Ferreteria.CapaDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_ConfigurarTicket
    {
        private CD_ConfigurarTicket _CD_ConfigurarTicket;

        //Metodo para Listar los ticket em la DataWirdView
        public ConfigurarTicket ObtenerConfiguracion()
        {
            _CD_ConfigurarTicket = new CD_ConfigurarTicket();

            return _CD_ConfigurarTicket.ObtenerConfiguracion();
        }
        //Metodo para Editar un Ticket en la Base de Datos
        public void EditarConfiguracionTicket(ConfigurarTicket Config)
        {
            _CD_ConfigurarTicket = new CD_ConfigurarTicket();

            _CD_ConfigurarTicket.EditarConfiguracion(Config);
        }
    }
}
