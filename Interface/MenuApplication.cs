﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP.Interface
{
    class MenuApplication
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao PROFIT+");
            Console.WriteLine();

            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine();
            Console.WriteLine("Cadastrar novo PRODUTO -> 0");
            Console.WriteLine("Cadastrar novo ROTEIRO -> 1");
            Console.WriteLine("Cadastrar novo PEDIDO DE VENDA -> 2");
            Console.WriteLine("Cadastrar nova ORDEM DE PRODUÇÃO -> 3");
            Console.WriteLine("Cadastrar novo CLIENTE -> 4");
            Console.WriteLine("Consultar produtos cadastrados -> 9");
            Console.WriteLine("Encerrar aplicação -> 10");
            Console.WriteLine();
            Console.Write("OPÇÃO: ");
            int menuOption = int.Parse(Console.ReadLine());

            switch (menuOption)
            {
                case 0: RegistrationOptions.ProductRegistration(); break;
                case 1: RegistrationOptions.GuideRegistration(); break;
                case 2: RegistrationOptions.SalesOrderRegistration(); break;
                case 3: RegistrationOptions.ProductionOrderRegistration(); break;
                case 4: RegistrationOptions.ClientRegistration(); break;

                case 10: Environment.Exit(0); break;

            }
        }
    }
}