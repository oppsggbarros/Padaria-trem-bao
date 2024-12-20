using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public bool Recorrente { get; set; }

        public Fornecedor(string nome, string endereco, string cnpj, bool recorrente)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cnpj = cnpj;
            this.Recorrente = recorrente;
        }
        public double ControlRecorrente(bool recorrente)
        {
            if (recorrente)
            {
                return 0.05;
            }
            else
            {
                return 0.0;
            }
        }

        
    }
}