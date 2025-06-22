namespace Ferreteria.CapaPresentacion.VistaEspecificacion
{
    partial class FrmAgregarEditarEspecificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarEspecificacion));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_id_especificacion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.txt_id_valorEspecificacion = new System.Windows.Forms.TextBox();
            this.txt_id_TipoEspecificacion = new System.Windows.Forms.TextBox();
            this.txt_nombre_TipoEspecificacion = new System.Windows.Forms.TextBox();
            this.txt_valorEspecificacion = new System.Windows.Forms.TextBox();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_valor_especificacion = new System.Windows.Forms.Button();
            this.btn_tipo_especificacion = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(271, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 44);
            this.label1.TabIndex = 105;
            this.label1.Text = "Tipo Especificación:";
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
            this.btn_cancelar.Location = new System.Drawing.Point(523, 594);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 104;
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
            this.btn_Agregar.Location = new System.Drawing.Point(99, 594);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 103;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_id_especificacion
            // 
            this.lbl_id_especificacion.AutoSize = true;
            this.lbl_id_especificacion.BackColor = System.Drawing.Color.Black;
            this.lbl_id_especificacion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_especificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id_especificacion.Location = new System.Drawing.Point(27, 30);
            this.lbl_id_especificacion.Name = "lbl_id_especificacion";
            this.lbl_id_especificacion.Size = new System.Drawing.Size(0, 35);
            this.lbl_id_especificacion.TabIndex = 102;
            this.lbl_id_especificacion.Visible = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 18F);
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(285, 432);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(328, 44);
            this.lbl_nombre.TabIndex = 100;
            this.lbl_nombre.Text = "Valor Especificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(359, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 44);
            this.label2.TabIndex = 107;
            this.label2.Text = "Producto";
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Enabled = false;
            this.txt_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_id_producto.Location = new System.Drawing.Point(33, 107);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.ReadOnly = true;
            this.txt_id_producto.Size = new System.Drawing.Size(115, 44);
            this.txt_id_producto.TabIndex = 108;
            // 
            // txt_id_valorEspecificacion
            // 
            this.txt_id_valorEspecificacion.Enabled = false;
            this.txt_id_valorEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_valorEspecificacion.ForeColor = System.Drawing.Color.Black;
            this.txt_id_valorEspecificacion.Location = new System.Drawing.Point(33, 432);
            this.txt_id_valorEspecificacion.Name = "txt_id_valorEspecificacion";
            this.txt_id_valorEspecificacion.ReadOnly = true;
            this.txt_id_valorEspecificacion.Size = new System.Drawing.Size(103, 44);
            this.txt_id_valorEspecificacion.TabIndex = 109;
            // 
            // txt_id_TipoEspecificacion
            // 
            this.txt_id_TipoEspecificacion.Enabled = false;
            this.txt_id_TipoEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_TipoEspecificacion.ForeColor = System.Drawing.Color.Black;
            this.txt_id_TipoEspecificacion.Location = new System.Drawing.Point(33, 265);
            this.txt_id_TipoEspecificacion.Name = "txt_id_TipoEspecificacion";
            this.txt_id_TipoEspecificacion.ReadOnly = true;
            this.txt_id_TipoEspecificacion.Size = new System.Drawing.Size(103, 44);
            this.txt_id_TipoEspecificacion.TabIndex = 110;
            // 
            // txt_nombre_TipoEspecificacion
            // 
            this.txt_nombre_TipoEspecificacion.Enabled = false;
            this.txt_nombre_TipoEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_TipoEspecificacion.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_TipoEspecificacion.Location = new System.Drawing.Point(33, 315);
            this.txt_nombre_TipoEspecificacion.Name = "txt_nombre_TipoEspecificacion";
            this.txt_nombre_TipoEspecificacion.ReadOnly = true;
            this.txt_nombre_TipoEspecificacion.Size = new System.Drawing.Size(705, 44);
            this.txt_nombre_TipoEspecificacion.TabIndex = 113;
            // 
            // txt_valorEspecificacion
            // 
            this.txt_valorEspecificacion.Enabled = false;
            this.txt_valorEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorEspecificacion.ForeColor = System.Drawing.Color.Black;
            this.txt_valorEspecificacion.Location = new System.Drawing.Point(33, 482);
            this.txt_valorEspecificacion.Name = "txt_valorEspecificacion";
            this.txt_valorEspecificacion.ReadOnly = true;
            this.txt_valorEspecificacion.Size = new System.Drawing.Size(705, 44);
            this.txt_valorEspecificacion.TabIndex = 112;
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Enabled = false;
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre_producto.Location = new System.Drawing.Point(33, 157);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.ReadOnly = true;
            this.txt_nombre_producto.Size = new System.Drawing.Size(705, 44);
            this.txt_nombre_producto.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Impact", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 44);
            this.label3.TabIndex = 114;
            this.label3.Text = "Selecciona los campos";
            // 
            // btn_valor_especificacion
            // 
            this.btn_valor_especificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_valor_especificacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_valor_especificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valor_especificacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valor_especificacion.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_valor_especificacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_valor_especificacion.Image")));
            this.btn_valor_especificacion.Location = new System.Drawing.Point(744, 476);
            this.btn_valor_especificacion.Name = "btn_valor_especificacion";
            this.btn_valor_especificacion.Size = new System.Drawing.Size(57, 56);
            this.btn_valor_especificacion.TabIndex = 115;
            this.btn_valor_especificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_valor_especificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_valor_especificacion.UseVisualStyleBackColor = false;
            this.btn_valor_especificacion.Click += new System.EventHandler(this.btn_valor_especificacion_Click);
            // 
            // btn_tipo_especificacion
            // 
            this.btn_tipo_especificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_tipo_especificacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_tipo_especificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tipo_especificacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipo_especificacion.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_tipo_especificacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_especificacion.Image")));
            this.btn_tipo_especificacion.Location = new System.Drawing.Point(744, 309);
            this.btn_tipo_especificacion.Name = "btn_tipo_especificacion";
            this.btn_tipo_especificacion.Size = new System.Drawing.Size(57, 56);
            this.btn_tipo_especificacion.TabIndex = 116;
            this.btn_tipo_especificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tipo_especificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tipo_especificacion.UseVisualStyleBackColor = false;
            this.btn_tipo_especificacion.Click += new System.EventHandler(this.btn_tipo_especificacion_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_producto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_producto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_producto.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_producto.Image = ((System.Drawing.Image)(resources.GetObject("btn_producto.Image")));
            this.btn_producto.Location = new System.Drawing.Point(744, 151);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(57, 56);
            this.btn_producto.TabIndex = 117;
            this.btn_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_producto.UseVisualStyleBackColor = false;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // FrmAgregarEditarEspecificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(830, 672);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.btn_tipo_especificacion);
            this.Controls.Add(this.btn_valor_especificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_TipoEspecificacion);
            this.Controls.Add(this.txt_valorEspecificacion);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.txt_id_TipoEspecificacion);
            this.Controls.Add(this.txt_id_valorEspecificacion);
            this.Controls.Add(this.txt_id_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_id_especificacion);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(852, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(852, 728);
            this.Name = "FrmAgregarEditarEspecificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarEditarEspecificacion";
            this.Load += new System.EventHandler(this.FrmAgregarEditarEspecificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_id_especificacion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.TextBox txt_id_valorEspecificacion;
        private System.Windows.Forms.TextBox txt_id_TipoEspecificacion;
        private System.Windows.Forms.TextBox txt_nombre_TipoEspecificacion;
        private System.Windows.Forms.TextBox txt_valorEspecificacion;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_valor_especificacion;
        private System.Windows.Forms.Button btn_tipo_especificacion;
        private System.Windows.Forms.Button btn_producto;
    }
}