using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Produto 
    {
        public string Nome { get; set; }
        public string Cod { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public double PrecoCusto { get; set; }
        
        public double PrecoFinal { get; set; }

        public bool Perecivel { get; set; }

        public DateTime DataValidade { get; set; }

        public int Quantidade { get; set; }

        public string Apelido { get; set; }

        public Produto(string nome, string cod, Fornecedor fornecedor, double precoCusto, double precoFinal, bool perecivel, int quantidade )
        {
            this.Nome = nome;
            this.Cod = cod;
            this.Fornecedor = fornecedor;
            this.PrecoCusto = precoCusto;
            this.PrecoFinal = precoFinal;
            this.Perecivel = perecivel;
            this.Quantidade = quantidade;
        }

        public Produto(string nome, string cod, Fornecedor fornecedor, double precoCusto, double precoFinal, bool perecivel, DateTime dataValidade, int quantidade )
        {
            this.Nome = nome;
            this.Cod = cod;
            this.Fornecedor = fornecedor;
            this.PrecoCusto = precoCusto;
            this.PrecoFinal = precoFinal;
            this.Perecivel = perecivel;
            this.Quantidade = quantidade;
            this.DataValidade = dataValidade;
        }

        public Produto(string nome, string cod, Fornecedor fornecedor, double precoCusto, double precoFinal, bool perecivel, int quantidade, string apelido)
        {
            this.Nome = nome;
            this.Cod = cod;
            this.Fornecedor = fornecedor;
            this.PrecoCusto = precoCusto;
            this.PrecoFinal = precoFinal;
            this.Perecivel = perecivel;
            this.Quantidade = quantidade;
            this.Apelido = apelido;
        }
        public Produto(string nome, string cod, Fornecedor fornecedor, double precoCusto, double precoFinal, bool perecivel, DateTime dataValidade, int quantidade, string apelido)
        {
            this.Nome = nome;
            this.Cod = cod;
            this.Fornecedor = fornecedor;
            this.PrecoCusto = precoCusto;
            this.PrecoFinal = precoFinal;
            this.Perecivel = perecivel;
            this.Quantidade = quantidade;
            this.Apelido = apelido;
            this.DataValidade = dataValidade;
        }
    }
}