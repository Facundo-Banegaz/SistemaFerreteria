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
            this.Tp_VencimientosProductos = new System.Windows.Forms.TabPage();
            this.Tp_InventarioBajo = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tp_Movimientos = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tp_VencimientosProductos
            // 
            this.Tp_VencimientosProductos.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_VencimientosProductos.Location = new System.Drawing.Point(4, 38);
            this.Tp_VencimientosProductos.Name = "Tp_VencimientosProductos";
            this.Tp_VencimientosProductos.Size = new System.Drawing.Size(1845, 761);
            this.Tp_VencimientosProductos.TabIndex = 3;
            this.Tp_VencimientosProductos.Text = "Productos Vencidos o por Vencer";
            this.Tp_VencimientosProductos.UseVisualStyleBackColor = true;
            this.Tp_VencimientosProductos.UseWaitCursor = true;
            // 
            // Tp_InventarioBajo
            // 
            this.Tp_InventarioBajo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_InventarioBajo.Location = new System.Drawing.Point(4, 38);
            this.Tp_InventarioBajo.Name = "Tp_InventarioBajo";
            this.Tp_InventarioBajo.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_InventarioBajo.Size = new System.Drawing.Size(1845, 761);
            this.Tp_InventarioBajo.TabIndex = 1;
            this.Tp_InventarioBajo.Text = "Inventario ";
            this.Tp_InventarioBajo.UseVisualStyleBackColor = true;
            this.Tp_InventarioBajo.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Tp_InventarioBajo);
            this.tabControl1.Controls.Add(this.Tp_VencimientosProductos);
            this.tabControl1.Controls.Add(this.Tp_Movimientos);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1853, 803);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tp_Movimientos
            // 
            this.Tp_Movimientos.Location = new System.Drawing.Point(4, 38);
            this.Tp_Movimientos.Name = "Tp_Movimientos";
            this.Tp_Movimientos.Size = new System.Drawing.Size(1845, 761);
            this.Tp_Movimientos.TabIndex = 4;
            this.Tp_Movimientos.Text = "Movimientos";
            this.Tp_Movimientos.UseVisualStyleBackColor = true;
            // 
            // FrmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 803);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1874, 859);
            this.Name = "FrmKardex";
            this.Text = "Gestion Inventario";
            this.Load += new System.EventHandler(this.FrmKardex_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Tp_VencimientosProductos;
        private System.Windows.Forms.TabPage Tp_InventarioBajo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tp_Movimientos;
    }
}