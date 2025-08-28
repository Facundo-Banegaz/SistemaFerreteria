namespace Ferreteria.CapaPresentacion.VistaMovimientoStock
{
    partial class FrmHistorialMovimientoStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialMovimientoStock));
            this.dgv_movimientoStock = new System.Windows.Forms.DataGridView();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_ver_detalle = new System.Windows.Forms.Button();
            this.cbo_TipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lbl_subcategoria = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_tiposMovimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimientoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_movimientoStock
            // 
            this.dgv_movimientoStock.AllowUserToAddRows = false;
            this.dgv_movimientoStock.AllowUserToDeleteRows = false;
            this.dgv_movimientoStock.AllowUserToOrderColumns = true;
            this.dgv_movimientoStock.AllowUserToResizeRows = false;
            this.dgv_movimientoStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_movimientoStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_movimientoStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_movimientoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_movimientoStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_movimientoStock.EnableHeadersVisualStyles = false;
            this.dgv_movimientoStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_movimientoStock.Location = new System.Drawing.Point(12, 220);
            this.dgv_movimientoStock.Name = "dgv_movimientoStock";
            this.dgv_movimientoStock.ReadOnly = true;
            this.dgv_movimientoStock.RowHeadersVisible = false;
            this.dgv_movimientoStock.RowHeadersWidth = 62;
            this.dgv_movimientoStock.RowTemplate.Height = 28;
            this.dgv_movimientoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_movimientoStock.Size = new System.Drawing.Size(1763, 539);
            this.dgv_movimientoStock.TabIndex = 91;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(650, 188);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 29);
            this.lbl_resultado.TabIndex = 87;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(650, 134);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 29);
            this.lbl_total.TabIndex = 86;
            // 
            // btn_ver_detalle
            // 
            this.btn_ver_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ver_detalle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ver_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver_detalle.Font = new System.Drawing.Font("Impact", 10F);
            this.btn_ver_detalle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_ver_detalle.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver_detalle.Image")));
            this.btn_ver_detalle.Location = new System.Drawing.Point(1623, 28);
            this.btn_ver_detalle.Name = "btn_ver_detalle";
            this.btn_ver_detalle.Size = new System.Drawing.Size(152, 50);
            this.btn_ver_detalle.TabIndex = 106;
            this.btn_ver_detalle.Text = "Ver Detalle \r\n";
            this.btn_ver_detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ver_detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver_detalle.UseVisualStyleBackColor = false;
            this.btn_ver_detalle.Click += new System.EventHandler(this.btn_ver_detalle_Click);
            // 
            // cbo_TipoMovimiento
            // 
            this.cbo_TipoMovimiento.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cbo_TipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbo_TipoMovimiento.FormattingEnabled = true;
            this.cbo_TipoMovimiento.Location = new System.Drawing.Point(237, 22);
            this.cbo_TipoMovimiento.Name = "cbo_TipoMovimiento";
            this.cbo_TipoMovimiento.Size = new System.Drawing.Size(397, 40);
            this.cbo_TipoMovimiento.TabIndex = 138;
            this.cbo_TipoMovimiento.UseWaitCursor = true;
            this.cbo_TipoMovimiento.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoMovimiento_SelectedIndexChanged);
            // 
            // lbl_subcategoria
            // 
            this.lbl_subcategoria.AutoSize = true;
            this.lbl_subcategoria.BackColor = System.Drawing.Color.Black;
            this.lbl_subcategoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_subcategoria.Location = new System.Drawing.Point(6, 27);
            this.lbl_subcategoria.Name = "lbl_subcategoria";
            this.lbl_subcategoria.Size = new System.Drawing.Size(210, 35);
            this.lbl_subcategoria.TabIndex = 137;
            this.lbl_subcategoria.Text = "Tipo Movimiento:";
            this.lbl_subcategoria.UseWaitCursor = true;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BackColor = System.Drawing.Color.LightGray;
            this.lbl_inicio.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_inicio.Location = new System.Drawing.Point(57, 79);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(159, 35);
            this.lbl_inicio.TabIndex = 135;
            this.lbl_inicio.Text = "Fecha Inicio:";
            this.lbl_inicio.UseWaitCursor = true;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.BackColor = System.Drawing.Color.LightGray;
            this.lbl_fin.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_fin.Location = new System.Drawing.Point(89, 134);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(127, 35);
            this.lbl_fin.TabIndex = 136;
            this.lbl_fin.Text = "Fecha Fin:";
            this.lbl_fin.UseWaitCursor = true;
            // 
            // dtp_fecha_fin
            // 
            this.dtp_fecha_fin.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_fin.Location = new System.Drawing.Point(239, 132);
            this.dtp_fecha_fin.Name = "dtp_fecha_fin";
            this.dtp_fecha_fin.Size = new System.Drawing.Size(395, 37);
            this.dtp_fecha_fin.TabIndex = 134;
            this.dtp_fecha_fin.UseWaitCursor = true;
            // 
            // dtp_fecha_inicio
            // 
            this.dtp_fecha_inicio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_inicio.Location = new System.Drawing.Point(238, 75);
            this.dtp_fecha_inicio.Name = "dtp_fecha_inicio";
            this.dtp_fecha_inicio.Size = new System.Drawing.Size(395, 37);
            this.dtp_fecha_inicio.TabIndex = 133;
            this.dtp_fecha_inicio.UseWaitCursor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Font = new System.Drawing.Font("Impact", 10F);
            this.btn_buscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1200, 27);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(152, 50);
            this.btn_buscar.TabIndex = 140;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_limpiar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(1374, 27);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(152, 50);
            this.btn_limpiar.TabIndex = 141;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.UseWaitCursor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Btn_tiposMovimiento
            // 
            this.Btn_tiposMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_tiposMovimiento.BackColor = System.Drawing.Color.SkyBlue;
            this.Btn_tiposMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_tiposMovimiento.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tiposMovimiento.ForeColor = System.Drawing.Color.AliceBlue;
            this.Btn_tiposMovimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_tiposMovimiento.Image")));
            this.Btn_tiposMovimiento.Location = new System.Drawing.Point(1469, 151);
            this.Btn_tiposMovimiento.Name = "Btn_tiposMovimiento";
            this.Btn_tiposMovimiento.Size = new System.Drawing.Size(306, 55);
            this.Btn_tiposMovimiento.TabIndex = 142;
            this.Btn_tiposMovimiento.Text = "Ver Tipos De Movimientos";
            this.Btn_tiposMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_tiposMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_tiposMovimiento.UseVisualStyleBackColor = false;
            this.Btn_tiposMovimiento.Click += new System.EventHandler(this.Btn_tiposMovimiento_Click);
            // 
            // FrmHistorialMovimientoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 771);
            this.Controls.Add(this.Btn_tiposMovimiento);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cbo_TipoMovimiento);
            this.Controls.Add(this.lbl_subcategoria);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.dtp_fecha_fin);
            this.Controls.Add(this.dtp_fecha_inicio);
            this.Controls.Add(this.btn_ver_detalle);
            this.Controls.Add(this.dgv_movimientoStock);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_total);
            this.Name = "FrmHistorialMovimientoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Movimientos de Stock";
            this.Load += new System.EventHandler(this.FrmMovimientoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movimientoStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_movimientoStock;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_ver_detalle;
        private System.Windows.Forms.ComboBox cbo_TipoMovimiento;
        private System.Windows.Forms.Label lbl_subcategoria;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dtp_fecha_inicio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button Btn_tiposMovimiento;
    }
}