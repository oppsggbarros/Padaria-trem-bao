using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Vendedor : Usuario
    {
        public int MetaVendas { get; set; }

        public Vendedor(string nome, string endereco, string cpf, string telefone, double salarioBase, int metaVendas) : base(nome, endereco, cpf, telefone, salarioBase)
        {
            this.MetaVendas = metaVendas;
        }

        public override double Bonificacao(double SalarioBase)
        {
            return SalarioBase = SalarioBase * 1.1;
        }

        public void IniciarVenda()
        {
            
        }
        
    }
}