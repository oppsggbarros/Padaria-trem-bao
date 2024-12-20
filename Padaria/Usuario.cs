using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria 
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        public Usuario(string nome, string cpf, string endereco, string telefone, double salarioBase)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.SalarioBase = salarioBase;
        }

        public virtual double Bonificacao(double SalarioBase)
        {
            return SalarioBase = SalarioBase * 1.0;
        }
        
    }
}