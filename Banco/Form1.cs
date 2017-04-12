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

        private void button1_Click(object sender, EventArgs e)
        {
            Conta contaAndre = new Conta();
            contaAndre.Titular = "André";
            contaAndre.Numero = 1;
            contaAndre.Deposita(100);
            if (contaAndre.Saca(500))
            {
                MessageBox.Show("Saque bem sucedido");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            MessageBox.Show("Saldo: "+contaAndre.Saldo);
        }
    }
}
