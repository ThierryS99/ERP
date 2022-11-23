using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.ProductionOrders
{
    class Client
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }

        public Client() { }
        public Client(string clientId, string clientName)
        {
            ClientId = clientId;
            ClientName = clientName;
        }
    }
}
