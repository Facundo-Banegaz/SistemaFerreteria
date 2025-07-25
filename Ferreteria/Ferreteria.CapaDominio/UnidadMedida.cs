﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio
{
    public class UnidadMedida
    {
        public int Id_UnidadMedida { get; set; }
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }

        [DisplayName("Permite Decimales")]
        public bool PermiteDecimales { get; set; } 
        public override string ToString()
        {
            return Nombre;
        }
        public List<Producto> Productos { get; set; }
    }
}
