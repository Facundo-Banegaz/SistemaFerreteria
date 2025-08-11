namespace Ferreteria.CapaPresentacion.VistaInventario
{
    partial class FrmVencimientosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVencimientosProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_Todos = new System.Windows.Forms.RadioButton();
            this.Rb_Vencido = new System.Windows.Forms.RadioButton();
            this.Rb_Por_Vencer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button7.Font = new System.Drawing.Font("Impact", 12F);
            this.button7.ForeColor = System.Drawing.Color.AliceBlue;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1619, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 56);
            this.button7.TabIndex = 123;
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
            this.button1.Location = new System.Drawing.Point(1412, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 56);
            this.button1.TabIndex = 122;
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
            this.button2.Location = new System.Drawing.Point(1241, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 121;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_productos.Location = new System.Drawing.Point(12, 237);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 62;
            this.dgv_productos.RowTemplate.Height = 28;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_productos.Size = new System.Drawing.Size(1759, 522);
            this.dgv_productos.TabIndex = 120;
            this.dgv_productos.UseWaitCursor = true;
            this.dgv_productos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_productos_CellFormatting);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Orange;
            this.lbl_resultado.Location = new System.Drawing.Point(1177, 96);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(63, 29);
            this.lbl_resultado.TabIndex = 119;
            this.lbl_resultado.Text = "fdgdf";
            this.lbl_resultado.UseWaitCursor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(412, 157);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(63, 29);
            this.lbl_total.TabIndex = 118;
            this.lbl_total.Text = "fdgdf";
            this.lbl_total.UseWaitCursor = true;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_buscar.Location = new System.Drawing.Point(18, 36);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(212, 35);
            this.lbl_buscar.TabIndex = 117;
            this.lbl_buscar.Text = "Buscar Producto:";
            this.lbl_buscar.UseWaitCursor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(265, 32);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(913, 39);
            this.txt_buscar.TabIndex = 116;
            this.txt_buscar.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Rb_Todos);
            this.groupBox1.Controls.Add(this.Rb_Vencido);
            this.groupBox1.Controls.Add(this.Rb_Por_Vencer);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 135);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // Rb_Todos
            // 
            this.Rb_Todos.AutoSize = true;
            this.Rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Todos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Rb_Todos.Location = new System.Drawing.Point(12, 26);
            this.Rb_Todos.Name = "Rb_Todos";
            this.Rb_Todos.Size = new System.Drawing.Size(248, 29);
            this.Rb_Todos.TabIndex = 127;
            this.Rb_Todos.Text = "Todos Los Productos ";
            this.Rb_Todos.UseVisualStyleBackColor = true;
            this.Rb_Todos.CheckedChanged += new System.EventHandler(this.Rb_Todos_CheckedChanged);
            // 
            // Rb_Vencido
            // 
            this.Rb_Vencido.AutoSize = true;
            this.Rb_Vencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Vencido.ForeColor = System.Drawing.Color.Red;
            this.Rb_Vencido.Location = new System.Drawing.Point(12, 96);
            this.Rb_Vencido.Name = "Rb_Vencido";
            this.Rb_Vencido.Size = new System.Drawing.Size(236, 29);
            this.Rb_Vencido.TabIndex = 126;
            this.Rb_Vencido.Text = "Productos Vencidos ";
            this.Rb_Vencido.UseVisualStyleBackColor = true;
            this.Rb_Vencido.CheckedChanged += new System.EventHandler(this.Rb_Vencido_CheckedChanged);
            // 
            // Rb_Por_Vencer
            // 
            this.Rb_Por_Vencer.AutoSize = true;
            this.Rb_Por_Vencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_Por_Vencer.ForeColor = System.Drawing.Color.Orange;
            this.Rb_Por_Vencer.Location = new System.Drawing.Point(12, 61);
            this.Rb_Por_Vencer.Name = "Rb_Por_Vencer";
            this.Rb_Por_Vencer.Size = new System.Drawing.Size(345, 29);
            this.Rb_Por_Vencer.TabIndex = 125;
            this.Rb_Por_Vencer.Text = "Por Vencer en  45 días o menos";
            this.Rb_Por_Vencer.UseVisualStyleBackColor = true;
            this.Rb_Por_Vencer.CheckedChanged += new System.EventHandler(this.Rb_Por_Vencer_CheckedChanged);
            // 
            // FrmVencimientosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 771);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Name = "FrmVencimientosProductos";
            this.Text = "FrmVencimientosProductos";
            this.Load += new System.EventHandler(this.FrmVencimientosProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_Por_Vencer;
        private System.Windows.Forms.RadioButton Rb_Vencido;
        private System.Windows.Forms.RadioButton Rb_Todos;
    }
}