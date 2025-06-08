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
            this.Menu_administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_items_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_subcategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_especificación = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_analisis = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_historial = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.Menu_secundario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_vendedor_secundario = new System.Windows.Forms.MenuStrip();
            this.Menu_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ProductosMasVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_items_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_VentaxMes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_VentaxDia = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ventasPorDia = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_CatySubMasVendido = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_productoBajoStock = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_VentaPorMes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_productoMasVendido = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_UnidadMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_TipoEspecificación = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_ValorEspecificación = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_principal.SuspendLayout();
            this.Menu_secundario.SuspendLayout();
            this.Menu_vendedor_secundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu_principal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_principal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_principal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_administracion,
            this.Menu_gestion_compras,
            this.menu_reportes,
            this.Menu_analisis,
            this.menu_mantenimiento,
            this.Menu_item_salir});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_principal.Size = new System.Drawing.Size(1620, 66);
            this.Menu_principal.TabIndex = 10;
            this.Menu_principal.Text = "Menu";
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
            this.menu_item_especificación});
            this.Menu_administracion.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_administracion.ForeColor = System.Drawing.Color.Orange;
            this.Menu_administracion.Image = ((System.Drawing.Image)(resources.GetObject("Menu_administracion.Image")));
            this.Menu_administracion.Name = "Menu_administracion";
            this.Menu_administracion.Size = new System.Drawing.Size(212, 46);
            this.Menu_administracion.Text = "Administración";
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
            // menu_item_especificación
            // 
            this.menu_item_especificación.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_especificación.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_TipoEspecificación,
            this.menu_item_ValorEspecificación});
            this.menu_item_especificación.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_especificación.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_especificación.Image")));
            this.menu_item_especificación.Name = "menu_item_especificación";
            this.menu_item_especificación.Size = new System.Drawing.Size(303, 42);
            this.menu_item_especificación.Text = "Especificación";
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
            this.Menu_gestion_compras.Size = new System.Drawing.Size(262, 46);
            this.Menu_gestion_compras.Text = "Gestion De Compras";
            // 
            // Menu_item_ingresos
            // 
            this.Menu_item_ingresos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ingresos.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ingresos.Image")));
            this.Menu_item_ingresos.Name = "Menu_item_ingresos";
            this.Menu_item_ingresos.Size = new System.Drawing.Size(278, 42);
            this.Menu_item_ingresos.Text = "Ingresos";
            // 
            // Menu_item_proveedores
            // 
            this.Menu_item_proveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_proveedores.Checked = true;
            this.Menu_item_proveedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_item_proveedores.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_proveedores.Image")));
            this.Menu_item_proveedores.Name = "Menu_item_proveedores";
            this.Menu_item_proveedores.Size = new System.Drawing.Size(278, 42);
            this.Menu_item_proveedores.Text = " Proveedores";
            // 
            // Menu_analisis
            // 
            this.Menu_analisis.BackColor = System.Drawing.Color.Black;
            this.Menu_analisis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_historial});
            this.Menu_analisis.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_analisis.ForeColor = System.Drawing.Color.Orange;
            this.Menu_analisis.Image = ((System.Drawing.Image)(resources.GetObject("Menu_analisis.Image")));
            this.Menu_analisis.Name = "Menu_analisis";
            this.Menu_analisis.Size = new System.Drawing.Size(137, 46);
            this.Menu_analisis.Text = "Analisis";
            // 
            // menu_item_historial
            // 
            this.menu_item_historial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_historial.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_historial.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_historial.Image")));
            this.menu_item_historial.Name = "menu_item_historial";
            this.menu_item_historial.Size = new System.Drawing.Size(310, 42);
            this.menu_item_historial.Text = "Historial de Ventas";
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
            this.Menu_item_salir.Size = new System.Drawing.Size(330, 46);
            this.Menu_item_salir.Text = "Salir del Sistema de Ventas";
            this.Menu_item_salir.Click += new System.EventHandler(this.Menu_item_salir_Click);
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
            this.lbl_fecha});
            this.Menu_secundario.Location = new System.Drawing.Point(0, 634);
            this.Menu_secundario.Name = "Menu_secundario";
            this.Menu_secundario.Size = new System.Drawing.Size(1620, 36);
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
            // menu_mantenimiento
            // 
            this.menu_mantenimiento.BackColor = System.Drawing.Color.Black;
            this.menu_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menu_mantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_mantenimiento.ForeColor = System.Drawing.Color.Orange;
            this.menu_mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("menu_mantenimiento.Image")));
            this.menu_mantenimiento.Name = "menu_mantenimiento";
            this.menu_mantenimiento.Size = new System.Drawing.Size(212, 46);
            this.menu_mantenimiento.Text = "Mantenimiento";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(278, 42);
            this.toolStripMenuItem2.Text = "Usuarios";
            // 
            // Menu_vendedor_secundario
            // 
            this.Menu_vendedor_secundario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu_vendedor_secundario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_vendedor_secundario.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_vendedor_secundario.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Menu_vendedor_secundario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.Menu_ventas,
            this.Menu_items_consultas});
            this.Menu_vendedor_secundario.Location = new System.Drawing.Point(0, 66);
            this.Menu_vendedor_secundario.Name = "Menu_vendedor_secundario";
            this.Menu_vendedor_secundario.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_vendedor_secundario.Size = new System.Drawing.Size(1620, 56);
            this.Menu_vendedor_secundario.TabIndex = 13;
            this.Menu_vendedor_secundario.Text = "Menu";
            // 
            // Menu_ventas
            // 
            this.Menu_ventas.BackColor = System.Drawing.Color.Black;
            this.Menu_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3});
            this.Menu_ventas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_ventas.Image")));
            this.Menu_ventas.Name = "Menu_ventas";
            this.Menu_ventas.Size = new System.Drawing.Size(194, 36);
            this.Menu_ventas.Text = "Presupuestos";
            // 
            // Menu_item_ProductosMasVendidos
            // 
            this.Menu_item_ProductosMasVendidos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_ProductosMasVendidos.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_ProductosMasVendidos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ProductosMasVendidos.Image")));
            this.Menu_item_ProductosMasVendidos.Name = "Menu_item_ProductosMasVendidos";
            this.Menu_item_ProductosMasVendidos.Size = new System.Drawing.Size(370, 42);
            this.Menu_item_ProductosMasVendidos.Text = "Productos Más Vendidos";
            // 
            // Menu_items_consultas
            // 
            this.Menu_items_consultas.BackColor = System.Drawing.Color.Black;
            this.Menu_items_consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_Consultar,
            this.Menu_item_VentaxDia,
            this.Menu_item_VentaxMes,
            this.Menu_item_ProductosMasVendidos});
            this.Menu_items_consultas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_items_consultas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_items_consultas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_items_consultas.Image")));
            this.Menu_items_consultas.Name = "Menu_items_consultas";
            this.Menu_items_consultas.Size = new System.Drawing.Size(157, 36);
            this.Menu_items_consultas.Text = "Consultas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(331, 42);
            this.toolStripMenuItem3.Text = "Ver Presupuestos";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(331, 42);
            this.toolStripMenuItem4.Text = "Generar Presupuesto";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Orange;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(253, 36);
            this.toolStripMenuItem5.Text = "  Gestion De Ventas";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.SystemColors.GrayText;
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(304, 42);
            this.toolStripMenuItem6.Text = "Nueva Venta";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(304, 42);
            this.toolStripMenuItem7.Text = "Nueva Venta Libre";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(304, 42);
            this.toolStripMenuItem8.Text = "Historial Ventas";
            // 
            // Menu_item_VentaxMes
            // 
            this.Menu_item_VentaxMes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_VentaxMes.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_VentaxMes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_VentaxMes.Image")));
            this.Menu_item_VentaxMes.Name = "Menu_item_VentaxMes";
            this.Menu_item_VentaxMes.Size = new System.Drawing.Size(370, 42);
            this.Menu_item_VentaxMes.Text = "Ventas Del Mes";
            // 
            // Menu_item_VentaxDia
            // 
            this.Menu_item_VentaxDia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_VentaxDia.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_VentaxDia.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_VentaxDia.Image")));
            this.Menu_item_VentaxDia.Name = "Menu_item_VentaxDia";
            this.Menu_item_VentaxDia.Size = new System.Drawing.Size(370, 42);
            this.Menu_item_VentaxDia.Text = "Ventas Del Dia";
            // 
            // menu_reportes
            // 
            this.menu_reportes.BackColor = System.Drawing.Color.Black;
            this.menu_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_ventasPorDia,
            this.Menu_item_VentaPorMes,
            this.Menu_item_productoBajoStock,
            this.Menu_item_productoMasVendido,
            this.Menu_item_CatySubMasVendido});
            this.menu_reportes.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.menu_reportes.ForeColor = System.Drawing.Color.Orange;
            this.menu_reportes.Image = ((System.Drawing.Image)(resources.GetObject("menu_reportes.Image")));
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(149, 46);
            this.menu_reportes.Text = "Reportes";
            // 
            // Menu_item_ventasPorDia
            // 
            this.Menu_item_ventasPorDia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ventasPorDia.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_ventasPorDia.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ventasPorDia.Image")));
            this.Menu_item_ventasPorDia.Name = "Menu_item_ventasPorDia";
            this.Menu_item_ventasPorDia.Size = new System.Drawing.Size(513, 42);
            this.Menu_item_ventasPorDia.Text = "Ventas por Día";
            // 
            // Menu_item_CatySubMasVendido
            // 
            this.Menu_item_CatySubMasVendido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_CatySubMasVendido.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_CatySubMasVendido.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_CatySubMasVendido.Image")));
            this.Menu_item_CatySubMasVendido.Name = "Menu_item_CatySubMasVendido";
            this.Menu_item_CatySubMasVendido.Size = new System.Drawing.Size(513, 42);
            this.Menu_item_CatySubMasVendido.Text = "Categoria/Subcategoria  mas Vendidos ";
            // 
            // Menu_item_productoBajoStock
            // 
            this.Menu_item_productoBajoStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_productoBajoStock.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_productoBajoStock.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_productoBajoStock.Image")));
            this.Menu_item_productoBajoStock.Name = "Menu_item_productoBajoStock";
            this.Menu_item_productoBajoStock.Size = new System.Drawing.Size(513, 42);
            this.Menu_item_productoBajoStock.Text = "Productos con Bajo Stock";
            // 
            // Menu_item_VentaPorMes
            // 
            this.Menu_item_VentaPorMes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_VentaPorMes.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_VentaPorMes.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_VentaPorMes.Image")));
            this.Menu_item_VentaPorMes.Name = "Menu_item_VentaPorMes";
            this.Menu_item_VentaPorMes.Size = new System.Drawing.Size(513, 42);
            this.Menu_item_VentaPorMes.Text = "Ventas por Mes";
            // 
            // Menu_item_productoMasVendido
            // 
            this.Menu_item_productoMasVendido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_productoMasVendido.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_productoMasVendido.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_productoMasVendido.Image")));
            this.Menu_item_productoMasVendido.Name = "Menu_item_productoMasVendido";
            this.Menu_item_productoMasVendido.Size = new System.Drawing.Size(513, 42);
            this.Menu_item_productoMasVendido.Text = "Productos mas Vendidos ";
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
            // menu_item_TipoEspecificación
            // 
            this.menu_item_TipoEspecificación.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_TipoEspecificación.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_TipoEspecificación.Name = "menu_item_TipoEspecificación";
            this.menu_item_TipoEspecificación.Size = new System.Drawing.Size(312, 36);
            this.menu_item_TipoEspecificación.Text = "Tipo Especificación";
            // 
            // menu_item_ValorEspecificación
            // 
            this.menu_item_ValorEspecificación.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_ValorEspecificación.ForeColor = System.Drawing.Color.SeaShell;
            this.menu_item_ValorEspecificación.Name = "menu_item_ValorEspecificación";
            this.menu_item_ValorEspecificación.Size = new System.Drawing.Size(312, 36);
            this.menu_item_ValorEspecificación.Text = "Valor Especificación";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem12.ForeColor = System.Drawing.Color.SeaShell;
            this.toolStripMenuItem12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem12.Image")));
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(303, 42);
            this.toolStripMenuItem12.Text = "Marcas";
            // 
            // Menu_item_Consultar
            // 
            this.Menu_item_Consultar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_item_Consultar.ForeColor = System.Drawing.Color.SeaShell;
            this.Menu_item_Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_Consultar.Image")));
            this.Menu_item_Consultar.Name = "Menu_item_Consultar";
            this.Menu_item_Consultar.Size = new System.Drawing.Size(370, 42);
            this.Menu_item_Consultar.Text = "Consultar  Productos";
            // 
            // FrmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 670);
            this.Controls.Add(this.Menu_vendedor_secundario);
            this.Controls.Add(this.Menu_secundario);
            this.Controls.Add(this.Menu_principal);
            this.IsMdiContainer = true;
            this.Name = "FrmMdiPrincipal";
            this.Text = "Sistema Ferreteria Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            this.Menu_secundario.ResumeLayout(false);
            this.Menu_secundario.PerformLayout();
            this.Menu_vendedor_secundario.ResumeLayout(false);
            this.Menu_vendedor_secundario.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ingresos;
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
        private System.Windows.Forms.ToolStripMenuItem menu_mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip Menu_vendedor_secundario;
        private System.Windows.Forms.ToolStripMenuItem Menu_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_items_consultas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ProductosMasVendidos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_VentaxDia;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_VentaxMes;
        private System.Windows.Forms.ToolStripMenuItem menu_reportes;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ventasPorDia;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_VentaPorMes;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_productoBajoStock;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_CatySubMasVendido;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_productoMasVendido;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_UnidadMedida;
        private System.Windows.Forms.ToolStripMenuItem menu_item_TipoEspecificación;
        private System.Windows.Forms.ToolStripMenuItem menu_item_ValorEspecificación;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_Consultar;
    }
}