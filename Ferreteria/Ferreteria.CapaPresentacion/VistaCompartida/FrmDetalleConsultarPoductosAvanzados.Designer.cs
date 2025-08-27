namespace Ferreteria.CapaPresentacion.VistaCompartida
{
    partial class FrmDetalleConsultarPoductosAvanzados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_caracteristicas = new System.Windows.Forms.DataGridView();
            this.Chk_estado = new System.Windows.Forms.CheckBox();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caracteristicas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_categoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_unidad);
            this.groupBox2.Controls.Add(this.lbl_Id);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Chk_estado);
            this.groupBox2.Controls.Add(this.lbl_stock_minimo);
            this.groupBox2.Controls.Add(this.lbl_marca);
            this.groupBox2.Controls.Add(this.lbl_subcategoria);
            this.groupBox2.Controls.Add(this.lbl_stock);
            this.groupBox2.Controls.Add(this.lbl_precio);
            this.groupBox2.Controls.Add(this.lbl_nombre);
            this.groupBox2.Controls.Add(this.lbl_codigo);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1757, 601);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Del Producto Seleccionado";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(865, 45);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(113, 29);
            this.lbl_categoria.TabIndex = 102;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Estado:";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(865, 185);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(184, 29);
            this.lbl_unidad.TabIndex = 100;
            this.lbl_unidad.Text = "Unidad de Medida";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(407, 45);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(0, 29);
            this.lbl_Id.TabIndex = 99;
            this.lbl_Id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgv_caracteristicas);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1701, 320);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas adicional del Producto:";
            // 
            // dgv_caracteristicas
            // 
            this.dgv_caracteristicas.AllowUserToAddRows = false;
            this.dgv_caracteristicas.AllowUserToDeleteRows = false;
            this.dgv_caracteristicas.AllowUserToOrderColumns = true;
            this.dgv_caracteristicas.AllowUserToResizeRows = false;
            this.dgv_caracteristicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_caracteristicas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_caracteristicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_caracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_caracteristicas.EnableHeadersVisualStyles = false;
            this.dgv_caracteristicas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_caracteristicas.Location = new System.Drawing.Point(25, 36);
            this.dgv_caracteristicas.Name = "dgv_caracteristicas";
            this.dgv_caracteristicas.ReadOnly = true;
            this.dgv_caracteristicas.RowHeadersVisible = false;
            this.dgv_caracteristicas.RowHeadersWidth = 62;
            this.dgv_caracteristicas.RowTemplate.Height = 28;
            this.dgv_caracteristicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_caracteristicas.Size = new System.Drawing.Size(1652, 264);
            this.dgv_caracteristicas.TabIndex = 81;
            // 
            // Chk_estado
            // 
            this.Chk_estado.AutoSize = true;
            this.Chk_estado.Enabled = false;
            this.Chk_estado.Location = new System.Drawing.Point(978, 232);
            this.Chk_estado.Name = "Chk_estado";
            this.Chk_estado.Size = new System.Drawing.Size(22, 21);
            this.Chk_estado.TabIndex = 94;
            this.Chk_estado.UseVisualStyleBackColor = true;
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(21, 227);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(149, 29);
            this.lbl_stock_minimo.TabIndex = 9;
            this.lbl_stock_minimo.Text = "Stock Minimo:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(865, 137);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(80, 29);
            this.lbl_marca.TabIndex = 8;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.Location = new System.Drawing.Point(865, 90);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(149, 29);
            this.lbl_subcategoria.TabIndex = 6;
            this.lbl_subcategoria.Text = "Subcategoria:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(21, 185);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(72, 29);
            this.lbl_stock.TabIndex = 5;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_precio.ForeColor = System.Drawing.Color.Coral;
            this.lbl_precio.Location = new System.Drawing.Point(21, 137);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(81, 29);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 90);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(95, 29);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(21, 45);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(85, 29);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // FrmDetalleConsultarPoductosAvanzados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 615);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1784, 671);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1784, 671);
            this.Name = "FrmDetalleConsultarPoductosAvanzados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del Productos";
            this.Load += new System.EventHandler(this.FrmDetalleConsultarroductosAvanzados_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caracteristicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv_caracteristicas;
        private System.Windows.Forms.CheckBox Chk_estado;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_categoria;
    }
}