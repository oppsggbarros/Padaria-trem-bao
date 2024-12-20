using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Padeiro : Usuario
    {
        public int HorasTrabalhadas { get; set;} 

        public Padeiro(string nome, string endereco, string cpf, string telefone, double salarioBase, int horasTrabalhadas) : base(nome, cpf, endereco, telefone, salarioBase)
        {
            this.HorasTrabalhadas = horasTrabalhadas;
        }

        // Esse Metodo Construto é pra quando o vendedor não teve Hora de Trabalho Alternativa
        public Padeiro(string nome, string endereco, string cpf, string telefone, double salarioBase) : base(nome, cpf, endereco, telefone, salarioBase)
        {
        }

        public override double Bonificacao(double salarioBase)
        {
            for(int i = 0 ; i <= this.HorasTrabalhadas; i++ )
            {
                this.SalarioBase = this.SalarioBase * 0.25;
            }

            return 0;
        }

        
    }
}