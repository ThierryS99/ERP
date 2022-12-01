using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Products
{
    class Weight
    {
        public double GrossWeight { get; set; } // PESO BRUTO
        public double NetWeight { get; set; } // PESO LÍQUIDO

        public Weight()
        {
        }
        public Weight(double grossWeight, double netWeight)
        {
            GrossWeight = grossWeight;
            NetWeight = netWeight;
        }
    }
}
