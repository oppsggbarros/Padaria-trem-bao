using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Rank { get; set; }
        public Cliente(string nome, string telefone, string endereco, string cpf, string rank)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Rank = rank;
        }


        // Passar função para a classe venda
        public void Desconto(string Rank, double valor)
        {
            if (Rank == "Gold" || Rank == "gold")
            {
                valor = valor - (valor*0.05);
                System.Console.WriteLine($"Seu desconto é de 5%, total do pedido: {valor:c2}"); 
            }
            else if (Rank == "Platinum" || Rank == "platinum")
            {
                valor = valor - (valor*0.1);
                System.Console.WriteLine($"Seu desconto é de 10%, total do pedido: {valor:c2}"); 
            }
            else
            {
                System.Console.WriteLine($"Sem desconto, total do pedido: {valor}");
            }
        }
    }
}