namespace Ferreteria.CapaPresentacion.VistaReporte
{
    partial class FrmReporteFacturaVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spReportefacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new Ferreteria.CapaPresentacion.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporte_factura_VentaTableAdapter = new Ferreteria.CapaPresentacion.DsPrincipalTableAdapters.SpReporte_factura_VentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReportefacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spReportefacturaVentaBindingSource
            // 
            this.spReportefacturaVentaBindingSource.DataMember = "SpReporte_factura_Venta";
            this.spReportefacturaVentaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SpReporte_factura_Venta";
            reportDataSource1.Value = this.spReportefacturaVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferreteria.CapaPresentacion.Reportes.RptFacturaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1551, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReporte_factura_VentaTableAdapter
            // 
            this.spReporte_factura_VentaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 644);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1573, 700);
            this.Name = "FrmReporteFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta de Venta";
            this.Load += new System.EventHandler(this.FrmReporteFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReportefacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportefacturaVentaBindingSource;
        private DsPrincipal dsPrincipal;
        private DsPrincipalTableAdapters.SpReporte_factura_VentaTableAdapter spReporte_factura_VentaTableAdapter;
    }
}