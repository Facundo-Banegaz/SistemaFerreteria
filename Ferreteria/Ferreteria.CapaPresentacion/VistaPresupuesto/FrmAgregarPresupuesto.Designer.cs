namespace Ferreteria.CapaPresentacion.VistaPresupuesto
{
    partial class FrmAgregarPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarPresupuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_totalFinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalUnidades = new System.Windows.Forms.Label();
            this.lbl_cantidadProductos = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.lbl_correlativo = new System.Windows.Forms.Label();
            this.lbl_serie_correlativo = new System.Windows.Forms.Label();
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.Btn_producto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_acceso = new System.Windows.Forms.TextBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_id_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbo_comprobante = new System.Windows.Forms.ComboBox();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.chk_EditarNombre = new System.Windows.Forms.CheckBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dgv_detalles_ventas = new System.Windows.Forms.DataGridView();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1884, 568);
            this.groupBox1.TabIndex = 183;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presupuesto";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.btn_cancelar);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.btn_guardar);
            this.groupBox5.Location = new System.Drawing.Point(1378, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(506, 522);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Controls.Add(this.lbl_totalFinal);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.lbl_totalUnidades);
            this.groupBox7.Controls.Add(this.lbl_cantidadProductos);
            this.groupBox7.Location = new System.Drawing.Point(22, 142);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(459, 272);
            this.groupBox7.TabIndex = 99;
            this.groupBox7.TabStop = false;
            // 
            // lbl_totalFinal
            // 
            this.lbl_totalFinal.AutoSize = true;
            this.lbl_totalFinal.BackColor = System.Drawing.Color.Black;
            this.lbl_totalFinal.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_totalFinal.Location = new System.Drawing.Point(6, 219);
            this.lbl_totalFinal.Name = "lbl_totalFinal";
            this.lbl_totalFinal.Size = new System.Drawing.Size(0, 35);
            this.lbl_totalFinal.TabIndex = 201;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(64, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 35);
            this.label4.TabIndex = 200;
            this.label4.Text = "Resultado del Presupuesto:";
            // 
            // lbl_totalUnidades
            // 
            this.lbl_totalUnidades.AutoSize = true;
            this.lbl_totalUnidades.BackColor = System.Drawing.Color.Black;
            this.lbl_totalUnidades.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalUnidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_totalUnidades.Location = new System.Drawing.Point(6, 139);
            this.lbl_totalUnidades.Name = "lbl_totalUnidades";
            this.lbl_totalUnidades.Size = new System.Drawing.Size(0, 35);
            this.lbl_totalUnidades.TabIndex = 199;
            // 
            // lbl_cantidadProductos
            // 
            this.lbl_cantidadProductos.AutoSize = true;
            this.lbl_cantidadProductos.BackColor = System.Drawing.Color.Black;
            this.lbl_cantidadProductos.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cantidadProductos.Location = new System.Drawing.Point(6, 86);
            this.lbl_cantidadProductos.Name = "lbl_cantidadProductos";
            this.lbl_cantidadProductos.Size = new System.Drawing.Size(0, 35);
            this.lbl_cantidadProductos.TabIndex = 191;
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
            this.btn_cancelar.Location = new System.Drawing.Point(285, 436);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(196, 66);
            this.btn_cancelar.TabIndex = 180;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Controls.Add(this.lbl_serie);
            this.groupBox6.Controls.Add(this.lbl_correlativo);
            this.groupBox6.Controls.Add(this.lbl_serie_correlativo);
            this.groupBox6.Controls.Add(this.lbl_encabezado);
            this.groupBox6.Location = new System.Drawing.Point(22, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(459, 111);
            this.groupBox6.TabIndex = 98;
            this.groupBox6.TabStop = false;
            // 
            // lbl_serie
            // 
            this.lbl_serie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.BackColor = System.Drawing.Color.Black;
            this.lbl_serie.Enabled = false;
            this.lbl_serie.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_serie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_serie.Location = new System.Drawing.Point(99, 32);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(100, 20);
            this.lbl_serie.TabIndex = 182;
            this.lbl_serie.Text = "Comprobante:";
            this.lbl_serie.Visible = false;
            // 
            // lbl_correlativo
            // 
            this.lbl_correlativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_correlativo.AutoSize = true;
            this.lbl_correlativo.BackColor = System.Drawing.Color.Black;
            this.lbl_correlativo.Enabled = false;
            this.lbl_correlativo.Font = new System.Drawing.Font("Impact", 8F);
            this.lbl_correlativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_correlativo.Location = new System.Drawing.Point(279, 34);
            this.lbl_correlativo.Name = "lbl_correlativo";
            this.lbl_correlativo.Size = new System.Drawing.Size(100, 20);
            this.lbl_correlativo.TabIndex = 202;
            this.lbl_correlativo.Text = "Comprobante:";
            this.lbl_correlativo.Visible = false;
            // 
            // lbl_serie_correlativo
            // 
            this.lbl_serie_correlativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_serie_correlativo.AutoSize = true;
            this.lbl_serie_correlativo.BackColor = System.Drawing.Color.Black;
            this.lbl_serie_correlativo.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_serie_correlativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_serie_correlativo.Location = new System.Drawing.Point(34, 65);
            this.lbl_serie_correlativo.Name = "lbl_serie_correlativo";
            this.lbl_serie_correlativo.Size = new System.Drawing.Size(179, 35);
            this.lbl_serie_correlativo.TabIndex = 181;
            this.lbl_serie_correlativo.Text = "Comprobante:";
            // 
            // lbl_encabezado
            // 
            this.lbl_encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_encabezado.AutoSize = true;
            this.lbl_encabezado.BackColor = System.Drawing.Color.Black;
            this.lbl_encabezado.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encabezado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_encabezado.Location = new System.Drawing.Point(95, -3);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(284, 35);
            this.lbl_encabezado.TabIndex = 180;
            this.lbl_encabezado.Text = "BOLETA DE PRESUPUESTO";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.Location = new System.Drawing.Point(22, 438);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(180, 66);
            this.btn_guardar.TabIndex = 179;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(0, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1378, 522);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.btn_editar);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.txt_producto);
            this.groupBox2.Controls.Add(this.txt_stock);
            this.groupBox2.Controls.Add(this.txt_precioVenta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_codigoBarra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_id_producto);
            this.groupBox2.Controls.Add(this.btn_quitar);
            this.groupBox2.Controls.Add(this.Btn_producto);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(15, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 235);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Productos";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.BackColor = System.Drawing.Color.Snow;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Location = new System.Drawing.Point(848, 158);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(86, 60);
            this.btn_eliminar.TabIndex = 210;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.Color.Orange;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(963, 156);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 65);
            this.btn_editar.TabIndex = 185;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(1244, 156);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(85, 65);
            this.btn_agregar.TabIndex = 185;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txt_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_producto.Location = new System.Drawing.Point(301, 91);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(423, 30);
            this.txt_producto.TabIndex = 200;
            this.txt_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_stock
            // 
            this.txt_stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_stock.BackColor = System.Drawing.Color.DarkOrange;
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_stock.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_stock.ForeColor = System.Drawing.Color.Black;
            this.txt_stock.Location = new System.Drawing.Point(1129, 91);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(200, 37);
            this.txt_stock.TabIndex = 199;
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precioVenta.BackColor = System.Drawing.Color.DarkOrange;
            this.txt_precioVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_precioVenta.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_precioVenta.ForeColor = System.Drawing.Color.Black;
            this.txt_precioVenta.Location = new System.Drawing.Point(848, 91);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.ReadOnly = true;
            this.txt_precioVenta.Size = new System.Drawing.Size(200, 37);
            this.txt_precioVenta.TabIndex = 198;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 10F);
            this.label9.Location = new System.Drawing.Point(882, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 197;
            this.label9.Text = "Precio Venta:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 10F);
            this.label8.Location = new System.Drawing.Point(1175, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 196;
            this.label8.Text = "Stock Disp:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 193;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 10F);
            this.label7.Location = new System.Drawing.Point(439, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 192;
            this.label7.Text = "Producto:";
            // 
            // txt_codigoBarra
            // 
            this.txt_codigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigoBarra.BackColor = System.Drawing.Color.SandyBrown;
            this.txt_codigoBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_codigoBarra.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_codigoBarra.ForeColor = System.Drawing.Color.Black;
            this.txt_codigoBarra.Location = new System.Drawing.Point(21, 88);
            this.txt_codigoBarra.Name = "txt_codigoBarra";
            this.txt_codigoBarra.Size = new System.Drawing.Size(200, 37);
            this.txt_codigoBarra.TabIndex = 191;
            this.txt_codigoBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigoBarra_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10F);
            this.label3.Location = new System.Drawing.Point(35, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 190;
            this.label3.Text = "Cod. Producto:";
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_producto.Enabled = false;
            this.txt_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_id_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_id_producto.Location = new System.Drawing.Point(300, 50);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.ReadOnly = true;
            this.txt_id_producto.Size = new System.Drawing.Size(115, 35);
            this.txt_id_producto.TabIndex = 188;
            this.txt_id_producto.Visible = false;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(192)))));
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(1129, 156);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(85, 65);
            this.btn_quitar.TabIndex = 186;
            this.btn_quitar.UseVisualStyleBackColor = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // Btn_producto
            // 
            this.Btn_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_producto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_producto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_producto.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_producto.Image")));
            this.Btn_producto.Location = new System.Drawing.Point(730, 81);
            this.Btn_producto.Name = "Btn_producto";
            this.Btn_producto.Size = new System.Drawing.Size(57, 55);
            this.Btn_producto.TabIndex = 124;
            this.Btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_producto.UseVisualStyleBackColor = false;
            this.Btn_producto.Click += new System.EventHandler(this.Btn_producto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_acceso);
            this.groupBox3.Controls.Add(this.txt_nombre_usuario);
            this.groupBox3.Controls.Add(this.txt_id_usuario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(15, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1350, 71);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Vendedor:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(715, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 35);
            this.label1.TabIndex = 123;
            this.label1.Text = "Acceso:";
            // 
            // txt_acceso
            // 
            this.txt_acceso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_acceso.ForeColor = System.Drawing.Color.Black;
            this.txt_acceso.Location = new System.Drawing.Point(867, 24);
            this.txt_acceso.Name = "txt_acceso";
            this.txt_acceso.ReadOnly = true;
            this.txt_acceso.Size = new System.Drawing.Size(442, 35);
            this.txt_acceso.TabIndex = 122;
            this.txt_acceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(203, 24);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.ReadOnly = true;
            this.txt_nombre_usuario.Size = new System.Drawing.Size(458, 35);
            this.txt_nombre_usuario.TabIndex = 120;
            this.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_usuario.Enabled = false;
            this.txt_id_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_id_usuario.Location = new System.Drawing.Point(720, -5);
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.ReadOnly = true;
            this.txt_id_usuario.Size = new System.Drawing.Size(66, 26);
            this.txt_id_usuario.TabIndex = 119;
            this.txt_id_usuario.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 118;
            this.label2.Text = "Usuario:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Controls.Add(this.cbo_comprobante);
            this.groupBox8.Controls.Add(this.lbl_comprobante);
            this.groupBox8.Controls.Add(this.chk_EditarNombre);
            this.groupBox8.Controls.Add(this.txt_cliente);
            this.groupBox8.Controls.Add(this.dtp_fecha);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.lbl_fecha);
            this.groupBox8.Location = new System.Drawing.Point(15, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1350, 172);
            this.groupBox8.TabIndex = 93;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Información Presupuesto";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // cbo_comprobante
            // 
            this.cbo_comprobante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comprobante.FormattingEnabled = true;
            this.cbo_comprobante.Location = new System.Drawing.Point(6, 122);
            this.cbo_comprobante.Name = "cbo_comprobante";
            this.cbo_comprobante.Size = new System.Drawing.Size(358, 34);
            this.cbo_comprobante.TabIndex = 183;
            this.cbo_comprobante.SelectedIndexChanged += new System.EventHandler(this.cbo_comprobante_SelectedIndexChanged);
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.BackColor = System.Drawing.Color.Black;
            this.lbl_comprobante.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_comprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_comprobante.Location = new System.Drawing.Point(99, 65);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(179, 35);
            this.lbl_comprobante.TabIndex = 182;
            this.lbl_comprobante.Text = "Comprobante:";
            // 
            // chk_EditarNombre
            // 
            this.chk_EditarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_EditarNombre.AutoSize = true;
            this.chk_EditarNombre.Font = new System.Drawing.Font("Impact", 12F);
            this.chk_EditarNombre.Location = new System.Drawing.Point(792, 123);
            this.chk_EditarNombre.Name = "chk_EditarNombre";
            this.chk_EditarNombre.Size = new System.Drawing.Size(132, 33);
            this.chk_EditarNombre.TabIndex = 181;
            this.chk_EditarNombre.Text = "Modificar";
            this.chk_EditarNombre.UseVisualStyleBackColor = true;
            this.chk_EditarNombre.CheckedChanged += new System.EventHandler(this.chk_EditarNombre_CheckedChanged);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_cliente.ForeColor = System.Drawing.Color.Black;
            this.txt_cliente.Location = new System.Drawing.Point(370, 121);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(416, 35);
            this.txt_cliente.TabIndex = 124;
            this.txt_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fecha.CalendarFont = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Location = new System.Drawing.Point(940, 122);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(404, 37);
            this.dtp_fecha.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(456, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 35);
            this.label5.TabIndex = 180;
            this.label5.Text = "Nombre Del Cliente:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Black;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(1002, 60);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(274, 35);
            this.lbl_fecha.TabIndex = 178;
            this.lbl_fecha.Text = "Fecha de Presupuesto:";
            // 
            // dgv_detalles_ventas
            // 
            this.dgv_detalles_ventas.AllowUserToAddRows = false;
            this.dgv_detalles_ventas.AllowUserToDeleteRows = false;
            this.dgv_detalles_ventas.AllowUserToOrderColumns = true;
            this.dgv_detalles_ventas.AllowUserToResizeRows = false;
            this.dgv_detalles_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_detalles_ventas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalles_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detalles_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detalles_ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detalles_ventas.EnableHeadersVisualStyles = false;
            this.dgv_detalles_ventas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_detalles_ventas.Location = new System.Drawing.Point(12, 586);
            this.dgv_detalles_ventas.Name = "dgv_detalles_ventas";
            this.dgv_detalles_ventas.ReadOnly = true;
            this.dgv_detalles_ventas.RowHeadersVisible = false;
            this.dgv_detalles_ventas.RowHeadersWidth = 62;
            this.dgv_detalles_ventas.RowTemplate.Height = 28;
            this.dgv_detalles_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles_ventas.Size = new System.Drawing.Size(1884, 327);
            this.dgv_detalles_ventas.TabIndex = 184;
            this.dgv_detalles_ventas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalles_ventas_CellValueChanged);
            this.dgv_detalles_ventas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_detalles_ventas_RowsRemoved);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmAgregarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 925);
            this.Controls.Add(this.dgv_detalles_ventas);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarPresupuesto";
            this.Text = "FrmAgregarPresupuesto";
            this.Load += new System.EventHandler(this.FrmAgregarPresupuesto_Load);
            this.Shown += new System.EventHandler(this.FrmAgregarPresupuesto_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbl_totalFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalUnidades;
        private System.Windows.Forms.Label lbl_cantidadProductos;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.Label lbl_correlativo;
        private System.Windows.Forms.Label lbl_serie_correlativo;
        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button Btn_producto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_acceso;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_id_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.DataGridView dgv_detalles_ventas;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.CheckBox chk_EditarNombre;
        private System.Windows.Forms.ComboBox cbo_comprobante;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}