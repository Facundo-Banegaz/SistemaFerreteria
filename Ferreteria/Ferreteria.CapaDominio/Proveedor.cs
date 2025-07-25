﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class Proveedor
    {
        public int Id_Proveedor { get; set; }
        public string Nombre { get; set; }

        public string SectorComercial { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
        public List<Ingreso> Ingresos { get; set; }
    }
}
