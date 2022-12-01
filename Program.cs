using System;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using ERP.Interface;
using ERP.Products;

namespace ERP
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=ErpServer;User ID=sa;Password=1q2w3e4r@#$";

        public static void Main(string[] args)
        {
            MenuApplication.Menu();
        }
        public static void ReadProduct()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var product = connection.GetAll<Product>();

                foreach (var product1 in product)
                {
                    Console.WriteLine(product1.ProductId);
                }
            }
        }
    }
}