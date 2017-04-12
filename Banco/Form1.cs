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
            contaAndre.Numero = 1;

            Cliente Titular = new Cliente();
            contaAndre.Titular = Titular;
            contaAndre.Titular.Nome = "André";
            contaAndre.Titular.Idade = 17;

            contaAndre.Deposita(500);
            contaAndre.Saca(300);
        }
    }
}
