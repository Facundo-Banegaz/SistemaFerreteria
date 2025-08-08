namespace Ferreteria.CapaPresentacion.VistaKardex
{
    partial class FrmKardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKardex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Tp_VencimientosProductos = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tp_ReporteInventarios = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tp_InventarioBajo = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.Tp_Movimientos = new System.Windows.Forms.TabPage();
            this.btn_unidadMedida = new System.Windows.Forms.Button();
            this.txt_unidadMedida = new System.Windows.Forms.TextBox();
            this.txt_id_unidadMedida = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.cbo_subcategoria = new System.Windows.Forms.ComboBox();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dgv_ingresos = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tp_VencimientosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Tp_ReporteInventarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tp_InventarioBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.Tp_Movimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventarios";
            // 
            // Tp_VencimientosProductos
            // 
            this.Tp_VencimientosProductos.Controls.Add(this.button5);
            this.Tp_VencimientosProductos.Controls.Add(this.button6);
            this.Tp_VencimientosProductos.Controls.Add(this.button9);
            this.Tp_VencimientosProductos.Controls.Add(this.label9);
            this.Tp_VencimientosProductos.Controls.Add(this.textBox2);
            this.Tp_VencimientosProductos.Controls.Add(this.dataGridView2);
            this.Tp_VencimientosProductos.Controls.Add(this.label7);
            this.Tp_VencimientosProductos.Controls.Add(this.label8);
            this.Tp_VencimientosProductos.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_VencimientosProductos.Location = new System.Drawing.Point(4, 38);
            this.Tp_VencimientosProductos.Name = "Tp_VencimientosProductos";
            this.Tp_VencimientosProductos.Size = new System.Drawing.Size(1794, 652);
            this.Tp_VencimientosProductos.TabIndex = 3;
            this.Tp_VencimientosProductos.Text = "Productos Vencidos o por Vencer";
            this.Tp_VencimientosProductos.UseVisualStyleBackColor = true;
            this.Tp_VencimientosProductos.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button5.Font = new System.Drawing.Font("Impact", 12F);
            this.button5.ForeColor = System.Drawing.Color.AliceBlue;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1617, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 56);
            this.button5.TabIndex = 120;
            this.button5.Text = "Imprimir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Goldenrod;
            this.button6.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.AliceBlue;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1410, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 56);
            this.button6.TabIndex = 119;
            this.button6.Text = "Limpiar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.AliceBlue;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(1239, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(152, 56);
            this.button9.TabIndex = 118;
            this.button9.Text = "Buscar";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14F);
            this.label9.Location = new System.Drawing.Point(16, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 35);
            this.label9.TabIndex = 117;
            this.label9.Text = "Buscar Producto:";
            this.label9.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(292, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(913, 39);
            this.textBox2.TabIndex = 116;
            this.textBox2.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView2.Location = new System.Drawing.Point(21, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1748, 405);
            this.dataGridView2.TabIndex = 101;
            this.dataGridView2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(778, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 100;
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LawnGreen;
            this.label8.Location = new System.Drawing.Point(327, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 99;
            this.label8.UseWaitCursor = true;
            // 
            // Tp_ReporteInventarios
            // 
            this.Tp_ReporteInventarios.Controls.Add(this.button3);
            this.Tp_ReporteInventarios.Controls.Add(this.button4);
            this.Tp_ReporteInventarios.Controls.Add(this.button8);
            this.Tp_ReporteInventarios.Controls.Add(this.textBox1);
            this.Tp_ReporteInventarios.Controls.Add(this.dataGridView1);
            this.Tp_ReporteInventarios.Controls.Add(this.label4);
            this.Tp_ReporteInventarios.Controls.Add(this.label5);
            this.Tp_ReporteInventarios.Controls.Add(this.label6);
            this.Tp_ReporteInventarios.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_ReporteInventarios.Location = new System.Drawing.Point(4, 38);
            this.Tp_ReporteInventarios.Name = "Tp_ReporteInventarios";
            this.Tp_ReporteInventarios.Size = new System.Drawing.Size(1794, 652);
            this.Tp_ReporteInventarios.TabIndex = 2;
            this.Tp_ReporteInventarios.Text = "Reporte Inventarios";
            this.Tp_ReporteInventarios.UseVisualStyleBackColor = true;
            this.Tp_ReporteInventarios.UseWaitCursor = true;
            this.Tp_ReporteInventarios.Click += new System.EventHandler(this.Tp_ReporteInventarios_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.Font = new System.Drawing.Font("Impact", 12F);
            this.button3.ForeColor = System.Drawing.Color.AliceBlue;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1619, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 56);
            this.button3.TabIndex = 119;
            this.button3.Text = "Imprimir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.AliceBlue;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1412, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 56);
            this.button4.TabIndex = 118;
            this.button4.Text = "Limpiar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.AliceBlue;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1241, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 56);
            this.button8.TabIndex = 117;
            this.button8.Text = "Buscar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(294, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(913, 39);
            this.textBox1.TabIndex = 116;
            this.textBox1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(18, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1753, 401);
            this.dataGridView1.TabIndex = 101;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(768, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 100;
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(317, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 99;
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14F);
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 35);
            this.label6.TabIndex = 98;
            this.label6.Text = "Buscar Producto:";
            this.label6.UseWaitCursor = true;
            // 
            // Tp_InventarioBajo
            // 
            this.Tp_InventarioBajo.Controls.Add(this.button7);
            this.Tp_InventarioBajo.Controls.Add(this.button1);
            this.Tp_InventarioBajo.Controls.Add(this.button2);
            this.Tp_InventarioBajo.Controls.Add(this.dgv_productos);
            this.Tp_InventarioBajo.Controls.Add(this.label2);
            this.Tp_InventarioBajo.Controls.Add(this.label3);
            this.Tp_InventarioBajo.Controls.Add(this.lbl_buscar);
            this.Tp_InventarioBajo.Controls.Add(this.txt_buscar);
            this.Tp_InventarioBajo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_InventarioBajo.Location = new System.Drawing.Point(4, 38);
            this.Tp_InventarioBajo.Name = "Tp_InventarioBajo";
            this.Tp_InventarioBajo.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_InventarioBajo.Size = new System.Drawing.Size(1794, 652);
            this.Tp_InventarioBajo.TabIndex = 1;
            this.Tp_InventarioBajo.Text = "Inventario Bajos o Criticos";
            this.Tp_InventarioBajo.UseVisualStyleBackColor = true;
            this.Tp_InventarioBajo.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button7.Font = new System.Drawing.Font("Impact", 12F);
            this.button7.ForeColor = System.Drawing.Color.AliceBlue;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1622, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 56);
            this.button7.TabIndex = 115;
            this.button7.Text = "Imprimir";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1415, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 96;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1244, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 95;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToOrderColumns = true;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_productos.Location = new System.Drawing.Point(18, 223);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 62;
            this.dgv_productos.RowTemplate.Height = 28;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(1756, 412);
            this.dgv_productos.TabIndex = 94;
            this.dgv_productos.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(773, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 93;
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(322, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 92;
            this.label3.UseWaitCursor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_buscar.Location = new System.Drawing.Point(21, 48);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(212, 35);
            this.lbl_buscar.TabIndex = 91;
            this.lbl_buscar.Text = "Buscar Producto:";
            this.lbl_buscar.UseWaitCursor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(297, 44);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(913, 39);
            this.txt_buscar.TabIndex = 90;
            this.txt_buscar.UseWaitCursor = true;
            // 
            // Tp_Movimientos
            // 
            this.Tp_Movimientos.Controls.Add(this.btn_unidadMedida);
            this.Tp_Movimientos.Controls.Add(this.txt_unidadMedida);
            this.Tp_Movimientos.Controls.Add(this.txt_id_unidadMedida);
            this.Tp_Movimientos.Controls.Add(this.lbl_categoria);
            this.Tp_Movimientos.Controls.Add(this.cbo_subcategoria);
            this.Tp_Movimientos.Controls.Add(this.lbl_subcategoria);
            this.Tp_Movimientos.Controls.Add(this.lbl_inicio);
            this.Tp_Movimientos.Controls.Add(this.lbl_total);
            this.Tp_Movimientos.Controls.Add(this.dgv_ingresos);
            this.Tp_Movimientos.Controls.Add(this.btn_buscar);
            this.Tp_Movimientos.Controls.Add(this.lbl_fin);
            this.Tp_Movimientos.Controls.Add(this.btn_limpiar);
            this.Tp_Movimientos.Controls.Add(this.btn_imprimir);
            this.Tp_Movimientos.Controls.Add(this.dtp_fecha_fin);
            this.Tp_Movimientos.Controls.Add(this.lbl_resultado);
            this.Tp_Movimientos.Controls.Add(this.dtp_fecha_inicio);
            this.Tp_Movimientos.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_Movimientos.Location = new System.Drawing.Point(4, 38);
            this.Tp_Movimientos.Name = "Tp_Movimientos";
            this.Tp_Movimientos.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Movimientos.Size = new System.Drawing.Size(1794, 652);
            this.Tp_Movimientos.TabIndex = 0;
            this.Tp_Movimientos.Text = "Movimientos";
            this.Tp_Movimientos.UseVisualStyleBackColor = true;
            this.Tp_Movimientos.UseWaitCursor = true;
            // 
            // btn_unidadMedida
            // 
            this.btn_unidadMedida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_unidadMedida.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_unidadMedida.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unidadMedida.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_unidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("btn_unidadMedida.Image")));
            this.btn_unidadMedida.Location = new System.Drawing.Point(671, 126);
            this.btn_unidadMedida.Name = "btn_unidadMedida";
            this.btn_unidadMedida.Size = new System.Drawing.Size(62, 56);
            this.btn_unidadMedida.TabIndex = 133;
            this.btn_unidadMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_unidadMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_unidadMedida.UseVisualStyleBackColor = false;
            this.btn_unidadMedida.UseWaitCursor = true;
            // 
            // txt_unidadMedida
            // 
            this.txt_unidadMedida.BackColor = System.Drawing.SystemColors.Window;
            this.txt_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidadMedida.ForeColor = System.Drawing.Color.Black;
            this.txt_unidadMedida.Location = new System.Drawing.Point(193, 138);
            this.txt_unidadMedida.Name = "txt_unidadMedida";
            this.txt_unidadMedida.ReadOnly = true;
            this.txt_unidadMedida.Size = new System.Drawing.Size(472, 35);
            this.txt_unidadMedida.TabIndex = 132;
            this.txt_unidadMedida.UseWaitCursor = true;
            // 
            // txt_id_unidadMedida
            // 
            this.txt_id_unidadMedida.Enabled = false;
            this.txt_id_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_unidadMedida.ForeColor = System.Drawing.Color.Black;
            this.txt_id_unidadMedida.Location = new System.Drawing.Point(755, 138);
            this.txt_id_unidadMedida.Name = "txt_id_unidadMedida";
            this.txt_id_unidadMedida.ReadOnly = true;
            this.txt_id_unidadMedida.Size = new System.Drawing.Size(115, 44);
            this.txt_id_unidadMedida.TabIndex = 131;
            this.txt_id_unidadMedida.UseWaitCursor = true;
            this.txt_id_unidadMedida.Visible = false;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Black;
            this.lbl_categoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_categoria.Location = new System.Drawing.Point(61, 138);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(126, 35);
            this.lbl_categoria.TabIndex = 130;
            this.lbl_categoria.Text = "Producto:";
            this.lbl_categoria.UseWaitCursor = true;
            // 
            // cbo_subcategoria
            // 
            this.cbo_subcategoria.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbo_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_subcategoria.FormattingEnabled = true;
            this.cbo_subcategoria.Location = new System.Drawing.Point(625, 74);
            this.cbo_subcategoria.Name = "cbo_subcategoria";
            this.cbo_subcategoria.Size = new System.Drawing.Size(430, 37);
            this.cbo_subcategoria.TabIndex = 129;
            this.cbo_subcategoria.UseWaitCursor = true;
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.BackColor = System.Drawing.Color.Black;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_subcategoria.Location = new System.Drawing.Point(730, 18);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(210, 35);
            this.lbl_subcategoria.TabIndex = 128;
            this.lbl_subcategoria.Text = "Tipo Movimiento:";
            this.lbl_subcategoria.UseWaitCursor = true;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BackColor = System.Drawing.Color.LightGray;
            this.lbl_inicio.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_inicio.Location = new System.Drawing.Point(28, 20);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(159, 35);
            this.lbl_inicio.TabIndex = 118;
            this.lbl_inicio.Text = "Fecha Inicio:";
            this.lbl_inicio.UseWaitCursor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(29, 199);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(155, 25);
            this.lbl_total.TabIndex = 121;
            this.lbl_total.Text = "Total de Ingresos:";
            this.lbl_total.UseWaitCursor = true;
            // 
            // dgv_ingresos
            // 
            this.dgv_ingresos.AllowUserToAddRows = false;
            this.dgv_ingresos.AllowUserToDeleteRows = false;
            this.dgv_ingresos.AllowUserToOrderColumns = true;
            this.dgv_ingresos.AllowUserToResizeRows = false;
            this.dgv_ingresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ingresos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ingresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingresos.EnableHeadersVisualStyles = false;
            this.dgv_ingresos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_ingresos.Location = new System.Drawing.Point(17, 241);
            this.dgv_ingresos.Name = "dgv_ingresos";
            this.dgv_ingresos.ReadOnly = true;
            this.dgv_ingresos.RowHeadersVisible = false;
            this.dgv_ingresos.RowHeadersWidth = 62;
            this.dgv_ingresos.RowTemplate.Height = 28;
            this.dgv_ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ingresos.Size = new System.Drawing.Size(1761, 392);
            this.dgv_ingresos.TabIndex = 111;
            this.dgv_ingresos.UseWaitCursor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_buscar.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1092, 39);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(197, 66);
            this.btn_buscar.TabIndex = 112;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.UseWaitCursor = true;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.BackColor = System.Drawing.Color.LightGray;
            this.lbl_fin.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_fin.Location = new System.Drawing.Point(60, 76);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(127, 35);
            this.lbl_fin.TabIndex = 119;
            this.lbl_fin.Text = "Fecha Fin:";
            this.lbl_fin.UseWaitCursor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_limpiar.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(1311, 38);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(197, 66);
            this.btn_limpiar.TabIndex = 113;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.UseWaitCursor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimir.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_imprimir.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(1581, 38);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(197, 66);
            this.btn_imprimir.TabIndex = 114;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.UseWaitCursor = true;
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_fin.Location = new System.Drawing.Point(193, 76);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(392, 37);
            this.dtp_fecha_fin.TabIndex = 117;
            this.dtp_fecha_fin.UseWaitCursor = true;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_resultado.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(1096, 148);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 25);
            this.lbl_resultado.TabIndex = 115;
            this.lbl_resultado.Tag = "";
            this.lbl_resultado.UseWaitCursor = true;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(193, 18);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(392, 37);
            this.dtp_fecha_inicio.TabIndex = 116;
            this.dtp_fecha_inicio.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Tp_Movimientos);
            this.tabControl1.Controls.Add(this.Tp_InventarioBajo);
            this.tabControl1.Controls.Add(this.Tp_ReporteInventarios);
            this.tabControl1.Controls.Add(this.Tp_VencimientosProductos);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(27, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1802, 694);
            this.tabControl1.TabIndex = 2;
            // 
            // FrmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 803);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1874, 859);
            this.Name = "FrmKardex";
            this.Text = "Historial de Movimientos";
            this.Load += new System.EventHandler(this.FrmKardex_Load);
            this.Tp_VencimientosProductos.ResumeLayout(false);
            this.Tp_VencimientosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Tp_ReporteInventarios.ResumeLayout(false);
            this.Tp_ReporteInventarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tp_InventarioBajo.ResumeLayout(false);
            this.Tp_InventarioBajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.Tp_Movimientos.ResumeLayout(false);
            this.Tp_Movimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingresos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Tp_VencimientosProductos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage Tp_ReporteInventarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Tp_InventarioBajo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.TabPage Tp_Movimientos;
        private System.Windows.Forms.Button btn_unidadMedida;
        private System.Windows.Forms.TextBox txt_unidadMedida;
        private System.Windows.Forms.TextBox txt_id_unidadMedida;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ComboBox cbo_subcategoria;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.DataGridView dgv_ingresos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.TabControl tabControl1;
    }
}