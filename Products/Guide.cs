using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Products
{
    public class Guide
    {
        public ResourceCenter ResourceCenter { get; set; } // CENTRO DE RECURSO (SETOR/MÁQUINA)
        public DateTime AdjustmentTime { get; set; } // TEMPO DE REGULAGEM
        public DateTime ManufacturingTime { get; set; } // TEMPO DE FABRICAÇÃO

        public Guide() { }
        public Guide(ResourceCenter resourceCenter, DateTime adjustmentTime, DateTime manufacturingTime)
        {
            ResourceCenter = resourceCenter;
            AdjustmentTime = adjustmentTime;
            ManufacturingTime = manufacturingTime;
        }

        public void GuideRegistration(ResourceCenter resourceCenter, DateTime adjustmentTime, DateTime manufacturingTime)
        {
            List<Guide> newGuide = new List<Guide>();
        }
    }
}
