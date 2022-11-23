using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.ProductionOrders
{
    class ProductionOrder
    {
        public string ProductionOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }

        public ProductionOrder() { }

        public ProductionOrder(string productionOrderId, SalesOrder salesOrder)
        {
            ProductionOrderId = productionOrderId;
            SalesOrder = salesOrder;
        }
    }
}
