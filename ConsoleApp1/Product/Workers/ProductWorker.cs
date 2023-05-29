using Loja.DataBase.Product.Repositories;
using Loja.Product.Interfaces.Workers;
using Loja.Product.Models;
using Loja.Product.Services;
using MongoDB.Bson;

namespace Loja.Product.Workers
{
    public class ProductWorker : IProductWorker
    {
        public void ProductScreen()
        {
            var productRepository = new ProductRepository();
            var productService = new ProductService(productRepository);

            Console.Title = "Menu Product";

            Console.WriteLine("Escolha qual opção deseja: ");
            while (true)
            {
                Console.WriteLine("1. Cadastrar Produto");

                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                switch (Console.Read())
                {
                    case '1':
                        //aqui fiz um teste para validar o insert na collection 
                        var product = new ProductModel()
                        {
                            Id = ObjectId.GenerateNewId().ToString(),
                            ProductName = "Teste",
                            ProductValue = 89.56,
                            ProductSize = 16.00,
                            ProductId = 988
                        };
                        productService.SetProduct(product);
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
}
