using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.CapaDominio.Reportes
{
    public class SalesReport
    {
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }

        public List<SalesListing>  salesListing { get; private set; }

        public List<NetSalesByPeriod> netSalesByPeriods { get; private set; }

        public decimal totalNetSales {  get; private set; }

    }
}
