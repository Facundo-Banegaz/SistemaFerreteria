namespace Ferreteria.CapaPresentacion.VistaIngresos
{
    partial class FrmAgregarEditarIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarIngreso));
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_serie_correlativo = new System.Windows.Forms.Label();
            this.lbl_encabezado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_producto_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Btn_producto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sectorComercial = new System.Windows.Forms.TextBox();
            this.Btn_proveedor = new System.Windows.Forms.Button();
            this.txt_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cbo_comprobante = new System.Windows.Forms.ComboBox();
            this.lbl_comprobante = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.AllowUserToAddRows = false;
            this.dgv_categorias.AllowUserToDeleteRows = false;
            this.dgv_categorias.AllowUserToOrderColumns = true;
            this.dgv_categorias.AllowUserToResizeRows = false;
            this.dgv_categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_categorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_categorias.EnableHeadersVisualStyles = false;
            this.dgv_categorias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_categorias.Location = new System.Drawing.Point(8, 369);
            this.dgv_categorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.ReadOnly = true;
            this.dgv_categorias.RowHeadersVisible = false;
            this.dgv_categorias.RowHeadersWidth = 62;
            this.dgv_categorias.RowTemplate.Height = 28;
            this.dgv_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categorias.Size = new System.Drawing.Size(1256, 177);
            this.dgv_categorias.TabIndex = 96;
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
            this.btn_cancelar.Location = new System.Drawing.Point(1133, 550);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(131, 43);
            this.btn_cancelar.TabIndex = 180;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(942, 550);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 43);
            this.btn_guardar.TabIndex = 179;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1256, 363);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(919, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(337, 339);
            this.groupBox5.TabIndex = 99;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Controls.Add(this.lbl_total);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.txt_subtotal);
            this.groupBox7.Controls.Add(this.txt_cantidad);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(15, 127);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(306, 177);
            this.groupBox7.TabIndex = 99;
            this.groupBox7.TabStop = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Black;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Location = new System.Drawing.Point(113, 146);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(75, 23);
            this.lbl_total.TabIndex = 199;
            this.lbl_total.Text = "Total S/:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 198;
            this.label6.Text = "Total S/:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_subtotal.ForeColor = System.Drawing.Color.Black;
            this.txt_subtotal.Location = new System.Drawing.Point(112, 71);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(191, 26);
            this.txt_subtotal.TabIndex = 195;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_cantidad.ForeColor = System.Drawing.Color.Black;
            this.txt_cantidad.Location = new System.Drawing.Point(112, 26);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(191, 26);
            this.txt_cantidad.TabIndex = 124;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 192;
            this.label5.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 191;
            this.label4.Text = "Cantidad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Controls.Add(this.lbl_serie_correlativo);
            this.groupBox6.Controls.Add(this.lbl_encabezado);
            this.groupBox6.Location = new System.Drawing.Point(15, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(306, 72);
            this.groupBox6.TabIndex = 98;
            this.groupBox6.TabStop = false;
            // 
            // lbl_serie_correlativo
            // 
            this.lbl_serie_correlativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_serie_correlativo.AutoSize = true;
            this.lbl_serie_correlativo.BackColor = System.Drawing.Color.Black;
            this.lbl_serie_correlativo.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_serie_correlativo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_serie_correlativo.Location = new System.Drawing.Point(23, 42);
            this.lbl_serie_correlativo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_serie_correlativo.Name = "lbl_serie_correlativo";
            this.lbl_serie_correlativo.Size = new System.Drawing.Size(123, 23);
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
            this.lbl_encabezado.Location = new System.Drawing.Point(85, 0);
            this.lbl_encabezado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_encabezado.Name = "lbl_encabezado";
            this.lbl_encabezado.Size = new System.Drawing.Size(152, 23);
            this.lbl_encabezado.TabIndex = 180;
            this.lbl_encabezado.Text = "BOLETA DE COMPRA";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Location = new System.Drawing.Point(0, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(919, 339);
            this.groupBox4.TabIndex = 98;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_producto);
            this.groupBox2.Controls.Add(this.txt_producto_cantidad);
            this.groupBox2.Controls.Add(this.txt_precioCompra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_codigoBarra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_id_producto);
            this.groupBox2.Controls.Add(this.btn_quitar);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.Btn_producto);
            this.groupBox2.Location = new System.Drawing.Point(10, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(899, 160);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Productos";
            // 
            // txt_producto
            // 
            this.txt_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_producto.Enabled = false;
            this.txt_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_producto.Location = new System.Drawing.Point(154, 63);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.ReadOnly = true;
            this.txt_producto.Size = new System.Drawing.Size(246, 26);
            this.txt_producto.TabIndex = 200;
            // 
            // txt_producto_cantidad
            // 
            this.txt_producto_cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_producto_cantidad.BackColor = System.Drawing.Color.Orange;
            this.txt_producto_cantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_producto_cantidad.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_producto_cantidad.Location = new System.Drawing.Point(645, 63);
            this.txt_producto_cantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_producto_cantidad.Name = "txt_producto_cantidad";
            this.txt_producto_cantidad.Size = new System.Drawing.Size(116, 27);
            this.txt_producto_cantidad.TabIndex = 199;
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_precioCompra.BackColor = System.Drawing.Color.Orange;
            this.txt_precioCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_precioCompra.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_precioCompra.Location = new System.Drawing.Point(484, 62);
            this.txt_precioCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(116, 27);
            this.txt_precioCompra.TabIndex = 198;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 10F);
            this.label9.Location = new System.Drawing.Point(489, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 197;
            this.label9.Text = "Precio Compra:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 10F);
            this.label8.Location = new System.Drawing.Point(673, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 196;
            this.label8.Text = "Cantidad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 193;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 10F);
            this.label7.Location = new System.Drawing.Point(245, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 192;
            this.label7.Text = "Producto";
            // 
            // txt_codigoBarra
            // 
            this.txt_codigoBarra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigoBarra.BackColor = System.Drawing.Color.Orange;
            this.txt_codigoBarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_codigoBarra.Font = new System.Drawing.Font("Impact", 12F);
            this.txt_codigoBarra.Location = new System.Drawing.Point(9, 63);
            this.txt_codigoBarra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_codigoBarra.Name = "txt_codigoBarra";
            this.txt_codigoBarra.Size = new System.Drawing.Size(135, 27);
            this.txt_codigoBarra.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10F);
            this.label3.Location = new System.Drawing.Point(38, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 190;
            this.label3.Text = "Cod. Producto:";
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_producto.Enabled = false;
            this.txt_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_id_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_id_producto.Location = new System.Drawing.Point(154, 37);
            this.txt_id_producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.ReadOnly = true;
            this.txt_id_producto.Size = new System.Drawing.Size(78, 26);
            this.txt_id_producto.TabIndex = 188;
            this.txt_id_producto.Visible = false;
            // 
            // btn_quitar
            // 
            this.btn_quitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(192)))));
            this.btn_quitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitar.Image = ((System.Drawing.Image)(resources.GetObject("btn_quitar.Image")));
            this.btn_quitar.Location = new System.Drawing.Point(831, 110);
            this.btn_quitar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(57, 39);
            this.btn_quitar.TabIndex = 186;
            this.btn_quitar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Location = new System.Drawing.Point(831, 16);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(57, 39);
            this.btn_agregar.TabIndex = 185;
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_producto
            // 
            this.Btn_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_producto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_producto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_producto.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_producto.Image")));
            this.Btn_producto.Location = new System.Drawing.Point(411, 55);
            this.Btn_producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_producto.Name = "Btn_producto";
            this.Btn_producto.Size = new System.Drawing.Size(38, 36);
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
            this.groupBox3.Controls.Add(this.txt_sectorComercial);
            this.groupBox3.Controls.Add(this.Btn_proveedor);
            this.groupBox3.Controls.Add(this.txt_nombre_proveedor);
            this.groupBox3.Controls.Add(this.txt_id_proveedor);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(900, 65);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Proveedor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(463, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 123;
            this.label1.Text = "Sector Comercial";
            // 
            // txt_sectorComercial
            // 
            this.txt_sectorComercial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sectorComercial.Enabled = false;
            this.txt_sectorComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_sectorComercial.ForeColor = System.Drawing.Color.Black;
            this.txt_sectorComercial.Location = new System.Drawing.Point(615, 23);
            this.txt_sectorComercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_sectorComercial.Name = "txt_sectorComercial";
            this.txt_sectorComercial.ReadOnly = true;
            this.txt_sectorComercial.Size = new System.Drawing.Size(233, 26);
            this.txt_sectorComercial.TabIndex = 122;
            // 
            // Btn_proveedor
            // 
            this.Btn_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_proveedor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_proveedor.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_proveedor.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_proveedor.Image")));
            this.Btn_proveedor.Location = new System.Drawing.Point(851, 16);
            this.Btn_proveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_proveedor.Name = "Btn_proveedor";
            this.Btn_proveedor.Size = new System.Drawing.Size(38, 36);
            this.Btn_proveedor.TabIndex = 121;
            this.Btn_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_proveedor.UseVisualStyleBackColor = false;
            this.Btn_proveedor.Click += new System.EventHandler(this.Btn_proveedor_Click);
            // 
            // txt_nombre_proveedor
            // 
            this.txt_nombre_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_proveedor.Enabled = false;
            this.txt_nombre_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nombre_proveedor.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_proveedor.Location = new System.Drawing.Point(109, 23);
            this.txt_nombre_proveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombre_proveedor.Name = "txt_nombre_proveedor";
            this.txt_nombre_proveedor.ReadOnly = true;
            this.txt_nombre_proveedor.Size = new System.Drawing.Size(246, 26);
            this.txt_nombre_proveedor.TabIndex = 120;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_proveedor.Enabled = false;
            this.txt_id_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txt_id_proveedor.ForeColor = System.Drawing.Color.Black;
            this.txt_id_proveedor.Location = new System.Drawing.Point(357, 23);
            this.txt_id_proveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.ReadOnly = true;
            this.txt_id_proveedor.Size = new System.Drawing.Size(78, 26);
            this.txt_id_proveedor.TabIndex = 119;
            this.txt_id_proveedor.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 118;
            this.label2.Text = "Proveedor:";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Controls.Add(this.dtp_fecha);
            this.groupBox8.Controls.Add(this.lbl_fecha);
            this.groupBox8.Controls.Add(this.cbo_comprobante);
            this.groupBox8.Controls.Add(this.lbl_comprobante);
            this.groupBox8.Location = new System.Drawing.Point(10, 16);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox8.Size = new System.Drawing.Size(900, 65);
            this.groupBox8.TabIndex = 93;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Información Compra";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_fecha.CalendarFont = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Location = new System.Drawing.Point(591, 22);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(299, 27);
            this.dtp_fecha.TabIndex = 179;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Black;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(417, 22);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(166, 23);
            this.lbl_fecha.TabIndex = 178;
            this.lbl_fecha.Text = "Fecha de la compra:";
            // 
            // cbo_comprobante
            // 
            this.cbo_comprobante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_comprobante.FormattingEnabled = true;
            this.cbo_comprobante.Location = new System.Drawing.Point(146, 22);
            this.cbo_comprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_comprobante.Name = "cbo_comprobante";
            this.cbo_comprobante.Size = new System.Drawing.Size(244, 26);
            this.cbo_comprobante.TabIndex = 177;
            this.cbo_comprobante.SelectedIndexChanged += new System.EventHandler(this.cbo_comprobante_SelectedIndexChanged);
            // 
            // lbl_comprobante
            // 
            this.lbl_comprobante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_comprobante.AutoSize = true;
            this.lbl_comprobante.BackColor = System.Drawing.Color.Black;
            this.lbl_comprobante.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_comprobante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_comprobante.Location = new System.Drawing.Point(4, 21);
            this.lbl_comprobante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_comprobante.Name = "lbl_comprobante";
            this.lbl_comprobante.Size = new System.Drawing.Size(123, 23);
            this.lbl_comprobante.TabIndex = 176;
            this.lbl_comprobante.Text = "Comprobante:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 10F);
            this.label10.Location = new System.Drawing.Point(18, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 18);
            this.label10.TabIndex = 201;
            this.label10.Text = "Fecha Producción";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 10F);
            this.label11.Location = new System.Drawing.Point(354, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 18);
            this.label11.TabIndex = 202;
            this.label11.Text = "Fecha Vencimiento:";
            // 
            // FrmAgregarEditarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1272, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dgv_categorias);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(857, 449);
            this.Name = "FrmAgregarEditarIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEditarIngreso";
            this.Load += new System.EventHandler(this.FrmAgregarEditarIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbl_encabezado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sectorComercial;
        private System.Windows.Forms.Button Btn_proveedor;
        private System.Windows.Forms.TextBox txt_nombre_proveedor;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cbo_comprobante;
        private System.Windows.Forms.Label lbl_comprobante;
        private System.Windows.Forms.Label lbl_serie_correlativo;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.Button Btn_producto;
        private System.Windows.Forms.TextBox txt_codigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_producto_cantidad;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}