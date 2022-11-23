using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Products;

namespace ERP.ProductionOrders
{
    internal class SalesOrder
    {
        public string IdSalesOrder { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DeliveryTime { get; set; }

        public SalesOrder() { }
        public SalesOrder(string idSalesOrder, Client client, Product product, int quantity)
        {
            IdSalesOrder = idSalesOrder;
            Client = client;
            Product = product;
            Quantity = quantity;
        }
    }
}
