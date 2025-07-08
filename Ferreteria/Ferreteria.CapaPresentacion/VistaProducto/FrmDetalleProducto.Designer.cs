namespace Ferreteria.CapaPresentacion.VistaProducto
{
    partial class FrmDetalleProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Chk_estado = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_caracteristicas = new System.Windows.Forms.DataGridView();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_requierevencimineto = new System.Windows.Forms.Label();
            this.Chk_requiereVencimiento = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Chk_actualizarPrecioAutomaticamente = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caracteristicas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chk_estado
            // 
            this.Chk_estado.AutoSize = true;
            this.Chk_estado.Location = new System.Drawing.Point(1404, 186);
            this.Chk_estado.Name = "Chk_estado";
            this.Chk_estado.Size = new System.Drawing.Size(22, 21);
            this.Chk_estado.TabIndex = 94;
            this.Chk_estado.UseVisualStyleBackColor = true;
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
            this.btn_cancelar.Location = new System.Drawing.Point(1483, 537);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 95;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dgv_caracteristicas);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1628, 199);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_caracteristicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_caracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_caracteristicas.EnableHeadersVisualStyles = false;
            this.dgv_caracteristicas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_caracteristicas.Location = new System.Drawing.Point(39, 36);
            this.dgv_caracteristicas.Name = "dgv_caracteristicas";
            this.dgv_caracteristicas.ReadOnly = true;
            this.dgv_caracteristicas.RowHeadersVisible = false;
            this.dgv_caracteristicas.RowHeadersWidth = 62;
            this.dgv_caracteristicas.RowTemplate.Height = 28;
            this.dgv_caracteristicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_caracteristicas.Size = new System.Drawing.Size(1565, 143);
            this.dgv_caracteristicas.TabIndex = 81;
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion_producto.Enabled = false;
            this.txt_descripcion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_producto.Location = new System.Drawing.Point(35, 272);
            this.txt_descripcion_producto.Multiline = true;
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(1628, 118);
            this.txt_descripcion_producto.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Chk_actualizarPrecioAutomaticamente);
            this.groupBox2.Controls.Add(this.lbl_requierevencimineto);
            this.groupBox2.Controls.Add(this.Chk_requiereVencimiento);
            this.groupBox2.Controls.Add(this.txt_descripcion_producto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_unidad);
            this.groupBox2.Controls.Add(this.lbl_Id);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.Chk_estado);
            this.groupBox2.Controls.Add(this.lbl_stock_minimo);
            this.groupBox2.Controls.Add(this.lbl_marca);
            this.groupBox2.Controls.Add(this.lbl_subcategoria);
            this.groupBox2.Controls.Add(this.lbl_stock);
            this.groupBox2.Controls.Add(this.lbl_fecha);
            this.groupBox2.Controls.Add(this.lbl_precio);
            this.groupBox2.Controls.Add(this.lbl_nombre);
            this.groupBox2.Controls.Add(this.lbl_codigo);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1684, 601);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Del Producto Seleccionado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Desccripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1291, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Estado:";
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Location = new System.Drawing.Point(1291, 92);
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
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(791, 181);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(149, 29);
            this.lbl_stock_minimo.TabIndex = 9;
            this.lbl_stock_minimo.Text = "Stock Minimo:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(791, 136);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(80, 29);
            this.lbl_marca.TabIndex = 8;
            this.lbl_marca.Text = "Marca:";
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.Location = new System.Drawing.Point(791, 92);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(149, 29);
            this.lbl_subcategoria.TabIndex = 6;
            this.lbl_subcategoria.Text = "Subcategoria:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(21, 181);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(72, 29);
            this.lbl_stock.TabIndex = 5;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_fecha.ForeColor = System.Drawing.Color.Coral;
            this.lbl_fecha.Location = new System.Drawing.Point(791, 45);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(329, 29);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha de la Ultima Actualización:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_precio.ForeColor = System.Drawing.Color.Coral;
            this.lbl_precio.Location = new System.Drawing.Point(21, 136);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(81, 29);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 92);
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
            // lbl_requierevencimineto
            // 
            this.lbl_requierevencimineto.AutoSize = true;
            this.lbl_requierevencimineto.Location = new System.Drawing.Point(293, 232);
            this.lbl_requierevencimineto.Name = "lbl_requierevencimineto";
            this.lbl_requierevencimineto.Size = new System.Drawing.Size(235, 29);
            this.lbl_requierevencimineto.TabIndex = 104;
            this.lbl_requierevencimineto.Text = "Requiere Vencimiento:";
            // 
            // Chk_requiereVencimiento
            // 
            this.Chk_requiereVencimiento.AutoSize = true;
            this.Chk_requiereVencimiento.Location = new System.Drawing.Point(562, 240);
            this.Chk_requiereVencimiento.Name = "Chk_requiereVencimiento";
            this.Chk_requiereVencimiento.Size = new System.Drawing.Size(22, 21);
            this.Chk_requiereVencimiento.TabIndex = 103;
            this.Chk_requiereVencimiento.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(791, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 29);
            this.label4.TabIndex = 106;
            this.label4.Text = "Actualizar Precio Automaticamente:";
            // 
            // Chk_actualizarPrecioAutomaticamente
            // 
            this.Chk_actualizarPrecioAutomaticamente.AutoSize = true;
            this.Chk_actualizarPrecioAutomaticamente.Location = new System.Drawing.Point(1209, 235);
            this.Chk_actualizarPrecioAutomaticamente.Name = "Chk_actualizarPrecioAutomaticamente";
            this.Chk_actualizarPrecioAutomaticamente.Size = new System.Drawing.Size(22, 21);
            this.Chk_actualizarPrecioAutomaticamente.TabIndex = 105;
            this.Chk_actualizarPrecioAutomaticamente.UseVisualStyleBackColor = true;
            // 
            // FrmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1714, 671);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1714, 671);
            this.Name = "FrmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleProducto";
            this.Load += new System.EventHandler(this.FrmDetalleProducto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_caracteristicas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox Chk_estado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcion_producto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_caracteristicas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Chk_actualizarPrecioAutomaticamente;
        private System.Windows.Forms.Label lbl_requierevencimineto;
        private System.Windows.Forms.CheckBox Chk_requiereVencimiento;
    }
}