namespace Adega
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartMenu();
        }

        public static void StartMenu()
        {
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
                        //chama start que é o "menu de operações" do cliente
                        break;
                    case '2':
                        //chama start que é o ""menu de operações"" do produto
                        break;
                    case '3':
                        //chama start que é o ""menu de operações"" do estoque
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
