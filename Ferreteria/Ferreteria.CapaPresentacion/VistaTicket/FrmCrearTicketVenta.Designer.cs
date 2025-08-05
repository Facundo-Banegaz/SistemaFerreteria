namespace Ferreteria.CapaPresentacion.VistaTicket
{
    partial class FrmCrearTicketVenta
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
            this.Btn_crearTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_crearTicket
            // 
            this.Btn_crearTicket.Location = new System.Drawing.Point(280, 367);
            this.Btn_crearTicket.Name = "Btn_crearTicket";
            this.Btn_crearTicket.Size = new System.Drawing.Size(246, 61);
            this.Btn_crearTicket.TabIndex = 0;
            this.Btn_crearTicket.Text = "Crear Ticket";
            this.Btn_crearTicket.UseVisualStyleBackColor = true;
            this.Btn_crearTicket.Click += new System.EventHandler(this.Btn_crearTicket_Click);
            // 
            // FrmCrearTicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_crearTicket);
            this.Name = "FrmCrearTicketVenta";
            this.Text = "FrmCrearTicketVenta";
            this.Load += new System.EventHandler(this.FrmCrearTicketVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_crearTicket;
    }
}