namespace Ferreteria.CapaPresentacion.VistaUsuario
{
    partial class FrmAgregarEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarUsuario));
            this.cbo_acceso = new System.Windows.Forms.ComboBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_numero_documento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.txt_id_usuario = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.gb_DatosPersonales = new System.Windows.Forms.GroupBox();
            this.gb_cuenta = new System.Windows.Forms.GroupBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_DatosPersonales.SuspendLayout();
            this.gb_cuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_acceso
            // 
            this.cbo_acceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_acceso.FormattingEnabled = true;
            this.cbo_acceso.Location = new System.Drawing.Point(101, 99);
            this.cbo_acceso.Name = "cbo_acceso";
            this.cbo_acceso.Size = new System.Drawing.Size(375, 34);
            this.cbo_acceso.TabIndex = 166;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.Location = new System.Drawing.Point(561, 97);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(379, 35);
            this.txt_nombre_usuario.TabIndex = 165;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(687, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 164;
            this.label1.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(240, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 35);
            this.label6.TabIndex = 163;
            this.label6.Text = "Acceso:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(956, 529);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 168;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(436, 529);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 167;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_numero_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_documento.Location = new System.Drawing.Point(268, 322);
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Size = new System.Drawing.Size(394, 35);
            this.txt_numero_documento.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1145, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 35);
            this.label5.TabIndex = 175;
            this.label5.Text = "Numero Documento:";
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(1076, 96);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(375, 35);
            this.txt_dni.TabIndex = 174;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(199, 94);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(379, 35);
            this.txt_nombre.TabIndex = 172;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(343, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(111, 35);
            this.lbl_nombre.TabIndex = 171;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(622, 96);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(375, 35);
            this.txt_apellido.TabIndex = 170;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // lbl_sector
            // 
            this.lbl_sector.AutoSize = true;
            this.lbl_sector.BackColor = System.Drawing.Color.Black;
            this.lbl_sector.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sector.Location = new System.Drawing.Point(738, 38);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(114, 35);
            this.lbl_sector.TabIndex = 169;
            this.lbl_sector.Text = "Apellido:";
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.BackColor = System.Drawing.Color.GhostWhite;
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_id_usuario.Location = new System.Drawing.Point(17, 88);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.ReadOnly = true;
            this.txt_id_usuario.Size = new System.Drawing.Size(146, 42);
            this.txt_id_usuario.TabIndex = 178;
            this.txt_id_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.BackColor = System.Drawing.Color.Black;
            this.lbl_Id.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Id.Location = new System.Drawing.Point(19, 38);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(151, 29);
            this.lbl_Id.TabIndex = 177;
            this.lbl_Id.Text = "Id del Usuario:";
            // 
            // gb_DatosPersonales
            // 
            this.gb_DatosPersonales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gb_DatosPersonales.Controls.Add(this.lbl_Id);
            this.gb_DatosPersonales.Controls.Add(this.txt_dni);
            this.gb_DatosPersonales.Controls.Add(this.txt_numero_documento);
            this.gb_DatosPersonales.Controls.Add(this.txt_id_usuario);
            this.gb_DatosPersonales.Controls.Add(this.label5);
            this.gb_DatosPersonales.Controls.Add(this.lbl_nombre);
            this.gb_DatosPersonales.Controls.Add(this.lbl_sector);
            this.gb_DatosPersonales.Controls.Add(this.txt_apellido);
            this.gb_DatosPersonales.Controls.Add(this.txt_nombre);
            this.gb_DatosPersonales.Location = new System.Drawing.Point(38, 30);
            this.gb_DatosPersonales.Name = "gb_DatosPersonales";
            this.gb_DatosPersonales.Size = new System.Drawing.Size(1495, 184);
            this.gb_DatosPersonales.TabIndex = 179;
            this.gb_DatosPersonales.TabStop = false;
            this.gb_DatosPersonales.Text = "Datos Personales";
            // 
            // gb_cuenta
            // 
            this.gb_cuenta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gb_cuenta.Controls.Add(this.label6);
            this.gb_cuenta.Controls.Add(this.lbl_clave);
            this.gb_cuenta.Controls.Add(this.txt_clave);
            this.gb_cuenta.Controls.Add(this.label1);
            this.gb_cuenta.Controls.Add(this.cbo_acceso);
            this.gb_cuenta.Controls.Add(this.txt_nombre_usuario);
            this.gb_cuenta.Location = new System.Drawing.Point(38, 264);
            this.gb_cuenta.Name = "gb_cuenta";
            this.gb_cuenta.Size = new System.Drawing.Size(1495, 184);
            this.gb_cuenta.TabIndex = 180;
            this.gb_cuenta.TabStop = false;
            this.gb_cuenta.Text = "Usuario";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Black;
            this.lbl_clave.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_clave.Location = new System.Drawing.Point(1099, 41);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(155, 35);
            this.lbl_clave.TabIndex = 161;
            this.lbl_clave.Text = "Contraseña:";
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(983, 97);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(375, 35);
            this.txt_clave.TabIndex = 162;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmAgregarEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 619);
            this.Controls.Add(this.gb_cuenta);
            this.Controls.Add(this.gb_DatosPersonales);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAgregarEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEditarUsuario";
            this.Load += new System.EventHandler(this.FrmAgregarEditarUsuario_Load);
            this.gb_DatosPersonales.ResumeLayout(false);
            this.gb_DatosPersonales.PerformLayout();
            this.gb_cuenta.ResumeLayout(false);
            this.gb_cuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_acceso;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_numero_documento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.TextBox txt_id_usuario;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox gb_DatosPersonales;
        private System.Windows.Forms.GroupBox gb_cuenta;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}