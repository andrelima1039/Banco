using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    class Conta
    {
        const double LimiteSaqueMenorDeIdade = 200;

        public Double Saldo { get; set; }
        public Cliente Titular { get; set; }
        //public String Titular { get; set; }
        public int Numero { get; set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if(this.Saldo > valor)
            {
                if (valor > LimiteSaqueMenorDeIdade)
                {
                    if (Titular.EhMaiorDeIdade(Titular.Idade))
                    {
                        this.Saldo -= valor;
                        MessageBox.Show("Saque realizado com sucesso");
                        return true;
                    }
                    MessageBox.Show("Somente é permitido o saque de até 200 reais para clientes menores de idade. Entre em contato com a sua agência");
                    return false;
                }
                else
                {
                    this.Saldo -= valor;
                    MessageBox.Show("Saque realizado com sucesso");
                    return true;
                }

            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
                return false;
            }
            

        }

        public void Transfere(double valor,Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
