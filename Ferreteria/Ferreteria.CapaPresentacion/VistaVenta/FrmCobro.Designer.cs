namespace Ferreteria.CapaPresentacion.VistaVenta
{
    partial class FrmCobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_paga_con = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_monto_final = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vuelto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 101);
            this.panel1.TabIndex = 0;
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
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(596, 722);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(281, 66);
            this.btn_cancelar.TabIndex = 182;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.Location = new System.Drawing.Point(30, 722);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(281, 66);
            this.btn_guardar.TabIndex = 181;
            this.btn_guardar.Text = "Cobrar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paga con:";
            // 
            // txt_paga_con
            // 
            this.txt_paga_con.BackColor = System.Drawing.Color.Beige;
            this.txt_paga_con.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_paga_con.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_paga_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paga_con.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_paga_con.Location = new System.Drawing.Point(30, 90);
            this.txt_paga_con.Name = "txt_paga_con";
            this.txt_paga_con.Size = new System.Drawing.Size(847, 53);
            this.txt_paga_con.TabIndex = 2;
            this.txt_paga_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_paga_con.TextChanged += new System.EventHandler(this.txt_paga_con_TextChanged);
            this.txt_paga_con.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paga_con_KeyPress);
            this.txt_paga_con.Leave += new System.EventHandler(this.txt_paga_con_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total a Cobrar:";
            // 
            // txt_monto_final
            // 
            this.txt_monto_final.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_monto_final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto_final.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_monto_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_final.ForeColor = System.Drawing.Color.Ivory;
            this.txt_monto_final.Location = new System.Drawing.Point(30, 118);
            this.txt_monto_final.Name = "txt_monto_final";
            this.txt_monto_final.ReadOnly = true;
            this.txt_monto_final.Size = new System.Drawing.Size(847, 57);
            this.txt_monto_final.TabIndex = 1;
            this.txt_monto_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 148);
            this.groupBox2.TabIndex = 185;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_monto_final);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(0, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 227);
            this.groupBox1.TabIndex = 184;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_paga_con);
            this.groupBox3.Location = new System.Drawing.Point(0, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 194);
            this.groupBox3.TabIndex = 185;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_vuelto);
            this.groupBox4.Location = new System.Drawing.Point(0, 501);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 178);
            this.groupBox4.TabIndex = 186;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(373, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vuelto:";
            // 
            // txt_vuelto
            // 
            this.txt_vuelto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_vuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vuelto.ForeColor = System.Drawing.Color.Blue;
            this.txt_vuelto.Location = new System.Drawing.Point(30, 100);
            this.txt_vuelto.Name = "txt_vuelto";
            this.txt_vuelto.ReadOnly = true;
            this.txt_vuelto.Size = new System.Drawing.Size(847, 53);
            this.txt_vuelto.TabIndex = 2;
            this.txt_vuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar Venta";
            this.Load += new System.EventHandler(this.FrmCobro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_paga_con;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_monto_final;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vuelto;
    }
}