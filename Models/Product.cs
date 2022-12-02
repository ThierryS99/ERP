using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ERP.Models
{
    [Table("[Product]")]

    public class Product
    {
        public string ProductId { get; set; }
        public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }

        public Product() { }

        public Product(string productId, string primaryDescription, string secondaryDescription)
        {
            ProductId = productId;
            PrimaryDescription = primaryDescription;
            SecondaryDescription = secondaryDescription;
        }

        public static void DescriptionRegistration(string primaryDescription, string secondaryDescription)
        {
            Console.Write("DESCRIÇÃO: ");
            primaryDescription = Console.ReadLine();
            Console.Write("DESCRIÇÃO COMPLEMENTAR: ");
            secondaryDescription = Console.ReadLine();
        }
    }
}
