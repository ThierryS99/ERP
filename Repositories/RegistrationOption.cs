using ERP.Models;
using ERP.ProductionOrders;
using ERP.Interface;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;


namespace ERP.Repositories
{
    class RegistrationOption
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433; Database=ErpServer; User ID=sa; Password=1q2w3e4r@#$; TrustServerCertificate=True";

        public static void ProductRegistration() // CADASTRO DO PRODUTO
        {
            Product product = new Product();

            Console.Clear();
            Console.WriteLine("CADASTRO DE PRODUTO");
            Console.WriteLine();
            Console.Write("CÓDIGO: ");
            product.ProductId = Console.ReadLine();
            Product.DescriptionRegistration(product.PrimaryDescription, product.SecondaryDescription);

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<Product>(product);
                {
                    Console.Clear();
                    Console.WriteLine("Cadastro realizado com sucesso!");
                }
            }
            Console.WriteLine();
            Console.Write("O ROTEIRO do produto já está cadastrado? (S/N): ");
            char option = char.Parse(Console.ReadLine().ToUpper());
            if (option == 'S')
            {
                Console.WriteLine();
                Console.Write("Deseja fazer a ligação do PRODUTO x ROTEIRO? (S/N): ");
                option = char.Parse(Console.ReadLine().ToUpper());
                if (option == 'S')
                {
                    Console.WriteLine();
                    Console.Write("Código do ROTEIRO: ");

                }

            }
            else if (option == 'N')
            {
                Console.WriteLine();
                Console.Write("Deseja fazer o cadastro do ROTEIRO agora? (S/N): ");
                option = char.Parse(Console.ReadLine().ToUpper());
                if (option == 'N')
                {
                    MenuApplication.Menu(); // RETORNA PARA O MENU
                }
                else if (option == 'S')
                {
                    GuideRegistration();
                }
            }
        }

        public static void GuideRegistration() // CADASTRO DO ROTEIRO
        {
            Sequence newGuide = new Sequence();


        }

        public static void SalesOrderRegistration() // CADASTRANDO UMA NOVA ORDEM DE VENDA
        {
            SalesOrder salesOrder = new SalesOrder();

            Console.Clear();
            Console.WriteLine("CADASTRO DE ORDEM DE VENDA");
            Console.WriteLine();
            Console.Write("O cliente está cadastrado? (S/N): ");
            char option = char.Parse(Console.ReadLine().ToUpper());
            if (option == 'S')
            {
                Console.WriteLine();
                Console.Write("Digite o código do CLIENTE: ");
                string searchIdClient = Console.ReadLine();

                // FAZER UMA VERIFICAÇÃO PARA SABER SE O CLIENTE ESTÁ REGISTRADO NO  SISTEMA.

                Console.Write("Número da ordem de venda: ");
                salesOrder.IdSalesOrder = Console.ReadLine();

                Console.Write("Código do produto: ");
                string productId = Console.ReadLine(); // CRIAR FORMA DE LIGAR ESSE CÓDIGO DA VARIÁVEL AO OBJETO CRIADO NA LISTA

                Console.Write("Quantidade: ");
                salesOrder.Quantity = int.Parse(Console.ReadLine());
                Console.Write("Data de entrega: ");
                salesOrder.DeliveryTime = DateTime.Parse(Console.ReadLine());
            }
            else if (option == 'N')
            {
                Console.WriteLine();
                Console.Write("Deseja cadastrar um novo cliente? (S/N): ");
                option = char.Parse(Console.ReadLine().ToUpper());
                if (option == 'S')
                {
                    ClientRegistration();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"ATENÇÃO: NÃO É POSSIVEL CADASTRAR UMA NOVA ORDEM DE VENDAS SEM QUE O CLIENTE ESTEJA CADASTRADO.\n" +
                        $"PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU.");
                    Console.ReadKey();
                    MenuApplication.Menu();
                }
            }
        }

        public static void ClientRegistration() // CADASTRANDO NOVO CLIENTE
        {
            Console.Clear();
            Client newClient = new Client();

            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.WriteLine();
            Console.Write("ID do cliente: ");
            newClient.ClientId = Console.ReadLine();
            Console.Write("Nome do cliente: ");
            newClient.ClientName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"CLIENTE CADASTRADO COM SUCESSO! \n" +
                $"PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU.");
            Console.ReadKey();
            MenuApplication.Menu();
        }

        public static void ProductionOrderRegistration() // CADASTRO DE ORDEM DE PRODUÇÃO.
        {
            Console.Clear();
            ProductionOrder newProductionOrder = new ProductionOrder();

            Console.WriteLine("GERAR NOVA ORDEM DE PRODUÇÃO:");
            Console.WriteLine();
            Console.Write("A ordem de venda está cadastrada? (S/N): ");
            char option = char.Parse(Console.ReadLine().ToUpper());
            if (option == 'S')
            {
                Console.WriteLine();
                Console.Write("ID da ORDEM DE PRODUÇÃO: ");
                newProductionOrder.ProductionOrderId = Console.ReadLine();

                Console.Write("ID do pedido de venda: ");
                string salesOrder = Console.ReadLine(); // CRIAR FORMA DE LIGAR PEDIDO DE VENDA COM ESSA VARIAVEL DA ORDEM DE PRODUÇÃO

                Console.WriteLine();
                Console.WriteLine($"ORDEM DE VENDA CADASTRADA COM SUCESSO! \n" +
                    $"PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU.");
                Console.ReadKey();
                MenuApplication.Menu();
            }
            else if (option == 'N')
            {
                Console.WriteLine();
                Console.Write("Deseja cadastrar um PEDIDO DE VENDA? (S/N): ");
                option = char.Parse(Console.ReadLine().ToUpper());
                if (option == 'S')
                {
                    RegistrationOption.SalesOrderRegistration();
                }
                else if (option == 'N')
                {
                    Console.Clear();
                    Console.WriteLine($"ATENÇÃO: NÃO É POSSIVEL CADASTRAR UMA ORDEM DE PRODUÇÃO SEM QUE A ORDEM DE VENDA ESTEJA CADASTRADA! \n" +
                        $"PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU.");
                    Console.ReadKey();
                    MenuApplication.Menu();
                }
            }
        }
    }
}