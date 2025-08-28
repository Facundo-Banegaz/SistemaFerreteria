namespace Ferreteria.CapaPresentacion.VistaCompartida
{
    partial class FrmSeleccionarTipoMovimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_TipoMovimiento = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TipoMovimiento
            // 
            this.dgv_TipoMovimiento.AllowUserToAddRows = false;
            this.dgv_TipoMovimiento.AllowUserToDeleteRows = false;
            this.dgv_TipoMovimiento.AllowUserToOrderColumns = true;
            this.dgv_TipoMovimiento.AllowUserToResizeRows = false;
            this.dgv_TipoMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TipoMovimiento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TipoMovimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TipoMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TipoMovimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TipoMovimiento.EnableHeadersVisualStyles = false;
            this.dgv_TipoMovimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_TipoMovimiento.Location = new System.Drawing.Point(32, 181);
            this.dgv_TipoMovimiento.Name = "dgv_TipoMovimiento";
            this.dgv_TipoMovimiento.ReadOnly = true;
            this.dgv_TipoMovimiento.RowHeadersVisible = false;
            this.dgv_TipoMovimiento.RowHeadersWidth = 62;
            this.dgv_TipoMovimiento.RowTemplate.Height = 28;
            this.dgv_TipoMovimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TipoMovimiento.Size = new System.Drawing.Size(1592, 554);
            this.dgv_TipoMovimiento.TabIndex = 94;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_total.Location = new System.Drawing.Point(312, 107);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 29);
            this.lbl_total.TabIndex = 92;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Impact", 14F);
            this.lbl_buscar.Location = new System.Drawing.Point(659, 40);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(275, 35);
            this.lbl_buscar.TabIndex = 89;
            this.lbl_buscar.Text = " Tipos de Movimientos:";
            // 
            // FrmSeleccionarTipoMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 750);
            this.Controls.Add(this.dgv_TipoMovimiento);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_buscar);
            this.Name = "FrmSeleccionarTipoMovimiento";
            this.Text = "FrmSeleccionarTipoMovimiento";
            this.Load += new System.EventHandler(this.FrmSeleccionarTipoMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TipoMovimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_TipoMovimiento;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_buscar;
    }
}