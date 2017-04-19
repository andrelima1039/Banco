using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Conta conta;
        public Cliente cliente;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaCorrente();
            this.cliente = new Cliente("André");

            conta.Titular = cliente;
            conta.Numero = 1;
            conta.Deposita(500);

            conta.Titular.Documentos = "teste";
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void Sacar_Click(object sender, EventArgs e)
        {
            conta.Saca(Double.Parse(textoValor.Text));
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void depositar_Click(object sender, EventArgs e)
        {
            conta.Deposita(Double.Parse(textoValor.Text));
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private void TotalSaldoContas_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(534);
            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(200);
            ContaPoupanca c3 = new ContaPoupanca();
            c3.Deposita(300);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);
            t.Soma(c3);

            MessageBox.Show(Convert.ToString(t.SaldoTotal));
        }
    }
}
