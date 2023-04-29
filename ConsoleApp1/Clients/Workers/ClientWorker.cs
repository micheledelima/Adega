using Adega.Clients.Interfaces.Services;
using Adega.Clients.Models;

namespace Adega.Clients.Workers
{
    public class ClientWorker
    {
        private readonly IClientService _clientService;

        public ClientWorker(IClientService clientService)
        {
            _clientService = clientService;
        }

        public ClientWorker(IClientService clientService, object clientService1) : this(clientService)
        {
        }

        public void ClientScreen()
        {
            Console.Title = "Area adminitrativa - Cliente";

            Console.WriteLine("Escolha qual opção deseja: ");
            while (true)
            {
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Visualizar Cadastro Cliente");
                Console.WriteLine("3. Atualizar Cadastro Cliente");
                Console.WriteLine("0. Sair");
                Console.Write("Opção: ");
                switch (Console.Read())
                {
                    case '1':
                        ClientRegisterHandler();
                        break;
                    case '2':
                        ClientVisualizationHandler();
                        break;
                    case '3':
                        ClientUpdateHandler();
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

        private void ClientRegisterHandler()
        {
            var cliModel = new ClientModel();

            Console.WriteLine("Informe o nome:");
            cliModel.Nome = Console.ReadLine();

            Console.WriteLine("Informe o enereço:");
            cliModel.Endereco = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            cliModel.Email = Console.ReadLine();

            Console.WriteLine("Informe o telefone:");
            cliModel.Telefone = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            cliModel.CPF = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            cliModel.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o CEP:");
            cliModel.CEP = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento:");
            cliModel.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            _clientService.SetClient(cliModel);
        }


        private void ClientVisualizationHandler()
        {

        }

        private void ClientUpdateHandler()
        {
            var cliModel = new ClientModel();

            Console.WriteLine("Selecione o cliente para alterar:");

            



            Console.WriteLine("Selecione o campo para alterar:");
            Console.WriteLine("Selecione o campo para alterar:");


            Console.WriteLine("1 - nome: "  + cliModel.Nome);
            Console.WriteLine("2 - enereço: " + cliModel.Endereco);
            Console.WriteLine("3 - Informe o email: " + cliModel.Email);                        
            Console.WriteLine("4 - Telefone: " + cliModel.Telefone);
            Console.WriteLine("5 - CPF: " + cliModel.CPF);
            Console.WriteLine("6 - Idade: " + cliModel.Idade);
            Console.WriteLine("7 - Informe o CEP " + cliModel.CEP);
            Console.WriteLine("8 - Data de nascimento: " + cliModel.DataNascimento);
            Console.WriteLine("9 - Sair");


            //switch (console.readline())
            //{
            //    case '1':
            //    case '2':
            //    case '3':
            //    case '4':
            //    case '5':
            //    case '6':
            //    case '7':
            //    case '8':
            //    case '9':

            //}

            switch (Console.ReadLine())
            {

            }


            _clientService.UpdateClient(cliModel);
        }
    }
}
