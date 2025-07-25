﻿namespace Ferreteria.CapaPresentacion.VistaMovimientoStock
{
    partial class FrmMovimientoStockManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimientoStockManual));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.txt_IdTipoMovimiento = new System.Windows.Forms.TextBox();
            this.btn_buscar_TipoMovimiento = new System.Windows.Forms.Button();
            this.txt_tipoMovimiento = new System.Windows.Forms.TextBox();
            this.btn_buscar_producto = new System.Windows.Forms.Button();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_cancelar.Location = new System.Drawing.Point(637, 645);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 155;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agregar.Location = new System.Drawing.Point(269, 645);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 154;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txt_observacion);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 246);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar una observación ( opcional ):";
            // 
            // txt_observacion
            // 
            this.txt_observacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_observacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacion.Location = new System.Drawing.Point(14, 36);
            this.txt_observacion.Multiline = true;
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacion.Size = new System.Drawing.Size(1089, 193);
            this.txt_observacion.TabIndex = 23;
            // 
            // txt_IdTipoMovimiento
            // 
            this.txt_IdTipoMovimiento.Enabled = false;
            this.txt_IdTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTipoMovimiento.ForeColor = System.Drawing.Color.Black;
            this.txt_IdTipoMovimiento.Location = new System.Drawing.Point(419, 166);
            this.txt_IdTipoMovimiento.Name = "txt_IdTipoMovimiento";
            this.txt_IdTipoMovimiento.ReadOnly = true;
            this.txt_IdTipoMovimiento.Size = new System.Drawing.Size(115, 44);
            this.txt_IdTipoMovimiento.TabIndex = 163;
            this.txt_IdTipoMovimiento.Visible = false;
            // 
            // btn_buscar_TipoMovimiento
            // 
            this.btn_buscar_TipoMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_buscar_TipoMovimiento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_buscar_TipoMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_TipoMovimiento.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_TipoMovimiento.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_buscar_TipoMovimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_TipoMovimiento.Image")));
            this.btn_buscar_TipoMovimiento.Location = new System.Drawing.Point(934, 98);
            this.btn_buscar_TipoMovimiento.Name = "btn_buscar_TipoMovimiento";
            this.btn_buscar_TipoMovimiento.Size = new System.Drawing.Size(62, 56);
            this.btn_buscar_TipoMovimiento.TabIndex = 162;
            this.btn_buscar_TipoMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_TipoMovimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_TipoMovimiento.UseVisualStyleBackColor = false;
            this.btn_buscar_TipoMovimiento.Click += new System.EventHandler(this.btn_buscar_TipoMovimiento_Click);
            // 
            // txt_tipoMovimiento
            // 
            this.txt_tipoMovimiento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoMovimiento.ForeColor = System.Drawing.Color.Black;
            this.txt_tipoMovimiento.Location = new System.Drawing.Point(418, 213);
            this.txt_tipoMovimiento.Name = "txt_tipoMovimiento";
            this.txt_tipoMovimiento.ReadOnly = true;
            this.txt_tipoMovimiento.Size = new System.Drawing.Size(510, 44);
            this.txt_tipoMovimiento.TabIndex = 161;
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_buscar_producto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_producto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_producto.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_buscar_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_producto.Image")));
            this.btn_buscar_producto.Location = new System.Drawing.Point(934, 3);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(62, 56);
            this.btn_buscar_producto.TabIndex = 160;
            this.btn_buscar_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_producto.Location = new System.Drawing.Point(425, 118);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.ReadOnly = true;
            this.txt_nombre_producto.Size = new System.Drawing.Size(503, 44);
            this.txt_nombre_producto.TabIndex = 159;
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Enabled = false;
            this.txt_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_id_producto.Location = new System.Drawing.Point(426, 71);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.ReadOnly = true;
            this.txt_id_producto.Size = new System.Drawing.Size(115, 44);
            this.txt_id_producto.TabIndex = 158;
            this.txt_id_producto.Visible = false;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.BackColor = System.Drawing.Color.Black;
            this.lbl_categoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_categoria.Location = new System.Drawing.Point(134, 216);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(244, 35);
            this.lbl_categoria.TabIndex = 157;
            this.lbl_categoria.Text = "Tipo De Movimiento:";
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.BackColor = System.Drawing.Color.Black;
            this.lbl_producto.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_producto.Location = new System.Drawing.Point(204, 115);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(126, 35);
            this.lbl_producto.TabIndex = 156;
            this.lbl_producto.Text = "Producto:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.Black;
            this.txt_cantidad.Location = new System.Drawing.Point(419, 291);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.ReadOnly = true;
            this.txt_cantidad.Size = new System.Drawing.Size(571, 44);
            this.txt_cantidad.TabIndex = 164;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cantidad.Location = new System.Drawing.Point(224, 294);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(126, 35);
            this.lbl_cantidad.TabIndex = 165;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(402, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 44);
            this.label1.TabIndex = 166;
            this.label1.Text = "Agrega un Movimiento de Stock";
            // 
            // FrmMovimientoStockManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_IdTipoMovimiento);
            this.Controls.Add(this.btn_buscar_TipoMovimiento);
            this.Controls.Add(this.txt_tipoMovimiento);
            this.Controls.Add(this.btn_buscar_producto);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.txt_id_producto);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1197, 775);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1197, 775);
            this.Name = "FrmMovimientoStockManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovimientoStockManual";
            this.Load += new System.EventHandler(this.FrmMovimientoStockManual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_observacion;
        private System.Windows.Forms.TextBox txt_IdTipoMovimiento;
        private System.Windows.Forms.Button btn_buscar_TipoMovimiento;
        private System.Windows.Forms.TextBox txt_tipoMovimiento;
        private System.Windows.Forms.Button btn_buscar_producto;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label1;
    }
}