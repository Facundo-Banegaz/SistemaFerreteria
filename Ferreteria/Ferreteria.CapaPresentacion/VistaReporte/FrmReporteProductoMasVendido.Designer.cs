namespace Ferreteria.CapaPresentacion.VistaReporte
{
    partial class FrmReporteProductoMasVendido
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new Ferreteria.CapaPresentacion.DsPrincipal();
            this.spProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ProductosMasVendidosTableAdapter = new Ferreteria.CapaPresentacion.DsPrincipalTableAdapters.Sp_ProductosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ProductosMasVendidos";
            reportDataSource2.Value = this.spProductosMasVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferreteria.CapaPresentacion.Reportes.RptProductosMasVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1601, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "DsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spProductosMasVendidosBindingSource
            // 
            this.spProductosMasVendidosBindingSource.DataMember = "Sp_ProductosMasVendidos";
            this.spProductosMasVendidosBindingSource.DataSource = this.dsPrincipal;
            // 
            // sp_ProductosMasVendidosTableAdapter
            // 
            this.sp_ProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteProductoMasVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 750);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1623, 806);
            this.Name = "FrmReporteProductoMasVendido";
            this.Text = "Reporte Producto Mas Vendidos";
            this.Load += new System.EventHandler(this.FrmReporteProductoMasVendido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spProductosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spProductosMasVendidosBindingSource;
        private DsPrincipal dsPrincipal;
        private DsPrincipalTableAdapters.Sp_ProductosMasVendidosTableAdapter sp_ProductosMasVendidosTableAdapter;
    }
}