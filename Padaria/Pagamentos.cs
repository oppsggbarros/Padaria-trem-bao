using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public interface Pagamentos 
    {
        public string FormaPagamento { get; set; }

        public bool Prazo { get; set; }

        public int QuantidadeParcelas { get; set; }

    }
}