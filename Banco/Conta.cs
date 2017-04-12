using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public Double Saldo { get; set; }
        public String Titular { get; set; }
        public int Numero { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(this.Saldo > valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Transfere(double valor,Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
