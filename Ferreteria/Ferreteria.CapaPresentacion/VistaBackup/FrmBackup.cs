using Ferreteria.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.CapaPresentacion.VistaBackup
{
    public partial class FrmBackup : Form
    {

        private string carpetaBackupAuto;
        private TimeSpan horaBackupAuto;
        private bool backupHechoHoy = false;
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            // Cargar hora persistente
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UltimaFechaHora))
                dtpHoraBackup.Value = DateTime.Parse(Properties.Settings.Default.UltimaFechaHora);
            else
                dtpHoraBackup.Value = DateTime.Now;

            // Cargar carpeta persistente
            if (!string.IsNullOrEmpty(Properties.Settings.Default.CarpetaBackup))
            {
                carpetaBackupAuto = Properties.Settings.Default.CarpetaBackup;
                Txt_carpeta.Text = carpetaBackupAuto;
            }

            // Iniciar timer si ya había configuración
            if (!string.IsNullOrEmpty(carpetaBackupAuto))
            {
                horaBackupAuto = dtpHoraBackup.Value.TimeOfDay;
                timer1.Interval = 60000; // 1 minuto
                timer1.Start();
            }
        }

        private void Btn_crear_respaldo_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (!Directory.Exists(carpetaBackupAuto))
                {
                    MessageBox.Show("La carpeta seleccionada no existe o no tiene permisos. Se recomienda usar C:\\BackupFerreteria.");
                    return;
                }


                string archivoBackup = Path.Combine(carpetaBackupAuto,"Ferreteria_DB_" + DateTime.Now.ToString("d-MM-yyyy_HH-mm-ss") + "_RESPALDO_MANUAL.bak");

                CN_BackupRestore backup = new CN_BackupRestore();
                backup.HacerBackup("Ferreteria_DB", archivoBackup);

                MessageBox.Show("Backup manual realizado en: " + archivoBackup);
            }

        }

        private void Btn_restaurar_respaldo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Backup (*.bak)|*.bak";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string archivoBackup = ofd.FileName;

                    CN_BackupRestore restore = new CN_BackupRestore();
                    restore.RestaurarBackup("Ferreteria_DB", archivoBackup);

                    MessageBox.Show("Base de datos restaurada desde: " + archivoBackup);
                }
            }
        }

        private void Btn_seleccionarCarpeta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Guardar carpeta seleccionada
                    carpetaBackupAuto = fbd.SelectedPath;
                    Txt_carpeta.Text = carpetaBackupAuto; // opcional, si querés mostrar en un TextBox

                    // Recomendar usar C:\BackupFerreteria si la carpeta no está en C:\
                    if (!carpetaBackupAuto.StartsWith("C:\\"))
                    {
                        MessageBox.Show("Se recomienda guardar los backups en una carpeta de disco local, por ejemplo C:\\BackupFerreteria, para evitar problemas de permisos.");
                    }

                    // Guardar hora seleccionada en DateTimePicker
                    horaBackupAuto = dtpHoraBackup.Value.TimeOfDay;

                    // Guardar ambos valores en Settings para persistencia
                    Properties.Settings.Default.CarpetaBackup = carpetaBackupAuto;
                    Properties.Settings.Default.UltimaFechaHora = dtpHoraBackup.Value.ToString();
                    Properties.Settings.Default.Save();

                    // Configurar timer para revisar cada minuto
                    timer1.Interval = 60000; 
                    timer1.Start();

                    MessageBox.Show("Respaldo automático configurado para las " + horaBackupAuto);
                }
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now.TimeOfDay;

            if (now.Hours == horaBackupAuto.Hours &&
                now.Minutes == horaBackupAuto.Minutes &&
                !backupHechoHoy)
            {
                if (!Directory.Exists(carpetaBackupAuto))
                {
                    MessageBox.Show("La carpeta seleccionada no existe o no tiene permisos. Se recomienda usar C:\\BackupFerreteria.");
                    return;
                }

                string archivoBackup = Path.Combine(
                    carpetaBackupAuto,
                    "Ferreteria_DB_" + DateTime.Now.ToString("d-MM-yyyy_HH-mm-ss") + "_RESPALDO_AUTOMATICO.bak"
                ); 

                CN_BackupRestore backup = new CN_BackupRestore();
                backup.HacerBackup("Ferreteria_DB", archivoBackup);

                MessageBox.Show("Backup automático realizado en: " + archivoBackup);

                backupHechoHoy = true; // evita duplicados en el mismo minuto
            }

            // Reiniciar flag si cambia la hora o minuto
            if (now.Hours != horaBackupAuto.Hours || now.Minutes != horaBackupAuto.Minutes)
                backupHechoHoy = false;
        }


        private void FrmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UltimaFechaHora = dtpHoraBackup.Value.ToString();
            Properties.Settings.Default.Save();
        }
    } 
}

