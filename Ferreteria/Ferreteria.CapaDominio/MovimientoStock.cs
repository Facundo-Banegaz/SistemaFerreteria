﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class MovimientoStock
    {
        public int Id_MovimientoStock { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Relación con Producto
        public Producto Producto { get; set; }

        // Relación con TipoMovimiento
        public TipoMovimiento TipoMovimiento { get; set; }

        public decimal Cantidad { get; set; }
        public decimal StockAnterior { get; set; }
        public decimal StockNuevo { get; set; }

        // Relación con Usuario
        public Usuario Usuario { get; set; }

        public string Observacion { get; set; }

        public bool Estado { get; set; }
    }
}
