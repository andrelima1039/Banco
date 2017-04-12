using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public bool EhMaiorDeIdade(int idade)
        {
            if(this.Idade > 18)
            {
                return true;
            }
            return false;
        }
    }
}
