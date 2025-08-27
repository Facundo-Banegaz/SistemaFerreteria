namespace Ferreteria.CapaPresentacion.VistaReporte
{
    partial class FrmReporteFacturaPresupuesto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new Ferreteria.CapaPresentacion.DsPrincipal();
            this.spReportefacturaPresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spReporte_factura_PresupuestoTableAdapter = new Ferreteria.CapaPresentacion.DsPrincipalTableAdapters.SpReporte_factura_PresupuestoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportefacturaPresupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SpReportePresupuesto";
            reportDataSource1.Value = this.spReportefacturaPresupuestoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferreteria.CapaPresentacion.Reportes.RptFacturaPresupuesto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1551, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReportefacturaPresupuestoBindingSource
            // 
            this.spReportefacturaPresupuestoBindingSource.DataMember = "SpReporte_factura_Presupuesto";
            this.spReportefacturaPresupuestoBindingSource.DataSource = this.dsPrincipal;
            // 
            // spReporte_factura_PresupuestoTableAdapter
            // 
            this.spReporte_factura_PresupuestoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFacturaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 644);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1573, 700);
            this.Name = "FrmReporteFacturaPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta de Presupuesto";
            this.Load += new System.EventHandler(this.FrmReporteFacturaPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReportefacturaPresupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReportefacturaPresupuestoBindingSource;
        private DsPrincipal dsPrincipal;
        private DsPrincipalTableAdapters.SpReporte_factura_PresupuestoTableAdapter spReporte_factura_PresupuestoTableAdapter;
    }
}