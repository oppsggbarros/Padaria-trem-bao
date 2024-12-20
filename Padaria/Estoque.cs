using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Estoque
    {
        public List<Produto> ProdutosEstoque = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            ProdutosEstoque.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            ProdutosEstoque.Remove(produto);
        }

        public void GerenciarEstoque()
    {
        foreach (var produto in ProdutosEstoque)
        {
            if (produto.Quantidade == 1)
            {
                Console.WriteLine($"⚠️ Alerta: O produto '{produto.Nome}' (Código: {produto.Cod}) está com apenas 1 unidade no estoque.");
            }
        }
    }

        
        public void ListarProdutos()
        {
            foreach (var produto in ProdutosEstoque)
            {
                Console.WriteLine($"Nome: {produto.Nome}, Código: {produto.Cod}, Preço Final: {produto.PrecoFinal:F2}, Quantidade: {produto.Quantidade}");
            }
        }

    }
}