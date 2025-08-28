namespace Ferreteria.CapaPresentacion.VistaBackup
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.Btn_restaurar_respaldo = new System.Windows.Forms.Button();
            this.Btn_crear_respaldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraBackup = new System.Windows.Forms.DateTimePicker();
            this.Txt_carpeta = new System.Windows.Forms.TextBox();
            this.Btn_seleccionarCarpeta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_restaurar_respaldo
            // 
            this.Btn_restaurar_respaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_restaurar_respaldo.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_restaurar_respaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_restaurar_respaldo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_restaurar_respaldo.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_restaurar_respaldo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_restaurar_respaldo.Image")));
            this.Btn_restaurar_respaldo.Location = new System.Drawing.Point(456, 95);
            this.Btn_restaurar_respaldo.Name = "Btn_restaurar_respaldo";
            this.Btn_restaurar_respaldo.Size = new System.Drawing.Size(284, 65);
            this.Btn_restaurar_respaldo.TabIndex = 108;
            this.Btn_restaurar_respaldo.Text = "Restaurar Respaldo";
            this.Btn_restaurar_respaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_restaurar_respaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_restaurar_respaldo.UseVisualStyleBackColor = false;
            this.Btn_restaurar_respaldo.Click += new System.EventHandler(this.Btn_restaurar_respaldo_Click);
            // 
            // Btn_crear_respaldo
            // 
            this.Btn_crear_respaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_crear_respaldo.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_crear_respaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_crear_respaldo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear_respaldo.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_crear_respaldo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_crear_respaldo.Image")));
            this.Btn_crear_respaldo.Location = new System.Drawing.Point(15, 95);
            this.Btn_crear_respaldo.Name = "Btn_crear_respaldo";
            this.Btn_crear_respaldo.Size = new System.Drawing.Size(284, 65);
            this.Btn_crear_respaldo.TabIndex = 107;
            this.Btn_crear_respaldo.Text = "Generar Respaldo";
            this.Btn_crear_respaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_crear_respaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_crear_respaldo.UseVisualStyleBackColor = false;
            this.Btn_crear_respaldo.Click += new System.EventHandler(this.Btn_crear_respaldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 44);
            this.label1.TabIndex = 109;
            this.label1.Text = "Gestión de Respaldo de Base de Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpHoraBackup);
            this.groupBox1.Controls.Add(this.Txt_carpeta);
            this.groupBox1.Controls.Add(this.Btn_seleccionarCarpeta);
            this.groupBox1.Location = new System.Drawing.Point(12, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 383);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Automático";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(6, 235);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(734, 128);
            this.textBox1.TabIndex = 114;
            this.textBox1.Text = "Cada día, a la hora que elijas, se ejecutará automáticamente un backup y se guard" +
    "ará en la carpeta que seleccionaste.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "Hora del Backup:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpHoraBackup
            // 
            this.dtpHoraBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraBackup.Location = new System.Drawing.Point(15, 153);
            this.dtpHoraBackup.Name = "dtpHoraBackup";
            this.dtpHoraBackup.ShowUpDown = true;
            this.dtpHoraBackup.Size = new System.Drawing.Size(495, 44);
            this.dtpHoraBackup.TabIndex = 3;
            this.dtpHoraBackup.Value = new System.DateTime(2025, 8, 27, 17, 44, 0, 0);
            // 
            // Txt_carpeta
            // 
            this.Txt_carpeta.Location = new System.Drawing.Point(15, 47);
            this.Txt_carpeta.Multiline = true;
            this.Txt_carpeta.Name = "Txt_carpeta";
            this.Txt_carpeta.Size = new System.Drawing.Size(725, 46);
            this.Txt_carpeta.TabIndex = 2;
            // 
            // Btn_seleccionarCarpeta
            // 
            this.Btn_seleccionarCarpeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_seleccionarCarpeta.BackColor = System.Drawing.Color.Gold;
            this.Btn_seleccionarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_seleccionarCarpeta.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionarCarpeta.Location = new System.Drawing.Point(527, 148);
            this.Btn_seleccionarCarpeta.Name = "Btn_seleccionarCarpeta";
            this.Btn_seleccionarCarpeta.Size = new System.Drawing.Size(213, 55);
            this.Btn_seleccionarCarpeta.TabIndex = 1;
            this.Btn_seleccionarCarpeta.Text = "Seleccionar Carpeta";
            this.Btn_seleccionarCarpeta.UseVisualStyleBackColor = false;
            this.Btn_seleccionarCarpeta.Click += new System.EventHandler(this.Btn_seleccionarCarpeta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Btn_restaurar_respaldo);
            this.groupBox2.Controls.Add(this.Btn_crear_respaldo);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 226);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Manual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "Respaldo y Restauración DB  ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(778, 794);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackup_FormClosing);
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_restaurar_respaldo;
        private System.Windows.Forms.Button Btn_crear_respaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_seleccionarCarpeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_carpeta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpHoraBackup;
    }
}