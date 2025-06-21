namespace Ferreteria.CapaPresentacion.VistaEspecificacion.VistaValorEspecificacion
{
    partial class FrmAgregarEditarValorEspecificacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEditarValorEspecificacion));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_IdvalorEspecificacion = new System.Windows.Forms.Label();
            this.txt_nombre_ValorEspecificacion = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
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
            this.btn_cancelar.Location = new System.Drawing.Point(417, 437);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 66);
            this.btn_cancelar.TabIndex = 107;
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
            this.btn_Agregar.Location = new System.Drawing.Point(134, 437);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(180, 66);
            this.btn_Agregar.TabIndex = 106;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_IdvalorEspecificacion
            // 
            this.lbl_IdvalorEspecificacion.AutoSize = true;
            this.lbl_IdvalorEspecificacion.BackColor = System.Drawing.Color.Black;
            this.lbl_IdvalorEspecificacion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdvalorEspecificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_IdvalorEspecificacion.Location = new System.Drawing.Point(128, 86);
            this.lbl_IdvalorEspecificacion.Name = "lbl_IdvalorEspecificacion";
            this.lbl_IdvalorEspecificacion.Size = new System.Drawing.Size(0, 35);
            this.lbl_IdvalorEspecificacion.TabIndex = 105;
            // 
            // txt_nombre_ValorEspecificacion
            // 
            this.txt_nombre_ValorEspecificacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nombre_ValorEspecificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_ValorEspecificacion.Location = new System.Drawing.Point(75, 268);
            this.txt_nombre_ValorEspecificacion.Name = "txt_nombre_ValorEspecificacion";
            this.txt_nombre_ValorEspecificacion.Size = new System.Drawing.Size(578, 35);
            this.txt_nombre_ValorEspecificacion.TabIndex = 104;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Black;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombre.Location = new System.Drawing.Point(141, 184);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(388, 35);
            this.lbl_nombre.TabIndex = 103;
            this.lbl_nombre.Text = "Nombre del valor Especificacion:";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.BackColor = System.Drawing.Color.Black;
            this.lbl_costo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_costo.Location = new System.Drawing.Point(36, 16);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(317, 35);
            this.lbl_costo.TabIndex = 102;
            this.lbl_costo.Text = "Id Del ValorEspecificacion:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmAgregarEditarValorEspecificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 518);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_IdvalorEspecificacion);
            this.Controls.Add(this.txt_nombre_ValorEspecificacion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_costo);
            this.Name = "FrmAgregarEditarValorEspecificacion";
            this.Text = "FrmAgregarEditarValorEspecificacion";
            this.Load += new System.EventHandler(this.FrmAgregarEditarValorEspecificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_IdvalorEspecificacion;
        private System.Windows.Forms.TextBox txt_nombre_ValorEspecificacion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}