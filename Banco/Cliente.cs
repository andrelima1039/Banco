using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Documentos { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                bool maiorDeIdade = this.Idade >= 18;
                bool emancipado = this.Documentos.Contains("emancipacao");
                bool possuiCPF = !string.IsNullOrEmpty(this.CPF);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }

        
    }
}
