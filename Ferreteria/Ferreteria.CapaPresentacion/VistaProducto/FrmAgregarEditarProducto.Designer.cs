namespace Ferreteria.CapaPresentacion.VistaProducto
{
    partial class FrmAgregarEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarProducto));
            this.cbo_subcategoria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_marca = new System.Windows.Forms.Button();
            this.txt_nombre_marca = new System.Windows.Forms.TextBox();
            this.txt_id_marca = new System.Windows.Forms.TextBox();
            this.Chk_RequiereVencimiento = new System.Windows.Forms.CheckBox();
            this.Chk_actualizarPrecioAutomaticamente = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_unidadMedida = new System.Windows.Forms.Button();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.txt_id_unidadMedida = new System.Windows.Forms.TextBox();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.Chk_CambiarEstado = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_subcategoria
            // 
            this.cbo_subcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_subcategoria.FormattingEnabled = true;
            this.cbo_subcategoria.Location = new System.Drawing.Point(624, 174);
            this.cbo_subcategoria.Name = "cbo_subcategoria";
            this.cbo_subcategoria.Size = new System.Drawing.Size(540, 37);
            this.cbo_subcategoria.TabIndex = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 586);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 181);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desccripcion del Producto ( opcional ) :";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(14, 36);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(1130, 128);
            this.txt_descripcion.TabIndex = 23;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(624, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(540, 35);
            this.txt_nombre.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(824, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 90;
            this.label1.Text = "Precio:";
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(51, 174);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(540, 37);
            this.cbo_categoria.TabIndex = 89;
            this.cbo_categoria.SelectedIndexChanged += new System.EventHandler(this.cbo_categoria_SelectedIndexChanged);
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Black;
            this.lbl_cargo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(254, 122);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(139, 35);
            this.lbl_cargo.TabIndex = 86;
            this.lbl_cargo.Text = " Categoria:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(853, 11);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(111, 35);
            this.lbl_nombre.TabIndex = 85;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.BackColor = System.Drawing.Color.Black;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_subcategoria.Location = new System.Drawing.Point(815, 122);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(176, 35);
            this.lbl_subcategoria.TabIndex = 84;
            this.lbl_subcategoria.Text = "Subcategoria:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(52, 71);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(539, 35);
            this.txt_codigo.TabIndex = 82;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Black;
            this.lbl_codigo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Location = new System.Drawing.Point(254, 9);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(102, 35);
            this.lbl_codigo.TabIndex = 81;
            this.lbl_codigo.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(199, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 35);
            this.label3.TabIndex = 96;
            this.label3.Text = "Stock Minimo:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Black;
            this.lbl_categoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_categoria.Location = new System.Drawing.Point(762, 236);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(280, 35);
            this.lbl_categoria.TabIndex = 102;
            this.lbl_categoria.Text = "Tipo De Unidad Medida:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.BackColor = System.Drawing.Color.Black;
            this.lbl_marca.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_marca.Location = new System.Drawing.Point(281, 248);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(93, 35);
            this.lbl_marca.TabIndex = 101;
            this.lbl_marca.Text = "Marca:";
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
            this.btn_cancelar.Location = new System.Drawing.Point(672, 784);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 106;
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
            this.btn_Agregar.Location = new System.Drawing.Point(288, 784);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 105;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(24, 24);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 20);
            this.lbl_id.TabIndex = 107;
            this.lbl_id.Visible = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Coral;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(282, 532);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(279, 29);
            this.lbl_fecha.TabIndex = 108;
            this.lbl_fecha.Text = "La ultima modificación fue: ";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btn_marca
            // 
            this.btn_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_marca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marca.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_marca.Image = ((System.Drawing.Image)(resources.GetObject("btn_marca.Image")));
            this.btn_marca.Location = new System.Drawing.Point(530, 283);
            this.btn_marca.Name = "btn_marca";
            this.btn_marca.Size = new System.Drawing.Size(62, 56);
            this.btn_marca.TabIndex = 121;
            this.btn_marca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_marca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_marca.UseVisualStyleBackColor = false;
            this.btn_marca.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // txt_nombre_marca
            // 
            this.txt_nombre_marca.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_marca.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_marca.Location = new System.Drawing.Point(52, 295);
            this.txt_nombre_marca.Name = "txt_nombre_marca";
            this.txt_nombre_marca.ReadOnly = true;
            this.txt_nombre_marca.Size = new System.Drawing.Size(472, 35);
            this.txt_nombre_marca.TabIndex = 120;
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.Enabled = false;
            this.txt_id_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_marca.ForeColor = System.Drawing.Color.Black;
            this.txt_id_marca.Location = new System.Drawing.Point(52, 248);
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.ReadOnly = true;
            this.txt_id_marca.Size = new System.Drawing.Size(115, 44);
            this.txt_id_marca.TabIndex = 119;
            this.txt_id_marca.Visible = false;
            // 
            // Chk_RequiereVencimiento
            // 
            this.Chk_RequiereVencimiento.AutoSize = true;
            this.Chk_RequiereVencimiento.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_RequiereVencimiento.Location = new System.Drawing.Point(45, 25);
            this.Chk_RequiereVencimiento.Name = "Chk_RequiereVencimiento";
            this.Chk_RequiereVencimiento.Size = new System.Drawing.Size(216, 29);
            this.Chk_RequiereVencimiento.TabIndex = 122;
            this.Chk_RequiereVencimiento.Text = "Requiere Vencimiento";
            this.Chk_RequiereVencimiento.UseVisualStyleBackColor = true;
            // 
            // Chk_actualizarPrecioAutomaticamente
            // 
            this.Chk_actualizarPrecioAutomaticamente.AutoSize = true;
            this.Chk_actualizarPrecioAutomaticamente.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_actualizarPrecioAutomaticamente.Location = new System.Drawing.Point(669, 25);
            this.Chk_actualizarPrecioAutomaticamente.Name = "Chk_actualizarPrecioAutomaticamente";
            this.Chk_actualizarPrecioAutomaticamente.Size = new System.Drawing.Size(340, 29);
            this.Chk_actualizarPrecioAutomaticamente.TabIndex = 123;
            this.Chk_actualizarPrecioAutomaticamente.Text = "Actualizar Automaticamente el Precio";
            this.Chk_actualizarPrecioAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chk_actualizarPrecioAutomaticamente);
            this.groupBox2.Controls.Add(this.Chk_RequiereVencimiento);
            this.groupBox2.Location = new System.Drawing.Point(52, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 62);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recomendaciones Opcionales:";
            // 
            // btn_unidadMedida
            // 
            this.btn_unidadMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_unidadMedida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_unidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_unidadMedida.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unidadMedida.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_unidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("btn_unidadMedida.Image")));
            this.btn_unidadMedida.Location = new System.Drawing.Point(1102, 283);
            this.btn_unidadMedida.Name = "btn_unidadMedida";
            this.btn_unidadMedida.Size = new System.Drawing.Size(62, 56);
            this.btn_unidadMedida.TabIndex = 127;
            this.btn_unidadMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_unidadMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_unidadMedida.UseVisualStyleBackColor = false;
            this.btn_unidadMedida.Click += new System.EventHandler(this.btn_unidadMedida_Click);
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.BackColor = System.Drawing.SystemColors.Window;
            this.txt_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.ForeColor = System.Drawing.Color.Black;
            this.txt_unidadMedida.Location = new System.Drawing.Point(624, 295);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.ReadOnly = true;
            this.txt_unidadMedida.Size = new System.Drawing.Size(472, 35);
            this.txt_unidadMedida.TabIndex = 126;
            // 
            // txt_id_unidadMedida
            // 
            this.txt_id_unidadMedida.Enabled = false;
            this.txt_id_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_unidadMedida.ForeColor = System.Drawing.Color.Black;
            this.txt_id_unidadMedida.Location = new System.Drawing.Point(624, 248);
            this.txt_id_unidadMedida.Name = "txt_id_unidadMedida";
            this.txt_id_unidadMedida.ReadOnly = true;
            this.txt_id_unidadMedida.Size = new System.Drawing.Size(115, 44);
            this.txt_id_unidadMedida.TabIndex = 125;
            this.txt_id_unidadMedida.Visible = false;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.ForeColor = System.Drawing.Color.Black;
            this.txt_stock_minimo.Location = new System.Drawing.Point(52, 395);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(472, 35);
            this.txt_stock_minimo.TabIndex = 128;
            this.txt_stock_minimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_minimo_KeyPress);
            this.txt_stock_minimo.Leave += new System.EventHandler(this.txt_stock_minimo_Leave);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.Black;
            this.txt_precio.Location = new System.Drawing.Point(624, 395);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(472, 35);
            this.txt_precio.TabIndex = 129;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            this.txt_precio.Leave += new System.EventHandler(this.txt_precio_Leave);
            // 
            // Chk_CambiarEstado
            // 
            this.Chk_CambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Chk_CambiarEstado.AutoSize = true;
            this.Chk_CambiarEstado.Font = new System.Drawing.Font("Impact", 12F);
            this.Chk_CambiarEstado.Location = new System.Drawing.Point(392, 12);
            this.Chk_CambiarEstado.Name = "Chk_CambiarEstado";
            this.Chk_CambiarEstado.Size = new System.Drawing.Size(183, 33);
            this.Chk_CambiarEstado.TabIndex = 182;
            this.Chk_CambiarEstado.Text = "Permitir Letras";
            this.Chk_CambiarEstado.UseVisualStyleBackColor = true;
            this.Chk_CambiarEstado.CheckedChanged += new System.EventHandler(this.Chk_CambiarEstado_CheckedChanged);
            // 
            // FrmAgregarEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 862);
            this.Controls.Add(this.Chk_CambiarEstado);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_stock_minimo);
            this.Controls.Add(this.btn_unidadMedida);
            this.Controls.Add(this.txt_unidadMedida);
            this.Controls.Add(this.txt_id_unidadMedida);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_marca);
            this.Controls.Add(this.txt_nombre_marca);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_subcategoria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_subcategoria);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1239, 809);
            this.Name = "FrmAgregarEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEditarProducto";
            this.Load += new System.EventHandler(this.FrmAgregarEditarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_subcategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_categoria;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Button btn_marca;
        private System.Windows.Forms.TextBox txt_nombre_marca;
        private System.Windows.Forms.TextBox txt_id_marca;
        private System.Windows.Forms.CheckBox Chk_RequiereVencimiento;
        private System.Windows.Forms.CheckBox Chk_actualizarPrecioAutomaticamente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_unidadMedida;
        private System.Windows.Forms.TextBox txt_unidadMedida;
        private System.Windows.Forms.TextBox txt_id_unidadMedida;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.CheckBox Chk_CambiarEstado;
        private System.Windows.Forms.ToolTip toolTip;
    }
}