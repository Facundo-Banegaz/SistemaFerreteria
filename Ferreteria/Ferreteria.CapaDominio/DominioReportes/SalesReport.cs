using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.Reportes
{
    public class SalesReport
    {
        public DateTime reportDate { get;  set; }
        public DateTime startDate { get;  set; }
        public DateTime endDate { get;  set; }

        public List<SalesListing> salesListing { get;  set; }

        public List<NetSalesByPeriod> netSalesByPeriod { get;  set; }

        public decimal totalNetSales { get;  set; }


     
    }
}
