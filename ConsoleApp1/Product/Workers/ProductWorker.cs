using Store.DataBase.Product.Repositories;
using Store.Product.Interfaces.Workers;
using Store.Product.Models;
using Store.Product.Services;

namespace Store.Product.Workers
{
    public class ProductWorker : IProductWorker
    {
        private readonly ProductModel _productModel;
        private readonly ProductRepository _productRepository;
        private readonly ProductService _productService;

        public ProductWorker()
        {
            _productModel = new ProductModel();
            _productRepository = new ProductRepository();
            _productService = new ProductService(_productRepository);
        }
        public void ProductScreen()
        {
            Console.Title = "Menu Product";

            Console.WriteLine("Escolha qual opção deseja: ");
            while (true)
            {
                Console.WriteLine("1. Cadastrar Produto");
                Console.WriteLine("2. Visualizar Todos os Produtos Cadastrados");
                Console.WriteLine("3. Pesquisar um produto pelo nome ou código");
                Console.WriteLine("4. Atualizar um produto pelo código");
                Console.WriteLine("5. Deletar um produto pelo código");

                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                switch (Console.Read())
                {
                    case '1':
                        var product = RegisterProduct();
                        var result = _productService.SetProduct(product);
                        MessageConsoleRegister(result, product);
                        break;
                    case '2':
                        var getAllproducts = _productService.GetAllProducts();
                        MessageConsoleAllProducts(getAllproducts);
                        break;
                    case '3':
                        MessageConsoleGetUnitProduct();
                        break;
                    case '4':


                        break;
                    case '5':


                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ReadLine();
                        Console.WriteLine("Opção Invalida, Tente novamente.....");
                        break;
                }
            }
        }

        public ProductModel RegisterProduct()
        {
            Console.Title = "Cadastro";
            Console.ReadLine();

            Console.WriteLine("Digite o nome do produto que deseja cadastrar: ");
            _productModel.ProductName = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto que deseja cadastrar: ");
            _productModel.ProductValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do produto que deseja cadastrar: ");
            _productModel.ProductSize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o código do produto que deseja cadastrar: ");
            _productModel.ProductId = int.TryParse(Console.ReadLine(), out var product) ? product : 0;

            return _productModel;
        }

        public void MessageConsoleRegister(bool result, ProductModel product)
        {
            if (result)
                Console.WriteLine("Cadastro concluido com sucesso");
            else
            {
                Console.WriteLine($"Esse código de produto: {product.ProductId} já existe ");
                Console.WriteLine("Tente novamente.");
            }
        }

        public void MessageConsoleAllProducts(List<ProductModel> products)
        {
            Console.WriteLine("Abaixo todos os produtos cadastrados: ");
            foreach (var product in products)
            {
                Console.WriteLine($"Codigo do Produto: {product.ProductId}, Nome do Produto: {product.ProductName}, " +
                    $"Tamanho do Produto: {product.ProductSize}, Valor do Produto: {product.ProductValue}");
            }
            Console.ReadKey();
        }

        public void MessageConsoleGetUnitProduct()
        {
            Console.Title = "Pesquisa";
            Console.ReadLine();
            Console.WriteLine("Escolha como deseja fazer a busca pelo produto:");
            Console.WriteLine("1. Pelo nome do produto");
            Console.WriteLine("2. Pelo código do produto");
            switch (Console.Read())
            {
                case '1':
                    Console.Title = "Nome";
                    Console.ReadLine();
                    Console.WriteLine("Digite o nome do produto, por favor: ");

                    var name = Console.ReadLine();
                    var productName = _productService.GetProductByProductName(name);

                    if (productName != null && productName.ProductName != null)
                    {
                        Console.WriteLine("A pesquisa retornou esse cadastro: ");
                        Console.WriteLine($"Codigo do Produto: {productName.ProductId}, Nome do Produto: {productName.ProductName}, " +
                        $"Tamanho do Produto: {productName.ProductSize}, Valor do Produto: {productName.ProductValue}");
                    }
                    else
                        Console.WriteLine($"Não esse nome {name} não existe");

                    Console.ReadKey();

                    break;
                case '2':
                    Console.Title = "Id";
                    Console.ReadLine();
                    Console.WriteLine("Digite o código do produto, por favor: ");

                    var code = int.TryParse(Console.ReadLine(), out var id) ? id : 0;
                    var productId = _productService.GetProductByProductId(code);

                    if (productId != null && productId.ProductName != null)
                    {
                        Console.WriteLine("A pesquisa retornou esse cadastro: ");
                        Console.WriteLine($"Codigo do Produto: {productId.ProductId}, Nome do Produto: {productId.ProductName}, " +
                        $"Tamanho do Produto: {productId.ProductSize}, Valor do Produto: {productId.ProductValue}");
                    }
                    else
                        Console.WriteLine($"Não esse código {code} não existe");

                    Console.ReadKey();

                    break;
                case '0':
                    Environment.Exit(0);

                    break;
                default:
                    Console.Clear();
                    Console.ReadLine();
                    Console.WriteLine("Opção Invalida, Tente novamente.....");

                    break;
            }
        }
    }
}
