using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    internal class Cliente
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }
        
        public int AnoNascimento { get; private set; } 
    }
}
