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
            this.Menu_gestion_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_presupuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_presupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_Ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDelMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasAProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeIngresosPorDíamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDeCadaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_analisis = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_analis_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_analisis_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_items_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_subcategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_UnidadMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_especificación = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Item_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.Menu_secundario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu_gestion_movimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Item_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Item_Ajustes_Movimientos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Menu_gestion_ventas,
            this.Menu_gestion_presupuestos,
            this.Menu_gestion_consultas,
            this.Menu_gestion_compras,
            this.Menu_gestion_reportes,
            this.Menu_gestion_analisis,
            this.Menu_item_salir,
            this.Menu_gestion_mantenimientos,
            this.Menu_gestion_movimientos,
            this.Menu_gestion_Configuracion});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_principal.Size = new System.Drawing.Size(1924, 84);
            this.Menu_principal.TabIndex = 10;
            this.Menu_principal.Text = "Menu";
            // 
            // Menu_gestion_ventas
            // 
            this.Menu_gestion_ventas.BackColor = System.Drawing.Color.SeaShell;
            this.Menu_gestion_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_venta});
            this.Menu_gestion_ventas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_ventas.Image")));
            this.Menu_gestion_ventas.Name = "Menu_gestion_ventas";
            this.Menu_gestion_ventas.Size = new System.Drawing.Size(221, 64);
            this.Menu_gestion_ventas.Text = "  Gestion De Ventas";
            this.Menu_gestion_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_item_venta
            // 
            this.Menu_item_venta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_venta.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_venta.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_venta.Image")));
            this.Menu_item_venta.Name = "Menu_item_venta";
            this.Menu_item_venta.Size = new System.Drawing.Size(181, 36);
            this.Menu_item_venta.Text = "Ventas";
            this.Menu_item_venta.Click += new System.EventHandler(this.Menu_item_venta_Click);
            // 
            // Menu_gestion_presupuestos
            // 
            this.Menu_gestion_presupuestos.BackColor = System.Drawing.Color.SeaShell;
            this.Menu_gestion_presupuestos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_presupuesto});
            this.Menu_gestion_presupuestos.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_presupuestos.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_presupuestos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_presupuestos.Image")));
            this.Menu_gestion_presupuestos.Name = "Menu_gestion_presupuestos";
            this.Menu_gestion_presupuestos.Size = new System.Drawing.Size(162, 64);
            this.Menu_gestion_presupuestos.Text = "Presupuestos";
            this.Menu_gestion_presupuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_gestion_presupuestos.Click += new System.EventHandler(this.toolStripMenuItem16_Click);
            // 
            // Menu_item_presupuesto
            // 
            this.Menu_item_presupuesto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_presupuesto.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_presupuesto.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_presupuesto.Image")));
            this.Menu_item_presupuesto.Name = "Menu_item_presupuesto";
            this.Menu_item_presupuesto.Size = new System.Drawing.Size(248, 36);
            this.Menu_item_presupuesto.Text = "Presupuestos";
            this.Menu_item_presupuesto.Click += new System.EventHandler(this.Menu_item_presupuesto_Click);
            // 
            // Menu_gestion_consultas
            // 
            this.Menu_gestion_consultas.BackColor = System.Drawing.Color.SeaShell;
            this.Menu_gestion_consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23});
            this.Menu_gestion_consultas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_consultas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_consultas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_consultas.Image")));
            this.Menu_gestion_consultas.Name = "Menu_gestion_consultas";
            this.Menu_gestion_consultas.Size = new System.Drawing.Size(125, 64);
            this.Menu_gestion_consultas.Text = "Consultas";
            this.Menu_gestion_consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_gestion_consultas.Click += new System.EventHandler(this.Menu_gestion_consultas_Click);
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
            this.Menu_item_Ingresos});
            this.Menu_gestion_compras.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_compras.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_compras.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_compras.Image")));
            this.Menu_gestion_compras.Name = "Menu_gestion_compras";
            this.Menu_gestion_compras.Size = new System.Drawing.Size(230, 64);
            this.Menu_gestion_compras.Text = "Gestion De Compras";
            this.Menu_gestion_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_item_Ingresos
            // 
            this.Menu_item_Ingresos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_Ingresos.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_Ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_Ingresos.Image")));
            this.Menu_item_Ingresos.Name = "Menu_item_Ingresos";
            this.Menu_item_Ingresos.Size = new System.Drawing.Size(278, 42);
            this.Menu_item_Ingresos.Text = "Ingresos";
            this.Menu_item_Ingresos.Click += new System.EventHandler(this.Menu_item_Ingresos_Click_1);
            // 
            // Menu_gestion_reportes
            // 
            this.Menu_gestion_reportes.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasDelDiaToolStripMenuItem,
            this.ventasDelMesToolStripMenuItem,
            this.ventasPorFechasToolStripMenuItem,
            this.ventasPorVendedorToolStripMenuItem,
            this.comprasAProveedoresToolStripMenuItem,
            this.totalDeIngresosPorDíamesToolStripMenuItem,
            this.detallesDeCadaVentaToolStripMenuItem});
            this.Menu_gestion_reportes.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_reportes.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_reportes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_reportes.Image")));
            this.Menu_gestion_reportes.Name = "Menu_gestion_reportes";
            this.Menu_gestion_reportes.Size = new System.Drawing.Size(117, 64);
            this.Menu_gestion_reportes.Text = "Reportes";
            this.Menu_gestion_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ventasDelDiaToolStripMenuItem
            // 
            this.ventasDelDiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasDelDiaToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasDelDiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasDelDiaToolStripMenuItem.Image")));
            this.ventasDelDiaToolStripMenuItem.Name = "ventasDelDiaToolStripMenuItem";
            this.ventasDelDiaToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.ventasDelDiaToolStripMenuItem.Text = "Ventas Del Dia";
            // 
            // ventasDelMesToolStripMenuItem
            // 
            this.ventasDelMesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasDelMesToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasDelMesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasDelMesToolStripMenuItem.Image")));
            this.ventasDelMesToolStripMenuItem.Name = "ventasDelMesToolStripMenuItem";
            this.ventasDelMesToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.ventasDelMesToolStripMenuItem.Text = "Ventas Del Mes";
            // 
            // ventasPorFechasToolStripMenuItem
            // 
            this.ventasPorFechasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasPorFechasToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasPorFechasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasPorFechasToolStripMenuItem.Image")));
            this.ventasPorFechasToolStripMenuItem.Name = "ventasPorFechasToolStripMenuItem";
            this.ventasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.ventasPorFechasToolStripMenuItem.Text = "Ventas Por Fechas";
            // 
            // ventasPorVendedorToolStripMenuItem
            // 
            this.ventasPorVendedorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ventasPorVendedorToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.ventasPorVendedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasPorVendedorToolStripMenuItem.Image")));
            this.ventasPorVendedorToolStripMenuItem.Name = "ventasPorVendedorToolStripMenuItem";
            this.ventasPorVendedorToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.ventasPorVendedorToolStripMenuItem.Text = "Ventas Por Vendedor";
            // 
            // comprasAProveedoresToolStripMenuItem
            // 
            this.comprasAProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comprasAProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.comprasAProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasAProveedoresToolStripMenuItem.Image")));
            this.comprasAProveedoresToolStripMenuItem.Name = "comprasAProveedoresToolStripMenuItem";
            this.comprasAProveedoresToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.comprasAProveedoresToolStripMenuItem.Text = "Compras a Proveedores";
            // 
            // totalDeIngresosPorDíamesToolStripMenuItem
            // 
            this.totalDeIngresosPorDíamesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.totalDeIngresosPorDíamesToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.totalDeIngresosPorDíamesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("totalDeIngresosPorDíamesToolStripMenuItem.Image")));
            this.totalDeIngresosPorDíamesToolStripMenuItem.Name = "totalDeIngresosPorDíamesToolStripMenuItem";
            this.totalDeIngresosPorDíamesToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.totalDeIngresosPorDíamesToolStripMenuItem.Text = "Total de ingresos por día/mes";
            // 
            // detallesDeCadaVentaToolStripMenuItem
            // 
            this.detallesDeCadaVentaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.detallesDeCadaVentaToolStripMenuItem.ForeColor = System.Drawing.Color.SeaShell;
            this.detallesDeCadaVentaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detallesDeCadaVentaToolStripMenuItem.Image")));
            this.detallesDeCadaVentaToolStripMenuItem.Name = "detallesDeCadaVentaToolStripMenuItem";
            this.detallesDeCadaVentaToolStripMenuItem.Size = new System.Drawing.Size(421, 42);
            this.detallesDeCadaVentaToolStripMenuItem.Text = "Detalles de cada Venta";
            // 
            // Menu_gestion_analisis
            // 
            this.Menu_gestion_analisis.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_analisis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_analis_venta,
            this.Menu_item_analisis_stock});
            this.Menu_gestion_analisis.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_analisis.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_analisis.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_analisis.Image")));
            this.Menu_gestion_analisis.Name = "Menu_gestion_analisis";
            this.Menu_gestion_analisis.Size = new System.Drawing.Size(105, 64);
            this.Menu_gestion_analisis.Text = "Analisis";
            this.Menu_gestion_analisis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_item_analis_venta
            // 
            this.Menu_item_analis_venta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_analis_venta.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_analis_venta.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_analis_venta.Image")));
            this.Menu_item_analis_venta.Name = "Menu_item_analis_venta";
            this.Menu_item_analis_venta.Size = new System.Drawing.Size(300, 42);
            this.Menu_item_analis_venta.Text = "Análisis de ventas";
            // 
            // Menu_item_analisis_stock
            // 
            this.Menu_item_analisis_stock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_analisis_stock.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_analisis_stock.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_analisis_stock.Image")));
            this.Menu_item_analisis_stock.Name = "Menu_item_analisis_stock";
            this.Menu_item_analisis_stock.Size = new System.Drawing.Size(300, 42);
            this.Menu_item_analisis_stock.Text = "Análisis de stock";
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
            // Menu_gestion_mantenimientos
            // 
            this.Menu_gestion_mantenimientos.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_productos,
            this.menu_items_categorias,
            this.menu_item_subcategorias,
            this.toolStripMenuItem12,
            this.Menu_item_UnidadMedida,
            this.Menu_item_proveedores,
            this.menu_item_especificación,
            this.Menu_item_usuarios});
            this.Menu_gestion_mantenimientos.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_mantenimientos.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_mantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_mantenimientos.Image")));
            this.Menu_gestion_mantenimientos.Name = "Menu_gestion_mantenimientos";
            this.Menu_gestion_mantenimientos.Size = new System.Drawing.Size(180, 64);
            this.Menu_gestion_mantenimientos.Text = "Mantenimiento";
            this.Menu_gestion_mantenimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_item_productos
            // 
            this.menu_item_productos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_productos.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_productos.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_productos.Image")));
            this.menu_item_productos.Name = "menu_item_productos";
            this.menu_item_productos.Size = new System.Drawing.Size(303, 42);
            this.menu_item_productos.Text = "Productos";
            this.menu_item_productos.Click += new System.EventHandler(this.menu_item_productos_Click);
            // 
            // menu_items_categorias
            // 
            this.menu_items_categorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_items_categorias.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_items_categorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_items_categorias.Image")));
            this.menu_items_categorias.Name = "menu_items_categorias";
            this.menu_items_categorias.Size = new System.Drawing.Size(303, 42);
            this.menu_items_categorias.Text = "Categorias";
            this.menu_items_categorias.Click += new System.EventHandler(this.menu_items_categorias_Click);
            // 
            // menu_item_subcategorias
            // 
            this.menu_item_subcategorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_subcategorias.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_subcategorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_subcategorias.Image")));
            this.menu_item_subcategorias.Name = "menu_item_subcategorias";
            this.menu_item_subcategorias.Size = new System.Drawing.Size(303, 42);
            this.menu_item_subcategorias.Text = "Subcategorias";
            this.menu_item_subcategorias.Click += new System.EventHandler(this.menu_item_subcategorias_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem12.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(303, 42);
            this.toolStripMenuItem12.Text = "Marcas";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.menu_item_marcas_Click);
            // 
            // Menu_item_UnidadMedida
            // 
            this.Menu_item_UnidadMedida.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_UnidadMedida.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_UnidadMedida.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_UnidadMedida.Image")));
            this.Menu_item_UnidadMedida.Name = "Menu_item_UnidadMedida";
            this.Menu_item_UnidadMedida.Size = new System.Drawing.Size(303, 42);
            this.Menu_item_UnidadMedida.Text = "Unidad de Medida";
            this.Menu_item_UnidadMedida.Click += new System.EventHandler(this.Menu_item_UnidadMedida_Click);
            // 
            // Menu_item_proveedores
            // 
            this.Menu_item_proveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_proveedores.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_proveedores.Image")));
            this.Menu_item_proveedores.Name = "Menu_item_proveedores";
            this.Menu_item_proveedores.Size = new System.Drawing.Size(303, 42);
            this.Menu_item_proveedores.Text = "Proveedores";
            this.Menu_item_proveedores.Click += new System.EventHandler(this.Menu_item_proveedores_Click_1);
            // 
            // menu_item_especificación
            // 
            this.menu_item_especificación.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_especificación.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_especificación.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_especificación.Image")));
            this.menu_item_especificación.Name = "menu_item_especificación";
            this.menu_item_especificación.Size = new System.Drawing.Size(303, 42);
            this.menu_item_especificación.Text = "Especificación";
            this.menu_item_especificación.Click += new System.EventHandler(this.menu_item_especificación_Click);
            // 
            // Menu_item_usuarios
            // 
            this.Menu_item_usuarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_usuarios.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_usuarios.Image")));
            this.Menu_item_usuarios.Name = "Menu_item_usuarios";
            this.Menu_item_usuarios.Size = new System.Drawing.Size(303, 42);
            this.Menu_item_usuarios.Text = "Usuarios";
            this.Menu_item_usuarios.Click += new System.EventHandler(this.Menu_item_usuarios_Click);
            // 
            // Menu_gestion_Configuracion
            // 
            this.Menu_gestion_Configuracion.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_Configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Item_Ticket,
            this.toolStripMenuItem3});
            this.Menu_gestion_Configuracion.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_Configuracion.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_Configuracion.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_Configuracion.Image")));
            this.Menu_gestion_Configuracion.Name = "Menu_gestion_Configuracion";
            this.Menu_gestion_Configuracion.Size = new System.Drawing.Size(95, 64);
            this.Menu_gestion_Configuracion.Text = "Config";
            this.Menu_gestion_Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_Item_Ticket
            // 
            this.Menu_Item_Ticket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_Item_Ticket.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_Item_Ticket.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Item_Ticket.Image")));
            this.Menu_Item_Ticket.Name = "Menu_Item_Ticket";
            this.Menu_Item_Ticket.Size = new System.Drawing.Size(330, 42);
            this.Menu_Item_Ticket.Text = "Configuración Ticket";
            this.Menu_Item_Ticket.Click += new System.EventHandler(this.Menu_Item_Ticket_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(330, 42);
            this.toolStripMenuItem3.Text = "Análisis de stock";
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
            this.Menu_secundario.Location = new System.Drawing.Point(0, 655);
            this.Menu_secundario.Name = "Menu_secundario";
            this.Menu_secundario.Size = new System.Drawing.Size(1924, 36);
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
            // Menu_gestion_movimientos
            // 
            this.Menu_gestion_movimientos.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_movimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Item_Inventario,
            this.Menu_Item_Ajustes_Movimientos});
            this.Menu_gestion_movimientos.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_movimientos.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_movimientos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_movimientos.Image")));
            this.Menu_gestion_movimientos.Name = "Menu_gestion_movimientos";
            this.Menu_gestion_movimientos.Size = new System.Drawing.Size(251, 64);
            this.Menu_gestion_movimientos.Text = "Movimientos De Stock";
            this.Menu_gestion_movimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu_Item_Inventario
            // 
            this.Menu_Item_Inventario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_Item_Inventario.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_Item_Inventario.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Item_Inventario.Image")));
            this.Menu_Item_Inventario.Name = "Menu_Item_Inventario";
            this.Menu_Item_Inventario.Size = new System.Drawing.Size(362, 42);
            this.Menu_Item_Inventario.Text = "Movimientos";
            this.Menu_Item_Inventario.Click += new System.EventHandler(this.Menu_Item_Inventario_Click);
            // 
            // Menu_Item_Ajustes_Movimientos
            // 
            this.Menu_Item_Ajustes_Movimientos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_Item_Ajustes_Movimientos.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_Item_Ajustes_Movimientos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Item_Ajustes_Movimientos.Image")));
            this.Menu_Item_Ajustes_Movimientos.Name = "Menu_Item_Ajustes_Movimientos";
            this.Menu_Item_Ajustes_Movimientos.Size = new System.Drawing.Size(362, 42);
            this.Menu_Item_Ajustes_Movimientos.Text = "Ajustes de Movimientos";
            this.Menu_Item_Ajustes_Movimientos.Click += new System.EventHandler(this.Menu_Item_Ajustes_Movimientos_Click);
            // 
            // FrmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 691);
            this.Controls.Add(this.Menu_secundario);
            this.Controls.Add(this.Menu_principal);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.IsMdiContainer = true;
            this.Name = "FrmMdiPrincipal";
            this.Text = "Sistema Ferreteria Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMdiPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMdiPrincipal_Load);
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            this.Menu_secundario.ResumeLayout(false);
            this.Menu_secundario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem menu_item_productos;
        private System.Windows.Forms.ToolStripMenuItem menu_item_subcategorias;
        private System.Windows.Forms.ToolStripMenuItem menu_item_especificación;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_analisis;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_analisis_stock;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_salir;
        private System.Windows.Forms.Timer tn_tiempo;
        private System.Windows.Forms.StatusStrip Menu_secundario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_fecha;
        private System.Windows.Forms.ToolStripMenuItem menu_items_categorias;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_reportes;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_UnidadMedida;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem ventasDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDelMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasAProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeIngresosPorDíamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDeCadaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_venta;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_presupuestos;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_presupuesto;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_consultas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_usuarios;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_analis_venta;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_proveedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_Ingresos;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_Configuracion;
        private System.Windows.Forms.ToolStripMenuItem Menu_Item_Ticket;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_movimientos;
        private System.Windows.Forms.ToolStripMenuItem Menu_Item_Inventario;
        private System.Windows.Forms.ToolStripMenuItem Menu_Item_Ajustes_Movimientos;
    }
}