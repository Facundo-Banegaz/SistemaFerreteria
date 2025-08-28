using Ferreteria.CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaNegocio
{
    public class CN_BackupRestore
    {

        private CD_BackupRestore objDatos = new CD_BackupRestore();

        // Método para generar backup
        public void HacerBackup(string nombreBD, string rutaArchivo)
        {
            try
            {
                objDatos.HacerBackup(nombreBD, rutaArchivo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al realizar el backup: " + ex.Message);
            }
        }

        // Método para restaurar backup
        public void RestaurarBackup(string nombreBD, string rutaArchivo)
        {
            try
            {
                objDatos.RestaurarBackup(nombreBD, rutaArchivo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de negocio al restaurar el backup: " + ex.Message);
            }
        }
    }
}
