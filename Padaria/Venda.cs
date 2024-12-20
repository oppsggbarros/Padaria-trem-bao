using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Venda :  Estoque, Pagamentos
    {
        public List<Produto> Produtos = new List<Produto>();

        public DateTime DataVenda { get; set; }

        public Vendedor Vendedor { get; set; }

        public Pagamentos Pagamentos { get; set; }    

        public double Total { get; set; }

        public Venda(string FormaPagamento, bool Prazo , int QuantidadeParcelas ,DateTime dataVenda, Vendedor vendedor, Pagamentos pagamentos, List<Produto> produtos) : base(FormaPagamento, Prazo, QuantidadeParcelas)
        {
            this.DataVenda = dataVenda;
            this.Vendedor = vendedor;
            this.Pagamentos = pagamentos;
            this.Produtos = produtos;
           
        }
        public void FazerVenda()
        {

            while (true) 
            {
                System.Console.WriteLine("Digite o código do produto: ");
                int choose = Convert.ToInt32(Console.ReadLine());

                Produtos.Add(ProdutosEstoque[choose + 1]);

                
            }
        }

    }
}

