namespace Ferreteria.CapaPresentacion.VistaTicket
{
    partial class FrmEditarTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarTicket));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpb_datosDelNegocio = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre_negocio = new System.Windows.Forms.TextBox();
            this.txt_cuit = new System.Windows.Forms.TextBox();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_impresoraTermica = new System.Windows.Forms.TextBox();
            this.txt_frasePresupuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fraseVenta = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Id_ConfigurarTicket = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.gpb_datosDelNegocio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_cancelar.Location = new System.Drawing.Point(1433, 646);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 151;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(1126, 646);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 150;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // gpb_datosDelNegocio
            // 
            this.gpb_datosDelNegocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_datosDelNegocio.Controls.Add(this.txt_email);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_codigo);
            this.gpb_datosDelNegocio.Controls.Add(this.txt_telefono);
            this.gpb_datosDelNegocio.Controls.Add(this.txt_nombre_negocio);
            this.gpb_datosDelNegocio.Controls.Add(this.txt_cuit);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_subcategoria);
            this.gpb_datosDelNegocio.Controls.Add(this.txt_direccion);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_ciudad);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_categoria);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_cargo);
            this.gpb_datosDelNegocio.Controls.Add(this.lbl_marca);
            this.gpb_datosDelNegocio.Controls.Add(this.txt_ciudad);
            this.gpb_datosDelNegocio.Location = new System.Drawing.Point(26, 28);
            this.gpb_datosDelNegocio.Name = "gpb_datosDelNegocio";
            this.gpb_datosDelNegocio.Size = new System.Drawing.Size(1600, 318);
            this.gpb_datosDelNegocio.TabIndex = 156;
            this.gpb_datosDelNegocio.TabStop = false;
            this.gpb_datosDelNegocio.Text = "Datos Del Negocio";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(1165, 209);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(400, 35);
            this.txt_email.TabIndex = 169;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Black;
            this.lbl_codigo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Location = new System.Drawing.Point(85, 38);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(250, 35);
            this.lbl_codigo.TabIndex = 158;
            this.lbl_codigo.Text = "Nombre Del Negocio:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(13, 209);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(400, 35);
            this.txt_telefono.TabIndex = 168;
            // 
            // txt_nombre_negocio
            // 
            this.txt_nombre_negocio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre_negocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_negocio.Location = new System.Drawing.Point(15, 98);
            this.txt_nombre_negocio.Name = "txt_nombre_negocio";
            this.txt_nombre_negocio.Size = new System.Drawing.Size(400, 35);
            this.txt_nombre_negocio.TabIndex = 159;
            // 
            // txt_cuit
            // 
            this.txt_cuit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit.Location = new System.Drawing.Point(580, 204);
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Size = new System.Drawing.Size(400, 35);
            this.txt_cuit.TabIndex = 167;
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.BackColor = System.Drawing.Color.Black;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_subcategoria.Location = new System.Drawing.Point(738, 149);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(88, 35);
            this.lbl_subcategoria.TabIndex = 160;
            this.lbl_subcategoria.Text = "C.U.I.T:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(1165, 91);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(400, 35);
            this.txt_direccion.TabIndex = 166;
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.BackColor = System.Drawing.Color.Black;
            this.lbl_ciudad.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ciudad.Location = new System.Drawing.Point(733, 38);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(103, 35);
            this.lbl_ciudad.TabIndex = 161;
            this.lbl_ciudad.Text = "Ciudad:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Black;
            this.lbl_categoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_categoria.Location = new System.Drawing.Point(1265, 149);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(206, 35);
            this.lbl_categoria.TabIndex = 165;
            this.lbl_categoria.Text = "Email (opcional):";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Black;
            this.lbl_cargo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(1304, 38);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(131, 35);
            this.lbl_cargo.TabIndex = 162;
            this.lbl_cargo.Text = "Dirección:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Black;
            this.lbl_marca.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_marca.Location = new System.Drawing.Point(149, 162);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(119, 35);
            this.lbl_marca.TabIndex = 164;
            this.lbl_marca.Text = "Teléfono:";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(580, 100);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(400, 35);
            this.txt_ciudad.TabIndex = 163;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_impresoraTermica);
            this.groupBox1.Controls.Add(this.txt_frasePresupuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_fraseVenta);
            this.groupBox1.Location = new System.Drawing.Point(26, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1600, 232);
            this.groupBox1.TabIndex = 170;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Negocio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 35);
            this.label1.TabIndex = 158;
            this.label1.Text = "Frase Despedida Presupuesto:";
            // 
            // txt_impresoraTermica
            // 
            this.txt_impresoraTermica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_impresoraTermica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_impresoraTermica.Location = new System.Drawing.Point(1165, 137);
            this.txt_impresoraTermica.Name = "txt_impresoraTermica";
            this.txt_impresoraTermica.Size = new System.Drawing.Size(400, 35);
            this.txt_impresoraTermica.TabIndex = 168;
            // 
            // txt_frasePresupuesto
            // 
            this.txt_frasePresupuesto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_frasePresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_frasePresupuesto.Location = new System.Drawing.Point(15, 137);
            this.txt_frasePresupuesto.Name = "txt_frasePresupuesto";
            this.txt_frasePresupuesto.Size = new System.Drawing.Size(400, 35);
            this.txt_frasePresupuesto.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(620, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 35);
            this.label3.TabIndex = 161;
            this.label3.Text = "Frase de Despedida Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1177, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 35);
            this.label6.TabIndex = 164;
            this.label6.Text = "Nombre De Impresora Termica:";
            // 
            // txt_fraseVenta
            // 
            this.txt_fraseVenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_fraseVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fraseVenta.Location = new System.Drawing.Point(580, 137);
            this.txt_fraseVenta.Name = "txt_fraseVenta";
            this.txt_fraseVenta.Size = new System.Drawing.Size(400, 35);
            this.txt_fraseVenta.TabIndex = 163;
            // 
            // lbl_Id_ConfigurarTicket
            // 
            this.lbl_Id_ConfigurarTicket.AutoSize = true;
            this.lbl_Id_ConfigurarTicket.BackColor = System.Drawing.Color.Black;
            this.lbl_Id_ConfigurarTicket.Enabled = false;
            this.lbl_Id_ConfigurarTicket.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_ConfigurarTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Id_ConfigurarTicket.Location = new System.Drawing.Point(20, 623);
            this.lbl_Id_ConfigurarTicket.Name = "lbl_Id_ConfigurarTicket";
            this.lbl_Id_ConfigurarTicket.Size = new System.Drawing.Size(0, 35);
            this.lbl_Id_ConfigurarTicket.TabIndex = 169;
            this.lbl_Id_ConfigurarTicket.Visible = false;
            // 
            // FrmEditarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 724);
            this.Controls.Add(this.lbl_Id_ConfigurarTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_datosDelNegocio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1660, 780);
            this.Name = "FrmEditarTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarTicket";
            this.Load += new System.EventHandler(this.FrmEditarTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.gpb_datosDelNegocio.ResumeLayout(false);
            this.gpb_datosDelNegocio.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.GroupBox gpb_datosDelNegocio;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_nombre_negocio;
        private System.Windows.Forms.TextBox txt_cuit;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_impresoraTermica;
        private System.Windows.Forms.TextBox txt_frasePresupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fraseVenta;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_Id_ConfigurarTicket;
    }
}