using System;
using System.Collections.Generic;

namespace Padaria
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Padaria padaria = new Padaria("Rua das aves, 6547, Nova Lima", "1234-5678", new List<Cliente>());
            Estoque estoque = new Estoque();

            while (true)
            {
                Console.WriteLine("=== Menu da Padaria ===");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Adicionar Produto ao Estoque");
                Console.WriteLine("4. Remover Produto do Estoque");
                Console.WriteLine("5. Listar Produtos do Estoque");
                Console.WriteLine("6. Realizar Venda");
                Console.WriteLine("7. Calcular Desconto");
                Console.WriteLine("8. Relatórios");
                Console.WriteLine("9. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        padaria.CadastrarCliente();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":

                        break;
                    case "7":

                        break;
                    case "8":
                        padaria.DirecionarRelatorios();
                        break;
                    case "9":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}