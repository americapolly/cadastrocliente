using System;
using System.Collections.Generic;

namespace CadastroClientes
{
    class Program
    {
        static List<Cliente> listaClientes = new List<Cliente>();

        static void Main(string[] args)
        {
            bool executar = true;

            while (executar)
            {
                Console.WriteLine("\nOpções disponíveis:");
                Console.WriteLine("1 - Cadastrar novo cliente");
                Console.WriteLine("2 - Listar clientes cadastrados");
                Console.WriteLine("3 - Buscar cliente pelo nome");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite o número da opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        BuscarClientePorNome();
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por utilizar o Cadastro de Clientes. Volte sempre!");
                        executar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o e-mail do cliente: ");
            string email = Console.ReadLine();

            Cliente novoCliente = new Cliente(nome, idade, email);
            listaClientes.Add(novoCliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
        }

        static void ListarClientes()
        {
            if (listaClientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado ainda.");
            }
            else
            {
                Console.WriteLine("\nLista de clientes cadastrados:");
                foreach (Cliente cliente in listaClientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, E-mail: {cliente.Email}");
                }
            }
        }

        static void BuscarClientePorNome()
        {
            Console.Write("Digite o nome do cliente que deseja buscar: ");
            string nomeBusca = Console.ReadLine();

            List<Cliente> clientesEncontrados = listaClientes.FindAll(cliente => cliente.Nome.Contains(nomeBusca));

            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("Nenhum cliente encontrado com esse nome.");
            }
            else
            {
                Console.WriteLine("\nClientes encontrados:");
                foreach (Cliente cliente in clientesEncontrados)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}, Idade: {cliente.Idade}, E-mail: {cliente.Email}");
                }
            }
        }
    }
}
