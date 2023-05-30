using Store.Product.Workers;

namespace Store
{
    public static class MainWorker
    {
        public static void Main(string[] args)
        {
            StartMenu();
        }

        public static void StartMenu()
        {
            Console.Title = "Projeto Loja";
            ProductWorker productWorker = new ProductWorker();

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
                        //_clientWorker.ClientScreen();
                        break;
                    case '2':
                        productWorker.ProductScreen();
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
