namespace Ferreteria.CapaPresentacion.VistaInventario
{
    partial class FrmInventarioBajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventarioBajo));
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_Stock_Ok = new System.Windows.Forms.Label();
            this.lbl_Stock_Critico = new System.Windows.Forms.Label();
            this.lbl_Stock_Igual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_productos.Location = new System.Drawing.Point(12, 242);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 62;
            this.dgv_productos.RowTemplate.Height = 28;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_productos.Size = new System.Drawing.Size(1763, 517);
            this.dgv_productos.TabIndex = 128;
            this.dgv_productos.UseWaitCursor = true;
            this.dgv_productos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_productos_CellFormatting);
            this.dgv_productos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellValueChanged);
            this.dgv_productos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_productos_RowsRemoved);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resultado.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultado.Location = new System.Drawing.Point(1177, 97);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 29);
            this.lbl_resultado.TabIndex = 127;
            this.lbl_resultado.UseWaitCursor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 16F);
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(12, 200);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 39);
            this.lbl_total.TabIndex = 126;
            this.lbl_total.UseWaitCursor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimir.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_imprimir.Font = new System.Drawing.Font("Impact", 12F);
            this.btn_imprimir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_imprimir.Image")));
            this.btn_imprimir.Location = new System.Drawing.Point(1623, 23);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(152, 56);
            this.btn_imprimir.TabIndex = 136;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.UseWaitCursor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_limpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_limpiar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(1420, 23);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(152, 56);
            this.btn_limpiar.TabIndex = 135;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.UseWaitCursor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_buscar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1249, 23);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(152, 56);
            this.btn_buscar.TabIndex = 134;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.UseWaitCursor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_buscar.Location = new System.Drawing.Point(6, 32);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(212, 35);
            this.lbl_buscar.TabIndex = 133;
            this.lbl_buscar.Text = "Buscar Producto:";
            this.lbl_buscar.UseWaitCursor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(264, 32);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(913, 39);
            this.txt_buscar.TabIndex = 132;
            this.txt_buscar.UseWaitCursor = true;
            // 
            // lbl_Stock_Ok
            // 
            this.lbl_Stock_Ok.AutoSize = true;
            this.lbl_Stock_Ok.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Stock_Ok.Font = new System.Drawing.Font("Impact", 15F);
            this.lbl_Stock_Ok.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Stock_Ok.Location = new System.Drawing.Point(14, 159);
            this.lbl_Stock_Ok.Name = "lbl_Stock_Ok";
            this.lbl_Stock_Ok.Size = new System.Drawing.Size(0, 37);
            this.lbl_Stock_Ok.TabIndex = 137;
            this.lbl_Stock_Ok.UseWaitCursor = true;
            // 
            // lbl_Stock_Critico
            // 
            this.lbl_Stock_Critico.AutoSize = true;
            this.lbl_Stock_Critico.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Stock_Critico.Font = new System.Drawing.Font("Impact", 15F);
            this.lbl_Stock_Critico.ForeColor = System.Drawing.Color.Red;
            this.lbl_Stock_Critico.Location = new System.Drawing.Point(14, 77);
            this.lbl_Stock_Critico.Name = "lbl_Stock_Critico";
            this.lbl_Stock_Critico.Size = new System.Drawing.Size(0, 37);
            this.lbl_Stock_Critico.TabIndex = 138;
            this.lbl_Stock_Critico.UseWaitCursor = true;
            // 
            // lbl_Stock_Igual
            // 
            this.lbl_Stock_Igual.AutoSize = true;
            this.lbl_Stock_Igual.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Stock_Igual.Font = new System.Drawing.Font("Impact", 15F);
            this.lbl_Stock_Igual.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Stock_Igual.Location = new System.Drawing.Point(14, 118);
            this.lbl_Stock_Igual.Name = "lbl_Stock_Igual";
            this.lbl_Stock_Igual.Size = new System.Drawing.Size(0, 37);
            this.lbl_Stock_Igual.TabIndex = 139;
            this.lbl_Stock_Igual.UseWaitCursor = true;
            // 
            // FrmInventarioBajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 771);
            this.Controls.Add(this.lbl_Stock_Igual);
            this.Controls.Add(this.lbl_Stock_Critico);
            this.Controls.Add(this.lbl_Stock_Ok);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_total);
            this.Name = "FrmInventarioBajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Inventario";
            this.Load += new System.EventHandler(this.FrmInventarioBajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_Stock_Ok;
        private System.Windows.Forms.Label lbl_Stock_Critico;
        private System.Windows.Forms.Label lbl_Stock_Igual;
    }
}