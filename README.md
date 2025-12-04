## Sistema de Gestión Comercial “Ferre Gestión” 

## 🎯 Objetivo del Proyecto

El objetivo principal del sistema fue **digitalizar completamente la operatoria de una ferretería**, reemplazando los procesos manuales por un sistema robusto, auditable y escalable, mejorando:

- El control de stock
- La facturación diaria
- La trazabilidad de operaciones
- La gestión administrativa
- La toma de decisiones mediante reportes


## 👨‍💻 Rol en el Proyecto

Proyecto desarrollado de forma **individual**, abarcando:

- Relevamiento de requerimientos con el cliente.
- Diseño del modelo de base de datos.
- Desarrollo completo del backend.
- Implementación de reglas de negocio.
- Integración con hardware (lector de código de barras, impresora térmica e impresora convencional).
- Puesta en producción y soporte.

📅 **Duración del proyecto:** Mayo 2025 – Septiembre 2025  


## 🏢 Descripción del Proyecto

Desarrollé un **sistema ERP comercial completo para una ferretería**, orientado a la gestión integral del negocio. El sistema permite administrar de forma centralizada **ventas, compras, stock, presupuestos, productos, proveedores, movimientos de stock y reportes**, garantizando trazabilidad total de las operaciones.

El proyecto se realizó a partir de un **relevamiento de requerimientos con el cliente**, mediante entrevistas previas al inicio del desarrollo y reuniones de seguimiento durante la implementación, adaptando cada módulo a las necesidades reales del comercio.

El sistema cuenta con **integración con lector de códigos de barras**, **impresora térmica para la emisión de tickets de venta (consumidor final)** e **impresora convencional para reportes**, los cuales se utilizan para:
- Reportes de **presupuestos**
- **Boletas de ventas a consumidor final**
- **Reportes de auditoría**
- Reportes administrativos y de control interno
- 
El sistema se encuentra **actualmente en uso en producción**, optimizando los procesos diarios de la ferretería, reduciendo errores de stock, mejorando el control administrativo y agilizando la facturación.

## 🔧 Módulos del Sistema

### Gestión de Ventas
- Generaciónde ventas.
- Historial completo con detalle por producto.
- Asociación de venta a usuarios del sistema.
- Anulación de ventas con impacto automático en stock.

### Presupuestos
- Generación de presupuestos.
- Historial.
  
### Consultas de Productos
-Búsqueda de productos.
- Visualización de especificaciones
- Consulta de stock y precios.

### Compras / Ingresos
- Registro de ingresos de mercadería.
- Historial de ingresos
- Asociación de ingresos por proveedor.
- Anulación de ingresos con impacto automático en stock
  

### Reportes
- Ventas por rango de  fechas.
- Productos más vendidos por rango de fechas.

### Mantenimiento (ABM)
-  Categorías
-  Subcategorías
-  Marcas
-  Unidades de medida
-  Productos
-  Proveedores
-  Usuarios
-  Especificaciones.

### Gestión de Stock
- Inventario en tiempo real.
- Historial completo de movimientos.
- Tipos de movimientos:
  - Venta
  - Compra
  - Devolución cliente/proveedor
  - Ajustes
  - Reposición
  - Robo
  - Anulaciones
  - Ajustes manuales con registro para auditoría.


### Auditoría
- Registro completo de cada modificación de stock.

### Configuración del Sistema
- Datos de la empresa(CUIT, nombre, dirección, teléfono).
- Mensajes personalizados del ticket.
- Configuración de impresora térmica.
- Backups manuales y automáticos programados por horario.

  ## 🗄️ Modelo de Base de Datos

El sistema cuenta con una base de datos relacional compuesta por **20 tablas**, diseñada para garantizar integridad, trazabilidad y escalabilidad del negocio.


<img width="1114" height="820" alt="DiagramaFerreGestión" src="https://github.com/user-attachments/assets/b0846ad5-a28a-4c88-94b5-72c3ce737de0" />

## ⚙️ Arquitectura y Funcionalidades Técnicas

- Uso de **transacciones SQL** para garantizar la integridad de datos en:
  - Ventas
  - Compras
  - Movimientos de stock
  - Devoluciones
- Implementación de **procedimientos almacenados (Stored Procedures)** para operaciones críticas.
- Control de **auditoría de movimientos de stock** (ventas, compras, ajustes, devoluciones, robos, anulaciones).
- Manejo de **stock inicial, reposiciones y ajustes manuales**.
- Validaciones de negocio en backend.
- Sistema de **backups manual y automático** con configuración de horarios.

  
## Demo  del Sistema



