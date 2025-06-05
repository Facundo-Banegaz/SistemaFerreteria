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
            this.Menu_almacen = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_productos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_items_categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_subcategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ingresos = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_gestion_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_consultas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_trabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.tn_tiempo = new System.Windows.Forms.Timer(this.components);
            this.Menu_secundario = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_fecha = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.Menu_almacen,
            this.Menu_gestion_compras,
            this.Menu_gestion_ventas,
            this.Menu_consultas,
            this.Menu_mantenimiento,
            this.Menu_item_salir});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Padding = new System.Windows.Forms.Padding(9, 10, 0, 10);
            this.Menu_principal.Size = new System.Drawing.Size(1620, 66);
            this.Menu_principal.TabIndex = 10;
            this.Menu_principal.Text = "Menu";
            // 
            // Menu_almacen
            // 
            this.Menu_almacen.BackColor = System.Drawing.Color.Black;
            this.Menu_almacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_productos,
            this.menu_items_categorias,
            this.menu_item_subcategorias,
            this.menu_item_marcas});
            this.Menu_almacen.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_almacen.ForeColor = System.Drawing.Color.Orange;
            this.Menu_almacen.Image = ((System.Drawing.Image)(resources.GetObject("Menu_almacen.Image")));
            this.Menu_almacen.Name = "Menu_almacen";
            this.Menu_almacen.Size = new System.Drawing.Size(145, 46);
            this.Menu_almacen.Text = "Almacén";
            // 
            // menu_item_productos
            // 
            this.menu_item_productos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_productos.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_productos.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_productos.Image")));
            this.menu_item_productos.Name = "menu_item_productos";
            this.menu_item_productos.Size = new System.Drawing.Size(253, 36);
            this.menu_item_productos.Text = "Productos";
            this.menu_item_productos.Click += new System.EventHandler(this.menu_item_productos_Click);
            // 
            // menu_items_categorias
            // 
            this.menu_items_categorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_items_categorias.ForeColor = System.Drawing.Color.Orange;
            this.menu_items_categorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_items_categorias.Image")));
            this.menu_items_categorias.Name = "menu_items_categorias";
            this.menu_items_categorias.Size = new System.Drawing.Size(253, 36);
            this.menu_items_categorias.Text = "Categorias";
            this.menu_items_categorias.Click += new System.EventHandler(this.menu_items_categorias_Click);
            // 
            // menu_item_subcategorias
            // 
            this.menu_item_subcategorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_subcategorias.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_subcategorias.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_subcategorias.Image")));
            this.menu_item_subcategorias.Name = "menu_item_subcategorias";
            this.menu_item_subcategorias.Size = new System.Drawing.Size(253, 36);
            this.menu_item_subcategorias.Text = "Subcategorias";
            this.menu_item_subcategorias.Click += new System.EventHandler(this.menu_item_subcategorias_Click);
            // 
            // menu_item_marcas
            // 
            this.menu_item_marcas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_marcas.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_marcas.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_marcas.Image")));
            this.menu_item_marcas.Name = "menu_item_marcas";
            this.menu_item_marcas.Size = new System.Drawing.Size(253, 36);
            this.menu_item_marcas.Text = "Marcas";
            this.menu_item_marcas.Click += new System.EventHandler(this.menu_item_marcas_Click);
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
            this.Menu_item_ingresos.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_ingresos.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ingresos.Image")));
            this.Menu_item_ingresos.Name = "Menu_item_ingresos";
            this.Menu_item_ingresos.Size = new System.Drawing.Size(239, 36);
            this.Menu_item_ingresos.Text = "Ingresos";
            // 
            // Menu_item_proveedores
            // 
            this.Menu_item_proveedores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_proveedores.Checked = true;
            this.Menu_item_proveedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_item_proveedores.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_proveedores.Image")));
            this.Menu_item_proveedores.Name = "Menu_item_proveedores";
            this.Menu_item_proveedores.Size = new System.Drawing.Size(239, 36);
            this.Menu_item_proveedores.Text = "Proveedores";
            // 
            // Menu_gestion_ventas
            // 
            this.Menu_gestion_ventas.BackColor = System.Drawing.Color.Black;
            this.Menu_gestion_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_ventas});
            this.Menu_gestion_ventas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_gestion_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_gestion_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_gestion_ventas.Image")));
            this.Menu_gestion_ventas.Name = "Menu_gestion_ventas";
            this.Menu_gestion_ventas.Size = new System.Drawing.Size(253, 46);
            this.Menu_gestion_ventas.Text = "  Gestion De Ventas";
            // 
            // Menu_item_ventas
            // 
            this.Menu_item_ventas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu_item_ventas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_item_ventas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_item_ventas.Image")));
            this.Menu_item_ventas.Name = "Menu_item_ventas";
            this.Menu_item_ventas.Size = new System.Drawing.Size(181, 36);
            this.Menu_item_ventas.Text = "Ventas";
            // 
            // Menu_consultas
            // 
            this.Menu_consultas.BackColor = System.Drawing.Color.Black;
            this.Menu_consultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_stock});
            this.Menu_consultas.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_consultas.ForeColor = System.Drawing.Color.Orange;
            this.Menu_consultas.Image = ((System.Drawing.Image)(resources.GetObject("Menu_consultas.Image")));
            this.Menu_consultas.Name = "Menu_consultas";
            this.Menu_consultas.Size = new System.Drawing.Size(157, 46);
            this.Menu_consultas.Text = "Consultas";
            // 
            // menu_item_stock
            // 
            this.menu_item_stock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_stock.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_stock.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_stock.Image")));
            this.menu_item_stock.Name = "menu_item_stock";
            this.menu_item_stock.Size = new System.Drawing.Size(294, 36);
            this.menu_item_stock.Text = "Stock de Articulos";
            // 
            // Menu_mantenimiento
            // 
            this.Menu_mantenimiento.BackColor = System.Drawing.Color.Black;
            this.Menu_mantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_trabajador});
            this.Menu_mantenimiento.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.Menu_mantenimiento.ForeColor = System.Drawing.Color.Orange;
            this.Menu_mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("Menu_mantenimiento.Image")));
            this.Menu_mantenimiento.Name = "Menu_mantenimiento";
            this.Menu_mantenimiento.Size = new System.Drawing.Size(212, 46);
            this.Menu_mantenimiento.Text = "Mantenimiento";
            // 
            // menu_item_trabajador
            // 
            this.menu_item_trabajador.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu_item_trabajador.ForeColor = System.Drawing.Color.Orange;
            this.menu_item_trabajador.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_trabajador.Image")));
            this.menu_item_trabajador.Name = "menu_item_trabajador";
            this.menu_item_trabajador.Size = new System.Drawing.Size(201, 36);
            this.menu_item_trabajador.Text = "Usuarios";
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
            // FrmMdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 670);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_almacen;
        private System.Windows.Forms.ToolStripMenuItem menu_item_productos;
        private System.Windows.Forms.ToolStripMenuItem menu_item_subcategorias;
        private System.Windows.Forms.ToolStripMenuItem menu_item_marcas;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_compras;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ingresos;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_proveedores;
        private System.Windows.Forms.ToolStripMenuItem Menu_gestion_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_ventas;
        private System.Windows.Forms.ToolStripMenuItem Menu_consultas;
        private System.Windows.Forms.ToolStripMenuItem menu_item_stock;
        private System.Windows.Forms.ToolStripMenuItem Menu_mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem menu_item_trabajador;
        private System.Windows.Forms.ToolStripMenuItem Menu_item_salir;
        private System.Windows.Forms.Timer tn_tiempo;
        private System.Windows.Forms.StatusStrip Menu_secundario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbl_fecha;
        private System.Windows.Forms.ToolStripMenuItem menu_items_categorias;
    }
}