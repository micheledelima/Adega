using Adega.Clients.Workers;
using Adega.DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Adega
{
    public class MainWorker
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<StoreDatabaseSettings>(
                builder.Configuration.GetSection("StoreDatabase"));

            StartMenu();
        }


        public static void StartMenu()
        {

            ClientWorker client = new ClientWorker();

            Console.Title = "Projeto Adega";

            Console.WriteLine("Escolha qual area deseja realizar operação: ");
            while (true)
            {
                Console.WriteLine("1. Cliente");
                Console.WriteLine("2. Produto");
                Console.WriteLine("3. Estoque");
                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                switch (Console.Read())
                {
                    case '1':
                        client.ClientScreen();
                        break;
                    case '2':
                        //chama WorkerProduct que é o ""menu de operações"" do produto
                        break;
                    case '3':
                        //chama WorkerStock que é o ""menu de operações"" do estoque
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
