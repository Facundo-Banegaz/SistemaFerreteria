using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDatos
{
    public class CD_BackupRestore
    {
        public void HacerBackup(string nombreDB, string rutaArchivo)
        {
            CD_Conexion conexion = new CD_Conexion();

            try
            {
                conexion.SetConsulta($@"BACKUP DATABASE [{nombreDB}] TO DISK = '{rutaArchivo}' WITH INIT, NOFORMAT, SKIP, NAME = 'Backup_{nombreDB}', STATS = 10;");

                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar backup", ex);
            }

        }
        public void RestaurarBackup(string nombreDB, string rutaArchivo)
        {

            CD_Conexion conexion = new CD_Conexion("Conexion_Master");
            try
            {

                // 🔹 Poner la BD en SINGLE_USER para restaurar
                conexion.SetConsulta($@"ALTER DATABASE [{nombreDB}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                conexion.EjecutarAccion();

                // 🔹 Restaurar desde el archivo
                conexion.SetConsulta($@"     RESTORE DATABASE [{nombreDB}] FROM DISK = '{rutaArchivo}'   WITH REPLACE");

                conexion.EjecutarAccion();

                // 🔹 Devolver la BD a multiusuario
                conexion.SetConsulta($@"ALTER DATABASE [{nombreDB}] SET MULTI_USER");

                conexion.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al restaurar backup", ex);
            }

        }
    }
}
        ////public void HacerBackup(string nombreDB, string rutaDestino)
        ////{
        ////    CD_Conexion conexion = new CD_Conexion();

        ////    try
        ////    {
        ////        conexion.SetConsultaProcedure("sp_BackupDatabase");
        ////        conexion.SetearParametro("@DatabaseName", nombreDB);
        ////        conexion.SetearParametro("@BackupPath", rutaDestino);

        ////        conexion.EjecutarAccion();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw new Exception("Error al realizar backup", ex);
        ////    }
        ////}
        ////public void RestaurarBackup(string nombreDB, string rutaArchivo)
        ////{
        ////    CD_Conexion conexion = new CD_Conexion();

        ////    try
        ////    {
        ////        conexion.SetConsultaProcedure("sp_RestoreDatabase");
        ////        conexion.SetearParametro("@DatabaseName", nombreDB);
        ////        conexion.SetearParametro("@BackupPath", rutaArchivo);

        ////        conexion.EjecutarAccion();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw new Exception("Error al restaurar backup", ex);
        ////    }
        ////}
    
