using System;
using System.Collections.Generic;
using System.Linq;

namespace Padaria
{
    public class Padaria
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public List<Cliente> ListaClientes { get; set; } = new List<Cliente>();
        public List<Usuario> ListaUsuarios { get; set; } = new List<Usuario>();
        public List<Fornecedor> ListaFornecedores { get; set; } = new List<Fornecedor>();

        // Construtor
        public Padaria(string endereco, string telefone, List<Cliente> listaClientes)
        {
            Nome = "Trem Bão";
            Endereco = endereco;
            Telefone = telefone;
            ListaClientes = listaClientes;
        }

        // Cadastrar Cliente
        public void CadastrarCliente(Cliente cliente)
        {
            Cliente clienteNovo = new Cliente(cliente.Nome, cliente.Telefone, cliente.Endereco, cliente.Cpf, cliente.Rank);
            ListaClientes.Add(clienteNovo);
        }
        public void DirecionarRelatorios()
        {
            Console.WriteLine("De qual departamento você gostaria o relatório?");
            Console.WriteLine("1 - Clientes");
            Console.WriteLine("2 - Funcionários");
            Console.WriteLine("3 - Fornecedores");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ImprimirClientes();
                    break;
                case 2:
                    ImprimirUsuarios();
                    break;
                case 3:
                    ImprimirFornecedores();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        public void ImprimirClientes()
        {
            Console.WriteLine("Digite um nome para buscar (ou deixe em branco para listar todos):");
            string nomeBusca = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeBusca))
            {
                ImprimirTodosClientes();
            }
            else
            {
                Cliente result = ListaClientes.FirstOrDefault(cliente =>
                    cliente.Nome.ToLower().Contains(nomeBusca.ToLower())
                );

                if (result != null)
                {
                    DisplayResult(result, "Cliente encontrado pelo nome: " + nomeBusca);
                }
                else
                {
                    Console.WriteLine("\nCliente não encontrado: {0}", nomeBusca);
                }
            }
        }
        public void ImprimirTodosClientes()
        {
            if (ListaClientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Clientes:");
                foreach (var cliente in ListaClientes)
                {
                    Console.WriteLine($"Nome: {cliente.Nome}");
                }
            }
        }

        public void ImprimirUsuarios()
        {
            Console.WriteLine("Digite um nome para buscar:");
            string nomeBusca = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeBusca))
            {
                ImprimirTodosUsuarios();
            }
            else
            {
                Usuario result = ListaUsuarios.FirstOrDefault(Usuario =>
                    Usuario.Nome.ToLower().Contains(nomeBusca.ToLower())
                );

                if (result != null)
                {
                    DisplayResult(result, "Funcionário encontrado pelo nome: " + nomeBusca);
                }
                else
                {
                    Console.WriteLine("\nFuncionário não encontrado: {0}", nomeBusca);
                }
            }
        }
        public void ImprimirTodosUsuarios()
        {
            if (ListaUsuarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Funcionários:");
                foreach (var Usuario in ListaUsuarios)
                {
                    Console.WriteLine($"Nome: {Usuario.Nome}");
                }
            }
        }

        public void ImprimirFornecedores()
        {
            Console.WriteLine("Digite um nome para buscar (ou deixe em branco para listar todos):");
            string nomeBusca = Console.ReadLine();

            if (string.IsNullOrEmpty(nomeBusca))
            {
                ImprimirTodosFornecedores();
            }
            else
            {
                Fornecedor result = ListaFornecedores.FirstOrDefault(fornecedor =>
                    fornecedor.Nome.ToLower().Contains(nomeBusca.ToLower())
                );

                if (result != null)
                {
                    DisplayResult(result, "Fornecedor encontrado pelo nome: " + nomeBusca);
                }
                else
                {
                    Console.WriteLine("\nFornecedor não encontrado: {0}", nomeBusca);
                }
            }
        }

        public void ImprimirTodosFornecedores()
        {
            if (ListaFornecedores.Count == 0)
            {
                Console.WriteLine("Nenhum fornecedor cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Fornecedores:");
                foreach (var fornecedor in ListaFornecedores)
                {
                    Console.WriteLine($"Nome: {fornecedor.Nome}");
                }
            }
        }

        // Método para exibir os resultados encontrados
        public void DisplayResult(object obj, string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine($"Detalhes: {obj.ToString()}");
        }
    }
}
