using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Padaria
{
    public class Padaria
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public List<Cliente> listaClientes = new List<Cliente>();
    }
}