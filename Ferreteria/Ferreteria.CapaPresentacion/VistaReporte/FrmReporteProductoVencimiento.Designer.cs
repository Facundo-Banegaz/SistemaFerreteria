namespace Ferreteria.CapaPresentacion.VistaReporte
{
    partial class FrmReporteProductoVencimiento
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
            this.spProductosVencimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new Ferreteria.CapaPresentacion.DsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ProductosVencimientoTableAdapter = new Ferreteria.CapaPresentacion.DsPrincipalTableAdapters.Sp_ProductosVencimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosVencimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spProductosVencimientoBindingSource
            // 
            this.spProductosVencimientoBindingSource.DataMember = "Sp_ProductosVencimiento";
            this.spProductosVencimientoBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Sp_ProductosVencimiento";
            reportDataSource1.Value = this.spProductosVencimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferreteria.CapaPresentacion.Reportes.RptProductosConVencimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1601, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ProductosVencimientoTableAdapter
            // 
            this.sp_ProductosVencimientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteProductoVencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 750);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1573, 700);
            this.Name = "FrmReporteProductoVencimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Producto de Vencimiento";
            this.Load += new System.EventHandler(this.FrmReporteProductoVencimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spProductosVencimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spProductosVencimientoBindingSource;
        private DsPrincipal dsPrincipal;
        private DsPrincipalTableAdapters.Sp_ProductosVencimientoTableAdapter sp_ProductosVencimientoTableAdapter;
    }
}