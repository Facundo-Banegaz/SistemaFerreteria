namespace Ferreteria.CapaPresentacion.VistaMDIPrincipal
{
    partial class FrmMdiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMdiPrincipal));
            this.Menu_principal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_historial_vendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasAProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeIngresosPorDíamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeCadaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_analisis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_historial = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_items_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_subcategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_UnidadMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_especificación = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.Menu_secundario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu_principal.SuspendLayout();
            this.Menu_secundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu_principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_principal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_principal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem16,
            this.toolStripMenuItem19,
            this.Menu_gestion_compras,
            this.menu_reportes,
            this.Menu_analisis,
            this.Menu_item_salir,
            this.Menu_administracion});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_principal.Size = new System.Drawing.Size(1719, 84);
            this.Menu_principal.TabIndex = 10;
            this.Menu_principal.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_venta,
            this.Menu_item_historial_vendedor});
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 64);
            this.toolStripMenuItem2.Text = "  Gestion De Ventas";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_item_venta
            // 
            this.Menu_item_venta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_venta.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_venta.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_venta.Image")));
            this.Menu_item_venta.Name = "Menu_item_venta";
            this.Menu_item_venta.Size = new System.Drawing.Size(280, 42);
            this.Menu_item_venta.Text = "Nueva Venta ";
            this.Menu_item_venta.Click += new System.EventHandler(this.Menu_item_venta_Click);
            // 
            // Menu_item_historial_vendedor
            // 
            this.Menu_item_historial_vendedor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_historial_vendedor.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_historial_vendedor.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_historial_vendedor.Image")));
            this.Menu_item_historial_vendedor.Name = "Menu_item_historial_vendedor";
            this.Menu_item_historial_vendedor.Size = new System.Drawing.Size(280, 42);
            this.Menu_item_historial_vendedor.Text = "Historial Ventas";
            this.Menu_item_historial_vendedor.Click += new System.EventHandler(this.Menu_item_historial_vendedor_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.BackColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem16.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem18});
            this.toolStripMenuItem16.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem16.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem16.Image")));
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(162, 64);
            this.toolStripMenuItem16.Text = "Presupuestos";
            this.toolStripMenuItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem17.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem17.Image")));
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(331, 42);
            this.toolStripMenuItem17.Text = "Generar Presupuesto";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem18.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem18.Image")));
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(331, 42);
            this.toolStripMenuItem18.Text = "Ver Presupuestos";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.BackColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem19.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23});
            this.toolStripMenuItem19.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem19.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem19.Image")));
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(125, 64);
            this.toolStripMenuItem19.Text = "Consultas";
            this.toolStripMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem20.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem20.Image")));
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(370, 42);
            this.toolStripMenuItem20.Text = "Consultar  Productos";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem21.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem21.Image")));
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(370, 42);
            this.toolStripMenuItem21.Text = "Ventas Del Dia";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem22.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem22.Image")));
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(370, 42);
            this.toolStripMenuItem22.Text = "Ventas Del Mes";
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem23.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem23.Image")));
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(370, 42);
            this.toolStripMenuItem23.Text = "Productos Más Vendidos";
            // 
            // Menu_gestion_compras
            // 
            this.Menu_gestion_compras.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_ingresos,
            this.Menu_item_proveedores});
            this.Menu_gestion_compras.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_compras.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_compras.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_compras.Image")));
            this.Menu_gestion_compras.Name = "Menu_gestion_compras";
            this.Menu_gestion_compras.Size = new System.Drawing.Size(230, 64);
            this.Menu_gestion_compras.Text = "Gestion De Compras";
            this.Menu_gestion_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_item_ingresos
            // 
            this.Menu_item_ingresos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ingresos.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ingresos.Image")));
            this.Menu_item_ingresos.Name = "Menu_item_ingresos";
            this.Menu_item_ingresos.Size = new System.Drawing.Size(245, 36);
            this.Menu_item_ingresos.Text = "Ingresos";
            this.Menu_item_ingresos.Click += new System.EventHandler(this.Menu_item_ingresos_Click_1);
            // 
            // Menu_item_proveedores
            // 
            this.Menu_item_proveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_proveedores.Checked = true;
            this.Menu_item_proveedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_item_proveedores.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_proveedores.Image")));
            this.Menu_item_proveedores.Name = "Menu_item_proveedores";
            this.Menu_item_proveedores.Size = new System.Drawing.Size(245, 36);
            this.Menu_item_proveedores.Text = " Proveedores";
            this.Menu_item_proveedores.Click += new System.EventHandler(this.Menu_item_proveedores_Click);
            // 
            // menu_reportes
            // 
            this.menu_reportes.BackColor = System.Drawing.Color.Black;
            this.menu_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasDelDiaToolStripMenuItem,
            this.ventasDelMesToolStripMenuItem,
            this.ventasPorFechasToolStripMenuItem,
            this.ventasPorVendedorToolStripMenuItem,
            this.comprasAProveedoresToolStripMenuItem,
            this.totalDeIngresosPorDíamesToolStripMenuItem,
            this.detallesDeCadaVentaToolStripMenuItem});
            this.menu_reportes.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_reportes.ForeColor = System.Drawing.Color.Orange;
            this.menu_reportes.Image = ((System.Drawing.Image)(resources.GetObject("menu_reportes.Image")));
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(117, 64);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ventasDelDiaToolStripMenuItem
            // 
            this.ventasDelDiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasDelDiaToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasDelDiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasDelDiaToolStripMenuItem.Image")));
            this.ventasDelDiaToolStripMenuItem.Name = "ventasDelDiaToolStripMenuItem";
            this.ventasDelDiaToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.ventasDelDiaToolStripMenuItem.Text = "Ventas Del Dia";
            // 
            // ventasDelMesToolStripMenuItem
            // 
            this.ventasDelMesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasDelMesToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasDelMesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasDelMesToolStripMenuItem.Image")));
            this.ventasDelMesToolStripMenuItem.Name = "ventasDelMesToolStripMenuItem";
            this.ventasDelMesToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.ventasDelMesToolStripMenuItem.Text = "Ventas Del Mes";
            // 
            // ventasPorFechasToolStripMenuItem
            // 
            this.ventasPorFechasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasPorFechasToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasPorFechasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasPorFechasToolStripMenuItem.Image")));
            this.ventasPorFechasToolStripMenuItem.Name = "ventasPorFechasToolStripMenuItem";
            this.ventasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.ventasPorFechasToolStripMenuItem.Text = "Ventas Por Fechas";
            // 
            // ventasPorVendedorToolStripMenuItem
            // 
            this.ventasPorVendedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasPorVendedorToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasPorVendedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasPorVendedorToolStripMenuItem.Image")));
            this.ventasPorVendedorToolStripMenuItem.Name = "ventasPorVendedorToolStripMenuItem";
            this.ventasPorVendedorToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.ventasPorVendedorToolStripMenuItem.Text = "Ventas Por Vendedor";
            // 
            // comprasAProveedoresToolStripMenuItem
            // 
            this.comprasAProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comprasAProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.comprasAProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasAProveedoresToolStripMenuItem.Image")));
            this.comprasAProveedoresToolStripMenuItem.Name = "comprasAProveedoresToolStripMenuItem";
            this.comprasAProveedoresToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.comprasAProveedoresToolStripMenuItem.Text = "Compras a Proveedores";
            // 
            // totalDeIngresosPorDíamesToolStripMenuItem
            // 
            this.totalDeIngresosPorDíamesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.totalDeIngresosPorDíamesToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.totalDeIngresosPorDíamesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalDeIngresosPorDíamesToolStripMenuItem.Image")));
            this.totalDeIngresosPorDíamesToolStripMenuItem.Name = "totalDeIngresosPorDíamesToolStripMenuItem";
            this.totalDeIngresosPorDíamesToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.totalDeIngresosPorDíamesToolStripMenuItem.Text = "Total de ingresos por día/mes";
            // 
            // detallesDeCadaVentaToolStripMenuItem
            // 
            this.detallesDeCadaVentaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.detallesDeCadaVentaToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.detallesDeCadaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detallesDeCadaVentaToolStripMenuItem.Image")));
            this.detallesDeCadaVentaToolStripMenuItem.Name = "detallesDeCadaVentaToolStripMenuItem";
            this.detallesDeCadaVentaToolStripMenuItem.Size = new System.Drawing.Size(413, 36);
            this.detallesDeCadaVentaToolStripMenuItem.Text = "Detalles de cada Venta";
            // 
            // Menu_analisis
            // 
            this.Menu_analisis.BackColor = System.Drawing.Color.Black;
            this.Menu_analisis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem15,
            this.toolStripMenuItem13,
            this.toolStripMenuItem11,
            this.toolStripMenuItem10,
            this.toolStripMenuItem1,
            this.toolStripMenuItem14,
            this.menu_item_historial});
            this.Menu_analisis.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_analisis.ForeColor = System.Drawing.Color.Orange;
            this.Menu_analisis.Image = ((System.Drawing.Image)(resources.GetObject("Menu_analisis.Image")));
            this.Menu_analisis.Name = "Menu_analisis";
            this.Menu_analisis.Size = new System.Drawing.Size(105, 64);
            this.Menu_analisis.Text = "Analisis";
            this.Menu_analisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem9.Text = "Productos más Vendidos";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem15.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem15.Image")));
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem15.Text = "Categoria/Subcategoria más vendidas";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem13.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem13.Image")));
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem13.Text = "Marcas más vendidas";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem11.Text = "Productos con Bajo Stock";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem10.Text = "Comparación de ventas entre mes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem1.Text = "Tendencia por día, semanas o mes";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem14.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem14.Image")));
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(529, 36);
            this.toolStripMenuItem14.Text = "Productos que no se venden hace tiempo ";
            // 
            // menu_item_historial
            // 
            this.menu_item_historial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_historial.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_historial.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_historial.Image")));
            this.menu_item_historial.Name = "menu_item_historial";
            this.menu_item_historial.Size = new System.Drawing.Size(529, 36);
            this.menu_item_historial.Text = "Productos sin Stock con alta demanda ";
            // 
            // Menu_item_salir
            // 
            this.Menu_item_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Menu_item_salir.BackColor = System.Drawing.Color.Crimson;
            this.Menu_item_salir.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_item_salir.ForeColor = System.Drawing.Color.AliceBlue;
            this.Menu_item_salir.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_salir.Image")));
            this.Menu_item_salir.Name = "Menu_item_salir";
            this.Menu_item_salir.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Menu_item_salir.Size = new System.Drawing.Size(330, 64);
            this.Menu_item_salir.Text = "Salir del Sistema de Ventas";
            this.Menu_item_salir.Click += new System.EventHandler(this.Menu_item_salir_Click);
            // 
            // Menu_administracion
            // 
            this.Menu_administracion.BackColor = System.Drawing.Color.Black;
            this.Menu_administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_productos,
            this.menu_items_categorias,
            this.menu_item_subcategorias,
            this.toolStripMenuItem12,
            this.Menu_item_UnidadMedida,
            this.menu_item_especificación,
            this.Menu_item_usuarios});
            this.Menu_administracion.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_administracion.ForeColor = System.Drawing.Color.Orange;
            this.Menu_administracion.Image = ((System.Drawing.Image)(resources.GetObject("Menu_administracion.Image")));
            this.Menu_administracion.Name = "Menu_administracion";
            this.Menu_administracion.Size = new System.Drawing.Size(180, 64);
            this.Menu_administracion.Text = "Mantenimiento";
            this.Menu_administracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_item_productos
            // 
            this.menu_item_productos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_productos.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_productos.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_productos.Image")));
            this.menu_item_productos.Name = "menu_item_productos";
            this.menu_item_productos.Size = new System.Drawing.Size(295, 36);
            this.menu_item_productos.Text = "Productos";
            this.menu_item_productos.Click += new System.EventHandler(this.menu_item_productos_Click);
            // 
            // menu_items_categorias
            // 
            this.menu_items_categorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_items_categorias.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_items_categorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_items_categorias.Image")));
            this.menu_items_categorias.Name = "menu_items_categorias";
            this.menu_items_categorias.Size = new System.Drawing.Size(295, 36);
            this.menu_items_categorias.Text = "Categorias";
            this.menu_items_categorias.Click += new System.EventHandler(this.menu_items_categorias_Click);
            // 
            // menu_item_subcategorias
            // 
            this.menu_item_subcategorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_subcategorias.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_subcategorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_subcategorias.Image")));
            this.menu_item_subcategorias.Name = "menu_item_subcategorias";
            this.menu_item_subcategorias.Size = new System.Drawing.Size(295, 36);
            this.menu_item_subcategorias.Text = "Subcategorias";
            this.menu_item_subcategorias.Click += new System.EventHandler(this.menu_item_subcategorias_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem12.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(295, 36);
            this.toolStripMenuItem12.Text = "Marcas";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.menu_item_marcas_Click);
            // 
            // Menu_item_UnidadMedida
            // 
            this.Menu_item_UnidadMedida.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_UnidadMedida.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_UnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_UnidadMedida.Image")));
            this.Menu_item_UnidadMedida.Name = "Menu_item_UnidadMedida";
            this.Menu_item_UnidadMedida.Size = new System.Drawing.Size(295, 36);
            this.Menu_item_UnidadMedida.Text = "Unidad de Medida";
            this.Menu_item_UnidadMedida.Click += new System.EventHandler(this.Menu_item_UnidadMedida_Click);
            // 
            // menu_item_especificación
            // 
            this.menu_item_especificación.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_especificación.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_especificación.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_especificación.Image")));
            this.menu_item_especificación.Name = "menu_item_especificación";
            this.menu_item_especificación.Size = new System.Drawing.Size(295, 36);
            this.menu_item_especificación.Text = "Especificación";
            this.menu_item_especificación.Click += new System.EventHandler(this.menu_item_especificación_Click);
            // 
            // Menu_item_usuarios
            // 
            this.Menu_item_usuarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_usuarios.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_usuarios.Image")));
            this.Menu_item_usuarios.Name = "Menu_item_usuarios";
            this.Menu_item_usuarios.Size = new System.Drawing.Size(295, 36);
            this.Menu_item_usuarios.Text = "Usuarios";
            this.Menu_item_usuarios.Click += new System.EventHandler(this.Menu_item_usuarios_Click_1);
            // 
            // tn_tiempo
            // 
            this.tn_tiempo.Enabled = true;
            this.tn_tiempo.Tick += new System.EventHandler(this.tn_tiempo_Tick);
            // 
            // Menu_secundario
            // 
            this.Menu_secundario.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_secundario.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_secundario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_hora,
            this.toolStripStatusLabel2,
            this.lbl_fecha,
            this.toolStripStatusLabel3,
            this.lbl_usuario});
            this.Menu_secundario.Location = new System.Drawing.Point(0, 634);
            this.Menu_secundario.Name = "Menu_secundario";
            this.Menu_secundario.Size = new System.Drawing.Size(1719, 36);
            this.Menu_secundario.TabIndex = 11;
            this.Menu_secundario.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 29);
            this.toolStripStatusLabel1.Text = "Hora:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 29);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(77, 29);
            this.toolStripStatusLabel2.Text = "Fecha:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 29);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 29);
            this.toolStripStatusLabel3.Text = "Usuario:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(0, 29);
            // 
            // FrmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 670);
            this.Controls.Add(this.Menu_secundario);
            this.Controls.Add(this.Menu_principal);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IsMdiContainer = true;
            this.Name = "FrmMdiPrincipal";
            this.Text = "Sistema Ferreteria Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            this.Menu_secundario.ResumeLayout(false);
            this.Menu_secundario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_administracion;
        private System.Windows.Forms.ToolStripMenuItem menu_item_productos;
        private System.Windows.Forms.ToolStripMenuItem menu_item_subcategorias;
        private System.Windows.Forms.ToolStripMenuItem menu_item_especificación;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_proveedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_analisis;
        private System.Windows.Forms.ToolStripMenuItem menu_item_historial;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_salir;
        private System.Windows.Forms.Timer tn_tiempo;
        private System.Windows.Forms.StatusStrip Menu_secundario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_fecha;
        private System.Windows.Forms.ToolStripMenuItem menu_items_categorias;
        private System.Windows.Forms.ToolStripMenuItem menu_reportes;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_UnidadMedida;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem ventasDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasAProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem totalDeIngresosPorDíamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeCadaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_venta;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_historial_vendedor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ingresos;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_usuarios;
    }
}