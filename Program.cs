using System;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using ERP.Interface;
using ERP.Models;

namespace ERP
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuApplication.Menu();
        }
    }
}