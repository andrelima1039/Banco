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

        Conta conta = new Conta();
        Cliente cliente = new Cliente("Renata");



        private void Form1_Load(object sender, EventArgs e)
        {
            conta.Titular = cliente;
            conta.Numero = 1;
            conta.Deposita(500);

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
    }
}
