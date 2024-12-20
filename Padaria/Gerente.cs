using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Gerente : Usuario
    {
        public Padaria (string nome, string endereco, string cpf, string telefone, double salarioBase) : base(nome, cpf, endereco, telefone, salarioBase)
        {
            this.SalarioBase = salarioBase * 1.2;
        }

        
    }
}