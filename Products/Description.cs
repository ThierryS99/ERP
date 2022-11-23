using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.ProductFeatures
{

    public class Description // DESCRIÇÃO
    {
        public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }

        public Description()
        {
        }

        public Description(string primaryDescription)
        {
            PrimaryDescription = primaryDescription;
        }

        public Description(string primaryDescription, string secondaryDescription)
        {
            PrimaryDescription = primaryDescription;
            SecondaryDescription = secondaryDescription;
        }
        
        public override string ToString()
        {
            return $"{PrimaryDescription} - {SecondaryDescription}";
        }
    }
}
