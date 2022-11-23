using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.ProductFeatures;

namespace ERP.Products
{
    public class Product
    {
        public string ProductId { get; set; }
        public Description Description { get; set; }
        public Guide Manufacturing { get; set; }

        public Product() { }
        public Product(string productId, Description description)
        {
            ProductId = productId;
            Description = description;
        }
        public Product(string productId, Description description, Guide manufacturing)
        {
            ProductId = productId;
            Description = description;
            Manufacturing = manufacturing;
        }

        public static void DescriptionRegitration()
        {
            Description description = new Description();
            Console.Write("DESCRIÇÃO: ");
            description.PrimaryDescription = Console.ReadLine();
            Console.Write("DESCRIÇÃO COMPLEMENTAR: ");
            description.SecondaryDescription = Console.ReadLine();
        }
    }
}
