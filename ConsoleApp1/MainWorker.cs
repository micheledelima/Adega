using Adega.Clients.Interfaces.Services;
using Adega.Clients.Services;
using Adega.Clients.Workers;

namespace Adega
{
    public class MainWorker
    {
        static void Main(string[] args)
        {
            StartMenu();
        } 
        

        public static void StartMenu()        {
            
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
